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
        AnswerCheckController _scoreTimerController;
        

        public ButtonController(NumLetterController NumLetterController, AnswerCheckController ScoreTimerController)
        {
            //_NumLetterController = NumLetterController;
            _model = new ButtonModel();           
            _NumLetterModel = NumLetterController._model;
            _view = new Buttons(NumLetterController, this, _NumLetterModel);
            _scoreTimerController = ScoreTimerController;


        }

        public void checkAnswer(string nummerLetter, string BovenOfOnder)
        {
            _model.checkIfCorrect = false;
            bool AltijdFout = false;

                Console.WriteLine(_NumLetterModel.Nummerletter[0]);
                Console.WriteLine(_NumLetterModel.Nummerletter[1]);
          

            if (_NumLetterModel.BovenOfOnder == "boven")
            {
                
               

                for (int i = 0; i < evennumber.Length; i++)
                {
                    

                    if (_NumLetterModel.Nummerletter[0] == evennumber[i] || _NumLetterModel.Nummerletter[1] == evennumber[i])
                    {
                        if(_model.yesOrNo)
                        {
                            _model.checkIfCorrect = true;
                          
                            Console.WriteLine("correct");
                            break;
                        }
                        else
                        {
                            _model.checkIfCorrect = false;
                            AltijdFout = true;
                            break;
                            //Console.WriteLine("wrong");
                        }


                    }
                    else
                    {
                        if (!_model.yesOrNo && AltijdFout == false)
                        {
                            _model.checkIfCorrect = true;
                            //Console.WriteLine("correct");
                            
                        }
                        else
                        {
                            _model.checkIfCorrect = false;
                          
                            //Console.WriteLine("wrong");
                           
                        }
                    }
                

                }
            }
            
            if (_NumLetterModel.BovenOfOnder == "onder")
            {
               
                for (int i = 0; i < klinkers.Length; i++)
                {
                    if (_NumLetterModel.Nummerletter[0] == klinkers[i] || _NumLetterModel.Nummerletter[1] == klinkers[i])
                    {
                        if (_model.yesOrNo == true)
                        {
                            _model.checkIfCorrect = true;
                            break;
                            Console.WriteLine("correct");
                            
                        }
                        else
                        {
                            _model.checkIfCorrect = false;
                            AltijdFout = true;
                            break;
                            //Console.WriteLine("wrong");
                        }
                    }
                    else
                    {
                        if (_model.yesOrNo == false && AltijdFout == false)
                        {
                            _model.checkIfCorrect = true;
                            
                            //Console.WriteLine("correct");
                        }
                        else
                        {
                            _model.checkIfCorrect = false;                       
                            Console.WriteLine("wrong");
                          
                        }
                    }

                }

            }

            Console.WriteLine(_model.checkIfCorrect);
            if (_model.checkIfCorrect)
            {
                _scoreTimerController.answer("correct");
            }
            else
            {
                _scoreTimerController.answer("wrong");
            }


        }       


    

        public Buttons GetView()
        {
            return _view;
        }
    }
}
