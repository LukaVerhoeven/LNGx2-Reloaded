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
        NumLetterView _NumLetterView;

        public ButtonController(NumLetterController NumLetterController)
        {
            _NumLetterController = NumLetterController;
            _NumLetterView = _NumLetterController._view;
        }

        public void checkAnswer(string nummerLetter,string BovenOfOnder)
        {
            
        }

    }
}
