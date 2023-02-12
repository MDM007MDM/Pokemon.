using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Hitokage : Pokemon
    {
        public Hitokage()
        {
            Random random = new Random();
            Name = "Hitokage";
            HP = random.Next(188 , 282);
            _image = Properties.Resources.Hitokage;
            Attack = random.Next(98 , 223);
            Defense = random.Next(81 , 203);
        }
    }
}