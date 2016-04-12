using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POA_Final
{
    class Rectangle : Element
    {
        private Point point;
        private double largeur;
        private double hauteur;

        public Rectangle(string nom, int idElement, Point point, double largeur, double hauteur, Couleur couleur, int ordre) : base(nom, idElement, couleur, ordre)
        {
            this.point = point;
            this.largeur = largeur;
            this.hauteur = hauteur;
        }

        public void Translater(double dx, double dy)
        {
            this.DX = dx;
            this.DY = dy;
        }

        public void Rotation(double alpha, double cx, double cy)
        {
            this.Alpha = alpha;
            this.CX = cx;
            this.CY = cy;
        }

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
