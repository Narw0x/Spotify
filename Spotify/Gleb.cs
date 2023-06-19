using Guna.UI2.WinForms;
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
    public partial class Gleb : Form
    {
        public Gleb()
        {
            InitializeComponent();
            AutoScroll = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Checked == true)
            {
                guna2Button1.Text = "UNFOLLOW";
                guna2HtmlLabel2.Text = "333,968 followers";

            }
            else
            {
                guna2Button1.Text = "FOLLOW";
                guna2HtmlLabel2.Text = "333,967 followers";
            }
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (guna2ImageButton2.Checked == false)
            {
                guna2ImageButton2.Checked = true;
                Dashboard.Self.playsong("Hus");
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
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (guna2ImageButton1.Checked == false)
            {
                guna2ImageButton1.Checked = true;
                Dashboard.Self.playsong("Komander");
            }
            else
            {
                guna2ImageButton1.Checked = false;
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

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (guna2ImageButton3.Checked == false)
            {
                guna2ImageButton3.Checked = true;
                Dashboard.Self.playsong("G");
            }
            else
            {
                guna2ImageButton3.Checked = false;
            }

            if (guna2ImageButton1.Checked == true)
            {
                guna2ImageButton1.Checked = false;
            }
            if (guna2ImageButton2.Checked == true)
            {
                guna2ImageButton2.Checked = false;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
