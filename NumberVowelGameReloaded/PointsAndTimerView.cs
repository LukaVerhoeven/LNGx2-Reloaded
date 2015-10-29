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
            _model.counter = 60;
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
     
            int minutes;
            int seconds;
            string Minutes;
            string Seconds;
            if (_model.counter / 60 != 0)
            {
                float i = _model.counter / 60;
                minutes = (int)Math.Floor(i);
            }
            else
            {
                minutes = _model.counter / 60;
            }

            if (_model.counter % 60 != 0)
            {
                float i = _model.counter % 60;
                seconds = (int)Math.Floor(i);
            }
            else
            {
                seconds = _model.counter % 60;
            }
           

            if (minutes < 10) 
            { 
                 Minutes = "0" + minutes.ToString();
            }
            else
            {
                 Minutes = minutes.ToString();
            }
            if (seconds < 10) 
            {
                 Seconds = "0" + seconds.ToString();
            }
            else
            {
                Seconds = seconds.ToString();
            }
            label4.Text = (Minutes + ":" + Seconds); 
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
            if (_model.counter <= 0)
            {
                timer1.Stop();
                _model.counter = 0;
            }

            int minutes;
            int seconds;
            string Minutes;
            string Seconds;
            if (_model.counter / 60 != 0)
            {
                float i = _model.counter / 60;
                minutes = (int)Math.Floor(i);
            }
            else
            {
                minutes = _model.counter / 60;
            }

            if (_model.counter % 60 != 0)
            {
                float i = _model.counter % 60;
                seconds = (int)Math.Floor(i);
            }
            else
            {
                seconds = _model.counter % 60;
            }


            if (minutes < 10)
            {
                Minutes = "0" + minutes.ToString();
            }
            else
            {
                Minutes = minutes.ToString();
            }
            if (seconds < 10)
            {
                Seconds = "0" + seconds.ToString();
            }
            else
            {
                Seconds = seconds.ToString();
            }
            label4.Text = (Minutes + ":" + Seconds); 

            //if (_model.counter < 60 && _model.counter >= 10)
            //{
            //    label4.Text = ("00:" + _model.counter.ToString());
            //}
            //else if (_model.counter < 10)
            //{
            //    label4.Text = ("00:0" + _model.counter.ToString());
            //}
        }
    }
}
