using Heroes_Vs_Monsters.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Vs_Monsters.Modeles
{
    public class Loup : Monstre
    {
        public Loup(string nom) : base(nom)
        {
            Cuir = Dice.Lancer(DiceType.D4, 1);
        }

    }
}
