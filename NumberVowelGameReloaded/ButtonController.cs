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
        public ButtonModel _model;
        NumLetterModel _NumLetterModel;
        string klinkers = "AEIOU";
        string evennumber = "2468";
        ScoreTimerController _scoreTimerController;
        

        public ButtonController(NumLetterController NumLetterController, ScoreTimerController ScoreTimerController)
        {
            //_NumLetterController = NumLetterController;
            _model = new ButtonModel();           
            _NumLetterModel = NumLetterController._model;
            _view = new Buttons(NumLetterController, this, _NumLetterModel);
            _scoreTimerController = ScoreTimerController;


        }

        public void checkAnswer(string nummerLetter, string BovenOfOnder)
        {

          

            if (_NumLetterModel.BovenOfOnder == "boven")
            {

                for (int i = 0; i < evennumber.Length; i++)
                {
                    if (_NumLetterModel.Nummerletter[0] == evennumber[i] || _NumLetterModel.Nummerletter[0] == evennumber[i])
                    {
                        _model.checkIfCorrect = "correct";
                        _scoreTimerController.answer("correct");
                        Console.WriteLine("correct");

                    }
                    else
                    {
                        _model.checkIfCorrect = "wrong";
                        _scoreTimerController.answer("wrong");
                        Console.WriteLine("wrong");
                    }
                

                }
            }
            
            if (_NumLetterModel.BovenOfOnder == "onder")
            {
               
                for (int i = 0; i < klinkers.Length; i++)
                {
                    if (_NumLetterModel.Nummerletter[0] == klinkers[i] || _NumLetterModel.Nummerletter[1] == klinkers[i])
                    {
                        _model.checkIfCorrect = "correct";
                        _scoreTimerController.answer("correct");
                        Console.WriteLine("correct");
                    }
                    else
                    {
                        _model.checkIfCorrect = "wrong";
                        _scoreTimerController.answer("wrong");
                        Console.WriteLine("wrong");
                    }

                }

            }
        }       


    

        public Buttons GetView()
        {
            return _view;
        }
    }
}
