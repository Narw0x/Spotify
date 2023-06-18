using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify
{
    public partial class Dashboard : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        public static Dashboard Self;
        public Dashboard()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(move_window);
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
            Self = this;
            
        }
        private const int
           HTLEFT = 10,
           HTRIGHT = 11,
           HTTOP = 12,
           HTTOPLEFT = 13,
           HTTOPRIGHT = 14,
           HTBOTTOM = 15,
           HTBOTTOMLEFT = 16,
           HTBOTTOMRIGHT = 17;

        const int _ = 5; // you can rename this variable if you like

        Rectangle Topp { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Leftf { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottomm { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
        



        private void label1_Click(object sender, EventArgs e)
        {
            openchildFrom(new Saul());
        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        Rectangle Rightt { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }
        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        private void label4_Click(object sender, EventArgs e)
        {
            openchildFrom(new Gleb());
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            openchildFrom(new Gleb());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            openchildFrom(new Saul());
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            openchildFrom(new Home());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            openchildFrom(new Album());
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            openchildFrom(new Album());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            openchildFrom(new Your_playlist());
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            openchildFrom(new Your_playlist());
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            openchildFrom(new Search());
        }

        private void song_play_btn_Click(object sender, EventArgs e)
        {
            if(song_play_btn.Checked == false)
            {
                song_play_btn.Checked = true;
            }
            else
            {
                song_play_btn.Checked = false;
            }
        }


        private void song_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button3.Checked == false)
            {
                guna2Panel13.Visible = false;
                guna2Panel14.Visible = false;

            }
            else
            {
                guna2Panel13.Visible = true;
                guna2Panel14.Visible = true;
            }
            if (guna2Button2.Checked == false)
            {
                guna2Panel11.Visible = false;
                guna2Panel12.Visible = false;
            }
            else
            {
                guna2Panel11.Visible = true;
                guna2Panel12.Visible = true;
            }
            if (guna2Button1.Checked == false)
            {
                guna2Panel7.Visible = false;
                guna2Panel8.Visible = false;
                guna2Panel10.Visible = false;
                guna2Panel9.Visible = false;
            }
            else
            {
                guna2Panel7.Visible = true;
                guna2Panel8.Visible = true;
                guna2Panel10.Visible = true;
                guna2Panel9.Visible = true;
            }
            if ((guna2Button3.Checked == false && guna2Button2.Checked == false) && guna2Button1.Checked == false)
            {

                guna2Panel7.Visible = true;
                guna2Panel8.Visible = true;
                guna2Panel10.Visible = true;
                guna2Panel9.Visible = true;
                guna2Panel11.Visible = true;
                guna2Panel12.Visible = true;
                guna2Panel13.Visible = true;
                guna2Panel14.Visible = true;
            }

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(guna2Button3.Checked == false)
            {
                guna2Panel13.Visible = false;
                guna2Panel14.Visible = false;

            }
            else
            {
                guna2Panel13.Visible = true;
                guna2Panel14.Visible = true;
            }
            if (guna2Button2.Checked == false)
            {
                guna2Panel11.Visible = false;
                guna2Panel12.Visible = false;
            }
            else
            {
                guna2Panel11.Visible = true;
                guna2Panel12.Visible = true;
            }
            if (guna2Button1.Checked == false)
            {
                guna2Panel7.Visible = false;
                guna2Panel8.Visible = false;
                guna2Panel10.Visible = false;
                guna2Panel9.Visible = false;
            }
            else
            {
                guna2Panel7.Visible = true;
                guna2Panel8.Visible = true;
                guna2Panel10.Visible = true;
                guna2Panel9.Visible = true;
            }
            if ((guna2Button3.Checked == false && guna2Button2.Checked == false) && guna2Button1.Checked == false)
            {

                guna2Panel7.Visible = true;
                guna2Panel8.Visible = true;
                guna2Panel10.Visible = true;
                guna2Panel9.Visible = true;
                guna2Panel11.Visible = true;
                guna2Panel12.Visible = true;
                guna2Panel13.Visible = true;
                guna2Panel14.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2Button3.Checked == false)
            {
                guna2Panel13.Visible = false;
                guna2Panel14.Visible = false;

            }
            else
            {
                guna2Panel13.Visible = true;
                guna2Panel14.Visible = true;
            }
            if (guna2Button2.Checked == false)
            {
                guna2Panel11.Visible = false;
                guna2Panel12.Visible = false;
            }
            else
            {
                guna2Panel11.Visible = true;
                guna2Panel12.Visible = true;
            }
            if (guna2Button1.Checked == false)
            {
                guna2Panel7.Visible = false;
                guna2Panel8.Visible = false;
                guna2Panel10.Visible = false;
                guna2Panel9.Visible = false;
            }
            else
            {
                guna2Panel7.Visible = true;
                guna2Panel8.Visible = true;
                guna2Panel10.Visible = true;
                guna2Panel9.Visible = true;
            }
            if ((guna2Button3.Checked == false && guna2Button2.Checked == false) && guna2Button1.Checked == false)
            {

                guna2Panel7.Visible = true;
                guna2Panel8.Visible = true;
                guna2Panel10.Visible = true;
                guna2Panel9.Visible = true;
                guna2Panel11.Visible = true;
                guna2Panel12.Visible = true;
                guna2Panel13.Visible = true;
                guna2Panel14.Visible = true;
            }
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Topp.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Leftf.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Rightt.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottomm.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
        public static Form activeform = null;
        public void openchildFrom(Form childForm)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            
            panelchildform.BorderRadius = 10;
            panelchildform.Controls.Add(childForm);
            panelchildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        public static string active_song = null;
        public void playsong(string songName)
        {
            if(active_song != null)
            {
                active_song = null;
            }
            active_song = songName;
            switch(active_song)
            {
                case "Oblaky":
                    song_picture.Image = Properties.Resources.saul_oblaky;
                    song_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    song_name.Text = "Niekde v oblakoch";
                    song_panel.Visible = true;
                    panelchildform.Height = 567;                  
                    break;
                case "Zhorel":
                    song_picture.Image = Properties.Resources.saul_motyl;
                    song_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    song_name.Text = "Včera mi zhorel dom";
                    song_panel.Visible = true;
                    panelchildform.Height = 567;                   
                    break;
                case "Hus":
                    song_picture.Image = Properties.Resources.gleb_hus;
                    song_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    song_name.Text = "Šedá hus";
                    song_panel.Visible = true;
                    panelchildform.Height = 567;
                    break;
                case "Komander":
                    song_picture.Image = Properties.Resources.gleb_komander;
                    song_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    song_name.Text = "KOMANDER PUMP IT UP";
                    song_panel.Visible = true;
                    panelchildform.Height = 567;
                    break;
                case "Sativa":
                    song_picture.Image = Properties.Resources.lsdycham;
                    song_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    song_name.Text = "SATIVA";
                    song_panel.Visible = true;
                    panelchildform.Height = 567;
                    break;
                case "Lsdycham":
                    song_picture.Image = Properties.Resources.lsdycham;
                    song_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    song_name.Text = "LSDÝCHAM";
                    song_panel.Visible = true;
                    panelchildform.Height = 567;
                    break;
                case "Kacey":
                    song_picture.Image = Properties.Resources.flow_kacey;
                    song_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    song_name.Text = "Kacey talk";
                    song_panel.Visible = true;
                    panelchildform.Height = 567;
                    break;
                case "Stick":
                    song_picture.Image = Properties.Resources.flow_stick;
                    song_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    song_name.Text = "Stick to the Models";
                    song_panel.Visible = true;
                    panelchildform.Height = 567;
                    break;
                case "Spin":
                    song_picture.Image = Properties.Resources.flow_spin;
                    song_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    song_name.Text = "Spin Bout U";
                    song_panel.Visible = true;
                    panelchildform.Height = 567;
                    break;
                case "Slnovrat":
                    song_picture.Image = Properties.Resources.saul_slnovrat;
                    song_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    song_name.Text = "Slnovrat";
                    song_panel.Visible = true;
                    panelchildform.Height = 567;
                    break;
                case "G":
                    song_picture.Image = Properties.Resources.gleb_G;
                    song_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    song_name.Text = "HEY G!";
                    song_panel.Visible = true;
                    panelchildform.Height = 567;
                    break;
                default:
                    song_panel.Visible = false;
                    break;
            }

        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            openchildFrom(new Home());
            if(active_song == null) {
                song_panel.Visible = false;
            }
            
        }
    }
}
