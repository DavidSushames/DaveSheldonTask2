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
    }
}
