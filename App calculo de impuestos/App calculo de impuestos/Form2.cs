using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_calculo_de_impuestos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sfs_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clacbtn_Click(object sender, EventArgs e)
        {
            double Sueldobrut = Convert.ToDouble(Sueldobruto.Text);

            //sfs
            double sfs = Sueldobrut * 0.0304;

            sfs1.Text = sfs.ToString();

            //afp
            double afpp = Sueldobrut * 0.0287;

            afp.Text = afpp.ToString();

            //isr
            int x = 34685;
            if (Sueldobrut < x)
            {
                double isrr = Sueldobrut * 0;
                isr.Text = isrr.ToString();
                double Sueldotot = Sueldobrut - sfs - afpp - isrr;
                Sueldonet.Text = Sueldotot.ToString();
            }
            if (Sueldobrut > x && x < 72260)
            {
                double isrr = Sueldobrut * 0.15;
                isr.Text = isrr.ToString();
                double Sueldotot = Sueldobrut - sfs - afpp - isrr;
                Sueldonet.Text = Sueldotot.ToString();
            }
            if (Sueldobrut > 72260)
            {
                double isrr = Sueldobrut * 0.20;
                isr.Text = isrr.ToString();
                double Sueldotot = Sueldobrut - sfs - afpp - isrr;
                Sueldonet.Text = Sueldotot.ToString();
            }
          


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void afp_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Sueldobruto.Clear();
            Sueldonet.Clear();
            afp.Clear();
            sfs1.Clear();
            isr.Clear();    
        }
    }
}
