using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POA_Final
{
    public class Chemin : Element, IRotation
    {
        //Attribut
        private string path;
        
        //Constructeur
        public Chemin(string nom, int idElement, string path, Couleur couleur, int ordre) : base(nom, idElement, couleur, ordre)
        {
            this.path = path;
        }

        public void Rotation(double alpha, double cx, double cy)
        {
            this.Alpha = alpha;
            this.CX = cx;
            this.CY = cy;
        }
        
        //Méthode ToString qui converti les attributs en balises SVG pour déssiner l'élément
        public override string ToString()
        {
            if (this.DX == 0 && this.DY == 0)
            {
                if (this.Alpha == 0 && CX == 0 && CY == 0)
                {
                    return "<path d=\"" + path + "\" style=\"fill :rgb(" + Couleur + ")\" />";
                }
                else
                {
                    return "<path d=\"" + path + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ")\" />";
                }
            }
            else
            {
                if (this.Alpha == 0 && CX == 0 && CY == 0)
                {
                    return "<path d=\"" + path + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"translate(" + this.DX + "," + this.DY + ")\" />";
                }
                else
                {
                    return "<path d=\"" + path + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ") translate(" + this.DX + "," + this.DY + ")\" />";
                }
            }
        }
    }
}

