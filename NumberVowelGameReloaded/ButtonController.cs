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
        string klinkers = "AEIOU";
        string evennumber = "2468";
        

        public ButtonController(NumLetterController NumLetterController)
        {
            //_NumLetterController = NumLetterController;
            _view = new Buttons(NumLetterController);
            _NumLetterModel = NumLetterController._model;


        }

        public void checkAnswer(string nummerLetter,string BovenOfOnder)
        {
           

            if (_NumLetterModel.BovenOfOnder == "boven")
            {
          
                for (int i = 0; i < evennumber.Length; i++)
                {
                if (_NumLetterModel.Nummerletter[0] == evennumber[i] || _NumLetterModel.Nummerletter[0] == evennumber[i])
                {

                }

                }
            }

            if (_NumLetterModel.BovenOfOnder == "onder")
            {
                for (int i = 0; i < klinkers.Length; i++)
                {
                    if (_NumLetterModel.Nummerletter[0] == klinkers[i] || _NumLetterModel.Nummerletter[1] == klinkers[i])                      )
                    {

                    }

             }

         }        


    

        public Buttons GetView()
        {
            return _view;
        }
    }
}
