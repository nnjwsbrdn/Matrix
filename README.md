# Matrix 3x3

The GUI version of the DLL based Matrix project at:

https://github.com/nnjwsbrdn/Matrix

Sample Usage:

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixFinal;

namespace MatrixFinal
{
    public partial class Form1 : Form
    {
        Matrix trans1 = new Matrix();
        Matrix trans2 = new Matrix();
        Matrix transresult = new Matrix();

        Matrix add1 = new Matrix();
        Matrix add2 = new Matrix();
        Matrix addresult = new Matrix();

        Matrix sub1 = new Matrix();
        Matrix sub2 = new Matrix();
        Matrix subresult = new Matrix();

        Matrix mul1 = new Matrix();
        Matrix mul2 = new Matrix();
        Matrix mulresult = new Matrix();

        public Form1()
        {
            InitializeComponent();
        }

        private void transBut_Click(object sender, EventArgs e)
        {

            try
            {
                trans1.A = Convert.ToDouble(MatricT_a.Text);
                trans1.B = Convert.ToDouble(MatricT_d.Text);
                trans1.C = Convert.ToDouble(MatricT_g.Text);
                trans1.D = Convert.ToDouble(MatricT_b.Text);
                trans1.E = Convert.ToDouble(MatricT_e.Text);
                trans1.F = Convert.ToDouble(MatricT_h.Text);
                trans1.G = Convert.ToDouble(MatricT_c.Text);
                trans1.H = Convert.ToDouble(MatricT_f.Text);
                trans1.I = Convert.ToDouble(MatricT_i.Text);
            }
            catch (Exception ex)
            {
                //statement allows to define a block code to be executed if an errors occurs
                MessageBox.Show("ERROR, Please put valid value only");

            }
                         
            //Doing Transpose
            transresult = trans1.Transpose();

            MatricT_aT.Text = transresult.A.ToString();
            MatricT_bT.Text = transresult.B.ToString();
            MatricT_cT.Text = transresult.C.ToString();
            MatricT_dT.Text = transresult.D.ToString();
            MatricT_eT.Text = transresult.E.ToString();
            MatricT_fT.Text = transresult.F.ToString();
            MatricT_gT.Text = transresult.G.ToString();
            MatricT_hT.Text = transresult.H.ToString();
            MatricT_iT.Text = transresult.I.ToString();

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[18];
            array[0] = MatricA1_a;
            array[1] = MatricA1_b;
            array[2] = MatricA1_c;
            array[3] = MatricA1_d;
            array[4] = MatricA1_e;
            array[5] = MatricA1_f;
            array[6] = MatricA1_g;
            array[7] = MatricA1_h;
            array[8] = MatricA1_i;

            array[9] =  MatricA2_a;
            array[10] = MatricA2_b;
            array[11] = MatricA2_c;
            array[12] = MatricA2_d;
            array[13] = MatricA2_e;
            array[14] = MatricA2_f;
            array[15] = MatricA2_g;
            array[16] = MatricA2_h;
            array[17] = MatricA2_i;

            try
            {
               
                add1.A = Convert.ToDouble(MatricA1_a.Text);
                add1.B = Convert.ToDouble(MatricA1_b.Text);
                add1.C = Convert.ToDouble(MatricA1_c.Text);
                add1.D = Convert.ToDouble(MatricA1_d.Text);
                add1.E = Convert.ToDouble(MatricA1_e.Text);
                add1.F = Convert.ToDouble(MatricA1_f.Text);
                add1.G = Convert.ToDouble(MatricA1_g.Text);
                add1.H = Convert.ToDouble(MatricA1_h.Text);
                add1.I = Convert.ToDouble(MatricA1_i.Text);

                add2.A = Convert.ToDouble(MatricA2_a.Text);
                add2.B = Convert.ToDouble(MatricA2_b.Text);
                add2.C = Convert.ToDouble(MatricA2_c.Text);
                add2.D = Convert.ToDouble(MatricA2_d.Text);
                add2.E = Convert.ToDouble(MatricA2_e.Text);
                add2.F = Convert.ToDouble(MatricA2_f.Text);
                add2.G = Convert.ToDouble(MatricA2_g.Text);
                add2.H = Convert.ToDouble(MatricA2_h.Text);
                add2.I = Convert.ToDouble(MatricA2_i.Text);

            }
            catch (Exception ex)
            {
                //statement allows to define a block code to be executed if an errors occurs
                MessageBox.Show("ERROR, Please input numbers only");

            }
            
                //Doing Addition Operation
                addresult = add1 + add2;

                MatricAR_a.Text = addresult.A.ToString();
                MatricAR_b.Text = addresult.B.ToString();
                MatricAR_c.Text = addresult.C.ToString();
                MatricAR_d.Text = addresult.D.ToString();
                MatricAR_e.Text = addresult.E.ToString();
                MatricAR_f.Text = addresult.F.ToString();
                MatricAR_g.Text = addresult.G.ToString();
                MatricAR_h.Text = addresult.H.ToString();
                MatricAR_i.Text = addresult.I.ToString();
                                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[18];
            array[0] = MatricS1_a;
            array[1] = MatricS1_b;
            array[2] = MatricS1_c;
            array[3] = MatricS1_d;
            array[4] = MatricS1_e;
            array[5] = MatricS1_f;
            array[6] = MatricS1_g;
            array[7] = MatricS1_h;
            array[8] = MatricS1_i;

            array[9]  = MatricS2_a;
            array[10] = MatricS2_b;
            array[11] = MatricS2_c;
            array[12] = MatricS2_d;
            array[13] = MatricS2_e;
            array[14] = MatricS2_f;
            array[15] = MatricS2_g;
            array[16] = MatricS2_h;
            array[17] = MatricS2_i;

            try
            {
                
                sub1.A = Convert.ToDouble(MatricS1_a.Text);
                sub1.B = Convert.ToDouble(MatricS1_b.Text);
                sub1.C = Convert.ToDouble(MatricS1_c.Text);
                sub1.D = Convert.ToDouble(MatricS1_d.Text);
                sub1.E = Convert.ToDouble(MatricS1_e.Text);
                sub1.F = Convert.ToDouble(MatricS1_f.Text);
                sub1.G = Convert.ToDouble(MatricS1_g.Text);
                sub1.H = Convert.ToDouble(MatricS1_h.Text);
                sub1.I = Convert.ToDouble(MatricS1_i.Text);

                sub2.A = Convert.ToDouble(MatricS2_a.Text);
                sub2.B = Convert.ToDouble(MatricS2_b.Text);
                sub2.C = Convert.ToDouble(MatricS2_c.Text);
                sub2.D = Convert.ToDouble(MatricS2_d.Text);
                sub2.E = Convert.ToDouble(MatricS2_e.Text);
                sub2.F = Convert.ToDouble(MatricS2_f.Text);
                sub2.G = Convert.ToDouble(MatricS2_g.Text);
                sub2.H = Convert.ToDouble(MatricS2_h.Text);
                sub2.I = Convert.ToDouble(MatricS2_i.Text);

            }
            catch (Exception ex)
            {
                //statement allows to define a block code to be executed if an errors occurs
                MessageBox.Show("ERROR, Please input numbers only");

            }
         
                //Doing Subtration Operation
                subresult = sub1 - sub2;    

                MatricRS_a.Text = subresult.A.ToString();
                MatricRS_b.Text = subresult.B.ToString();
                MatricRS_c.Text = subresult.C.ToString();
                MatricRS_d.Text = subresult.D.ToString();
                MatricRS_e.Text = subresult.E.ToString();
                MatricRS_f.Text = subresult.F.ToString();
                MatricRS_g.Text = subresult.G.ToString();
                MatricRS_h.Text = subresult.H.ToString();
                MatricRS_i.Text = subresult.I.ToString();
                                      
        }


