## Matrix 3x3

__Team members:__
1) Najwa binti Sabaruddin 
2) Muhammad Faiz bin Fauzi
3) Muhammad Syarqawi Bin Sazali

## GUI Version of the DLL based Matrix 

https://github.com/nnjwsbrdn/Matrix

....

Result From GUI:

__GUI [ Transpose ]__

![Transpose](https://user-images.githubusercontent.com/116859559/215106446-9bdb18e7-efa8-4270-9c65-59b254d45111.png)
The matrix value that been input will interchange it row into column and column into row to form transpose

__GUI [ Addition ]__

![Addition](https://user-images.githubusercontent.com/116859559/215106568-4ff7f682-fa4f-4e72-a7b3-ae721a208a38.png)
The input value undergo the operation of adding two matrices by adding the corresponding entries together.

__GUI [ Substraction ]__

![Subtraction](https://user-images.githubusercontent.com/116859559/215106649-402a157b-7343-443a-af84-a5f0b9622f67.png)
The input value undergo the operation of substraction two matrices by substract the corresponding entries together.

__GUI [ Multiplication ]__

![Multiplication](https://user-images.githubusercontent.com/116859559/215106688-a78e2b6b-fb8d-4882-a7f8-690f6fbf25f6.png)
The input value been multiply to form 3x3 matrix

## Library Version based on Matrix project at:

https://github.com/syarqawi27/MatrxiLib

### Content in Library :
1. Properties
-Get Set 
public partial class Matrix
    {
        double _A, 

        public double A
        {
            get { return _A; }
            set { _A = value; }
        }
3. Constructor
-contructor for 3x3 matrices
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
        
3. Operation
-Transpose (method of interchange rows into columns and columns into rows)
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
- Adittion (operation of adding two matrices by adding the corresponding entries together)
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
 - Substraction (operation of substracting two matrices by substract the corresponding entries together)
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
 * Multiplication (operation of multiply two matrices by multiply the corresponding entries base on it scalar together)
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


## Gold Standard

The Gold Standard of this project is to determine the transpose and to calculate the multiplication, substraction and addition of the matrix.

Related Link : https://matrixcalc.org/
