﻿using System;
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
        
        

        public Dashboard()
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

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        Rectangle Rightt { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }
        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }
 
        
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
        private Form activeform = null;
        private void openchildFrom(Form childForm)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(childForm);
            panelchildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        

        
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
