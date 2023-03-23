using Heroes_Vs_Monsters.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Vs_Monsters.Modeles
{
    public class Monstre : Personnages
    {
        public Monstre(string nom) : base(nom)
        {
            Or = Dice.Lancer(DiceType.D6, 1 );
            Cuir = Dice.Lancer(DiceType.D4, 1) ;
        }


        public int Or { get; set; }
        public int Cuir { get; set; }
    }
}
