using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Vs_Monsters.Modeles
{
    public class Humain : Hero
    {
        public Humain(string nom) : base(nom)
        {
            Force += 1;
            Endurance += 1;
        }
    }
}
