using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactTracing_Bondad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            StreamWriter Information;
            Information = File.CreateText("Information.txt");
            Information.WriteLine("test");
            Information.WriteLine("test2");
            Information.Write("check");
            Information.Write("check");
            Information.Close();


        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
