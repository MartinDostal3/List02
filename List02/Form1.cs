using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<char> listZnaku = new List<char>();

        private void button1_Click(object sender, EventArgs e)
        {


            foreach (char c in textBox1.Text)
            {
                listZnaku.Add(c);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < listZnaku.Count; i++)
            {
                char znak = listZnaku[i];
                listBox1.Items.Add(znak);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listZnaku.Count; i++)
            {
                char znak = listZnaku[i];
                if (!char.IsLetterOrDigit(znak))
                {
                    listZnaku.Remove(znak);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listZnaku.Count; i++)
            {
                char znak = listZnaku[i];
                if (char.IsUpper(znak))
                {
                    listZnaku.Remove(znak);
                }
                if(char.IsDigit(znak))
                {
                    listZnaku.Remove(znak);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            
            for (int i = 0; i < listZnaku.Count; i++)
            {
                char znak = listZnaku[i];

                if (char.IsLower(znak))
                {
                    char velkePismeno = char.ToUpper(znak);
                    listBox1.Items.Add(znak);
                    listBox1.Items.Add(velkePismeno);
                }

            }
           
        }
    }
}
