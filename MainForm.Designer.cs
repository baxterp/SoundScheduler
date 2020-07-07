namespace SoundScheduler
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.soundEventsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // soundEventsDataGridView
            // 
            this.soundEventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soundEventsDataGridView.Location = new System.Drawing.Point(41, 49);
            this.soundEventsDataGridView.Name = "soundEventsDataGridView";
            this.soundEventsDataGridView.Size = new System.Drawing.Size(340, 341);
            this.soundEventsDataGridView.TabIndex = 0;
            // 
            // eventsDateTimePicker
            // 
            this.eventsDateTimePicker.Location = new System.Drawing.Point(27, 19);
            this.eventsDateTimePicker.Name = "eventsDateTimePicker";
            this.eventsDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eventsDateTimePicker.TabIndex = 1;
            this.eventsDateTimePicker.Value = new System.DateTime(2020, 7, 7, 14, 40, 14, 0);
            this.eventsDateTimePicker.ValueChanged += new System.EventHandler(this.eventsDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sound Events for Selected Day";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eventsDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(402, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 230);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Day";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 748);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soundEventsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sound Scheduler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soundEventsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView soundEventsDataGridView;
        private System.Windows.Forms.DateTimePicker eventsDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

