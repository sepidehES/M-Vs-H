using Heroes_Vs_Monsters.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Vs_Monsters.Modeles
{
    public class Orque
    {
        public Orque(string nom) : base(nom)
        {
            Force += 1;
            Or = Dice.Lancer(DiceType.D6, 1) + 1;
        }
    }
}
