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
            string name, age, address, number, gender, email, question;

            name = tbname.Text;
            age = tbage.Text;
            address = tbaddress.Text;
            number = tbnumber.Text;
            email = tbemail.Text;

            if (cbmale.Checked == true)
                gender = cbmale.Text;
            else if (cbfemale.Checked == true)
                gender = cbfemale.Text;
            else
                gender = cbpref.Text;





            StreamWriter Information;
            Information = File.CreateText("Information.txt");
            Information.WriteLine(name); 
            Information.WriteLine(age);
            Information.WriteLine(address);
            Information.Write(gender);
            Information.Close();


        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
