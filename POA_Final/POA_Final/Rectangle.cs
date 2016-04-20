using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POA_Final
{
    //Classe héritage Element
    public class Rectangle : Element
    {
        private Point point;
        private double largeur;
        private double hauteur;


//Constructeur Rectangle des points, une donnée de largeur et une donnée de longueur
        public Rectangle(string nom, int idElement, Point point, double largeur, double hauteur, Couleur couleur, int ordre) : base(nom, idElement, couleur, ordre)
        {
            this.point = point;
            this.largeur = largeur;
            this.hauteur = hauteur;
        }


// Méthode de translation des points
        public void Translater(double dx, double dy)
        {
            this.DX = dx;
            this.DY = dy;
        }

// Méthode de rotation des points
        public void Rotation(double alpha, double cx, double cy)
        {
            this.Alpha = alpha;
            this.CX = cx;
            this.CY = cy;
        }


//  Méthode de dessin qui renvoie au format svg les données csv
        public override string ToString()
        {
            if (this.DX == 0 && this.DY == 0)
            {
                if (this.Alpha == 0 && this.CX == 0 && this.CY == 0)
                {
                    return "<rect x=\"" + point.X + "\" y=\"" + point.Y + "\" width=\"" + largeur + "\" height=\"" + hauteur + "\" style=\"fill :rgb(" + Couleur + ")\" />";
                }
                else
                {
                    return "<rect x=\"" + point.X + "\" y=\"" + point.Y + "\" width=\"" + largeur + "\" height=\"" + hauteur + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ")\"/>";
                }
            }
            else
            {
                if (this.Alpha == 0 && this.CX == 0 && this.CY == 0)
                {
                    return "<rect x=\"" + point.X + "\" y=\"" + point.Y + "\" width=\"" + largeur + "\" height=\"" + hauteur + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"translate(" + this.DX + "," + this.DY + ")\"/>";
                }
                else
                {
                    return "<rect x=\"" + point.X + "\" y=\"" + point.Y + "\" width=\"" + largeur + "\" height=\"" + hauteur + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ") translate(" + this.DX + "," + this.DY + ")\" />";
                }
            }
        }
    }
}
