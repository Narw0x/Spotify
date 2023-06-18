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
    public partial class Your_playlist : Form
    {
        public Your_playlist()
        {
            InitializeComponent();
            AutoScroll = true;
        }

        private void Your_playlist_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (guna2ImageButton2.Checked == false)
            {
                guna2ImageButton2.Checked = true;
                Dashboard.Self.playsong("Sativa");
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
                Dashboard.Self.playsong("Lsdycham");
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
                Dashboard.Self.playsong("Zhorel");
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
