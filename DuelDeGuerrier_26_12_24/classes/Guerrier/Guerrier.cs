using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelDeGuerrier_26_12_24.classes.Guerrier
{
    public class Guerrier
    {
        Random aleatoire = new Random();

        //Attributs de la classe:
        private string _nom = "Guerrier Anonyme";
        private int _pointDeSante = 20;
        private int _nombreDeDesDAttaque = 1;

        //Propriétés de la classe:
        public string Nom { get { return _nom; } set { _nom = value; } }
        public int PointDeSante { get { return _pointDeSante; } set { _pointDeSante = value; } }
        public int NombreDeDesDAttaque { get { return _nombreDeDesDAttaque; } set { _nombreDeDesDAttaque = value; } }

        //Constructeur de la classe
        public Guerrier(string nom, int pointDeSante, int nombreDeDesDAttaque)
        {
            Nom = nom;
            PointDeSante = pointDeSante;
            NombreDeDesDAttaque = nombreDeDesDAttaque;
        }

        //Méthode d'affichage des infos du guerrier:
        public string AffichageInfo()
        {
            return Nom + "{PS = " + PointDeSante + "}";
        }

        //Méthode d'attaque du gerrier:
        public virtual int Attaque()
        {
            int attaque = 0;
            for (int i = 0; i < NombreDeDesDAttaque; i++)
            {
                attaque += aleatoire.Next(1, 7);//<--Simulation d'un D6
            };
            return attaque;
        }

        //Méthode de subission de l'attaque du gerrier adverse:
        public virtual void DegatsSubis(int degats)
        {
            PointDeSante -= degats;
        }
    }
}
