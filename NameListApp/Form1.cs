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

namespace NameListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GetNames();
        }

       
        private void GetNames()
        {
            StreamReader nameFileReader = new StreamReader("Names.txt");
            lbxNames.Items.Clear();
            while (!nameFileReader.EndOfStream)
            {
                string aName = nameFileReader.ReadLine();
                lbxNames.Items.Add(aName);
            }
            nameFileReader.Close();
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            GetSurnames();
        }


        private void GetSurnames()
        {
            StreamReader nameFileReader = new StreamReader("Surnames.txt");
            listBox1.Items.Clear();
            while (!nameFileReader.EndOfStream)
            {
                string aName2 = nameFileReader.ReadLine();
                listBox1.Items.Add(aName2);
            }
            nameFileReader.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
