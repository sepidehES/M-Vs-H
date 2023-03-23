using Heroes_Vs_Monsters.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Vs_Monsters.Modeles
{
    public abstract class Personnages
    {
        public Personnages(string nom)
        {
            Nom = nom;
            Endurance = Dice.Lancer();
            Force = Dice.Lancer();
            PointsDeVie = Endurance + CalculeVie.Modificateur(Endurance);
        }

        public event Action<Personnages> MortEvent;
        public string Nom { get; private set; }
        public int Endurance { get; set; }
        public int Force { get; set; }
        public int PointsDeVie { get; set; }
        public bool IsAlive => PointsDeVie > 0;


        public int Frapper(int d4 ,Personnages cible, int force = 0)
        {
            int degat = d4 + CalculeVie.Modificateur(d4) ;

            if (cible.IsAlive)
            {

                cible.PointsDeVie -= degat;

                Console.WriteLine($"{this.Nom} frappe {cible.Nom} avec {degat} dégats, Les points de vie de {cible.Nom} sont de {cible.PointsDeVie}");

                if (!cible.IsAlive)
                    Console.WriteLine($"Bravo ! Vous venez de tuer {cible.Nom}");
            }
            else if(cible.IsAlive == false)
            { 

                Console.WriteLine($"{cible.Nom} est déjà mort !");
            }

            return degat;


        }
        public void EnclencheMortEvent()
        {

            MortEvent?.Invoke(this);
        }


    }
}
