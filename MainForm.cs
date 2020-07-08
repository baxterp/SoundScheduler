using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace SoundScheduler
{
    public partial class MainForm : Form
    {
        #region Private Members

        private SoundEventsEntities soundEventsModel = new SoundEventsEntities();
        private delegate void InvokeDelegate();
        private System.Timers.Timer eventsTimer;
        private string baseResourceLocation = Environment.CurrentDirectory + @"\Resources\";
        private int timerFrequency = 60000;
        private System.Media.SoundPlayer player = null;
        private string filenameToPlay = string.Empty;

        private List<ScheduledEventsData> scheduledEventsForToday;

        #endregion

        #region Form Events

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            startTimeCmb.SelectedIndex = 0;
            numberCmb.SelectedIndex = 0;
            endTimeCmb.Enabled = false;
            numberCmb.Enabled = false;
            startCreateNewEventsBtn.Enabled = false;
            eventsDateTimePicker.Value = DateTime.Now;
            btnPlaySelectedRowSound.Enabled = false;
        }

        private void eventsDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var soundEventsList = soundEventsModel.SoundEvents
                                        .Where(s => s.TimeStamp.Value.Day == eventsDateTimePicker.Value.Day).OrderBy(o => o.TimeStamp).ToList();

            soundEventsDataGridView.DataSource = soundEventsList
                                                    .Select(x => new
                                                    {
                                                        x.TimeStamp,
                                                        x.Sound.SoundFileName,
                                                        x.IsEnabled
                                                    }).ToList();
        }

        private void startTimeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startTimeCmb.SelectedIndex == 0) 
                return;

            endTimeCmb.Items.Clear();

            var selectedValue = int.Parse(startTimeCmb.SelectedItem.ToString().Substring(0, 2));

            for (int i = selectedValue + 1; i <= 23; i++ )
            {
                if(i < 10)
                    endTimeCmb.Items.Add("0" + i + ":00");
                else
                    endTimeCmb.Items.Add(i + ":00");
            }
            endTimeCmb.Enabled = true;
            numberCmb.Enabled = true;
        }

        private void endTimeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            startCreateNewEventsBtn.Enabled = true;
        }

        private void startCreateNewEventsBtn_Click(object sender, EventArgs e)
        {
            InvokeMethodThreaded(new Action(() =>
            {
                DeleteOldEntriesForDate(newEventsDateTimePicker.Value);

                Random seed = new Random();

                int selectedStartTime = 0;
                int selectedEndTime = 0;
                int selectedNumberPer = 0;

                InvokeUIThreadAction(new Action(() =>
                {
                    selectedStartTime = int.Parse(startTimeCmb.SelectedItem.ToString().Substring(0, 2));
                    selectedEndTime = int.Parse(endTimeCmb.SelectedItem.ToString().Substring(0, 2));
                    selectedNumberPer = int.Parse(numberCmb.SelectedItem.ToString());
                }));

                do
                {
                    Thread.Sleep(50);
                } while (selectedNumberPer == 0);

                for (int i = selectedStartTime; i < selectedEndTime; i++)
                {
                    List<int> timeEvents = new List<int>();

                    for (int j = 1; j <= selectedNumberPer; j++)
                    {
                        int minuteValue = 0;
                        do
                        {
                            minuteValue = seed.Next(1, 60);

                        } while (timeEvents.Contains(minuteValue));

                        timeEvents.Add(minuteValue);

                    }

                    for (int j = 0; j < timeEvents.Count; j++)
                    {
                        var soundToPlay = seed.Next(1, 6);
                        var dateTimeToAdd = new DateTime(   newEventsDateTimePicker.Value.Year, 
                                                            newEventsDateTimePicker.Value.Month, 
                                                            newEventsDateTimePicker.Value.Day, 
                                                            i, timeEvents[j], 0);

                        var newEventToAdd = new SoundEvent { IsEnabled = true, SoundID = soundToPlay, TimeStamp = dateTimeToAdd };
                        soundEventsModel.SoundEvents.Add(newEventToAdd);
                    }
                }

                try
                {
                    soundEventsModel.SaveChanges();
                    soundEventsModel = new SoundEventsEntities();
                }
                catch (Exception ex)
                {
                    SendLogMessage("Problem saving data to the database, message : " + ex.Message);
                }

                InvokeUIThreadAction(new Action(() =>
                {
                    eventsDateTimePicker.Value = new DateTime(2001, 12, 12);
                    eventsDateTimePicker.Value = newEventsDateTimePicker.Value;
                }));

            }));
        }

        private void btnStartSheduler_Click(object sender, EventArgs e)
        {
            InvokeUIThreadAction(new Action(() =>
            {
                gbCreateNewEvents.Enabled = false;
                gbSelectDate.Enabled = false;
                btnStartSheduler.Enabled = false;
            }));

            try
            {
                eventsTimer = new System.Timers.Timer(timerFrequency);
                eventsTimer.Elapsed += EventsTimer_Elapsed;
                eventsTimer.Start();

                scheduledEventsForToday = soundEventsModel.SoundEvents
                                                .Where(s =>
                                                        s.TimeStamp.Value.Year == DateTime.Now.Year
                                                        && s.TimeStamp.Value.Month == DateTime.Now.Month
                                                        && s.TimeStamp.Value.Day == DateTime.Now.Day
                                                        && s.IsEnabled == true)
                                                .Select(s => new ScheduledEventsData
                                                {
                                                    EventsTime = s.TimeStamp,
                                                    FileNameToPlay = s.Sound.SoundFileName
                                                }).ToList();

                SendLogMessage("Events timer STARTED successfully");
            }
            catch (Exception ex)
            {
                SendLogMessage("Problem starting events timer: " + ex.Message);

                InvokeUIThreadAction(new Action(() =>
                {
                    gbCreateNewEvents.Enabled = true;
                    gbSelectDate.Enabled = true;
                    btnStartSheduler.Enabled = true;
                }));
            }
        }

        private void btnStopSheduler_Click(object sender, EventArgs e)
        {
            try
            {
                eventsTimer.Stop();
                SendLogMessage("Events timer STOPPED successfully");
            }
            catch (Exception ex)
            {
                SendLogMessage("Problem stopping events timer: " + ex.Message);
            }

            InvokeUIThreadAction(new Action(() =>
            {
                gbCreateNewEvents.Enabled = true;
                gbSelectDate.Enabled = true;
                btnStartSheduler.Enabled = true;
            }));
        }

        #endregion

        #region Private Methods

        private void EventsTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            bool messageSent = false;
            scheduledEventsForToday.ForEach(scheduledEvent =>
            {
                if (scheduledEvent.EventsTime.Value.Minute == DateTime.Now.Minute
                    && scheduledEvent.EventsTime.Value.Hour == DateTime.Now.Hour)
                {
                    var filePath = baseResourceLocation + scheduledEvent.FileNameToPlay;

                    try
                    {
                        PlaySound(filePath);

                        SendLogMessage("Sound file : " + scheduledEvent.FileNameToPlay + ", played successfully @ " + DateTime.Now.ToString("dd MMMM HH:mm"));
                        messageSent = true;
                    }
                    catch (Exception ex)
                    {
                        SendLogMessage("Sound file : " + scheduledEvent.FileNameToPlay + ", FAILED to play @ " + DateTime.Now.ToString("dd MMMM HH:mm"));
                        SendLogMessage("Error details: " + ex.Message);
                        messageSent = true;
                    }
                }
            });

            if (!messageSent)
            {
                SendLogMessage("No sound to play during timer event @ " + DateTime.Now.ToString("dd MMMM HH:mm"));
                messageSent = true;
            }
        }

        private void DeleteOldEntriesForDate(DateTime dateToDeleteFor)
        {
            var entriesToDelete = soundEventsModel.SoundEvents.Where(s => s.TimeStamp.Value.Year == dateToDeleteFor.Year
                                                                     && s.TimeStamp.Value.Month == dateToDeleteFor.Month
                                                                     && s.TimeStamp.Value.Day == dateToDeleteFor.Day).ToList();
            foreach(var entryToDelete in entriesToDelete)
            {
                soundEventsModel.SoundEvents.Remove(entryToDelete);
            }
            soundEventsModel.SaveChanges();
            soundEventsModel = new SoundEventsEntities();
        }

        private void InvokeMethodThreaded(Action actionToExecute)
        {
            Thread t = new Thread(delegate ()
            {
                this.BeginInvoke(new InvokeDelegate(new Action(() => this.Enabled = false)));
                actionToExecute();
                this.BeginInvoke(new InvokeDelegate(new Action(() => this.Enabled = true)));
            });
            t.Start();
        }

        private void InvokeUIThreadAction(Action actionToExecute)
        {
            this.BeginInvoke(new InvokeDelegate(actionToExecute));
        }

        private void PlaySound(string fileName)
        {
            try
            {
                player = new System.Media.SoundPlayer(fileName);
                player.Play();
            }
            catch (Exception ex)
            {
                SendLogMessage("Problem playing sound file: " + fileName);
                SendLogMessage("Error: " + ex.Message);
            }
        }

        private void SendLogMessage(string messageToDisplay)
        {
            InvokeUIThreadAction(new Action(() =>
            {
                rtbMessages.AppendText("> " + messageToDisplay + Environment.NewLine);
                rtbMessages.ScrollToCaret();
            }));
        }

        #endregion

        private void soundEventsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnPlaySelectedRowSound.Enabled = false;

            var rowsCount = soundEventsDataGridView.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;

            var row = soundEventsDataGridView.SelectedRows[0];
            if (row == null) return;

            var filename = row.Cells[1].Value.ToString();

            filenameToPlay = filename;

            btnPlaySelectedRowSound.Enabled = true;
        }

        private void btnPlaySelectedRowSound_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(filenameToPlay))
            {
                PlaySound(baseResourceLocation +  filenameToPlay);
            }
        }
    }

    public class ScheduledEventsData
    {
        public DateTime? EventsTime { get; set; }
        public string FileNameToPlay { get; set; }
    }
}
