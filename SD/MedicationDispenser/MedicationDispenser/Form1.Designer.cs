namespace MedicationDispenser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.medication_ScheduleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.medication_ScheduleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medication_ScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediactionDispenserDataSet = new MedicationDispenser.MediactionDispenserDataSet();
            this.medication_ScheduleTableAdapter = new MedicationDispenser.MediactionDispenserDataSetTableAdapters.Medication_ScheduleTableAdapter();
            this.tableAdapterManager = new MedicationDispenser.MediactionDispenserDataSetTableAdapters.TableAdapterManager();
            this.medication_PlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medication_PlanTableAdapter = new MedicationDispenser.MediactionDispenserDataSetTableAdapters.Medication_PlanTableAdapter();
            this.medication_PlanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medication_ScheduleBindingNavigator)).BeginInit();
            this.medication_ScheduleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medication_ScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediactionDispenserDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medication_PlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medication_PlanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medication_ScheduleBindingNavigator
            // 
            this.medication_ScheduleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medication_ScheduleBindingNavigator.BindingSource = this.medication_ScheduleBindingSource;
            this.medication_ScheduleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medication_ScheduleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medication_ScheduleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medication_ScheduleBindingNavigatorSaveItem});
            this.medication_ScheduleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medication_ScheduleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medication_ScheduleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medication_ScheduleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medication_ScheduleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medication_ScheduleBindingNavigator.Name = "medication_ScheduleBindingNavigator";
            this.medication_ScheduleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medication_ScheduleBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.medication_ScheduleBindingNavigator.TabIndex = 0;
            this.medication_ScheduleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // medication_ScheduleBindingNavigatorSaveItem
            // 
            this.medication_ScheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medication_ScheduleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medication_ScheduleBindingNavigatorSaveItem.Image")));
            this.medication_ScheduleBindingNavigatorSaveItem.Name = "medication_ScheduleBindingNavigatorSaveItem";
            this.medication_ScheduleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medication_ScheduleBindingNavigatorSaveItem.Text = "Save Data";
            this.medication_ScheduleBindingNavigatorSaveItem.Click += new System.EventHandler(this.medication_ScheduleBindingNavigatorSaveItem_Click);
            // 
            // medication_ScheduleBindingSource
            // 
            this.medication_ScheduleBindingSource.DataMember = "Medication_Schedule";
            this.medication_ScheduleBindingSource.DataSource = this.mediactionDispenserDataSet;
            // 
            // mediactionDispenserDataSet
            // 
            this.mediactionDispenserDataSet.DataSetName = "MediactionDispenserDataSet";
            this.mediactionDispenserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medication_ScheduleTableAdapter
            // 
            this.medication_ScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.Medication_PlanTableAdapter = null;
            this.tableAdapterManager.Medication_ScheduleTableAdapter = this.medication_ScheduleTableAdapter;
            this.tableAdapterManager.MedicationTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.ReplyDataTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MedicationDispenser.MediactionDispenserDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medication_PlanBindingSource
            // 
            this.medication_PlanBindingSource.DataMember = "Medication_Plan";
            this.medication_PlanBindingSource.DataSource = this.mediactionDispenserDataSet;
            // 
            // medication_PlanTableAdapter
            // 
            this.medication_PlanTableAdapter.ClearBeforeFill = true;
            // 
            // medication_PlanDataGridView
            // 
            this.medication_PlanDataGridView.AutoGenerateColumns = false;
            this.medication_PlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medication_PlanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.medication_PlanDataGridView.DataSource = this.medication_PlanBindingSource;
            this.medication_PlanDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medication_PlanDataGridView.Location = new System.Drawing.Point(0, 25);
            this.medication_PlanDataGridView.Name = "medication_PlanDataGridView";
            this.medication_PlanDataGridView.Size = new System.Drawing.Size(800, 425);
            this.medication_PlanDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "medication";
            this.dataGridViewTextBoxColumn2.HeaderText = "medication";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "medication_schedule";
            this.dataGridViewTextBoxColumn3.HeaderText = "medication_schedule";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "intakeTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "intakeTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Taken";
            this.dataGridViewTextBoxColumn5.HeaderText = "Taken";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.medication_PlanDataGridView);
            this.Controls.Add(this.medication_ScheduleBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medication_ScheduleBindingNavigator)).EndInit();
            this.medication_ScheduleBindingNavigator.ResumeLayout(false);
            this.medication_ScheduleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medication_ScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediactionDispenserDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medication_PlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medication_PlanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediactionDispenserDataSet mediactionDispenserDataSet;
        private System.Windows.Forms.BindingSource medication_ScheduleBindingSource;
        private MediactionDispenserDataSetTableAdapters.Medication_ScheduleTableAdapter medication_ScheduleTableAdapter;
        private MediactionDispenserDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medication_ScheduleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton medication_ScheduleBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource medication_PlanBindingSource;
        private MediactionDispenserDataSetTableAdapters.Medication_PlanTableAdapter medication_PlanTableAdapter;
        private System.Windows.Forms.DataGridView medication_PlanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn5;
    }
}

