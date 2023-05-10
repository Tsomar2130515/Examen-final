using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public enum typeRef
    {
        air,
        liquide,

    }

    public class Moteur 
    {
        private string marque;
        private typeRef typeRefroid;
        private int force;
        public Moteur()
        {
            this.marque = "Yamaha";
            this.force = 50;
            this.typeRefroid = typeRef.air;

        }
        public Moteur(string marque,int force,typeRef typeRefroid)
        {
            this.marque=marque;
            this.force = force;
            this.typeRefroid = typeRefroid;

        }
        public static bool operator >(Moteur moteur1, Moteur moteur2)
        {
            return  moteur1.force > moteur2.force ;
        }
        
        public static bool operator < (Moteur moteur1, Moteur moteur2)
        {
            return  moteur1.force < moteur2.force ;
        }
        public string Marque
        {
            get { return marque; }
        }
        public typeRef TypeRefroid
        {
            get { return typeRefroid; }
        }
        public int Force
        {
            get { return force; }
        }
        public override string ToString()
        {
            string info = "Marque: ";
            info+= Marque + " HP :" + Force + " Prix  : " + TypeRefroid + "\n";
            return info;
        }






    }
}
