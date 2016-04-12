using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POA_Final
{
    public class Element : IComparable<Element>
    {
        private string nom;
        private int idElement;
        private Couleur couleur;
        private int ordre;
        private double dX;
        private double dY;
        private double alpha;
        private double cX;
        private double cY;

        public Element(string nom, int idElement, Couleur couleur, int ordre)
        {
            this.nom = nom;
            this.idElement = idElement;
            this.couleur = couleur;
            this.ordre = ordre;
        }

        public int CompareTo(Element figure)
        {
            return ordre.CompareTo(figure.ordre);
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Ordre
        {
            get { return ordre; }
            set { ordre = value; }
        }

        public int IdElement
        {
            get { return idElement; }
            set { idElement = value; }
        }

        public Couleur Couleur
        {
            get { return couleur; }
        }

        public double DX
        {
            get { return dX; }
            set { dX = value; }
        }

        public double DY
        {
            get { return dY; }
            set { dY = value; }
        }

        public double Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        public double CX
        {
            get { return cX; }
            set { cX = value; }
        }

        public double CY
        {
            get { return cY; }
            set { cY = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
