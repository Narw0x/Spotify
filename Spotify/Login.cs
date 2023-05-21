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
using System.Data.SqlClient;

namespace Spotify
{
    public partial class Login : Form
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
        public Login()
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
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var Registerform = new Register();
            Registerform.Closed += (s, args) => this.Close();
            Registerform.Show();
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        

        private void guna2Panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Separator2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        static string constr = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Users;Data Source=DESKTOP-4IC0E7P";
        static SqlConnection con = new SqlConnection(constr);

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            try
            {
                if(guna2TextBox1.Text == "" && guna2TextBox2.Text == "")
                {

                }
                else { 
                    if (con.State == ConnectionState.Closed){
                        con.Open();
                    
                    }
                    string query = "select u_username, u_password from personal_info where u_username = '" + guna2TextBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                
                    if (sdr.HasRows)
                    {
                        sdr.Read();

                        if (sdr["u_password"].Equals(guna2TextBox2.Text))
                        {
                        
                        }else{
                            label7.ForeColor = Color.Red;
                        }
                    }
                    else{
                        label8.ForeColor = Color.Red;
                    }

                    con.Close();
                
                }
            }
            catch (Exception ex)
            {
                
                con.Close();
                label6.ForeColor = Color.Red;
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
