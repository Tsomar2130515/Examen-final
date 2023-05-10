using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public  class VTT : VehiculeMotorise
    {
        private Roue roue;
        public VTT(string nom, string marque, int prix, Moteur moteur, string marqueRoue, int grandeurRoue) : base(nom, marque, prix, moteur)
        {
            roue = new Roue(marqueRoue, grandeurRoue);
        }
        public VTT(string nom, string marque, int prix, Moteur moteur,Roue roue ) : base(nom, marque, prix, moteur)
        {
            this.roue = roue;
        }
        
        public override string ToString()
        {
            string info = "INFORMATION VTT \n";
            info += "Nom : " +nom + "Marque :"+marque+ " Prix  : " + prix+ "$"+"\n";
            info+=  "INFORMATION SUR LE MOTEUR \n";
            info += moteur.ToString() + "\n";
            info += "INFO ROUE \n";
            info += roue.ToString()+"\n";
            return info;

        }

    }
}
