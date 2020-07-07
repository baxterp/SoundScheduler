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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startCreateNewEventsBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.newEventsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numberCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endTimeCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startTimeCmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.soundEventsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Text = "Select Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startCreateNewEventsBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.newEventsDateTimePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numberCmb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.endTimeCmb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.startTimeCmb);
            this.groupBox2.Location = new System.Drawing.Point(41, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 181);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create new events";
            // 
            // startCreateNewEventsBtn
            // 
            this.startCreateNewEventsBtn.Location = new System.Drawing.Point(516, 36);
            this.startCreateNewEventsBtn.Name = "startCreateNewEventsBtn";
            this.startCreateNewEventsBtn.Size = new System.Drawing.Size(119, 48);
            this.startCreateNewEventsBtn.TabIndex = 8;
            this.startCreateNewEventsBtn.Text = "Create New Events";
            this.startCreateNewEventsBtn.UseVisualStyleBackColor = true;
            this.startCreateNewEventsBtn.Click += new System.EventHandler(this.startCreateNewEventsBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select Date";
            // 
            // newEventsDateTimePicker
            // 
            this.newEventsDateTimePicker.Location = new System.Drawing.Point(13, 37);
            this.newEventsDateTimePicker.Name = "newEventsDateTimePicker";
            this.newEventsDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newEventsDateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number per Hour";
            // 
            // numberCmb
            // 
            this.numberCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberCmb.FormattingEnabled = true;
            this.numberCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.numberCmb.Location = new System.Drawing.Point(377, 37);
            this.numberCmb.Name = "numberCmb";
            this.numberCmb.Size = new System.Drawing.Size(121, 21);
            this.numberCmb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Time";
            // 
            // endTimeCmb
            // 
            this.endTimeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endTimeCmb.FormattingEnabled = true;
            this.endTimeCmb.Location = new System.Drawing.Point(234, 88);
            this.endTimeCmb.Name = "endTimeCmb";
            this.endTimeCmb.Size = new System.Drawing.Size(121, 21);
            this.endTimeCmb.TabIndex = 2;
            this.endTimeCmb.SelectedIndexChanged += new System.EventHandler(this.endTimeCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Time";
            // 
            // startTimeCmb
            // 
            this.startTimeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimeCmb.FormattingEnabled = true;
            this.startTimeCmb.Items.AddRange(new object[] {
            "Select Start Time",
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.startTimeCmb.Location = new System.Drawing.Point(234, 36);
            this.startTimeCmb.Name = "startTimeCmb";
            this.startTimeCmb.Size = new System.Drawing.Size(121, 21);
            this.startTimeCmb.TabIndex = 0;
            this.startTimeCmb.SelectedIndexChanged += new System.EventHandler(this.startTimeCmb_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 748);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView soundEventsDataGridView;
        private System.Windows.Forms.DateTimePicker eventsDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox startTimeCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox endTimeCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox numberCmb;
        private System.Windows.Forms.Button startCreateNewEventsBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker newEventsDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}

