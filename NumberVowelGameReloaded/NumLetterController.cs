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
        public string GenResult;  
    
        string[] Alfabet = { "A", "B", "C", "D", "E", "F", "G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };


        public NumLetterController()
        {
            _view = new NumLetterView(this);
        }

        public void GenereerNumLetter()
        {
            Random rndom = new Random();
            int switchnbrlet = rndom.Next(2);

            if (switchnbrlet == 0)
            {
                Random rnd = new Random();
                int rndNbr = rnd.Next(1, 10);
                int rndLtr = rnd.Next(26);
                string result = rndNbr.ToString() + Alfabet[rndLtr];
                GenResult = result;

            }
            else if(switchnbrlet == 1)
            {
                Random rnd = new Random();
                int rndNbr = rnd.Next(1, 10);
                int rndLtr = rnd.Next(26);
                string result = Alfabet[rndLtr] + rndNbr.ToString();
                GenResult = result;
            }
            else
            {
                GenResult = "ERROR";
            }



        }
        public NumLetterView GetView()
        {
            return _view;
        }




    }
}
