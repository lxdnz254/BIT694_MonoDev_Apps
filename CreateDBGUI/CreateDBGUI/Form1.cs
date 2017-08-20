using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateDBGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myFirstDataBaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myFirstDataBaseDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.myFirstDataBaseDataSet.People);

        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            DataRow newRecord = myFirstDataBaseDataSet.Tables["People"].NewRow();
            newRecord["Id"] = Id.Text;
            newRecord["FirstName"] = FirstName.Text;
            newRecord["LastName"] = LastName.Text;
            Id.Clear();
            FirstName.Clear();
            LastName.Clear();
            myFirstDataBaseDataSet.Tables["People"].Rows.Add(newRecord);
            peopleTableAdapter.Update(myFirstDataBaseDataSet);
            myFirstDataBaseDataSet.Tables["People"].AcceptChanges();
        }
    }
}
