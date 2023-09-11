using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double hk1, hk2, dtb;
            hk1 = Convert.ToDouble(txthk1.Text);
            hk2 = Convert.ToDouble(txthk2.Text);
            dtb = (hk1 + hk2) / 2;
            txtdtb.Text = Convert.ToString(dtb);
            if(dtb >= 5){
                txtkq.Text = "Được lên lớp";
            }

            else{
                txtkq.Text = "Ở lại lớp";
            if (dtb < 5)
                {
                    txtxlht.Text = "Yếu";
                }
                else if (dtb <= 6)
                {
                    txtxlht.Text = "Trung Bình";
                }
                else if (dtb < 8)
                {
                    txtxlht.Text = "Khá";
                }
                else
                {
                    txtxlht.Text = "Giỏi";
                }
            }
        }
    }
}
