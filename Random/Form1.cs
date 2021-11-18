using System;
using System.Runtime;
using System.Windows.Forms;

namespace Random

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {

            
           
        var random = new System.Random();
           // int n = random.Next(10);
            //MessageBox.Show(n.ToString());
            int[,] en = new int[100,100];

            for(int i = 0; i < 100; i++)
                
            {
                
                for(int x = 0; x < 100; x++)
                {
                    en[x,i] = random.Next(500, 5000);
                }
            }
                MessageBox.Show("Se terminaron los datos:");

        }
        
    }
}
