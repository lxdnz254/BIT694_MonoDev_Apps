using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTwoNumbers
{
    public partial class AddTwoNumbers : Form
    {
        private int counter = 0;

        public AddTwoNumbers()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(FirstNumber.Text);
                int num2 = int.Parse(SecondNumber.Text);
                Sum.Text = (num1 + num2).ToString();
                counter++;
                if (counter >= 5) this.Close();
            }
            catch
            {
                Sum.Text = "Invalid Input";
                MessageBox.Show("Hello - Invalid Input");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FirstNumber.Clear();
            SecondNumber.Clear();
            Sum.Text = "Sum";
        }
    }
}
