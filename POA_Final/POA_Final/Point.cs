using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_Final
{
    
    // Classe implémentant les points des polygones à transformer
    public class Point
    {
        private double x;
        private double y;

// Un point est défini par des coordonnées en abscisse et en ordonnée 
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
