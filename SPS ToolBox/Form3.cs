using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SPS_ToolBox_Mini;

namespace SPS_ToolBox
{
    public partial class Form3 : Form
    {
        Form2 miniToolbox = new Form2();
        public Form3()
        {
            InitializeComponent();
            miniToolbox.MouseHover += new EventHandler(miniToolbox_MouseHover);
            //miniToolbox.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
           
        }
        //private miniToolbox_MouseMove (object sender, MouseEventArgs e)
        //{
        //    this.miniToolbox
        //}
        private void miniToolbox_MouseHover(object sender, EventArgs e)
        {
            // Update the mouse event label to indicate the MouseHover event occurred.
            //label1.Text = sender.GetType().ToString() + ": MouseHover";
            //Form2 miniToolbox = new Form2();
            //miniToolbox.Show();
            miniToolbox.Show();
            
        }

    }
}
