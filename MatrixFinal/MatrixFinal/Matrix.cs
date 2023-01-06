using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFinal
{
    public partial class Matrix
    {
        double _A, _B, _C, _D, _E, _F, _G, _H, _I;

        public double A
        {
            get { return _A; }
            set { _A = value; }
        }
        
        public double B
        {
            get { return _B; }
            set { _B = value; }
        }

        public double C
        {
            get { return _C; } 
            set { _C = value; }
        }

        public double D
        {
            get { return _D; }
            set { _D = value; }
        }

        public double E
        {
            get { return _E; }
            set { _E = value; }
        }

        public double F
        {
            get { return _F; }
            set { _F = value; }
        }

        public double G
        {
            get { return _G; }
            set { _G = value; }
        }

        public double H
        {
            get { return _H; }
            set { _H = value; }
        }

        public double I
        {
            get { return _I; }
            set { _I = value; }
        }

        public Matrix()
        {
            _A = 0;
            _B = 0;
            _C = 0;
            _D = 0;
            _E = 0;
            _F = 0;
            _G = 0;
            _H = 0;
            _I = 0;
        }
    }
}
