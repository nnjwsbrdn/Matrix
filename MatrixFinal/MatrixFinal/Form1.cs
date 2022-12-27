using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void transBut_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[9];
            array[0] = textBox1;
            array[1] = textBox2;
            array[2] = textBox3;
            array[3] = textBox4;
            array[4] = textBox5;
            array[5] = textBox6;
            array[6] = textBox7;
            array[7] = textBox8;
            array[8] = textBox9;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "")
            {
                textBox10.Text = textBox1.Text.ToString();
                textBox17.Text = textBox2.Text.ToString();
                textBox18.Text = textBox3.Text.ToString();

                textBox11.Text = textBox4.Text.ToString();
                textBox16.Text = textBox5.Text.ToString();
                textBox15.Text = textBox6.Text.ToString();

                textBox12.Text = textBox9.Text.ToString();
                textBox13.Text = textBox8.Text.ToString();
                textBox14.Text = textBox7.Text.ToString();
            }
            else
            {
                label1.Text = "Fill all the boxes";

            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[18];
            array[0] = textBox19;
            array[1] = textBox20;
            array[2] = textBox21;
            array[3] = textBox22;
            array[4] = textBox23;
            array[5] = textBox24;
            array[6] = textBox25;
            array[7] = textBox26;
            array[8] = textBox27;

            array[9] = textBox29;
            array[10] = textBox30;
            array[11] = textBox31;
            array[12] = textBox32;
            array[13] = textBox33;
            array[14] = textBox34;
            array[15] = textBox35;
            array[16] = textBox36;
            array[17] = textBox37;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
            {
                Int64 a = Int64.Parse(textBox19.Text) + Int64.Parse(textBox29.Text);
                Int64 b = Int64.Parse(textBox20.Text) + Int64.Parse(textBox30.Text);
                Int64 c = Int64.Parse(textBox21.Text) + Int64.Parse(textBox31.Text);

                Int64 d = Int64.Parse(textBox22.Text) + Int64.Parse(textBox32.Text);
                Int64 ee = Int64.Parse(textBox23.Text) + Int64.Parse(textBox33.Text);
                Int64 f = Int64.Parse(textBox24.Text) + Int64.Parse(textBox34.Text);
                Int64 g = Int64.Parse(textBox25.Text) + Int64.Parse(textBox35.Text);
                Int64 h = Int64.Parse(textBox26.Text) + Int64.Parse(textBox36.Text);
                Int64 i = Int64.Parse(textBox27.Text) + Int64.Parse(textBox37.Text);
                //Int64 b = Int64.Parse(textBox440.Text);
                //Int64 c = a + b;
                textBox39.Text = a.ToString();
                textBox40.Text = b.ToString();
                textBox41.Text = c.ToString();
                textBox42.Text = d.ToString();
                textBox43.Text = ee.ToString();
                textBox44.Text = f.ToString();
                textBox45.Text = g.ToString();
                textBox46.Text = h.ToString();
                textBox47.Text = i.ToString();
            }
            else
            {
                label2.Text = "Fill ALL the boxes";
            }
        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[18];
            array[0] = textBox76;
            array[1] = textBox75;
            array[2] = textBox74;
            array[3] = textBox73;
            array[4] = textBox72;
            array[5] = textBox71;
            array[6] = textBox70;
            array[7] = textBox69;
            array[8] = textBox68;

            array[9] = textBox66;
            array[10] = textBox65;
            array[11] = textBox64;
            array[12] = textBox63;
            array[13] = textBox62;
            array[14] = textBox61;
            array[15] = textBox60;
            array[16] = textBox59;
            array[17] = textBox58;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
            {
                Int64 a = Int64.Parse(textBox76.Text) - Int64.Parse(textBox66.Text);
                Int64 b = Int64.Parse(textBox75.Text) - Int64.Parse(textBox65.Text);
                Int64 c = Int64.Parse(textBox74.Text) - Int64.Parse(textBox64.Text);

                Int64 d = Int64.Parse(textBox73.Text) - Int64.Parse(textBox63.Text);
                Int64 ee = Int64.Parse(textBox72.Text) - Int64.Parse(textBox62.Text);
                Int64 f = Int64.Parse(textBox71.Text) - Int64.Parse(textBox61.Text);
                Int64 g = Int64.Parse(textBox70.Text) - Int64.Parse(textBox60.Text);
                Int64 h = Int64.Parse(textBox69.Text) - Int64.Parse(textBox59.Text);
                Int64 i = Int64.Parse(textBox68.Text) - Int64.Parse(textBox58.Text);
                //Int64 b = Int64.Parse(textBox440.Text);
                //Int64 c = a + b;
                textBox56.Text = a.ToString();
                textBox55.Text = b.ToString();
                textBox54.Text = c.ToString();
                textBox53.Text = d.ToString();
                textBox52.Text = ee.ToString();
                textBox51.Text = f.ToString();
                textBox50.Text = g.ToString();
                textBox49.Text = h.ToString();
                textBox48.Text = i.ToString();
            }
            else
            {
                label3.Text = "Fill ALL the boxes";
            }
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox72_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {

        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[18];
            array[0] = textBox105;
            array[1] = textBox104;
            array[2] = textBox103;
            array[3] = textBox102;
            array[4] = textBox101;
            array[5] = textBox100;
            array[6] = textBox99;
            array[7] = textBox98;
            array[8] = textBox97;

            array[9] = textBox95;
            array[10] = textBox94;
            array[11] = textBox93;
            array[12] = textBox92;
            array[13] = textBox91;
            array[14] = textBox90;
            array[15] = textBox89;
            array[16] = textBox88;
            array[17] = textBox87;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
            {
                Int64 a = (Int64.Parse(textBox105.Text) * Int64.Parse(textBox95.Text)) +
                          (Int64.Parse(textBox104.Text) * Int64.Parse(textBox92.Text)) +
                          (Int64.Parse(textBox103.Text) * Int64.Parse(textBox89.Text));

                Int64 b = (Int64.Parse(textBox105.Text) * Int64.Parse(textBox94.Text)) +
                          (Int64.Parse(textBox104.Text) * Int64.Parse(textBox91.Text)) +
                          (Int64.Parse(textBox103.Text) * Int64.Parse(textBox88.Text));

                Int64 c = (Int64.Parse(textBox105.Text) * Int64.Parse(textBox93.Text)) +
                          (Int64.Parse(textBox104.Text) * Int64.Parse(textBox90.Text)) +
                          (Int64.Parse(textBox103.Text) * Int64.Parse(textBox87.Text));

                Int64 d = (Int64.Parse(textBox102.Text) * Int64.Parse(textBox95.Text)) +
                          (Int64.Parse(textBox101.Text) * Int64.Parse(textBox92.Text)) +
                          (Int64.Parse(textBox100.Text) * Int64.Parse(textBox89.Text));

                Int64 ee = (Int64.Parse(textBox102.Text) * Int64.Parse(textBox94.Text)) +
                          (Int64.Parse(textBox101.Text) * Int64.Parse(textBox91.Text)) +
                          (Int64.Parse(textBox100.Text) * Int64.Parse(textBox88.Text));

                Int64 f = (Int64.Parse(textBox102.Text) * Int64.Parse(textBox93.Text)) +
                          (Int64.Parse(textBox101.Text) * Int64.Parse(textBox90.Text)) +
                          (Int64.Parse(textBox100.Text) * Int64.Parse(textBox87.Text));

                Int64 g = (Int64.Parse(textBox99.Text) * Int64.Parse(textBox95.Text)) +
                          (Int64.Parse(textBox98.Text) * Int64.Parse(textBox92.Text)) +
                          (Int64.Parse(textBox97.Text) * Int64.Parse(textBox89.Text));

                Int64 h = (Int64.Parse(textBox99.Text) * Int64.Parse(textBox94.Text)) +
                          (Int64.Parse(textBox98.Text) * Int64.Parse(textBox91.Text)) +
                          (Int64.Parse(textBox97.Text) * Int64.Parse(textBox88.Text));

                Int64 i = (Int64.Parse(textBox99.Text) * Int64.Parse(textBox93.Text)) +
                          (Int64.Parse(textBox98.Text) * Int64.Parse(textBox90.Text)) +
                          (Int64.Parse(textBox97.Text) * Int64.Parse(textBox87.Text));

                //Int64 b = Int64.Parse(textBox440.Text);
                //Int64 c = a + b;
                textBox85.Text = a.ToString();
                textBox84.Text = b.ToString();
                textBox83.Text = c.ToString();
                textBox82.Text = d.ToString();
                textBox81.Text = ee.ToString();
                textBox80.Text = f.ToString();
                textBox79.Text = g.ToString();
                textBox78.Text = h.ToString();
                textBox77.Text = i.ToString();
            }
            else
            {
                label4.Text = "Fill ALL the boxes";
            }
        }
    }
}
