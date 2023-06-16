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
    public partial class Saul : Form
    {
        public Saul()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(guna2Button1.Checked == true )
            {
                guna2Button1.Text = "UNFOLLOW";
                guna2HtmlLabel2.Text = "173,241 followers";

            }
            else
            {
                guna2Button1.Text = "FOLLOW";
                guna2HtmlLabel2.Text = "173,240 followers";
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
