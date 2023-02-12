using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Pojjama : Pokemon
    {
        public Pojjama()
        {
            Random random = new Random();
            Name = "Pojjama";
            HP = random.Next(216 , 310);
            _image = Properties.Resources.Pojjama;
            Attack = random.Next(96 , 221);
            Defense = random.Next(99 , 225);
        }
    }
}
