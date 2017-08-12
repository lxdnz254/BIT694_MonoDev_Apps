using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollingTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            DisplayResults.Clear();
            if (checkBox1.Checked == true)
            {
                String ResStr = "";
                for (int i = 0; i < 1000; i++)
                {
                    if (!(i % 2 == 0))
                    {
                        ResStr += i.ToString() + "\r\n";
                    }

                }
                DisplayResults.Text = ResStr;
            }
            else
            {
                for (int i=0; i < 1000; i ++)
                {
                    if (!(i % 2 == 0))
                    {
                        DisplayResults.Text += i.ToString() + "\r\n";
                    }
                }
            }
        
            
        }
    }
}
