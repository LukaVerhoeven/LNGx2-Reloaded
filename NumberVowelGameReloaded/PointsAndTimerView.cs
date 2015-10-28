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
        PointsAndTimerModel _model;
       

        public PointsAndTimerView(PointsAndTimerController Controller, PointsAndTimerModel model)
        {
            _model = model;
            _controller = Controller;
            InitializeComponent();
            Timer();
            _model.counter = 15;
    
        }

        public void Timer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            int minutes = 0;
            int seconds = _model.counter;
            if (seconds >= 60)
            {
                minutes++;
                seconds = 0;
                label4.Text = (minutes + ":" + seconds);
            }
            
            //label4.Text = ("00:" + counter.ToString());
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
            _model.counter--;
            if (_model.counter == 0)
                timer1.Stop();

            if (_model.counter < 60 && _model.counter >= 10)
            {
                label4.Text = ("00:" + _model.counter.ToString());
            }
            else if (_model.counter < 10)
            {
                label4.Text = ("00:0" + _model.counter.ToString());
            }
        }
    }
}
