using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POA_Final
{
    
    //Classe héritage Element
    public class Ellipse : Element, ITranslation, IRotation
    {
        private Point centre;
        private double rx;
        private double ry;

//Constructeur Ellipse par deux rayons et un point central
        public Ellipse(string nom, int idElement, Point centre, double rx, double ry, Couleur couleur, int ordre) : base(nom, idElement, couleur, ordre)
        {
            this.centre = centre;
            this.rx = rx;
            this.ry = ry;
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
                if (this.Alpha == 0 && CX == 0 && CY == 0)
                {
                    return "<ellipse cx=\"" + centre.X + "\" cy=\"" + centre.Y + "\" rx=\"" + rx + "\" ry=\"" + ry + "\" style=\"fill :rgb(" + Couleur + ")\" />";
                }
                else
                {
                    return "<ellipse cx=\"" + centre.X + "\" cy=\"" + centre.Y + "\" rx=\"" + rx + "\" ry=\"" + ry + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ")\" />";
                }
            }
            else
            {
                if (this.Alpha == 0 && CX == 0 && CY == 0)
                {
                    return "<ellipse cx=\"" + centre.X + "\" cy=\"" + centre.Y + "\" rx=\"" + rx + "\" ry=\"" + ry + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"translate(" + this.DX + "," + this.DY + ")\" />";
                }
                else
                {
                    return "<ellipse cx=\"" + centre.X + "\" cy=\"" + centre.Y + "\" rx=\"" + rx + "\" ry=\"" + ry + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ") translate(" + this.DX + "," + this.DY + ")\" />";
                }
            }
        }
    }
}
