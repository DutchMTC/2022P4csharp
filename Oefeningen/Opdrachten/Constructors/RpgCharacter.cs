using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class RpgCharacter
    {
        internal readonly string name;
        internal int str;
        internal int hp;

        public RpgCharacter(string name, int str, int hp)
        {
            this.name = name;
            this.str = str;
            this.hp = hp;
        }
    }
}
