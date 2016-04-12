using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POA_Final
{
    class Polygone : Element
    {
        private string points;

        public Polygone(string nom, int idElement, string points, Couleur couleur, int ordre) : base(nom, idElement, couleur, ordre)
        {
            this.points = points;
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
                    return "<polygon points=\"" + points + "\" style=\"fill :rgb(" + Couleur + ")\" />";
                }
                else
                {
                    return "<polygon points=\"" + points + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ")\" />";
                }
            }
            else
            {
                if (this.Alpha == 0 && this.CX == 0 && this.CY == 0)
                {
                    return "<polygon points=\"" + points + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"translate(" + this.DX + "," + this.DY + ")\" />";
                }
                else
                {
                    return "<polygon points=\"" + points + "\" style=\"fill :rgb(" + Couleur + ")\"" + " transform=\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ") translate(" + this.DX + "," + this.DY + ")\" />";
                }

            }

        }
    }
}
