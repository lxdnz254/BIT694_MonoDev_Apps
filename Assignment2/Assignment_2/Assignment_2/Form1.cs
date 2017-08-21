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

namespace Assignment_2
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
                // Select the folder
                string folderPath = folderBrowserDialog1.SelectedPath;
                FolderOutput.Clear();
                FolderOutput.Text += folderPath; // output folder to textBox
                FileOutput.Items.Clear(); // clear the file ListBox

                // Add the main folder
                List<string> folders = new List<string>();
                folders.Add(folderPath); // in case there are files inside the folder
                // Add the folders inside the folder
                string[] subFolders = Directory.GetDirectories(folderPath);
                foreach (string sub in subFolders)
                {
                    folders.Add(sub);
                }

                // iterate over each folder
                foreach (string folder in folders) 
                {
                    // get the list of files from each folder
                    string[] files = Directory.GetFiles(folder);

                    foreach (string file in files)
                    {
                        FileOutput.Items.Add(file); // add each file to the listBox
                    }
                }
                
            }
        }
    }
}
