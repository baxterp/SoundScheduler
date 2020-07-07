using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundScheduler
{
    public partial class MainForm : Form
    {
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
            var soundEventsModel = new SoundEventsEntities();

            var soundEventsList = soundEventsModel.SoundEvents
                                        .Where(s => s.TimeStamp.Value.Day == eventsDateTimePicker.Value.Day).ToList();

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
    }
}
