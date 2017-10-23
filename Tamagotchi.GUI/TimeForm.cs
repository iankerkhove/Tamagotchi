using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace we3.tamagotchi
{
    public partial class TimeForm : Form
    {
        private Timer timer;
        private bool running;
        private int current;

        public TimeForm()
        {
            InitializeComponent();
            timer = new Timer();
            running = true;
            current = 0;

            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 1000;
            timer.Start();
        }

        private void TimerEventProcessor(object source, EventArgs eventArgs)
        {
            current++;
            timer.Stop();

            if (MessageBox.Show("Continue?", "Current " + current, MessageBoxButtons.YesNo) == DialogResult.Yes)
                timer.Enabled = true;
            else
                running = false;


            label1.Text = current.ToString();
        }
    }
}
