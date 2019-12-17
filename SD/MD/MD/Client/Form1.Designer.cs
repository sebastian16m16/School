using Client.Models;
using System;
using System.Windows.Forms;

namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Load += Form1_Load;
            this.Text = "Medication Plan";

            //DATA
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGrid.Width = 800;
            this.dataGrid.Height = 200;

                //buttonColumn
                this.buttonColumn = new DataGridViewButtonColumn();
                //this.buttonColumn.CellTemplate = new MyButtonCell();
                this.buttonColumn.UseColumnTextForButtonValue = true;
                this.buttonColumn.Text = "Taken";
                this.buttonColumn.Name = "Taken";
                this.dataGrid.Columns.Add(buttonColumn);

            this.dataGrid.CellClick += DataGrid_CellClick;
            this.Controls.Add(dataGrid);

            //Label
            this.patientLabel = new System.Windows.Forms.Label();
            this.patientLabel.Location = new System.Drawing.Point(
                this.dataGrid.Width + 10, this.dataGrid.Location.Y+20);
            this.patientLabel.Text = "Patient ID: ";
            this.patientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Controls.Add(patientLabel);

            //TEXT BOX
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.patientIdTextBox.Location = new System.Drawing.Point(
                this.patientLabel.Location.X + 100, this.patientLabel.Location.Y);
            this.patientIdTextBox.Text = "0";
            this.Controls.Add(patientIdTextBox);

            //DOWNLOAD BUTTON
            this.downloadButton = new System.Windows.Forms.Button();
            this.downloadButton.Location = new System.Drawing.Point(
                this.patientLabel.Location.X + 30, this.patientLabel.Location.Y + 30);
            this.downloadButton.AutoSize = true;
            this.downloadButton.Text = "Download";
            this.downloadButton.MouseClick += DownloadButton_MouseClick;
            this.Controls.Add(downloadButton);

            //TIMER
            this.timer = new Timer();
            this.timer.Tick += Timer_Tick; ;

            //TIMER_LABEL
            this.timer_label = new Label();
            this.timer_label.Location = new System.Drawing.Point(downloadButton.Location.X, downloadButton.Location.Y + 350);
            this.Controls.Add(timer_label);


        }

        









        #endregion
    }
}

