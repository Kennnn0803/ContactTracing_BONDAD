﻿using System;
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

            if (cbyes.Checked == true)
                question = "has experienced COVID symptoms for the past 14 days.";
            else
                question = "hasn't experienced COVID symptoms for the past 14days.";


            StreamWriter Information;
            string path = @"..\..\..\Contact Tracing Information.txt";
            Information = File.CreateText(path);
            Information.WriteLine("Name: " + name); 
            Information.WriteLine("Age: " + age);
            Information.WriteLine("Address: " + address);
            Information.WriteLine("Mobile Number: " + number);
            Information.WriteLine("Email: " + email);
            Information.WriteLine("Gender: " + gender);
            Information.WriteLine(name + " " + question);
            Information.Close();


        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {
        }

        private void bopen_Click(object sender, EventArgs e)
        {
            Form2 nextform = new Form2();
            nextform.ShowDialog();
        }
    }
}
