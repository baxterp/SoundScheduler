﻿namespace SoundScheduler
{
    partial class MainForm
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
            this.soundEventsDataGridView = new System.Windows.Forms.DataGridView();
            this.eventsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.soundEventsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // soundEventsDataGridView
            // 
            this.soundEventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soundEventsDataGridView.Location = new System.Drawing.Point(38, 41);
            this.soundEventsDataGridView.Name = "soundEventsDataGridView";
            this.soundEventsDataGridView.Size = new System.Drawing.Size(489, 341);
            this.soundEventsDataGridView.TabIndex = 0;
            // 
            // eventsDateTimePicker
            // 
            this.eventsDateTimePicker.Location = new System.Drawing.Point(619, 66);
            this.eventsDateTimePicker.Name = "eventsDateTimePicker";
            this.eventsDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eventsDateTimePicker.TabIndex = 1;
            this.eventsDateTimePicker.Value = new System.DateTime(2020, 7, 7, 14, 40, 14, 0);
            this.eventsDateTimePicker.ValueChanged += new System.EventHandler(this.eventsDateTimePicker_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 748);
            this.Controls.Add(this.eventsDateTimePicker);
            this.Controls.Add(this.soundEventsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sound Scheduler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soundEventsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView soundEventsDataGridView;
        private System.Windows.Forms.DateTimePicker eventsDateTimePicker;
    }
}

