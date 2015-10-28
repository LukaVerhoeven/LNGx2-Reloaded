using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{
    public class PointsAndTimerController
    {
        public PointsAndTimerModel _model;
        public PointsAndTimerView _view;

        public PointsAndTimerController()
        {
            _model = new PointsAndTimerModel();
            _view = new PointsAndTimerView(this,_model);
        }

        public void updateScore()
        {
           _view.Score();
            if (_model.Score>_model.highScore)
            {
                _model.highScore = _model.Score;
                Console.WriteLine(_model.highScore);
            }
        }
        public PointsAndTimerView GetView()
        {
            return _view;
        }
    }
}
