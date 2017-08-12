using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectAFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                string folderPath = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(folderPath);
                ListResults.Items.Clear();

                foreach (string file in files)
                {
                    ListResults.Items.Add(file);
                }
            }
        }

        private void ListResults_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = ListResults.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                System.Diagnostics.Process.Start(ListResults.SelectedItem.ToString());
            }
        }

        private void ListResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