        private void MulButton_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[18];
            array[0] = MatricM1_a;
            array[1] = MatricM1_b;
            array[2] = MatricM1_c;
            array[3] = MatricM1_d;
            array[4] = MatricM1_e;
            array[5] = MatricM1_f;
            array[6] = MatricM1_g;
            array[7] = MatricM1_h;
            array[8] = MatricM1_i;

            array[9] = MatricM2_a;
            array[10] = MatricM2_b;
            array[11] = MatricM2_c;
            array[12] = MatricM2_d;
            array[13] = MatricM2_e;
            array[14] = MatricM2_f;
            array[15] = MatricM2_g;
            array[16] = MatricM2_h;
            array[17] = MatricM2_i;

            try
            {
                
                mul1.A = Convert.ToDouble(MatricM1_a.Text);
                mul1.B = Convert.ToDouble(MatricM1_b.Text);
                mul1.C = Convert.ToDouble(MatricM1_c.Text);
                mul1.D = Convert.ToDouble(MatricM1_d.Text);
                mul1.E = Convert.ToDouble(MatricM1_e.Text);
                mul1.F = Convert.ToDouble(MatricM1_f.Text);
                mul1.G = Convert.ToDouble(MatricM1_g.Text);
                mul1.H = Convert.ToDouble(MatricM1_h.Text);
                mul1.I = Convert.ToDouble(MatricM1_i.Text);

                mul2.A = Convert.ToDouble(MatricM2_a.Text);
                mul2.B = Convert.ToDouble(MatricM2_b.Text);
                mul2.C = Convert.ToDouble(MatricM2_c.Text);
                mul2.D = Convert.ToDouble(MatricM2_d.Text);
                mul2.E = Convert.ToDouble(MatricM2_e.Text);
                mul2.F = Convert.ToDouble(MatricM2_f.Text);
                mul2.G = Convert.ToDouble(MatricM2_g.Text);
                mul2.H = Convert.ToDouble(MatricM2_h.Text);
                mul2.I = Convert.ToDouble(MatricM2_i.Text);

            }
            catch (Exception ex)
            {
                //statement allows to define a block code to be executed if an errors occurs
                MessageBox.Show("ERROR, Please input numbers only");

            }
           
