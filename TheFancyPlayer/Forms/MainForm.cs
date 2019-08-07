using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using NAudio;
using NAudio.Wave;
using System.Diagnostics;
using TheFancyPlayer.Properties;
using IWshRuntimeLibrary;

namespace TheFancyPlayer
{



    public partial class MainForm : Form
    {

        public delegate void deviceChangedDelegate();
    
        public float floatVolume { get; set; }
        public static string[] _playlist { get; set; }
        public static string[] _playlistNames { get; set; }
        public static string[] _shuffledPlaylist { get; set; }
        public static string[] _shuffledFilesNames { get; set; }
        public Player player;
        private bool isOnTopEnabled = false;
        private bool isInSearchingMode = false;
        private string search = "";
        private string customImage;
        private int numberOfSearchResult = 0;

        globalKeyboardHook gkh = new globalKeyboardHook();


        #region dragwindow
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion dragwindows


        public MainForm()
        {
            InitializeComponent();

            gkh.HookedKeys.Add(Keys.MediaPlayPause);
            gkh.HookedKeys.Add(Keys.MediaPreviousTrack);
            gkh.HookedKeys.Add(Keys.MediaNextTrack);
            gkh.KeyDown += new KeyEventHandler(KeyDown);

          

            customImage = File_Operations.CheckCustomImage();
            if (!String.IsNullOrWhiteSpace(customImage))
            {
                try
                {
                    logo.Image = Image.FromFile(customImage);
                }
                catch (Exception )
                {
                    MessageBox.Show("Couldn't find custom image. Please try again.", "Couldn't Load Custom Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

          

        }

   

        void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.MediaPlayPause)
            {

                player.checkAndPlay();
            }
            else if (e.KeyCode == Keys.MediaPreviousTrack)
            {
                player.previous();

            }
            else if (e.KeyCode == Keys.MediaNextTrack)
            {
                player.next();
            }
            e.Handled = true;
        }



        public void UpdateUI()
        {

        
           playbacktimebar.Value = (int)player.audioFileReader.CurrentTime.TotalSeconds;       
           currentDuration.Text = player.audioFileReader.CurrentTime.ToString("mm\\:ss");

        }

        private void changeToPNGLogo()
        {
            if (String.IsNullOrWhiteSpace(customImage)) // if there is no custom image, then change logo to PNG version.
            {
                logo.Image = Resources.pauseBackground;
            }
        }

        private void changeToGIFLogo()
        {
            if (String.IsNullOrWhiteSpace(customImage)) // if there is no custom image, then change logo to gif version.
            {

                logo.Image = Resources.playBackground;
               
            }
        }

        public void UITasksWhenMusicStart()
        {
          
            var file = TagLib.File.Create(player.playingMusicPath);
            var duration = player.getDuration(file);   
            var durationspan = player.getDurationSpan(file);

            changeToPauseImage();
            totalDuration.Text = duration;
            if (player.shuffleEnabled == true)
            {
                labelCurrentPlaying.Text = "Playing:  " + player.shuffledFilesNames[player.playlistPos];
            }
            else if (player.playArgs == true)
            {
                labelCurrentPlaying.Text = "Playing:  " + player.argPlayListNames[player.playlistPos];
            }
            else
                labelCurrentPlaying.Text = "Playing:  " + player.playlistNames[player.playlistPos];

            playbacktimebar.MaximumValue = (int)durationspan.TotalSeconds;

            playlistview.Select();
          
            playlistview.Items[player.playlistPos].Focused = true;
            playlistview.Items[player.playlistPos].Selected = true;
            playlistview.Items[player.playlistPos].BackColor = SystemColors.Highlight;
            playlistview.Items[player.playlistPos].ForeColor = SystemColors.HighlightText;
            txtBoxSearch.Visible = false;
            search_ShowNext.Visible = false;
            // if playlist positon not first and last and currently playing song has bigger list view number ( at more bottom ) and bigger then 14 which is max song playlist can show
            // this will show the currently playing song at middle of listview
            if (!(player.playlistPos + 5 > Program.mainForm.playlistview.Items.Count - 1) && player.explaylistPos < player.playlistPos && Program.mainForm.playlistview.Items.Count > 14)
            {
                playlistview.EnsureVisible((player.playlistPos) + 5);

            }
            //same thing goes fore at above only this is runs in cases user played lower positon songs.
            else if (!(player.playlistPos - 5 < 0) && player.explaylistPos > player.playlistPos && Program.mainForm.playlistview.Items.Count > 14)
            {
                playlistview.EnsureVisible((player.playlistPos) - 5);
            }

            else
            {

                playlistview.EnsureVisible(player.playlistPos);
            }

            MiniWidget widget = Application.OpenForms.OfType<MiniWidget>().FirstOrDefault();
            if (widget != null)
            {
                widget.changeToPauseImage();
                if (player.shuffleEnabled == true)
                {
                    widget.labelCurrentPlaying.Text = "Playing:  " + player.shuffledFilesNames[player.playlistPos];
                }
                else if (player.playArgs == true)
                {
                    widget.labelCurrentPlaying.Text = "Playing:  " + player.argPlayListNames[player.playlistPos];
                }
                else
                    widget.labelCurrentPlaying.Text = "Playing:  " + player.playlistNames[player.playlistPos];

            }
            changeToGIFLogo();
        }

 
        public void UITasksWhenMusicStop()
        {
           
            if (playlistview.SelectedItems.Count != 0)
            {
                playlistview.SelectedItems[0].Selected = false;

            }
            changeToPlayImage();
            currentDuration.Text = "00:00";
            totalDuration.Text = "00:00";
            labelCurrentPlaying.Text = "";

            for (int i = playlistview.Items.Count - 1; i >= 0; i--)
            {
                playlistview.Items[i].ForeColor = System.Drawing.Color.FromArgb(30, 150, 114);
                playlistview.Items[i].BackColor = System.Drawing.Color.FromArgb(26, 29, 35);
            }
            MiniWidget widget = Application.OpenForms.OfType<MiniWidget>().FirstOrDefault();
            if (widget != null)
            {
                widget.labelCurrentPlaying.Text = "";
                widget.changeToPlayImage();
            }
            changeToPNGLogo();
        }

        public void UITasksWhenMusicPause()
        {
         
            changeToPlayImage();
            changeToPNGLogo();
            MiniWidget widget = Application.OpenForms.OfType<MiniWidget>().FirstOrDefault();
            if (widget != null)
            {
                widget.changeToPlayImage();
            }

        }



        public void changeToPlayImage()
        {
            playpauseButton.Image = Resources.PlayButton;
        }
        public void changeToPauseImage()
        {
            playpauseButton.Image = Resources.PauseButton;
        }

        private void searchInListview()
        {
            RemoveFocus();

            if (search != "")
            {
                for (int i = playlistview.Items.Count - 1; i >= 0; i--)
                {
                    var item = playlistview.Items[i];
                    if (item.Text.ToLower().Contains(txtBoxSearch.Text.ToLower()))
                    {
                        player.searchResultPositions.Add(i);
                        playlistview.Items[i].BackColor = SystemColors.Highlight;
                        playlistview.Items[i].ForeColor = SystemColors.HighlightText;
                    }
                }
            
            }
            player.searchResultPositions.Reverse();

            if (player.searchResultPositions.Count > 0)
            {
                FocusNextSearch();

            } 

            search = "";

        }

        private void FocusNextSearch()
        {

            numberOfSearchResult = player.searchResultPositions.Count;
            try
            {
                if (numberOfSearchResult == 1)
                {
                    player.searchResultExPos = 0;
                    playlistview.Select();

                    playlistview.Items[player.searchResultPositions.ElementAt(player.searchResultExPos)].Focused = true;
                    playlistview.Items[player.searchResultPositions.ElementAt(player.searchResultExPos)].Selected = true;

                    playlistview.EnsureVisible(player.searchResultPositions.ElementAt(player.searchResultExPos));
                }

                else if (player.searchResultExPos + 1 >= numberOfSearchResult)
                {
                    player.searchResultExPos = 0;
                    playlistview.Select();

                    playlistview.Items[player.searchResultPositions.ElementAt(player.searchResultExPos)].Focused = true;
                    playlistview.Items[player.searchResultPositions.ElementAt(player.searchResultExPos)].Selected = true;

                    playlistview.EnsureVisible(player.searchResultPositions.ElementAt(player.searchResultExPos));
                } 
                else if (player.searchResultExPos  < numberOfSearchResult)
                {

                    playlistview.Select();

                    playlistview.Items[player.searchResultPositions.ElementAt(player.searchResultExPos + 1)].Focused = true;
                    playlistview.Items[player.searchResultPositions.ElementAt(player.searchResultExPos + 1)].Selected = true;

                    playlistview.EnsureVisible(player.searchResultPositions.ElementAt(player.searchResultExPos + 1));
                }


                
        }


            catch (Exception )
            {

            }

            try
            {
                if (player.searchResultExPos + 1 < numberOfSearchResult)
                    player.searchResultExPos++;
                else
                    player.searchResultExPos = player.searchResultPositions.First();
            }
            catch(Exception )
            {

            }

            
          
        }

  

        private void RemoveFocus()
        {
            player.searchResultPositions.Clear();
            player.searchResultExPos = 0;
            numberOfSearchResult = 0;
            isInSearchingMode = false;
            txtBoxSearch.Visible = false;
            search_ShowNext.Visible = false;

            for (int i = playlistview.Items.Count - 1; i >= 0; i--)
            {
                var item = playlistview.Items[i];
                item.ForeColor = System.Drawing.Color.FromArgb(30, 150, 114);
                item.BackColor = System.Drawing.Color.FromArgb(26, 29, 35);
            }

            playlistview.Items[player.playlistPos].BackColor = SystemColors.Highlight;
            playlistview.Items[player.playlistPos].ForeColor = SystemColors.HighlightText;
            Program.mainForm.playlistview.EnsureVisible(player.playlistPos);
        }

        public void showinlistview() // we use it too open a dialog and show the chosen playlist.
        {
           
                clearListView();
                for (int i = 0; i < player.playlistNames.Length; i++)
                {
                    Program.mainForm.playlistview.Items.Add(player.playlistNames[i]);
                }
          
        }
        public void showinlistview(string FolderPath) // we use it to show already stored playlist.
        {

            clearListView();


            for (int i = 0; i < player.playlistNames.Length; i++)
            {
                Program.mainForm.playlistview.Items.Add(player.playlistNames[i]);
            }

        }

        public void showinlistview(string[] playList) // we use it to show any playlist array like shuffled, or from arguments.
        {
            clearListView();
            for (int i = 0; i < playList.Length; i++)
            {
                Program.mainForm.playlistview.Items.Add(playList[i]);
            }

            //  player.playList.ForEach(i=> Console.WriteLine("{0}\t", i ));
        }
         private void clearListView()
        {
            if (Program.mainForm.playlistview.Items.Count != 0)
            {
                Program.mainForm.playlistview.Items.Clear();
                Program.mainForm.playlistview.Update();
                Program.mainForm.playlistview.Refresh();
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)//EXIT
        {
            if(player !=null)
            player.clearBuffer();
            System.Environment.Exit(1);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)//drag drop
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)//minimize button
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)  //start-pause button
        {
            try
            {
                player.checkAndPlay();
            }
            catch (Exception)
            {

                
            }
           

        }

