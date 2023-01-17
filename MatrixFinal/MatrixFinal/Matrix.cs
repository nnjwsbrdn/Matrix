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

        public Matrix Transpose()
        {
            Matrix temp = new Matrix();

            temp.A = _A;
            temp.B = _D;
            temp.C = _G;
            temp.D = _B;
            temp.E = _E;
            temp.F = _H;
            temp.G = _C;
            temp.H = _F;
            temp.I = _I;

            return temp;
        }

        public static Matrix operator +(Matrix op1, Matrix op2)
        {
            Matrix temp = new Matrix();

            temp.A = op1.A + op2.A;
            temp.B = op1.B + op2.B;
            temp.C = op1.C + op2.C;
            temp.D = op1.D + op2.D;
            temp.E = op1.E + op2.E;
            temp.F = op1.F + op2.F;
            temp.G = op1.G + op2.G;
            temp.H = op1.H + op2.H;
            temp.I = op1.I + op2.I;

            return temp;

        }
        public static Matrix operator -(Matrix op1, Matrix op2)
        {
            Matrix temp = new Matrix();

            temp.A = op1.A - op2.A;
            temp.B = op1.B - op2.B;
            temp.C = op1.C - op2.C;
            temp.D = op1.D - op2.D;
            temp.E = op1.E - op2.E;
            temp.F = op1.F - op2.F;
            temp.G = op1.G - op2.G;
            temp.H = op1.H - op2.H;
            temp.I = op1.I - op2.I;

            return temp;

        }

        public static Matrix operator *(Matrix op1, Matrix op2)
        {

            Matrix temp = new Matrix();

            temp.A = (op1.A * op2.A) + (op1.B * op2.D) + (op1.C * op2.G);
            temp.B = (op1.A * op2.B) + (op1.B * op2.E) + (op1.C * op2.H);
            temp.C = (op1.A * op2.C) + (op1.B * op2.F) + (op1.C * op2.I);
            temp.D = (op1.D * op2.A) + (op1.E * op2.D) + (op1.F * op2.G);
            temp.E = (op1.D * op2.B) + (op1.E * op2.E) + (op1.F * op2.H);
            temp.F = (op1.D * op2.C) + (op1.E * op2.F) + (op1.F * op2.I);
            temp.G = (op1.G * op2.A) + (op1.H * op2.D) + (op1.I * op2.G);
            temp.H = (op1.G * op2.B) + (op1.H * op2.E) + (op1.I * op2.H);
            temp.I = (op1.G * op2.C) + (op1.H * op2.F) + (op1.I * op2.I);

            return temp;
        }

    }
}
