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
    }
}