        private void btnmenu_Click(object sender, EventArgs e) // Moves items location and changes their size in order to make it small or bigger.
        {

            if (panel2.Width == 50)
            {
                //EXPAND 

                changeViewsPosToMax();

            }
            else
            {
                //Minimize

                changeViewsPosToMin();


            }

        }

        private void changeViewsPosToMax()
        {
            panel2.Visible = false;

            panelAnimator.ShowSync(panel2);

            panel2.Width = 208;

            this.Size = new Size(816, 694);
            logo.Visible = true;
            playlistview.Size = new Size(503, 345);
            playlistview.Location = new Point(254, 120);
            btnmenu.Location = new Point(166, 3);
            btnmenu.Visible = false;

            buttonAnimation.ShowSync(btnmenu);

            btnFolder.Location = new Point(0, 191);
            btnShuffle.Location = new Point(0, 260);
            btnStayOnTop.Location = new Point(0, 325);
            btnChangeImage.Location = new Point(0, 390);
            btnConctact.Location = new Point(0, 460);
            //  btnDonate.Location = new Point(0, 525);




            previousButton.Size = new Size(69, 70);
            playpauseButton.Size = new Size(82, 79);
            nextButton.Size = new Size(69, 70);


            previousButton.Location = new Point(353, 523);
            playpauseButton.Location = new Point(445, 514);
            nextButton.Location = new Point(550, 523);
            btn_exit.Location = new Point(762, 14);

            playbacktimebar.Size = new Size(415, 30);
            playbacktimebar.Location = new Point(278, 652);
            playbacktimebar.IndicatorColor = System.Drawing.Color.FromArgb(0, 102, 204);
            labelCurrentPlaying.Visible = true;

            currentDuration.Location = new Point(458, 607);
        }

