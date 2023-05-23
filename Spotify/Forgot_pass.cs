using MySql.Data.MySqlClient;
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
            label8.Visible= false;
            label9.Visible = false;
            label10.Visible= false;
            label14.Visible= false;
            label15.Visible= false;
            label16.Visible= false;
            label12.Visible= false;
            try
            {
                if (guna2TextBox2.Text == "")
                {
                    label14.Visible = true;
                    if (guna2TextBox3.Text == "")
                    {
                        label15.Visible = true;
                    }
                    if (guna2TextBox4.Text == "")
                    {
                        label16.Visible = true;
                    }
                    string password1 = guna2TextBox3.Text;
                    string password2 = guna2TextBox4.Text;
                    int pass1lenght = password1.Length;
                    if (password1 == "" || password2 == "")
                    {
                        if (password1 == "")
                        {
                            label15.Visible = true;
                        }
                        if (password2 == "")
                        {
                            label16.Visible = true;
                        }
                    }
                    else
                    {
                        if (pass1lenght > 8)
                        {
                            if (password1 == password2)
                            {

                            }
                            else
                            {
                                label10.Visible = true;
                            }
                        }
                        else
                        {
                            label9.Visible = true;
                        }
                    }
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();

                    }
                    string email1_query = "SELECT u_email, u_password FROM spotify.personal_info WHERE u_email = '" + guna2TextBox2.Text + "'";
                    MySqlCommand cmad1 = new MySqlCommand(email1_query, conn);
                    MySqlDataReader sdrrr = cmad1.ExecuteReader();
                    if(sdrrr.HasRows)
                    {

                        string password1 = guna2TextBox3.Text;
                        string password2 = guna2TextBox4.Text;
                        int pass1lenght = password1.Length;
                        if (password1 == "" || password2 == "")
                        {
                            if (password1 == "")
                            {
                                label15.Visible = true;
                            }
                            if (password2 == "")
                            {
                                label16.Visible = true;
                            }
                        }
                        else
                        {
                            if (pass1lenght > 8)
                            {
                                if (password1 == password2)
                                {
                                    if (sdrrr["u_password"] == password1)
                                    {
                                        label12.Visible=true;
                                    }
                                    else
                                    {
                                        sdrrr.Close();
                                        string u_query = "UPDATE spotify.personal_info SET u_password = '"+ password1 + "' WHERE u_email = '" + guna2TextBox2.Text + "';";
                                        MySqlCommand u_cmd = new MySqlCommand(u_query, conn); 
                                        MySqlDataReader u_sdr = u_cmd.ExecuteReader();
                                        MessageBox.Show("kokot ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                   
                                }
                                else
                                {
                                    label10.Visible = true;
                                }
                            }
                            else
                            {
                                label15.Visible = true;
                                label16.Visible = true;
                            }
                        }
                    }
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
