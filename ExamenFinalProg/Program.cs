using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Moteur mot = new Moteur();
            Roue roue = new Roue("Af", 56);
            VTT vtt = new VTT("Spark Marque", "Spark",1200,mot,"Aw",52);
            VTT vt = new VTT("Spark Marque", "Spark", 1200, mot,roue);
            Console.WriteLine(vtt.ToString());
            Console.ReadKey();


        }
    }
}
