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
        ButtonController _buttonController;
        NumLetterModel _numLetterModel;

        public Buttons(NumLetterController NumLetterController, ButtonController ButtonController, NumLetterModel NumLetterModel)
        {
            _NumLetterController = NumLetterController;
            _buttonController = ButtonController;
            _numLetterModel = NumLetterModel;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _NumLetterController.VeranderLabel();

            _buttonController.checkAnswer(_numLetterModel.Nummerletter , _numLetterModel.BovenOfOnder);

            Console.WriteLine("---RUN COMPLETE---");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _NumLetterController.VeranderLabel();
            _buttonController.checkAnswer(_numLetterModel.Nummerletter, _numLetterModel.BovenOfOnder);
            Console.WriteLine("---RUN COMPLETE---");
        }
    }
}
