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
            this.gbSelectDate = new System.Windows.Forms.GroupBox();
            this.gbCreateNewEvents = new System.Windows.Forms.GroupBox();
            this.startCreateNewEventsBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.newEventsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numberCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endTimeCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startTimeCmb = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStopSheduler = new System.Windows.Forms.Button();
            this.btnStartSheduler = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.btnPlaySelectedRowSound = new System.Windows.Forms.Button();
            this.gbClearData = new System.Windows.Forms.GroupBox();
            this.btnDeleteAllData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.soundEventsDataGridView)).BeginInit();
            this.gbSelectDate.SuspendLayout();
            this.gbCreateNewEvents.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbClearData.SuspendLayout();
            this.SuspendLayout();
            // 
            // soundEventsDataGridView
            // 
            this.soundEventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soundEventsDataGridView.Location = new System.Drawing.Point(27, 68);
            this.soundEventsDataGridView.Name = "soundEventsDataGridView";
            this.soundEventsDataGridView.Size = new System.Drawing.Size(350, 413);
            this.soundEventsDataGridView.TabIndex = 0;
            this.soundEventsDataGridView.SelectionChanged += new System.EventHandler(this.soundEventsDataGridView_SelectionChanged);
            // 
            // eventsDateTimePicker
            // 
            this.eventsDateTimePicker.Location = new System.Drawing.Point(27, 19);
            this.eventsDateTimePicker.Name = "eventsDateTimePicker";
            this.eventsDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eventsDateTimePicker.TabIndex = 1;
            this.eventsDateTimePicker.Value = new System.DateTime(2020, 7, 8, 0, 0, 0, 0);
            this.eventsDateTimePicker.ValueChanged += new System.EventHandler(this.eventsDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sound Events for Selected Date";
            // 
            // gbSelectDate
            // 
            this.gbSelectDate.Controls.Add(this.btnPlaySelectedRowSound);
            this.gbSelectDate.Controls.Add(this.eventsDateTimePicker);
            this.gbSelectDate.Controls.Add(this.soundEventsDataGridView);
            this.gbSelectDate.Controls.Add(this.label1);
            this.gbSelectDate.Location = new System.Drawing.Point(695, 27);
            this.gbSelectDate.Name = "gbSelectDate";
            this.gbSelectDate.Size = new System.Drawing.Size(396, 578);
            this.gbSelectDate.TabIndex = 3;
            this.gbSelectDate.TabStop = false;
            this.gbSelectDate.Text = "Select Date";
            // 
            // gbCreateNewEvents
            // 
            this.gbCreateNewEvents.Controls.Add(this.startCreateNewEventsBtn);
            this.gbCreateNewEvents.Controls.Add(this.label5);
            this.gbCreateNewEvents.Controls.Add(this.newEventsDateTimePicker);
            this.gbCreateNewEvents.Controls.Add(this.label4);
            this.gbCreateNewEvents.Controls.Add(this.numberCmb);
            this.gbCreateNewEvents.Controls.Add(this.label3);
            this.gbCreateNewEvents.Controls.Add(this.endTimeCmb);
            this.gbCreateNewEvents.Controls.Add(this.label2);
            this.gbCreateNewEvents.Controls.Add(this.startTimeCmb);
            this.gbCreateNewEvents.Location = new System.Drawing.Point(23, 203);
            this.gbCreateNewEvents.Name = "gbCreateNewEvents";
            this.gbCreateNewEvents.Size = new System.Drawing.Size(655, 136);
            this.gbCreateNewEvents.TabIndex = 4;
            this.gbCreateNewEvents.TabStop = false;
            this.gbCreateNewEvents.Text = "Create new events";
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
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.numberCmb.Location = new System.Drawing.Point(377, 36);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStopSheduler);
            this.groupBox3.Controls.Add(this.btnStartSheduler);
            this.groupBox3.Location = new System.Drawing.Point(23, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 151);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shedule Events";
            // 
            // btnStopSheduler
            // 
            this.btnStopSheduler.Location = new System.Drawing.Point(252, 45);
            this.btnStopSheduler.Name = "btnStopSheduler";
            this.btnStopSheduler.Size = new System.Drawing.Size(163, 58);
            this.btnStopSheduler.TabIndex = 1;
            this.btnStopSheduler.Text = "Stop Scheduler";
            this.btnStopSheduler.UseVisualStyleBackColor = true;
            this.btnStopSheduler.Click += new System.EventHandler(this.btnStopSheduler_Click);
            // 
            // btnStartSheduler
            // 
            this.btnStartSheduler.Location = new System.Drawing.Point(34, 45);
            this.btnStartSheduler.Name = "btnStartSheduler";
            this.btnStartSheduler.Size = new System.Drawing.Size(163, 58);
            this.btnStartSheduler.TabIndex = 0;
            this.btnStartSheduler.Text = "Start Scheduler";
            this.btnStartSheduler.UseVisualStyleBackColor = true;
            this.btnStartSheduler.Click += new System.EventHandler(this.btnStartSheduler_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbMessages);
            this.groupBox4.Location = new System.Drawing.Point(23, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(655, 240);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log Messages";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(13, 19);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(622, 208);
            this.rtbMessages.TabIndex = 0;
            this.rtbMessages.Text = "";
            // 
            // btnPlaySelectedRowSound
            // 
            this.btnPlaySelectedRowSound.Location = new System.Drawing.Point(27, 498);
            this.btnPlaySelectedRowSound.Name = "btnPlaySelectedRowSound";
            this.btnPlaySelectedRowSound.Size = new System.Drawing.Size(350, 50);
            this.btnPlaySelectedRowSound.TabIndex = 3;
            this.btnPlaySelectedRowSound.Text = "Play selected sound";
            this.btnPlaySelectedRowSound.UseVisualStyleBackColor = true;
            this.btnPlaySelectedRowSound.Click += new System.EventHandler(this.btnPlaySelectedRowSound_Click);
            // 
            // gbClearData
            // 
            this.gbClearData.Controls.Add(this.btnDeleteAllData);
            this.gbClearData.Location = new System.Drawing.Point(506, 27);
            this.gbClearData.Name = "gbClearData";
            this.gbClearData.Size = new System.Drawing.Size(172, 151);
            this.gbClearData.TabIndex = 7;
            this.gbClearData.TabStop = false;
            this.gbClearData.Text = "Delete ALL Events data";
            // 
            // btnDeleteAllData
            // 
            this.btnDeleteAllData.Location = new System.Drawing.Point(18, 42);
            this.btnDeleteAllData.Name = "btnDeleteAllData";
            this.btnDeleteAllData.Size = new System.Drawing.Size(134, 58);
            this.btnDeleteAllData.TabIndex = 0;
            this.btnDeleteAllData.Text = "Delete Data";
            this.btnDeleteAllData.UseVisualStyleBackColor = true;
            this.btnDeleteAllData.Click += new System.EventHandler(this.btnDeleteAllData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 631);
            this.Controls.Add(this.gbClearData);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbCreateNewEvents);
            this.Controls.Add(this.gbSelectDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sound Scheduler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soundEventsDataGridView)).EndInit();
            this.gbSelectDate.ResumeLayout(false);
            this.gbSelectDate.PerformLayout();
            this.gbCreateNewEvents.ResumeLayout(false);
            this.gbCreateNewEvents.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbClearData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView soundEventsDataGridView;
        private System.Windows.Forms.DateTimePicker eventsDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSelectDate;
        private System.Windows.Forms.GroupBox gbCreateNewEvents;
        private System.Windows.Forms.ComboBox startTimeCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox endTimeCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox numberCmb;
        private System.Windows.Forms.Button startCreateNewEventsBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker newEventsDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStopSheduler;
        private System.Windows.Forms.Button btnStartSheduler;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnPlaySelectedRowSound;
        private System.Windows.Forms.GroupBox gbClearData;
        private System.Windows.Forms.Button btnDeleteAllData;
    }
}

