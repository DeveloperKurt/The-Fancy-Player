using TheFancyPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFancyPlayer
{
    public partial class MiniWidget : Form
    {
        private static Point ExLocation;
        private static bool posChanged = false;
        public MiniWidget()
        {
            InitializeComponent();
            
            Program.mainForm.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height,20, 20));


            if (Program.mainForm.player.shuffleEnabled == true)
            {
                labelCurrentPlaying.Text = "Playing:  " + Program.mainForm.player.shuffledFilesNames[Program.mainForm.player.playlistPos];
            }
            else if (Program.mainForm.player.playArgs == true)
            {
               labelCurrentPlaying.Text = "Playing:  " + Program.mainForm.player.argPlayListNames[Program.mainForm.player.playlistPos];
            }
            else
                labelCurrentPlaying.Text = "Playing:  " + Program.mainForm.player.playlistNames[Program.mainForm.player.playlistPos];


            if (Program.mainForm.player.isPlaying)
            {
                changeToPauseImage();

            }
     
            else if (Program.mainForm.player.isPlaying == false)

            {

                changeToPlayImage();
               
            }
        }
        

        private void MiniWidget_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                posChanged = true;
                ExLocation = this.Location;

            }
        }
        #region dragwindow
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion dragwindows

        private void labelCurrentPlaying_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                posChanged = true;
                ExLocation = this.Location;
                
            }
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


       
        private void btnChangeUI_Click_1(object sender, EventArgs e)
        {
            Program.mainForm.Visible = true;
            this.Close();
        }

        public void changeToPlayImage()
        {
    
            playpauseButton.Image = Resources.PlayButton; ;
        }
        public void changeToPauseImage()
        {
            playpauseButton.Image = Resources.PauseButton; 
        }

        private void playpauseButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.player.checkAndPlay();
                   
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.player.next();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.player.previous();
        }

        private void MiniWidget_Load(object sender, EventArgs e)
        {
            if(posChanged)
            this.Location = ExLocation;
        }
    }
}
