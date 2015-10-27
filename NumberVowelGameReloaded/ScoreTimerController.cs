using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{
    public class ScoreTimerController
    {

        scoreTimerView _view;

        public ScoreTimerController()
        {

            _view = new scoreTimerView();

        }
        public void answer(string Answer)
        {
            _view.changetext(Answer);
        }


        public scoreTimerView GetView()
        {
            return _view;
        }
    }
}
