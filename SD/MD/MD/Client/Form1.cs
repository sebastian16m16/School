using Grpc.Core;
using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        //INDEXES IN TABLE
        const int ID_Index = 1;
        const int PATIENT_Index = 2;
        const int MEDICATION_Index = 3;
        const int MEDICATION_SCHEDULE_Index = 4;
        const int INTAKETIME_Index = 5;

        private MedicationPlan.MedicationPlanClient client;
        private DataGridView dataGrid;
        private DataTable dt;
        private Label patientLabel;
        private TextBox patientIdTextBox;
        private Button downloadButton;
        private DataGridViewButtonColumn buttonColumn;
        private Timer timer;
        private Label timer_label;
        public Form1(MedicationPlan.MedicationPlanClient client)
        {
            InitializeComponent();
            this.client = client;

            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Patient");
            dt.Columns.Add("Medication");
            dt.Columns.Add("Medication Schedule");
            dt.Columns.Add("Time");

            dataGrid.DataSource = dt;
        }

        private async void getData()
        {
            try
            {
                var mpRequest = new MPFromPatient();
                mpRequest.Patient = Int32.Parse(patientIdTextBox.Text);

                using (var call = client.GetMedicationPlanFromPatient(mpRequest))
                {
                    while (await call.ResponseStream.MoveNext())
                    {
                        var currentMP = call.ResponseStream.Current;

                        dt.Rows.Add(currentMP.Id, currentMP.Patient, currentMP.Medication, currentMP.MedicationPlan, currentMP.Time);
                        dataGrid.DataSource = dt;
                        dataGrid.Refresh();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
    }

        private void DownloadButton_MouseClick(object sender, MouseEventArgs e)
        {
            getData();
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGrid.Columns[e.ColumnIndex].Name == "Taken")
            {
                DateTime intakeHour = DateTime.Parse(dataGrid.Rows[e.RowIndex].Cells[INTAKETIME_Index].Value.ToString());

                if(((intakeHour - DateTime.Now).Seconds > 0) || (intakeHour - DateTime.Now).Seconds == 0)
                {
                    DataGridViewButtonCell c = (DataGridViewButtonCell)dataGrid.Rows[e.RowIndex].Cells[0];
                    c.FlatStyle = FlatStyle.Popup;
                    c.Style.BackColor = Color.Green;
                    c.Selected = false;
                }
                else
                {
                    DataGridViewButtonCell c = (DataGridViewButtonCell)dataGrid.Rows[e.RowIndex].Cells[0];
                    c.FlatStyle = FlatStyle.Popup;
                    c.Style.BackColor = Color.Red;
                    c.Selected = false;

                }

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_label.Text = DateTime.Now.ToString("HH:mm:ss");
            timer.Start();
        }


    }
}
