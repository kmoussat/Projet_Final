using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POA_Final
{
    public class Cercle : Element
    {
        private Point centre;
        private double r;

        public Cercle(string nom, int idElement, Point centre, double r, Couleur couleur, int ordre) : base(nom, idElement, couleur, ordre)
        {
            this.centre = centre;
            this.r = r;
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
                if (this.Alpha == 0 && CX == 0 && CY == 0)
                {
                    return "<circle cx=\"" + centre.X + "\" cy=\"" + centre.Y + "\" r=\"" + r + "\" style=\"fill :rgb(" + Couleur + ")\" />";
                }
                else
                {
                    return "<circle cx=\"" + centre.X + "\" cy=\"" + centre.Y + "\" r=\"" + r + "\" style=\"fill :rgb(" + Couleur + ")\"" + "transform =\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ")\" />";
                }
            }
            else
            {
                if (this.Alpha == 0 && CX == 0 && CY == 0)
                {
                    return "<circle cx=\"" + centre.X + "\" cy=\"" + centre.Y + "\" r=\"" + r + "\" style=\"fill :rgb(" + Couleur + ")\"" + "transform =\"translate(" + this.DX + "," + this.DY + ")\" />";
                }
                else
                {
                    return "<circle cx=\"" + centre.X + "\" cy=\"" + centre.Y + "\" r=\"" + r + "\" style=\"fill :rgb(" + Couleur + ")\"" + "transform=\"rotate(" + this.Alpha + " " + this.CX + "," + this.CY + ") translate(" + this.DX + "," + this.DY + ")\" />";
                }
            }
        }

    }
}
