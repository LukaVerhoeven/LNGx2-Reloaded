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
        public PointsAndTimerView(PointsAndTimerController Controller)
        {
            _controller = Controller;
            InitializeComponent();
        }

        public void Score()
        {
            label3.Text = _controller._model.Score.ToString();
        }
    }
}
