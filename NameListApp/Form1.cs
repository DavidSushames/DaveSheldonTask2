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
            GetNames();   //calls the get name function when load is clicked
        }

       
        private void GetNames()  
        {
            StreamReader nameFileReader = new StreamReader("Names.txt"); //read the Names.txt file
            lbxNames.Items.Clear(); //clear list box 
            while (!nameFileReader.EndOfStream)
            {
                string aName = nameFileReader.ReadLine(); //read name from file
                lbxNames.Items.Add(aName); //add name to list box
            }
            nameFileReader.Close(); //stop reading names.txt file
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            GetSurnames(); //call the get surnames function when load is called
        }


        private void GetSurnames()
        {
            StreamReader nameFileReader = new StreamReader("Surnames.txt"); //read the Surnames.txt file
            listBox1.Items.Clear(); //clear list box
            while (!nameFileReader.EndOfStream)
            {
                string aName2 = nameFileReader.ReadLine(); //read surname from file
                listBox1.Items.Add(aName2); //add surname to list box
            }
            nameFileReader.Close(); //stop reading surnames.txt file
        }
        
    }
}
