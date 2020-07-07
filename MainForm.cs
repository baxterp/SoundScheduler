using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundScheduler
{
    public partial class MainForm : Form
    {
        SoundEventsEntities soundEventsModel = new SoundEventsEntities();
        public delegate void InvokeDelegate();
        
        List<string> endTimeValues = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            eventsDateTimePicker.Value = DateTime.Now;
            startTimeCmb.SelectedIndex = 0;
            numberCmb.SelectedIndex = 0;
            endTimeCmb.Enabled = false;
            numberCmb.Enabled = false;
            startCreateNewEventsBtn.Enabled = false;
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
                        var dateTimeToAdd = new DateTime(   newEventsDateTimePicker.Value.Year, 
                                                            newEventsDateTimePicker.Value.Month, 
                                                            newEventsDateTimePicker.Value.Day, 
                                                            i, timeEvents[j], 0);

                        var newEventToAdd = new SoundEvent { IsEnabled = true, SoundID = 1, TimeStamp = dateTimeToAdd };
                        soundEventsModel.SoundEvents.Add(newEventToAdd);
                    }
                }

                try
                {
                    soundEventsModel.SaveChanges();
                }
                catch (Exception ex)
                {

                }

                InvokeUIThreadAction(new Action(() =>
                {
                    eventsDateTimePicker.Value = newEventsDateTimePicker.Value;
                }));

            }));
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
    }
}
