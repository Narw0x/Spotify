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
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Mail;
using System.Net;

namespace Spotify
{
    public partial class Register : Form
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
        public Register()
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var Loginform =  new Login();
            Loginform.Closed += (s, args) => this.Close();
            Loginform.Show();
        }

        static string constring = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection conn = new MySqlConnection(constring);
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Color deafault_c  = Color.FromArgb(64,64,64);
            Color wrong_c = Color.FromArgb(253,87,87);


            guna2TextBox1.BorderColor = deafault_c;
            guna2TextBox2.BorderColor = deafault_c;
            guna2TextBox3.BorderColor = deafault_c;
            guna2TextBox4.BorderColor = deafault_c;
            guna2TextBox1.PlaceholderForeColor = deafault_c;
            guna2TextBox2.PlaceholderForeColor = deafault_c;
            guna2TextBox3.PlaceholderForeColor = deafault_c;
            guna2TextBox4.PlaceholderForeColor = deafault_c;
            guna2TextBox1.PlaceholderText = "Username";
            guna2TextBox2.PlaceholderText = "Email";
            guna2TextBox3.PlaceholderText = "Use at least 8 characters";
            guna2TextBox4.PlaceholderText = "Use at least 8 characters";
            guna2TextBox1.HoverState.BorderColor = deafault_c;
            guna2TextBox2.HoverState.BorderColor = deafault_c;
            guna2TextBox3.HoverState.BorderColor = deafault_c;
            guna2TextBox4.HoverState.BorderColor = deafault_c;

            string i_username = guna2TextBox1.Text;
            string i_email = guna2TextBox2.Text;
            string password1 = guna2TextBox3.Text;
            string password2 = guna2TextBox4.Text;
            int pass1lenght = password1.Length;
            string i_password = password1;
            string u_pattern = @"^[a-zA-Z0-9_]+$";
            string e_pattern1 = @"^[a-zA-Z0-9]+.[a-zA-Z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]{2,}$";
            string e_pattern2 = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]{2,}$";


            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();

                }
                string username_query = "SELECT u_username FROM spotify.personal_info WHERE u_username = '" + i_username + "'";
                MySqlCommand cmd = new MySqlCommand(username_query, conn);
                MySqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    guna2TextBox1.BorderColor = wrong_c;
                    guna2TextBox1.HoverState.BorderColor = wrong_c;
                    guna2TextBox1.PlaceholderForeColor = wrong_c;
                    guna2TextBox1.PlaceholderText = "Username already exist!";
                    guna2TextBox1.Text = string.Empty;
                }else if(i_username == "")
                {
                    guna2TextBox1.BorderColor = wrong_c;
                    guna2TextBox1.HoverState.BorderColor = wrong_c;
                    guna2TextBox1.PlaceholderForeColor = wrong_c;
                    guna2TextBox1.PlaceholderText = "Enter your username!";
                }else if (!(Regex.IsMatch(i_username, u_pattern)))
                {
                    guna2TextBox1.BorderColor = wrong_c;
                    guna2TextBox1.HoverState.BorderColor = wrong_c;
                    guna2TextBox1.PlaceholderForeColor = wrong_c;
                    guna2TextBox1.PlaceholderText = "Use letters or numbers!";
                    guna2TextBox1.Text = string.Empty;

                }
                sdr.Close();
                string email_query = "SELECT u_email FROM spotify.personal_info WHERE u_email = '" + i_email + "'";
                MySqlCommand cmad = new MySqlCommand(email_query, conn);
                MySqlDataReader sdrr = cmad.ExecuteReader();
                if (sdrr.HasRows)
                {
                    guna2TextBox2.BorderColor = wrong_c;
                    guna2TextBox2.HoverState.BorderColor = wrong_c;
                    guna2TextBox2.PlaceholderForeColor = wrong_c;
                    guna2TextBox2.PlaceholderText = "Email already exist!";
                    guna2TextBox2.Text = string.Empty;
                }else if(i_email == "")
                {
                    guna2TextBox2.BorderColor = wrong_c;
                    guna2TextBox2.HoverState.BorderColor = wrong_c;
                    guna2TextBox2.PlaceholderForeColor = wrong_c;
                    guna2TextBox2.PlaceholderText = "Enter your email!";
                }else if (!((Regex.IsMatch(i_email, e_pattern1)) || (Regex.IsMatch(i_email, e_pattern2))))
                {
                    guna2TextBox2.BorderColor = wrong_c;
                    guna2TextBox2.HoverState.BorderColor = wrong_c;
                    guna2TextBox2.PlaceholderForeColor = wrong_c;
                    guna2TextBox2.PlaceholderText = "Invalid email!";
                    guna2TextBox2.Text = string.Empty;
                }


                if (pass1lenght > 7)
                {
                    if (password1 == password2)
                    {
                        sdrr.Close();
                        string i_query = "INSERT INTO spotify.personal_info(u_username,u_email,u_password) VALUES('" + i_username + "', '" + i_email + "', '" + i_password + "');";
                        MySqlCommand i_cmd = new MySqlCommand(i_query, conn);
                        MySqlDataReader i_sdr = i_cmd.ExecuteReader();
                        MailMessage mail = new MailMessage("spotify.real100@gmail.com", guna2TextBox2.Text, "Registracia na 100% real spotify", "Registroval si sa ty blazon");
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("spotify.real100@gmail.com", "bmwnxnfpamymessw");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                        }
                        this.Hide();
                        var Loginform = new Login();
                        Loginform.Closed += (s, args) => this.Close();
                        Loginform.Show();

                    }
                    else
                    {
                        guna2TextBox4.BorderColor = wrong_c;
                        guna2TextBox4.PlaceholderForeColor = wrong_c;
                        guna2TextBox4.PlaceholderText = "Passwords don´t match";
                        guna2TextBox4.Text = string.Empty;
                    }
                }
                else
                {
                    guna2TextBox3.BorderColor = wrong_c;
                    guna2TextBox3.HoverState.BorderColor = wrong_c;
                    guna2TextBox3.PlaceholderForeColor = wrong_c;
                    guna2TextBox3.PlaceholderText = "Password is too short!";
                    guna2TextBox3.Text = string.Empty;
                    guna2TextBox4.BorderColor = wrong_c;
                    guna2TextBox4.HoverState.BorderColor = wrong_c;
                    guna2TextBox4.PlaceholderForeColor = wrong_c;
                    guna2TextBox4.PlaceholderText = "Password is too short!";
                    guna2TextBox4.Text = string.Empty;

                }
                conn.Close();

                
                    

            
            }         
            catch (Exception ex)
            {

                conn.Close();
                
                label12.Visible = true;
            }
        }
        

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

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

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public static implicit operator Register(Login v)
        {
            throw new NotImplementedException();
        }
    }
}
