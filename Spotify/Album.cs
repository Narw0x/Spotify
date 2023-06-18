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
    public partial class Album : Form
    {
        public Album()
        {
            InitializeComponent();
            AutoScroll= true;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (guna2ImageButton1.Checked == false)
            {
                guna2ImageButton1.Checked = true;
                guna2HtmlLabel5.Text = "6 Likes";
            }
            else
            {
                guna2ImageButton1.Checked = false;
                guna2HtmlLabel5.Text = "5 Likes";
            }
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (guna2ImageButton2.Checked == false)
            {
                guna2ImageButton2.Checked = true;
                Dashboard.Self.playsong("Kacey");
            }
            else
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

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (guna2ImageButton3.Checked == false)
            {
                guna2ImageButton3.Checked = true;
                Dashboard.Self.playsong("Stick");
            }
            else
            {
                guna2ImageButton3.Checked = false;
            }

            if (guna2ImageButton2.Checked == true)
            {
                guna2ImageButton2.Checked = false;
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
                Dashboard.Self.playsong("Spin");
            }
            else
            {
                guna2ImageButton4.Checked = false;
            }

            if (guna2ImageButton3.Checked == true)
            {
                guna2ImageButton3.Checked = false;
            }
            if (guna2ImageButton2.Checked == true)
            {
                guna2ImageButton2.Checked = false;
            }
        }
    }
}
