using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelDeGuerrier_26_12_24.classes.Guerrier.Gliesean
{
    public class Gliesean : Guerrier
    {
        //Attributs:
        private bool _portDeLArmureEnZibupite;

        //Propriétés:
        public bool PortDeLArmureEnZibupite { get { return _portDeLArmureEnZibupite; } set { _portDeLArmureEnZibupite = value; } }

        //Constructeur:
        public Gliesean(string nom, int pointDeSante, int nombreDeDesDAttaque, bool portDeLArmureEnZibupite) : base(nom, pointDeSante, nombreDeDesDAttaque)
        {
            PortDeLArmureEnZibupite = portDeLArmureEnZibupite = true;//<--Armure qui confère /2 en subission des dégats.
        }


        public override void DegatsSubis(int degats)
        {
            if (PortDeLArmureEnZibupite == true)
            {
                PointDeSante -= (degats / 2);
            }
            else
            {
                PointDeSante -= degats;
            }
        }
    }
}
