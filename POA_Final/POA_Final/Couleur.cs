using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POA_Final
{
    class Couleur
    {
        private int R;
        private int G;
        private int B;

        public int R1
        {
            get
            {
                return R;
            }

            set
            {
                R = value;
            }
        }

        public int G1
        {
            get
            {
                return G;
            }

            set
            {
                G = value;
            }
        }

        public int B1
        {
            get
            {
                return B;
            }

            set
            {
                B = value;
            }
        }

        public Couleur(int R, int G, int B)
        {
            this.R1 = R;
            this.G1 = G;
            this.B1 = B;
        }

        public override string ToString()
        {
            return R1 + "," + G1 + "," + B1;
        }
    }
}
