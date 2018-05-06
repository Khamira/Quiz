using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teleturniej
{
    class User
    {
        public int points { get; set; }
        public List<Questions> set_of_quest { get; set; }
        public Questions currQuest { get; set; }

        public User(int points)
        {
            this.points = points;
            set_of_quest = new List<Questions>();
        }
    }
}
