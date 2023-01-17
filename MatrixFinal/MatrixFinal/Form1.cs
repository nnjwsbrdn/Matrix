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
