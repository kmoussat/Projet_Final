using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_Final
{
    class Program
    {
        static void Main(string[] args)
        {

            Dessin d1 = new Dessin();
            d1.lireFichier("ExempleTout");
            d1.listElement.Sort();
            d1.ecrireFichier("ExempleTout");

            Dessin d2 = new Dessin();
            d2.lireFichier("exemple1");
            d2.listElement.Sort();
            d2.ecrireFichier("exemple1");

            Dessin d3 = new Dessin();
            d3.lireFichier("exemple2");
            d3.listElement.Sort();
            d3.ecrireFichier("exemple2");

            Dessin d4 = new Dessin();
            d4.lireFichier("exemple3");
            d4.listElement.Sort();
            d4.ecrireFichier("exemple3");

            Dessin d5 = new Dessin();
            d5.lireFichier("exemple4");
            d5.listElement.Sort();
            d5.ecrireFichier("exemple4");

            Console.WriteLine("Fin du programme, appuyez pour quitter");
            Console.ReadKey();
        }
    }
}