                //Doing Multiplication Operation
                mulresult = mul1 * mul2;

                MatricRM_a.Text = mulresult.A.ToString();
                MatricRM_b.Text = mulresult.B.ToString();
                MatricRM_c.Text = mulresult.C.ToString();
                MatricRM_d.Text = mulresult.D.ToString();
                MatricRM_e.Text = mulresult.E.ToString();
                MatricRM_f.Text = mulresult.F.ToString();
                MatricRM_g.Text = mulresult.G.ToString();
                MatricRM_h.Text = mulresult.H.ToString();
                MatricRM_i.Text = mulresult.I.ToString();
           
        }

 
    }
}

## Gold Standard

The Gold Standard of this project is to determine the transpose and to calculate the multiplication, substraction and addition of the matrix.

GUI [ Transpose ]

![Transpose](https://user-images.githubusercontent.com/116859559/215106446-9bdb18e7-efa8-4270-9c65-59b254d45111.png)
The matrix value that been input will interchange it row into column and column into row to form transpose
GUI [ Addition ]

![Addition](https://user-images.githubusercontent.com/116859559/215106568-4ff7f682-fa4f-4e72-a7b3-ae721a208a38.png)
The input value undergo the operation of adding two matrices by adding the corresponding entries together.
GUI [ Substraction ]

![Subtraction](https://user-images.githubusercontent.com/116859559/215106649-402a157b-7343-443a-af84-a5f0b9622f67.png)
The input value undergo the operation of substraction two matrices by substract the corresponding entries together.
GUI [ Multiplication ]

![Multiplication](https://user-images.githubusercontent.com/116859559/215106688-a78e2b6b-fb8d-4882-a7f8-690f6fbf25f6.png)
The input value been multiply to form 3x3 matrix


The Library version based on Matrix project at:

https://github.com/syarqawi27/MatrxiLib

Sample Usage :

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLib
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

        /// <summary>
        /// contructor for 3x3 matrices
        /// </summary>
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

        /// <summary>
        ///Transpose is a method of interchange rows into columns and columns into rows 
        /// </summary>
        /// <returns>the value of the row into column and the value of column into row </returns>
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
        /// <summary>
        /// the operation of adding two matrices by adding the corresponding entries together
        /// </summary>
        /// <param name="op1"> First matrice of the addition operation</param> 
        /// <param name="op2"> Second matrice of the addtion operation</param>
        /// <returns>the total value of both op1 and op2</returns>
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

        /// <summary>
        /// The operation where element wise substraction applies to the matrices of the same order, which essentially 
        /// means that substraction between two matrices can only happen when both pf them have the same number of rows and columns.
        /// </summary>
        /// <param name="op1">First matrice of the substraction in operation </param>
        /// <param name="op2">Second matrice of the substraction in operation</param>
        /// <returns> the subtration value of op1 and op2 </returns>
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

        /// <summary>
        /// the operation of substraction two matrices by adding the corresponding entries together
        /// </summary>
        /// <param name="op1"> First matrice of the multipication in operation</param>
        /// <param name="op2"> second matrice of the multiplication in operation</param>
        /// <returns></returns>
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

The Unit Test version based on Matrix project at:

https://github.com/syarqawi27/MatrxiLib

Sample Usage :

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MatrixLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructor() // constructurs
        {
            MatrixLib.Matrix Transpose = new Matrix();

            Transpose.A = 10;
            Transpose.B = 20;
            Transpose.C = 30;
            Transpose.D = 40;
            Transpose.E = 50;
            Transpose.F = 60;
            Transpose.G = 100;
            Transpose.H = 200;
            Transpose.I = 500;


            Assert.AreEqual(10, Transpose.A);
            Assert.AreEqual(20, Transpose.B);
            Assert.AreEqual(30, Transpose.C);
            Assert.AreEqual(40, Transpose.D);
            Assert.AreEqual(50, Transpose.E);
            Assert.AreEqual(60, Transpose.F);
            Assert.AreEqual(100, Transpose.G);
            Assert.AreEqual(200, Transpose.H);
            Assert.AreEqual(500, Transpose.I);

        }

        [TestMethod]

        public void SetterGetterTest()
        {
            MatrixLib.Matrix Transpose = new Matrix();

            Transpose.A = 10;
            Transpose.B = 20;
            Transpose.C = 30;
            Transpose.D = 40;
            Transpose.E = 50;
            Transpose.F = 60;
            Transpose.G = 100;
            Transpose.H = 200;
            Transpose.I = 500;

            Assert.AreEqual(10, Transpose.A);
            Assert.AreEqual(20, Transpose.B);
            Assert.AreEqual(30, Transpose.C);
            Assert.AreEqual(40, Transpose.D);
            Assert.AreEqual(50, Transpose.E);
            Assert.AreEqual(60, Transpose.F);
            Assert.AreEqual(100, Transpose.G);
            Assert.AreEqual(200, Transpose.H);
            Assert.AreEqual(500, Transpose.I);
        }

        [TestMethod]

        public void AdditionTest()
        {
            MatrixLib.Matrix op1 = new Matrix();
            MatrixLib.Matrix op2 = new Matrix();
            MatrixLib.Matrix result;

            op1.A = 1;
            op1.B = 2;
            op1.C = 3;
            op1.D = 4;
            op1.E = 5;
            op1.F = 6;
            op1.G = 7;
            op1.H = 8;
            op1.I = 9;

            op2.A = 10;
            op2.B = 11;
            op2.C = 12;
            op2.D = 13;
            op2.E = 14;
            op2.F = 15;
            op2.G = 16;
            op2.H = 17;
            op2.I = 18;

            result = op1 + op2;

            Assert.AreEqual(result.A, 11);
            Assert.AreEqual(result.B, 13);
            Assert.AreEqual(result.C, 15);
            Assert.AreEqual(result.D, 17);
            Assert.AreEqual(result.E, 19);
            Assert.AreEqual(result.F, 21);
            Assert.AreEqual(result.G, 23);
            Assert.AreEqual(result.H, 25);
            Assert.AreEqual(result.I, 27);
        }

        [TestMethod]

        public void SubtractionTest()
        {
            MatrixLib.Matrix op1 = new Matrix();
            MatrixLib.Matrix op2 = new Matrix();
            MatrixLib.Matrix result;

            op1.A = 10;
            op1.B = 20;
            op1.C = 30;
            op1.D = 40;
            op1.E = 50;
            op1.F = 60;
            op1.G = 70;
            op1.H = 80;
            op1.I = 90;

            op2.A = 2;
            op2.B = 4;
            op2.C = 6;
            op2.D = 8;
            op2.E = 10;
            op2.F = 20;
            op2.G = 30;
            op2.H = 40;
            op2.I = 50;

            result = op1 - op2;

            Assert.AreEqual(result.A, 8);
            Assert.AreEqual(result.B, 16);
            Assert.AreEqual(result.C, 24);
            Assert.AreEqual(result.D, 32);
            Assert.AreEqual(result.E, 40);
            Assert.AreEqual(result.F, 40);
            Assert.AreEqual(result.G, 40);
            Assert.AreEqual(result.H, 40);
            Assert.AreEqual(result.I, 40);
        }

        [TestMethod]

        public void MultiplicationTest()
        {
            MatrixLib.Matrix op1 = new Matrix();
            MatrixLib.Matrix op2 = new Matrix();
            MatrixLib.Matrix result;

            op1.A = 1;
            op1.B = 2;
            op1.C = 3;
            op1.D = 4;
            op1.E = 5;
            op1.F = 6;
            op1.G = 7;
            op1.H = 8;
            op1.I = 9;

            op2.A = 10;
            op2.B = 11;
            op2.C = 12;
            op2.D = 13;
            op2.E = 14;
            op2.F = 15;
            op2.G = 16;
            op2.H = 17;
            op2.I = 18;

            result = op1 * op2;

            Assert.AreEqual(result.A, 84);
            Assert.AreEqual(result.B, 90);
            Assert.AreEqual(result.C, 96);
            Assert.AreEqual(result.D, 201);
            Assert.AreEqual(result.E, 216);
            Assert.AreEqual(result.F, 231);
            Assert.AreEqual(result.G, 318);
            Assert.AreEqual(result.H, 342);
            Assert.AreEqual(result.I, 366);
        }

    }
}

Team members:
1) Najwa binti Sabaruddin 
2) Muhammad Faiz bin Fauzi
3) Muhammad Syarqawi Bin Sazali
