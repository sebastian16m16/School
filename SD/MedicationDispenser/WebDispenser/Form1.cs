using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicationDispenser.Handle;
using MedicationDispenser.Models;

namespace MedicationDispenser
{
    public partial class Form1 : Form
    {
        //INDEXES IN TABLE
        const int ID_Index = 0;
        const int MEDICATION_Index = 1;
        const int MEDICATION_SCHEDULE_Index = 2;
        const int INTAKETIME_Index = 3;
        const int BUTTON_Index = 4;

        Form2 form2;


        PlanHandler planHandler = new PlanHandler();

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form2.Show();
            timer1.Start();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(form2.Location.X + form2.Size.Width + 50, form2.Location.Y);
            dateToDownloadLabel.Text = "2019/01/28";

            gridview_Update();
        }

        
        private void medication_PlanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medication_PlanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mediactionDispenserDataSet);

        }

        private void medication_PlanDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Report report = new Report();
           
            
            if (e.ColumnIndex.Equals(BUTTON_Index))
            {
                
                int planID = Int32.Parse(medication_PlanDataGridView.Rows[e.RowIndex].Cells[ID_Index].Value.ToString());
                int medicationID = Int32.Parse(medication_PlanDataGridView.Rows[e.RowIndex].Cells[MEDICATION_SCHEDULE_Index].Value.ToString());
                DateTime intakeTime = planHandler.getPlanIntakeHour(planID);
                MedicationSchedule medicationSchedule = planHandler.getMedicationSchedule(medicationID);
                if ((intakeTime - DateTime.Now).Seconds > 0 || (intakeTime - DateTime.Now).Seconds == 0) 
                {
                    report.medication_schedule = medicationSchedule.id;
                    report.patient = medicationSchedule.patient;
                    report.taken = 1;

                    planHandler.addReport(report);
                }else if((intakeTime - DateTime.Now).Seconds < 0)
                {
                    report.medication_schedule = medicationSchedule.id;
                    report.patient = medicationSchedule.patient;
                    report.taken = 0;

                    planHandler.addReport(report);
                }
                planHandler.deletePlan(planID);

                MessageBox.Show(intakeTime.ToString());
                
                gridview_Update();
                form2.update_table();
            }
        }

        public void gridview_Update()
        {
            // TODO: This line of code loads data into the 'mediactionDispenserDataSet.Medication_Plan' table. You can move, or remove it, as needed.
            DateTime date = DateTime.Parse(dateToDownloadLabel.Text);
            this.medication_PlanTableAdapter.Fill(this.mediactionDispenserDataSet.Medication_Plan);
        } 
        
        public void gridview_Update(DateTime date)
        {
            // TODO: This line of code loads data into the 'mediactionDispenserDataSet.Medication_Plan' table. You can move, or remove it, as needed.
            this.medication_PlanTableAdapter.Fill(this.mediactionDispenserDataSet.Medication_Plan, date);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            gridview_Update(DateTime.Parse(dateToDownloadLabel.Text));
        }
    }
}
