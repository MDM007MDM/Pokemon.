using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon
{
    internal class Nyoha : Pokemon
    {
        public Nyoha()
        {
            Random random = new Random();
            Name = "Nyoha";
            HP = random.Next(190 , 284);
            _image = Properties.Resources.Nyoha;
            Attack = random.Next(114 , 243);
            Defense = random.Next(101 , 227);
        }
    }
}