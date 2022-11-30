using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<char> list = new List<char>();

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Random random = new Random();   
           
                for (int i = 0; i < n; i++)
                {
                int pismeno = random.Next('Z' - 'A' + 1) + 'A';
                char znak = (char)pismeno;

                list.Add(znak);

                }

           


            foreach(char c in list)
            {
                listBox1.Items.Add(c);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list = list.Distinct().ToList();
            listBox1.Items.Clear();
            foreach (char c in list)
            {
                listBox1.Items.Add(c);
            }
        }
    }
}
