using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{

    public class NumLetterController
    {
        NumLetterView _view;
        public NumLetterModel _model; 
    
        string[] Alfabet = { "A", "B", "C", "D", "E", "F", "G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };


        public NumLetterController()
        {
            _model = new NumLetterModel();
            _view = new NumLetterView(this, _model);
            
        }
        public void VeranderLabel()
        {
            _view.PutNumletterInLabel();
        }

        public void GenereerNumLetter()
        {
            Random rndom = new Random();
            int switchnbrlet = rndom.Next(2);
            Console.WriteLine("Order: " + switchnbrlet);
 
            if (switchnbrlet == 0)
            {
                Random rnd = new Random();
                int rndNbr = rnd.Next(1, 10);
                int rndLtr = rnd.Next(26);
                string result = rndNbr.ToString() + Alfabet[rndLtr];                
                _model.Nummerletter = result;
               

            }
            else if(switchnbrlet == 1)
            {
                Random rnd = new Random();
                int rndNbr = rnd.Next(1, 10);
                int rndLtr = rnd.Next(26);
                string result = Alfabet[rndLtr] + rndNbr.ToString();                
                _model.Nummerletter = result;

            }
            else
            {
                _model.Nummerletter = "ERROR";
            }



        }
        public NumLetterView GetView()
        {
            return _view;
        }




    }
}
