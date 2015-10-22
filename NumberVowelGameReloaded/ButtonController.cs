using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{
    public class ButtonController
    {
        NumLetterController _NumLetterController;
        Buttons _view;

        public ButtonController(NumLetterController NumLetterController)
        {
            _NumLetterController = NumLetterController;
            _view = new Buttons();

        }

        public void checkAnswer(string nummerLetter,string BovenOfOnder)
        {
            
        }

    }
}
