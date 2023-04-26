using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using ClassLibrary2Fcom;

namespace ARFur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
         
        private void button1_Click(object sender, EventArgs e)
        {
            var c = new Class1();
            if(comboBox1.SelectedIndex==0)
            {
                double v = 25000;
               
                var c2 = c.FdisTwen(v);
                label2.Text = ("Rs. ") + c2.ToString();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double v = 150000;
                
                var c2 = c.FdisTwen(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double v = 50000;
                
                var c2 = c.FdisTwen(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                double v = 60000;

                var c2 = c.FdisTwen(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
             else if (comboBox1.SelectedIndex == 4)
            {
                double v = 70000;

                var c2 = c.FdisTwen(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
           else
            {
                MessageBox.Show("Please select a furniture", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btn_fifp_Click(object sender, EventArgs e)
        {
            var c = new Class1();
            if (comboBox1.SelectedIndex == 0)
            {
                double v = 25000;

                var c2 = c.FdisFif(v);
                label2.Text = ("Rs. ") + c2.ToString();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double v = 150000;

                var c2 = c.FdisFif(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double v = 50000;

                var c2 = c.FdisFif(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                double v = 60000;

                var c2 = c.FdisFif(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                double v = 70000;

                var c2 = c.FdisFif(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else
            {
                MessageBox.Show("Please select a furniture", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_tenp_Click(object sender, EventArgs e)
        {
            var c = new Class1();
            if (comboBox1.SelectedIndex == 0)
            {
                double v = 25000;

                var c2 = c.FdisTen(v);
                label2.Text = ("Rs. ") + c2.ToString();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double v = 150000;

                var c2 = c.FdisTen(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double v = 50000;

                var c2 = c.FdisTen(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                double v = 60000;

                var c2 = c.FdisTen(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                double v = 70000;

                var c2 = ("Rs. ") + c.FdisTen(v);
                label2.Text = c2.ToString();
            }
            else
            {
                MessageBox.Show("Please select a furniture", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_senp_Click(object sender, EventArgs e)
        {
            var c = new Class1();
            if (comboBox1.SelectedIndex == 0)
            {
                double v = 25000;

                var c2 = c.FdisSev(v);
                label2.Text = ("Rs. ") + c2.ToString();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double v = 150000;

                var c2 = c.FdisSev(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double v = 50000;

                var c2 = c.FdisSev(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                double v = 60000;

                var c2 = c.FdisSev(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                double v = 70000;

                var c2 = c.FdisSev(v);
                label2.Text = ("Rs. ") + c2.ToString();
            }
           else
            {
                MessageBox.Show("Please select a furniture", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
   

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
      
        private void btn_custom_Click(object sender, EventArgs e)
        {
            double Height = Convert.ToDouble(txt_height.Text);
            double Width = Convert.ToDouble(txt_width.Text);

            var c = new Class2();
            

            if (comboBox2.SelectedIndex == 0)
            {
                //1500 for meterial, 15000 for labar cost
                //2000 for meterial, 35000 for labar cost
                //1800 for meterial, 35000 for labar cost
                if (cmb_typeW.SelectedIndex==0)
                {
                    var c2 = c.calcustomPChairOAK(Width, Height);
                    lbl_customfur.Text = ("Rs. ") + c2.ToString();
                }
                else if (cmb_typeW.SelectedIndex == 1)
                {
                    var c2 = c.calcustomPChairTEAK(Width, Height);
                    lbl_customfur.Text = ("Rs. ") + c2.ToString();
                }
                else if (cmb_typeW.SelectedIndex == 2)
                {
                    var c2 = c.calcustomPChairMAP(Width, Height);
                    lbl_customfur.Text = ("Rs. ") + c2.ToString();
                }

                else
                {
                    MessageBox.Show("Please select a wood type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            else if (comboBox2.SelectedIndex == 1)
            {
                //1500 for meterial, 20000 for labar cost
                //2000 for meterial, 25000 for labar cost 
                //1800 for meterial, 20000 for labar cost     

                if (cmb_typeW.SelectedIndex == 0)
                {
                    var c2 = c.calcustomPTableOAK(Width, Height);
                    lbl_customfur.Text = ("Rs. ") + c2.ToString();
                }
                else if (cmb_typeW.SelectedIndex == 1)
                {
                    var c2 = c.calcustomPTableTEAK(Width, Height);
                    lbl_customfur.Text = ("Rs. ") + c2.ToString();
                }
                else if (cmb_typeW.SelectedIndex == 2)
                {
                    var c2 = c.calcustomPTableMAP(Width, Height);
                    lbl_customfur.Text = ("Rs. ") + c2.ToString();
                }

                else
                {
                    MessageBox.Show("Please select a wood type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else if (comboBox2.SelectedIndex == 2)
            {
                //1500 for meterial, 30000 for labar cost
                //2000 for meterial, 40000 for labar cost
                //1800 for meterial, 45000 for labar cost
                if (cmb_typeW.SelectedIndex == 0)
                {
                    var c2 = c.calcustomPBedOAK(Width, Height);
                    lbl_customfur.Text = ("Rs. ") + c2.ToString();
                }
                else if (cmb_typeW.SelectedIndex == 1)
                {
                    var c2 = c.calcustomPBedTEAK(Width, Height);
                    lbl_customfur.Text = ("Rs. ") + c2.ToString();
                }
                else if (cmb_typeW.SelectedIndex == 2)
                {
                    var c2 = c.calcustomPBedMAP(Width, Height);
                    lbl_customfur.Text = ("Rs. ") + c2.ToString();
                }

                else
                {
                    MessageBox.Show("Please select a wood type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else if (comboBox2.SelectedIndex == 3)
            {

                //1500 for meterial, 45000 for labar cost
                //2000 for meterial, 50000 for labar cost      
                //1800 for meterial, 55000 for labar cost

                if (cmb_typeW.SelectedIndex == 0)
                {
                    var c2 = c.calcustomPCubOAK(Width, Height);
                    lbl_customfur.Text = c2.ToString();
                }
                else if (cmb_typeW.SelectedIndex == 1)
                {
                    var c2 = c.calcustomPCubTEAK(Width, Height);
                    lbl_customfur.Text = c2.ToString();
                }
                else if (cmb_typeW.SelectedIndex == 2)
                {
                    var c2 = c.calcustomPCubMAP(Width, Height);
                    lbl_customfur.Text = c2.ToString();
                }

                else
                {
                    MessageBox.Show("Please select a wood type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            else
            {
                MessageBox.Show("Please select a main furniture category", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_customfur_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_width_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_height_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_height.Clear();
            txt_width.Clear();
          
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
