using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{
    public class AnswerCheckController
    {

        AnswerCheckView _view;

        public AnswerCheckController()
        {

            _view = new AnswerCheckView();

        }
        public void answer(string Answer)
        {
            _view.changetext(Answer);
        }


        public AnswerCheckView GetView()
        {
            return _view;
        }
    }
}
