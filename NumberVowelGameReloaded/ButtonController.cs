using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{
    public class ButtonController
    {
        //NumLetterController _NumLetterController;
        Buttons _view;
        NumLetterModel _NumLetterModel;



        public ButtonController(NumLetterController NumLetterController)
        {
            //_NumLetterController = NumLetterController;
            _view = new Buttons(NumLetterController);
            _NumLetterModel = NumLetterController._model;


        }

        public void checkAnswer(string nummerLetter,string BovenOfOnder)
        {
            if (_NumLetterModel.BovenOfOnder == "Boven")
            {

            }
            
        }

        public Buttons GetView()
        {
            return _view;
        }
    }
}
