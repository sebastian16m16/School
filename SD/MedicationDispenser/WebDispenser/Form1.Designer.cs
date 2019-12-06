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
            this.medication_PlanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.medication_PlanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medication_PlanDataGridView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.dateToDownloadLabel = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.medication_PlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediactionDispenserDataSet = new MedicationDispenser.MediactionDispenserDataSet();
            this.medication_PlanTableAdapter = new MedicationDispenser.MediactionDispenserDataSetTableAdapters.Medication_PlanTableAdapter();
            this.tableAdapterManager = new MedicationDispenser.MediactionDispenserDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medication_PlanBindingNavigator)).BeginInit();
            this.medication_PlanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medication_PlanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medication_PlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediactionDispenserDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // medication_PlanBindingNavigator
            // 
            this.medication_PlanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medication_PlanBindingNavigator.BindingSource = this.medication_PlanBindingSource;
            this.medication_PlanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medication_PlanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medication_PlanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.medication_PlanBindingNavigatorSaveItem});
            this.medication_PlanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medication_PlanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medication_PlanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medication_PlanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medication_PlanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medication_PlanBindingNavigator.Name = "medication_PlanBindingNavigator";
            this.medication_PlanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medication_PlanBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.medication_PlanBindingNavigator.TabIndex = 0;
            this.medication_PlanBindingNavigator.Text = "bindingNavigator1";
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
            // medication_PlanBindingNavigatorSaveItem
            // 
            this.medication_PlanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medication_PlanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medication_PlanBindingNavigatorSaveItem.Image")));
            this.medication_PlanBindingNavigatorSaveItem.Name = "medication_PlanBindingNavigatorSaveItem";
            this.medication_PlanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medication_PlanBindingNavigatorSaveItem.Text = "Save Data";
            this.medication_PlanBindingNavigatorSaveItem.Click += new System.EventHandler(this.medication_PlanBindingNavigatorSaveItem_Click);
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
            this.medication_PlanDataGridView.Size = new System.Drawing.Size(800, 423);
            this.medication_PlanDataGridView.TabIndex = 1;
            this.medication_PlanDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medication_PlanDataGridView_CellContentClick_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(330, 11);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(35, 13);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "label1";
            // 
            // downloadButton
            // 
            this.downloadButton.AllowDrop = true;
            this.downloadButton.BackColor = System.Drawing.Color.Chocolate;
            this.downloadButton.Location = new System.Drawing.Point(630, 1);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(169, 23);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "Download Plan For Today";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // dateToDownloadLabel
            // 
            this.dateToDownloadLabel.Location = new System.Drawing.Point(524, 4);
            this.dateToDownloadLabel.Name = "dateToDownloadLabel";
            this.dateToDownloadLabel.Size = new System.Drawing.Size(100, 20);
            this.dateToDownloadLabel.TabIndex = 4;
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
            // medication_PlanBindingSource
            // 
            this.medication_PlanBindingSource.DataMember = "Medication_Plan";
            this.medication_PlanBindingSource.DataSource = this.mediactionDispenserDataSet;
            // 
            // mediactionDispenserDataSet
            // 
            this.mediactionDispenserDataSet.DataSetName = "MediactionDispenserDataSet";
            this.mediactionDispenserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medication_PlanTableAdapter
            // 
            this.medication_PlanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.Medication_PlanTableAdapter = this.medication_PlanTableAdapter;
            this.tableAdapterManager.Medication_ScheduleTableAdapter = null;
            this.tableAdapterManager.MedicationTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.ReportTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MedicationDispenser.MediactionDispenserDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insert date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateToDownloadLabel);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.medication_PlanDataGridView);
            this.Controls.Add(this.medication_PlanBindingNavigator);
            this.Name = "Form1";
            this.Text = "Patient Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medication_PlanBindingNavigator)).EndInit();
            this.medication_PlanBindingNavigator.ResumeLayout(false);
            this.medication_PlanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medication_PlanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medication_PlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediactionDispenserDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediactionDispenserDataSet mediactionDispenserDataSet;
        private System.Windows.Forms.BindingSource medication_PlanBindingSource;
        private MediactionDispenserDataSetTableAdapters.Medication_PlanTableAdapter medication_PlanTableAdapter;
        private MediactionDispenserDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medication_PlanBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton medication_PlanBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView medication_PlanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox dateToDownloadLabel;
        private System.Windows.Forms.Label label1;
    }
}

