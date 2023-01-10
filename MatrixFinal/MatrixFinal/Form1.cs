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
            TextBox[] array = new TextBox[9];
            array[0] = MatricT_a;
            array[1] = MatricT_b;
            array[2] = MatricT_c;
            array[3] = MatricT_d;
            array[4] = MatricT_e;
            array[5] = MatricT_f;
            array[6] = MatricT_i;
            array[7] = MatricT_h;
            array[8] = MatricT_g;


            try
            {
                //statement allows the code to be tested
                bool test = (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "");
               

            }
            catch (Exception ex)
            {
                //statement allows to define a block code to be executed if an errors occurs
                MessageBox.Show("ERROR, Please input numbers only");

            }
                //(array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "")
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

                //Doing Transpose
                transresult.A = trans1.A;
                transresult.B = trans1.D;
                transresult.C = trans1.G;
                transresult.D = trans1.B;
                transresult.E = trans1.E;
                transresult.F = trans1.H;
                transresult.G = trans1.C;
                transresult.H = trans1.F;
                transresult.I = trans1.I;

                MatricT_aT.Text = transresult.A.ToString();
                MatricT_bT.Text = transresult.B.ToString();
                MatricT_cT.Text = transresult.C.ToString();
                MatricT_dT.Text = transresult.D.ToString();
                MatricT_eT.Text = transresult.E.ToString();
                MatricT_fT.Text = transresult.F.ToString();
                MatricT_gT.Text = transresult.G.ToString();
                MatricT_hT.Text = transresult.H.ToString();
                MatricT_iT.Text = transresult.I.ToString();

                /*
                textBox10.Text = textBox1.Text.ToString();
                textBox17.Text = textBox2.Text.ToString();
                textBox18.Text = textBox3.Text.ToString();

                textBox11.Text = textBox4.Text.ToString();
                textBox16.Text = textBox5.Text.ToString();
                textBox15.Text = textBox6.Text.ToString();

                textBox12.Text = textBox9.Text.ToString();
                textBox13.Text = textBox8.Text.ToString();
                textBox14.Text = textBox7.Text.ToString();*/
            }
            
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
                //statement allows the code to be tested
                bool test = (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "");


            }
            catch (Exception ex)
            {
                //statement allows to define a block code to be executed if an errors occurs
                MessageBox.Show("ERROR, Please input numbers only");

            }

            //if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
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

                //Doing Addition Operation
                addresult.A = add1.A + add2.A;
                addresult.B = add1.B + add2.B;
                addresult.C = add1.C + add2.C;
                addresult.D = add1.D + add2.D;
                addresult.E = add1.E + add2.E;
                addresult.F = add1.F + add2.F;
                addresult.G = add1.G + add2.G;
                addresult.H = add1.H + add2.H;
                addresult.I = add1.I + add2.I;

                MatricAR_a.Text = addresult.A.ToString();
                MatricAR_b.Text = addresult.B.ToString();
                MatricAR_c.Text = addresult.C.ToString();
                MatricAR_d.Text = addresult.D.ToString();
                MatricAR_e.Text = addresult.E.ToString();
                MatricAR_f.Text = addresult.F.ToString();
                MatricAR_g.Text = addresult.G.ToString();
                MatricAR_h.Text = addresult.H.ToString();
                MatricAR_i.Text = addresult.I.ToString();

                /* Int64 a = long.Parse(MatricA1_a.Text) + long.Parse(MatricA2_a.Text);
                 Int64 b = Int64.Parse(MatricA1_b.Text) + Int64.Parse(MatricA2_b.Text);
                 Int64 c = Int64.Parse(MatricA1_c.Text) + Int64.Parse(MatricA2_c.Text);

                 Int64 d = Int64.Parse(MatricA1_d.Text) + Int64.Parse(MatricA2_d.Text);
                 Int64 ee = Int64.Parse(MatricA1_e.Text) + Int64.Parse(MatricA2_e.Text);
                 Int64 f = Int64.Parse(MatricA1_f.Text) + Int64.Parse(MatricA2_f.Text);
                 Int64 g = Int64.Parse(MatricA1_g.Text) + Int64.Parse(MatricA2_g.Text);
                 Int64 h = Int64.Parse(MatricA1_h.Text) + Int64.Parse(MatricA2_h.Text);
                 Int64 i = Int64.Parse(MatricA1_i.Text) + Int64.Parse(MatricA2_i.Text);
                 //Int64 b = Int64.Parse(textBox440.Text);
                 //Int64 c = a + b;
                 MatricAR_a.Text = a.ToString();
                 MatricAR_b.Text = b.ToString();
                 MatricAR_c.Text = c.ToString();
                 MatricAR_d.Text = d.ToString();
                 MatricAR_e.Text = ee.ToString();
                 MatricAR_f.Text = f.ToString();
                 MatricAR_g.Text = g.ToString();
                 MatricAR_h.Text = h.ToString();
                 MatricAR_i.Text = i.ToString(); */
            }
          
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
                //statement allows the code to be tested
                bool test = (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "");


            }
            catch (Exception ex)
            {
                //statement allows to define a block code to be executed if an errors occurs
                MessageBox.Show("ERROR, Please input numbers only");

            }

            //if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
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

                //Doing Subtration Operation
                subresult.A = sub1.A - sub2.A;
                subresult.B = sub1.B - sub2.B;
                subresult.C = sub1.C - sub2.C;
                subresult.D = sub1.D - sub2.D;
                subresult.E = sub1.E - sub2.E;
                subresult.F = sub1.F - sub2.F;
                subresult.G = sub1.G - sub2.G;
                subresult.H = sub1.H - sub2.H;
                subresult.I = sub1.I - sub2.I;

                MatricRS_a.Text = subresult.A.ToString();
                MatricRS_b.Text = subresult.B.ToString();
                MatricRS_c.Text = subresult.C.ToString();
                MatricRS_d.Text = subresult.D.ToString();
                MatricRS_e.Text = subresult.E.ToString();
                MatricRS_f.Text = subresult.F.ToString();
                MatricRS_g.Text = subresult.G.ToString();
                MatricRS_h.Text = subresult.H.ToString();
                MatricRS_i.Text = subresult.I.ToString();

                /*   Int64 a = Int64.Parse(MatricS1_a.Text) - Int64.Parse(MatricS2_a.Text);
                   Int64 b = Int64.Parse(MatricS1_b.Text) - Int64.Parse(MatricS2_b.Text);
                   Int64 c = Int64.Parse(MatricS1_c.Text) - Int64.Parse(MatricS2_c.Text);

                   Int64 d = Int64.Parse(MatricS1_d.Text) - Int64.Parse(MatricS2_d.Text);
                   Int64 ee = Int64.Parse(MatricS1_e.Text) - Int64.Parse(MatricS2_e.Text);
                   Int64 f = Int64.Parse(MatricS1_f.Text) - Int64.Parse(MatricS2_f.Text);
                   Int64 g = Int64.Parse(MatricS1_g.Text) - Int64.Parse(MatricS2_g.Text);
                   Int64 h = Int64.Parse(MatricS1_h.Text) - Int64.Parse(MatricS2_h.Text);
                   Int64 i = Int64.Parse(MatricS1_i.Text) - Int64.Parse(MatricS2_i.Text);
                   //Int64 b = Int64.Parse(textBox440.Text);
                   //Int64 c = a + b;
                   MatricRS_a.Text = a.ToString();
                   MatricRS_b.Text = b.ToString();
                   MatricRS_c.Text = c.ToString();
                   MatricRS_d.Text = d.ToString();
                   MatricRS_e.Text = ee.ToString();
                   MatricRS_f.Text = f.ToString();
                   MatricRS_g.Text = g.ToString();
                   MatricRS_h.Text = h.ToString();
                   MatricRS_i.Text = i.ToString(); */
            }
           
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
                //statement allows the code to be tested
                bool test = (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "");


            }
            catch (Exception ex)
            {
                //statement allows to define a block code to be executed if an errors occurs
                MessageBox.Show("ERROR, Please input numbers only");

            }

            //if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
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

                //Doing Multiplication Operation
                mulresult.A =  (mul1.A * mul2.A) + ( mul1.B * mul2.D) + ( mul1.C * mul2.G );
                mulresult.B =  (mul1.A * mul2.B) + ( mul1.B * mul2.E) + ( mul1.C * mul2.H );
                mulresult.C =  (mul1.A * mul2.C) + ( mul1.B * mul2.F) + ( mul1.C * mul2.I );
                mulresult.D =  (mul1.D * mul2.A) + ( mul1.E * mul2.D) + ( mul1.F * mul2.G );
                mulresult.E =  (mul1.D * mul2.B) + ( mul1.E * mul2.E) + ( mul1.F * mul2.H );
                mulresult.F =  (mul1.D * mul2.C) + ( mul1.E * mul2.F) + ( mul1.F * mul2.I );
                mulresult.G =  (mul1.G * mul2.A) + ( mul1.H * mul2.D) + ( mul1.I * mul2.G );
                mulresult.H =  (mul1.G * mul2.B) + ( mul1.H * mul2.E) + ( mul1.I * mul2.H );
                mulresult.I =  (mul1.G * mul2.C) + ( mul1.H * mul2.F) + ( mul1.I * mul2.I );

                MatricRM_a.Text = mulresult.A.ToString();
                MatricRM_b.Text = mulresult.B.ToString();
                MatricRM_c.Text = mulresult.C.ToString();
                MatricRM_d.Text = mulresult.D.ToString();
                MatricRM_e.Text = mulresult.E.ToString();
                MatricRM_f.Text = mulresult.F.ToString();
                MatricRM_g.Text = mulresult.G.ToString();
                MatricRM_h.Text = mulresult.H.ToString();
                MatricRM_i.Text = mulresult.I.ToString();

                /*   Int64 a = (Int64.Parse(MatricM1_a.Text) * Int64.Parse(MatricM2_a.Text)) +
                             (Int64.Parse(MatricM1_b.Text) * Int64.Parse(MatricM2_d.Text)) +
                             (Int64.Parse(MatricM1_c.Text) * Int64.Parse(MatricM2_g.Text));

                   Int64 b = (Int64.Parse(MatricM1_a.Text) * Int64.Parse(MatricM2_b.Text)) +
                             (Int64.Parse(MatricM1_b.Text) * Int64.Parse(MatricM2_e.Text)) +
                             (Int64.Parse(MatricM1_c.Text) * Int64.Parse(MatricM2_h.Text));

                   Int64 c = (Int64.Parse(MatricM1_a.Text) * Int64.Parse(MatricM2_c.Text)) +
                             (Int64.Parse(MatricM1_b.Text) * Int64.Parse(MatricM2_f.Text)) +
                             (Int64.Parse(MatricM1_c.Text) * Int64.Parse(MatricM2_i.Text));

                   Int64 d = (Int64.Parse(MatricM1_d.Text) * Int64.Parse(MatricM2_a.Text)) +
                             (Int64.Parse(MatricM1_e.Text) * Int64.Parse(MatricM2_d.Text)) +
                             (Int64.Parse(MatricM1_f.Text) * Int64.Parse(MatricM2_g.Text));

                   Int64 ee = (Int64.Parse(MatricM1_d.Text) * Int64.Parse(MatricM2_b.Text)) +
                             (Int64.Parse(MatricM1_e.Text) * Int64.Parse(MatricM2_e.Text)) +
                             (Int64.Parse(MatricM1_f.Text) * Int64.Parse(MatricM2_h.Text));

                   Int64 f = (Int64.Parse(MatricM1_d.Text) * Int64.Parse(MatricM2_c.Text)) +
                             (Int64.Parse(MatricM1_e.Text) * Int64.Parse(MatricM2_f.Text)) +
                             (Int64.Parse(MatricM1_f.Text) * Int64.Parse(MatricM2_i.Text));

                   Int64 g = (Int64.Parse(MatricM1_g.Text) * Int64.Parse(MatricM2_a.Text)) +
                             (Int64.Parse(MatricM1_h.Text) * Int64.Parse(MatricM2_d.Text)) +
                             (Int64.Parse(MatricM1_i.Text) * Int64.Parse(MatricM2_g.Text));

                   Int64 h = (Int64.Parse(MatricM1_g.Text) * Int64.Parse(MatricM2_b.Text)) +
                             (Int64.Parse(MatricM1_h.Text) * Int64.Parse(MatricM2_e.Text)) +
                             (Int64.Parse(MatricM1_i.Text) * Int64.Parse(MatricM2_h.Text));

                   Int64 i = (Int64.Parse(MatricM1_g.Text) * Int64.Parse(MatricM2_c.Text)) +
                             (Int64.Parse(MatricM1_h.Text) * Int64.Parse(MatricM2_f.Text)) +
                             (Int64.Parse(MatricM1_i.Text) * Int64.Parse(MatricM2_i.Text));

                   //Int64 b = Int64.Parse(textBox440.Text);
                   //Int64 c = a + b;
                   MatricRM_a.Text = a.ToString();
                   MatricRM_b.Text = b.ToString();
                   MatricRM_c.Text = c.ToString();
                   MatricRM_d.Text = d.ToString();
                   MatricRM_e.Text = ee.ToString();
                   MatricRM_f.Text = f.ToString();
                   MatricRM_g.Text = g.ToString();
                   MatricRM_h.Text = h.ToString();
                   MatricRM_i.Text = i.ToString(); */
            }
           
        }

      
    }
}
