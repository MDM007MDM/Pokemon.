using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Nias : Pokemon
    {
        public Nias()
        {
            Random random = new Random();
            Name = "Nias";
            HP = random.Next(190 , 284);
            _image = Properties.Resources.Nias;
            Attack = random.Next(85 , 207);
            Defense = random.Next(67 , 185);
        }
    }
}
