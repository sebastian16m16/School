using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicationDispenser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void medication_ScheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medication_ScheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mediactionDispenserDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediactionDispenserDataSet.Medication_Plan' table. You can move, or remove it, as needed.
            this.medication_PlanTableAdapter.Fill(this.mediactionDispenserDataSet.Medication_Plan);
            // TODO: This line of code loads data into the 'mediactionDispenserDataSet.Medication_Schedule' table. You can move, or remove it, as needed.
            this.medication_ScheduleTableAdapter.Fill(this.mediactionDispenserDataSet.Medication_Schedule);

        }

        private void medication_ScheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                switch((e.RowIndex + 1) % 10)
                {
                    case 1: MessageBox.Show("Pressed: " + (e.RowIndex + 1) + "'st button");
                        break;
                    case 2: MessageBox.Show("Pressed: " + (e.RowIndex + 1) + "'nd button");
                        break;
                    case 3: MessageBox.Show("Pressed: " + (e.RowIndex + 1) + "'rd button");
                        break;
                    default:
                        MessageBox.Show("Pressed: " + (e.RowIndex + 1) + "'th button");
                        break;
                }
               
            }
        }
    }
}
