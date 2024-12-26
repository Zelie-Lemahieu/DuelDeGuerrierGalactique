using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelDeGuerrier_26_12_24.classes.Guerrier.Keplerien
{
    public class Keplerien : Guerrier
    {
        public Keplerien(string nom, int pointDeSante, int nombreDeDesDAttaque) : base(nom, pointDeSante, nombreDeDesDAttaque)
        {

        }

        Random aleatoire = new Random();
        public override int Attaque()
        {
            int attaque = 0;
            for (int i = 0; i < NombreDeDesDAttaque; i++)
            {
                attaque += aleatoire.Next(1, 13);//<--Simulation d'un D12
            };
            if (attaque < 15)
            {
                attaque = 15;
            };
            return attaque;
        }
    }
}
