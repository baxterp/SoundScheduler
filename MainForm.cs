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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            eventsDateTimePicker.Value = DateTime.Now;
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
    }
}
