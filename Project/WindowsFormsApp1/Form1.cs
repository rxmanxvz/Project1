using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Подбросить монету";
            label1.Text = "";
            button1.Text = "Подбросить монету";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int storonaMonety = random.Next(0, 2);
            if (storonaMonety == 0)
            {
                label1.Text = "Орёл";
            }
            else
            {
                label1.Text = "Решка";
            }
        }
    }
}
