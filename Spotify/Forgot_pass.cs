using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify
{
    public partial class Forgot_pass : Form
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
        public Forgot_pass()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(move_window);
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
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

        

        Rectangle Rightt { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }
        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


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
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var Loginform = new Login();
            Loginform.Closed += (s, args) => this.Close();
            Loginform.Show();
        }
        static string constring = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection conn = new MySqlConnection(constring);
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            label6.Visible = false;
            label2.Visible = false;

            Color deafault_c = Color.FromArgb(64, 64, 64);
            Color wrong_c = Color.FromArgb(253, 87, 87);

           
            guna2TextBox2.BorderColor = deafault_c;            
            guna2TextBox2.PlaceholderForeColor = deafault_c;           
            guna2TextBox2.PlaceholderText = "Email";           
            guna2TextBox2.HoverState.BorderColor = deafault_c;
            try
            {
                if (guna2TextBox2.Text == "")
                {
                    guna2TextBox2.BorderColor = wrong_c;
                    guna2TextBox2.PlaceholderForeColor = wrong_c;
                    guna2TextBox2.PlaceholderText = "Enter your email!";
                    guna2TextBox2.HoverState.BorderColor = wrong_c;

                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();

                    }
                    string i_email = guna2TextBox2.Text;
                    string e_pattern1 = @"^[a-zA-Z0-9]+.[a-zA-Z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]{2,}$";
                    string e_pattern2 = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]{2,}$";
                    if ((Regex.IsMatch(i_email, e_pattern1)) || (Regex.IsMatch(i_email, e_pattern2)))
                    {

                        string email1_query = "SELECT u_email, u_password FROM spotify.personal_info WHERE u_email = '" + guna2TextBox2.Text + "'";
                        MySqlCommand cmad1 = new MySqlCommand(email1_query, conn);
                        MySqlDataReader sdrrr = cmad1.ExecuteReader();
                        if (sdrrr.HasRows)
                        {
                            label2.Visible = true;

                            //treba tu dorobit sendovanie emailov

                        }
                    }
                    else
                    {
                        guna2TextBox2.BorderColor = wrong_c;
                        guna2TextBox2.PlaceholderForeColor = wrong_c;
                        guna2TextBox2.PlaceholderText = "Email is not valid!";
                        guna2TextBox2.HoverState.BorderColor = wrong_c;
                        guna2TextBox2.Text = string.Empty;
                        
                    }
                    conn.Close();
                }



            }
            catch (Exception ex)
            {

                conn.Close();
                MessageBox.Show(" " + ex + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label6.Visible = true;
            }

        }
        private void Forgot_pass_Load(object sender, EventArgs e)
        {

        }
    }
}
