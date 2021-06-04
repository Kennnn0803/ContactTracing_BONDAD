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

namespace ContactTracing_Bondad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bshow_Click(object sender, EventArgs e)
        {
            string path = @"..\..\..\Contact Tracing Information.txt";
            var read = File.ReadAllText(path);
            tboxshow.Text = read;

        }
    }
}
