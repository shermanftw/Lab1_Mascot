using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Mascot
{
    public partial class Form1 : Form
    {
        bool Mascot_image;
        public Form1()
        {
            InitializeComponent();
            Mascot_image = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Mascot_image)
            {
                mascot_pic.Visible = false;
                Mascot_image = false;
            }
            else
            {
                mascot_pic.Visible = true;
                Mascot_image = true;
            }
        }

        private void mascot_pic_Click(object sender, EventArgs e)
        {

        }
    }
}
