using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameThatTune
{
    public class Player
    {
        public string Name { get; set; }
        public decimal Cash { get; set; }

        public string Answer { get; set; }
        public Player(string name, decimal c, string a)
        {
            Name = name;
            Cash = c;
            Answer = a;
        }
        public Player(Player p)
        {
            Name = p.Name;
            Cash = p.Cash;
            Answer = p.Answer;
        }
    }
    
}