        private void changeViewsPosToMin()
        {
            panel2.Visible = false;
            panel2.Width = 50;
            panelAnimator.ShowSync(panel2);
            logo.Visible = false;


            btnmenu.Visible = false;
            btnmenu.Location = new Point(11, 7);
            buttonAnimation.ShowSync(btnmenu);
            this.Size = new Size(375, 550);




            btnFolder.Location = new Point(4, 77);
            btnShuffle.Location = new Point(4, 142);
            btnStayOnTop.Location = new Point(4, 207);
            btnChangeImage.Location = new Point(3, 272);
            btnConctact.Location = new Point(4, 340);
            //  btnDonate.Location = new Point(4, 400);

            playlistview.Size = new Size(300, 330);
            playlistview.Location = new Point(65, 75);



            previousButton.Size = new Size(63, 61);
            playpauseButton.Size = new Size(65, 63);
            nextButton.Size = new Size(63, 61);

            previousButton.Location = new Point(95, 480);
            playpauseButton.Location = new Point(175, 475);
            nextButton.Location = new Point(255, 480);
            btn_exit.Location = new Point(313, 13);

            playbacktimebar.Size = new Size(270, 30);
            playbacktimebar.Location = new Point(75, 440);
            playbacktimebar.IndicatorColor = System.Drawing.Color.Green;

            currentDuration.Location = new Point(179, 420);

            labelCurrentPlaying.Visible = false;
            txtBoxSearch.Visible = false;
            isInSearchingMode = false;

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)//widget
        {
            MiniWidget widget = new MiniWidget();
            widget.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)// add music folder
        {
            if (File_Operations.getmusicfolder())
            {

                File_Operations.StoreMusicPath(File_Operations.folderpath);


                if (player == null)
                    player = new Player(_playlist, _playlistNames, _shuffledPlaylist, _shuffledFilesNames);

                Program.mainForm.player.playArgs = false;
                Program.mainForm.player.shuffleEnabled = false;
                player.playFromArgs(); // check if there are any song at arguments, if there is play it.
                player.searchResultPositions = new List<int>();
                showinlistview();
            }

           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)//Contact
        {
            Contact contactform = new Contact();

            // Show the Contact form
            contactform.Show();
        }




