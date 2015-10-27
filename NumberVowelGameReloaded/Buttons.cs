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
    public partial class Buttons : UserControl
    {

        NumLetterController _NumLetterController;

        public Buttons(NumLetterController NumLetterController)
        {
            _NumLetterController = NumLetterController;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _NumLetterController.VeranderLabel();

            Console.WriteLine("---RUN COMPLETE---");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _NumLetterController.VeranderLabel();
            Console.WriteLine("---RUN COMPLETE---");
        }
    }
}
