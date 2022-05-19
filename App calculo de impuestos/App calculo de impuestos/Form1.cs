namespace App_calculo_de_impuestos
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
           timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                this.Hide();
                
            }
            Opacity -= .2;
        }
    }
}