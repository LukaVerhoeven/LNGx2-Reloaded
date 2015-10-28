﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberVowelGameReloaded
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScoreTimerController STController = new ScoreTimerController();
            scoreTimerView STView = STController.GetView();
            Controls.Add(STController.GetView());
            STView.Location = new Point(45, 105);

            NumLetterController NLController = new NumLetterController();
            NumLetterView NLView = NLController.GetView();
            Controls.Add(NLController.GetView());
            NLView.Location = new Point(0, 0);

            ButtonController BController = new ButtonController(NLController, STController);
            Buttons BView = BController.GetView();
            Controls.Add(BController.GetView());
            BView.Location = new Point(0, 200);

        }
    }
}
