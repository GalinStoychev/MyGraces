using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Warrior
    {
        private string name;

        private string heroType;

        public Warrior(string name, string heroType)
        {
            this.heroType = heroType;
            this.name = name;
        }
    }
}
