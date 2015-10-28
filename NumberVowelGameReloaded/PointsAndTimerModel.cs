using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{
    public class PointsAndTimerModel
    {

        int score;
        int Counter;

        public int counter
        {
            get
            {
                return Counter;
            }
            set
            {
                Counter = value;
            }
        }
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }
    }
}
