using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Roue
    {
        public string Marque { get; set; }
        public int  Grandeur { get; set; }
        public Roue(string marque,int grandeur)
        {
            this.Marque = marque;
            this.Grandeur = grandeur;

        }
        public override string ToString()
        {
            string info = " Marque : "+Marque  ;
            info += " Grandeur : " + Grandeur;
            return info;
        }

    }
}