        private void playlistview_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo listViewHitTestInfo = playlistview.HitTest(e.X, e.Y);
            // text of the clicked ListView item
            string PlayFromList = listViewHitTestInfo.Item.Text;

            player.stop();
            player.playlistPos = listViewHitTestInfo.Item.Index;
            player.SetPlayingMusicPath(PlayFromList);
            player.play();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                player.next();
            }
            catch (Exception)
            {

                
            }
           
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            try
            {
                player.previous();
            }
            catch (Exception)
            {


            }
          
        }

        private void bunifuCustomLabel1_MouseDown(object sender, MouseEventArgs e) // drag drop
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.shuffleEnabled == false)
                {

                    btnShuffle.Iconimage = Resources.shuffletrue;
                    player.Shuffle();
                }
                else
                {

                    btnShuffle.Iconimage = Resources.ShuffleOff;
                    MiniWidget widget = Application.OpenForms.OfType<MiniWidget>().FirstOrDefault();
                    player.Shuffle();
                }
            }
            catch (Exception)
            {

              
            }
           
        }


        private void btnVolume_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.Muted == false)
                {

                    btnVolume.Image = Resources.mute;
                    player.mute();


                }
                else
                {
                    floatVolume = soundbar.Value / 100f;
                    btnVolume.Image = Resources.Speaker;
                    player.unmute();

                }
            }
            catch (Exception )
            {

            }
        }


        private void playbacktimebar_ValueChanged(object sender, EventArgs e) // if user changed play track bar value, its notifies our reader.
        {
            try
            {
                if (player.audioFileReader.Position != playbacktimebar.Value)
                {
                    player.pause();
                    int changedposition = playbacktimebar.Value;
                    long newPos;

                    newPos = (long)player.audioFileReader.WaveFormat.AverageBytesPerSecond * changedposition;

                  
                    player.audioFileReader.Position = newPos;
                    player.play();


                }
            }
            catch (Exception )
            {
                playbacktimebar.Value = 0;

            }

        }

        private void soundbar_ValueChanged(object sender, EventArgs e)
        {
            float floatVolume = soundbar.Value / 100f;

            try
            {
                btnVolume.Image = Resources.Speaker;
                player.Muted = false;
                player.audioFileReader.Volume = floatVolume;

            }
            catch (Exception )
            {

            }
        }

        private void btnStayOnTop_Click(object sender, EventArgs e)
        {
            if (isOnTopEnabled == false)
            {
                this.TopMost = true;
                btnStayOnTop.Iconimage = Resources.stayOnTopTrue;
                isOnTopEnabled = true;
            }
            else
            {
                this.TopMost = false;
                btnStayOnTop.Iconimage = Resources.stayOnTopFalse;
                isOnTopEnabled = false;
            }
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Choose image to change left top image of this application ( you can choose default image again at installation folder of this application) ";

            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(open.FileName))
            {
                logo.Image = new Bitmap(open.FileName);
                File_Operations.storeImageLocation(open.FileName);
            }

        }


        private void btnSearch_Click(object sender, EventArgs e) // 
        {
            if (txtBoxSearch.Text != "" && txtBoxSearch.Visible == true) // If user typed something, searches it. The purpose is after user typed something, he-she can click this button again and search it.
            {

                player.pause();
                search = txtBoxSearch.Text;
                searchInListview();
                isInSearchingMode = false;
            

            }
            else if (isInSearchingMode == false) // if textbox not visible this code block runs, it means user clicked search button first time 
            {
                try
                {
                    player.pause();
                    txtBoxSearch.Visible = true;
                    isInSearchingMode = true;
                    search_ShowNext.Visible = true;
                    txtBoxSearch.Focus();
                }
                catch(Exception )
                {

                }
            }
            else // if user didin't typed anything, ignores it.
            {
                txtBoxSearch.Text = "";
                txtBoxSearch.Visible = false;
                isInSearchingMode = false;
                search_ShowNext.Visible = false;
            }
          
        }


        private void search_ShowNext_Click(object sender, EventArgs e)
        {
            FocusNextSearch();
        }

        private void txtBoxSearch_Enter(object sender, EventArgs e)
        {
            txtBoxSearch.Text = string.Empty;


        }

        private void txtBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
                search = txtBoxSearch.Text;
                searchInListview();
            }
        }



        private void btnDonate_Click(object sender, EventArgs e)
        {
            Donate Donateform = new Donate();
            Donateform.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            File_Operations.folderpath = File_Operations.GetMusicPath();

            if (!String.IsNullOrEmpty(File_Operations.folderpath))
            {
                File_Operations.GetFiles(File_Operations.folderpath);
                player = new Player(_playlist, _playlistNames, _shuffledPlaylist, _shuffledFilesNames);
                showinlistview(File_Operations.folderpath);
                player.playFromArgs(); // check if there are any song at arguments, if there is play it.
                player.searchResultPositions = new List<int>();

            }
      


        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
      
            if(isInSearchingMode)
            {
                txtBoxSearch.Text = "";
                RemoveFocus();
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (isInSearchingMode)
            {
                txtBoxSearch.Text = "";
                RemoveFocus();
            }
        }

        
    }
}

