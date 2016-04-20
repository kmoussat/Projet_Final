using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POA_Final
{
   
    //Classe héritage Element
   public class Texte : Element, IRotation, ITranslation
    {
        private Point point;
        private string contenu;
        
//Constructeur Texte par du texte et des points
        public Texte(string nom, int idElement, Point point, string contenu, Couleur couleur, int ordre) : base(nom, idElement, couleur, ordre)
        {
            this.point = point;
            this.contenu = contenu;
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
                    return "<text x=\"" + point.X + "\" y=\"" + point.Y + "\" fill=\"rgb(" + Couleur + ")\">" + contenu + "</text>";
                }
                else
                {
                    return "<text x=\"" + point.X + "\" y=\"" + point.Y + "\" fill=\"rgb(" + Couleur + ")\"" + " transform=\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ")\">" + contenu + "</text>";
                }
            }
            else
            {
                if (this.Alpha == 0 && this.CX == 0 && this.CY == 0)
                {
                    return "<text x=\"" + point.X + "\" y=\"" + point.Y + "\" fill=\"rgb(" + Couleur + ")\"" + " transform=\"translate(" + this.DX + "," + this.DY + ")\">" + contenu + "</text>";
                }
                else
                {
                    return "<text x=\"" + point.X + "\" y=\"" + point.Y + "\" fill=\"rgb(" + Couleur + ")\"" + " transform=\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ") translate(" + this.DX + "," + this.DY + ")\">" + contenu + "</text>";
                }
            }
        }
    }
}
