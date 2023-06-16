using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lb_hi.Text = "Hi!  " + Login.name;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void lb_hi_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if(guna2ImageButton1.Checked == false){
                guna2ImageButton1.Checked = true;
            }
            else
            {
                guna2ImageButton1.Checked = false;
            }

            if (guna2ImageButton2.Checked == true)
            {
                guna2ImageButton2.Checked = false;
            }
            if (guna2ImageButton3.Checked == true)
            {
                guna2ImageButton3.Checked = false;
            }
            if (guna2ImageButton4.Checked == true)
            {
                guna2ImageButton4.Checked = false;
            }

        }

        private void guna2ImageButton2_Click_2(object sender, EventArgs e)
        {
            if (guna2ImageButton2.Checked == false)
            {
                guna2ImageButton2.Checked = true;
            }
            else
            {
                guna2ImageButton2.Checked = false;
            }

            if (guna2ImageButton1.Checked == true)
            {
                guna2ImageButton1.Checked = false;
            }
            if (guna2ImageButton3.Checked == true)
            {
                guna2ImageButton3.Checked = false;
            }
            if (guna2ImageButton4.Checked == true)
            {
                guna2ImageButton4.Checked = false;
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (guna2ImageButton3.Checked == false)
            {
                guna2ImageButton3.Checked = true;
            }
            else
            {
                guna2ImageButton3.Checked = false;
            }


            if (guna2ImageButton2.Checked == true)
            {
                guna2ImageButton2.Checked = false;
            }
            if (guna2ImageButton1.Checked == true)
            {
                guna2ImageButton1.Checked = false;
            }
            if (guna2ImageButton4.Checked == true)
            {
                guna2ImageButton4.Checked = false;
            }
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            if (guna2ImageButton4.Checked == false)
            {
                guna2ImageButton4.Checked = true;
            }
            else
            {
                guna2ImageButton4.Checked = false;
            }

            if (guna2ImageButton2.Checked == true)
            {
                guna2ImageButton2.Checked = false;
            }
            if (guna2ImageButton3.Checked == true)
            {
                guna2ImageButton3.Checked = false;
            }
            if (guna2ImageButton1.Checked == true)
            {
                guna2ImageButton1.Checked = false;
            }
        }
    }
}
