﻿using System;
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
    public partial class NumLetterView : UserControl
    {
        NumLetterController _controller;
        NumLetterModel _model;
        static int timer = 0;
        Random random = new Random(timer++);

        public NumLetterView(NumLetterController Controller , NumLetterModel Model)
        {
            _controller = Controller;
            _model = Model;
            InitializeComponent();
           
        }

        public void PutNumletterInLabel()
        {
            
            int rndLabel = random.Next(2);
            Console.WriteLine("Order: " + rndLabel);
            _controller.GenereerNumLetter();

            if (rndLabel == 0)
            {
                label2.Text = "";
                label1.Text = _model.Nummerletter;
            }
            else if(rndLabel == 1)
            {
                label1.Text = "";
                label2.Text = _model.Nummerletter;
            }
            else
            {
                label1.Text = "ERROR";
                label2.Text = "ERROR";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PutNumletterInLabel();
            Console.WriteLine("---RUN COMPLETE---");
        }

        private void NumLetterView_Load(object sender, EventArgs e)
        {

        }
    }
}
