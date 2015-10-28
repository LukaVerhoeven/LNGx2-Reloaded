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
        int highscore;

        public int highScore
        {
            get
            {
                return highscore;
            }
            set
            {
                highscore = value;
            }
        }
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
