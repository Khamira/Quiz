using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teleturniej
{
    class Questions
    {
        public string question { get; set; }
        public string answer { get; set; }
        public List<string> allAnswers { get; set; }


        public Questions(string q, string a, List<string> aa)
        {
            this.question = q;
            this.answer = a;
            this.allAnswers = aa;
        }
    }
}
