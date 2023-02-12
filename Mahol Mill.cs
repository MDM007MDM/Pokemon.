using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Mahol_Mill : Pokemon
    {
        public Mahol_Mill()
        {
            Random random = new Random();
            Name = "Mahol Mill";
            HP = random.Next(20 , 294);
            _image = Properties.Resources.Mahol_Mill;
            Attack = random.Next(76 , 196);
            Defense = random.Next(76 , 196);
        }
    }
}
