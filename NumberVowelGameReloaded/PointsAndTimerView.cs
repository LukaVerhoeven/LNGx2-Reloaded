using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberVowelGameReloaded
{
    public partial class PointsAndTimerView : UserControl
    {
        PointsAndTimerController _controller;
        int counter = 59;

        public PointsAndTimerView(PointsAndTimerController Controller)
        {
            _controller = Controller;
            InitializeComponent();
            Timer();
    
        }

        public void Timer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            label4.Text = "00:" + counter.ToString();
        }

        public void Score()
        {
            label3.Text = _controller._model.Score.ToString();
        }

        private void PointsAndTimerView_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                timer1.Stop();

            label4.Text = "00:" + counter.ToString();
        }
    }
}
