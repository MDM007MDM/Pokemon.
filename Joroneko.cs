using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Joroneko : Pokemon
    {
        public Joroneko()
        {
            Random random = new Random();
            Name = "Joroneko";
            HP = random.Next(290, 384);
            _image = Properties.Resources.Joroneko;
            Attack = random.Next(202, 350);
            Defense = random.Next(148, 284);
        }
    }
}