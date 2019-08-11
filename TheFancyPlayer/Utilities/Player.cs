using NAudio.Wave;
using NAudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Reflection;
using System.Drawing;

namespace TheFancyPlayer
{
    public class Player
    {

        #region declarations

        private IWavePlayer waveOutDevice;
        private NAudio.CoreAudioApi.MMDeviceEnumerator deviceEnum = new NAudio.CoreAudioApi.MMDeviceEnumerator();
        private NotificationClientImplementation notificationClient;
        private NAudio.CoreAudioApi.Interfaces.IMMNotificationClient notifyClient;
        private string[] args = Environment.GetCommandLineArgs();
        private ManualResetEvent pauseBackgroundWorker = new ManualResetEvent(true);
        private TagLib.Tag Tag { get; set; }

        public AudioFileReader audioFileReader { get; private set; }     
        public int explaylistPos { get; set; }
        public int playlistPos { get; set; }
        public int searchResultExPos { get; set; }
        public string playingMusicPath { get; set; }
        public bool isPlaying { get; private set; }
        public bool isReaderLoaded { get; private set; }
        public bool CoudlntPlay { get; private set; }
        public bool shuffleEnabled { get; set; }
        public bool Muted { get; set; }
        public bool playArgs { get; set; }
        public string[] playlistNames { get; set; }  // all musics name in folder, play those at listview
        public string[] playlist { get; set; } // all paths of musics in folder
        public string[] shuffledPlaylist { get; set; } // If you want to use shuffle function, first you have to fill this array with playlist
        public string[] shuffledFilesNames { get; set; }
        public string[] argPlayList { get; set; }
        public string[] argPlayListNames { get; set; }
        public string[] searchPlayList { get; set; }
        public string[] searchPlayListNames { get; set; }
        public  List<int> searchResultPositions { get; set; }
        BackgroundWorker bw;

        #endregion declarations

        public Player(string[] _playlist, string[] _playlistNames)
        {
            playlist  = _playlist;
            playlistNames = _playlistNames;

            explaylistPos = 0;
            playlistPos = 0;
            searchResultExPos = 0;
            isPlaying = false;
            isReaderLoaded = false;
            CoudlntPlay = false;
            shuffleEnabled = false;
            Muted = false;
            playArgs = false;

            notificationClient = new NotificationClientImplementation();
            notifyClient = (NAudio.CoreAudioApi.Interfaces.IMMNotificationClient)notificationClient;
            deviceEnum.RegisterEndpointNotificationCallback(notifyClient);

            waveOutDevice = new WaveOut();
     
           
            bw = new BackgroundWorker();

            bw.DoWork += new DoWorkEventHandler(BW_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(BW_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
            bw.WorkerReportsProgress = true;
           
        }

        public Player(string[] _playlist, string[] _playlistNames, string[] _ShuffledPlaylist ,string[] _ShuffledPlaylistNames)
        {
            playlist = _playlist;
            playlistNames = _playlistNames;
            shuffledPlaylist = _ShuffledPlaylist;
            shuffledFilesNames = _ShuffledPlaylistNames;

            explaylistPos = 0;
            playlistPos = 0;
            searchResultExPos = 0;
            isPlaying = false;
            isReaderLoaded = false;
            CoudlntPlay = false;
            shuffleEnabled = false;
            Muted = false;
            playArgs = false;

            notificationClient = new NotificationClientImplementation();
            notifyClient = (NAudio.CoreAudioApi.Interfaces.IMMNotificationClient)notificationClient;
            deviceEnum.RegisterEndpointNotificationCallback(notifyClient);
        

            waveOutDevice = new WaveOut();
          
            bw = new BackgroundWorker();

            bw.DoWork += new DoWorkEventHandler(BW_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(BW_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BW_RunWorkerCompleted);
            bw.WorkerReportsProgress = true;

        }
        public  void whenOutputDeviceChanged()
        {

            long position;
            try
            {
              
                if (isPlaying) // If was playing before default device changed.
                {
                    pause();
                    position = audioFileReader.Position;
                    stop();

                    play();
                    audioFileReader.Position = position;
                    position = 0;
                }
             
                else if (!isPlaying) // If its paused before default device changed.
                {
               
                        pause();
                        position = audioFileReader.Position;
                        stop();

                    if (!isReaderLoaded)
                    {
                        LoadReader();
                        /// we are playing and pausing right after because we used stop function to change to the default output device
                        /// but while we are doing that we also lost all our UI data such as song name, duration time, focused song etc.
                        /// So we are using play function to draw them into the UI back, and pausing right after.
                        audioFileReader.Position = position;
                        play();
                        pause();
                        audioFileReader.Position = position;
                        position = 0;
                    }
                }
              
            }
            catch (Exception )
            {
                Console.WriteLine("An exception occured at 'whenOutputDeviceChanged' function.");
            }

        }

        public void SetPlayingMusicPath(string playingMusic)
        {
            if (!String.IsNullOrEmpty(playingMusic))
            {
                playingMusicPath = File_Operations.GetMusicPath() + "\\" + playingMusic + ".mp3";
            }
        }
        public void playFromArgs()
        {
            if (args.Length == 1) return;

            else
            {
                argPlayListNames = new string[args.Length - 1];
                argPlayList = new string[args.Length - 1];
                for (int i = 0; i < args.Length - 1; i++)
                {
                    if (!String.IsNullOrEmpty(args[i + 1]) && args[i + 1].EndsWith(".mp3"))
                    {
                        argPlayList[i] = args[i + 1];

                        argPlayListNames[i] = Path.GetFileNameWithoutExtension(args[i + 1]);
                    }
                }
                playArgs = true;
                Program.mainForm.showinlistview(argPlayListNames);
                play();
            }

        }
        public String getDuration(TagLib.File f)
        {
            if (f == null)
            {
                Console.WriteLine("Cant read file metadata(duration). File is Null!");
                return "00:00";
            }

            String Hours = f.Properties.Duration.Hours.ToString("D2");
            String Minutes = f.Properties.Duration.Minutes.ToString("D2");
            String Seconds = f.Properties.Duration.Seconds.ToString("D2");

            String Duration = Minutes + ":" + Seconds;
            if (Hours != "00") Duration = Hours + ":" + Duration;
            return Duration;

        }

        public TimeSpan getDurationSpan(TagLib.File f)
        {

            TimeSpan Duration = f.Properties.Duration;
            return Duration;

        }

        public bool LoadReader()
        {
            if (isReaderLoaded == true)
            {
                pauseBackgroundWorker.Set();
                return false;
            }
            else
            {
                try
                {
                    pauseBackgroundWorker.Reset();
                    audioFileReader = new AudioFileReader(playingMusicPath);
                    waveOutDevice.Init(audioFileReader);
                    isReaderLoaded = true;
                    pauseBackgroundWorker.Set();
                    return true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Couldnt load reader or read file");
                    CoudlntPlay = true;
                    return false;
                }

            }
        }

        public bool isTherePlaylist()
        {
            try
            {

                if (playlist.Length == 0)
                    return false;
                else return true;
            }
            catch (Exception )
            {
                return false;
            }

        }

        public bool play()
        {
            try
            {
                if (shuffleEnabled == true)
                {
                    playingMusicPath = shuffledPlaylist[playlistPos];
                }

                else if (playArgs == true)
                {
                    playingMusicPath = argPlayList[playlistPos];
                }
                else
                {
                    playingMusicPath = playlist[playlistPos];

                }

                if (isReaderLoaded == false)
                {
                    LoadReader();
                }

                long fileLenght = new System.IO.FileInfo(playingMusicPath).Length;

                if (File.Exists(playingMusicPath) && (fileLenght != 0) && isPlaying == false)
                {

                    fileLenght = 0;
                    isPlaying = true;
                    if (Muted == false)
                    {
                        float floatVolume = Program.mainForm.soundbar.Value / 100f; // check volumebars value before play 
                        try
                        {
                            audioFileReader.Volume = floatVolume;

                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        audioFileReader.Volume = 0.0f;
                    }
                    waveOutDevice.Play();
            
           
                    Program.mainForm.UITasksWhenMusicStart();

                    if (!bw.IsBusy) // If thread is not already running, it starts it.
                        bw.RunWorkerAsync();
                    return true;
                }
                else
                {
                    next();
                    return false;
                }

            }
            catch (Exception )
            {
                Console.WriteLine("An exception thrown at play() funcyion");
            }
            return false;
        }

        public void checkAndPlay()
        {
            if (!playArgs)
            {
                if (isTherePlaylist())
                {
                    if (!isPlaying)
                    {
                        if (!play())
                        {
                            Console.WriteLine("Cant play");
                        }
                    }
            
                    else if (isPlaying)
                    {
                        pause();
                    }
                }
            }
            else
            {
                if (!isPlaying)
                {
                    if (!play())
                    {
                        Console.WriteLine("Cant play");
                    }
                }
                // Actives when press Pause
                //-----------------------------------//
                else if (isPlaying)

                {
                    pause();
                }
            }
        }

       
        void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            
            while (true)
            {
                try
                {
                    if ((long)audioFileReader.CurrentTime.Ticks != (long)audioFileReader.TotalTime.Ticks)
                    {
                        bw.ReportProgress((int)audioFileReader.CurrentTime.TotalSeconds);

                        Thread.Sleep(1000);
                    }
                    else
                        break;
                }
                catch (Exception exception)
                {
                    pauseBackgroundWorker.WaitOne(Timeout.Infinite);
                    Console.WriteLine("Exception thrown when playing the song: " + exception.Message + " \n" + exception.StackTrace);
                   
                }
               
            }

        }

        void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            next();
        }


        void BW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            if (isPlaying)
                Program.mainForm.UpdateUI();
        }


        public  void pause()
        {

            waveOutDevice.Pause();
            isPlaying = false;
            Program.mainForm.UITasksWhenMusicPause();
        }

        public void next()
        {
            stop();
            try
            {
                if (playlistPos == Program.mainForm.playlistview.Items.Count - 1)
                {
                    playlistPos = 0;
                    play();
                }

                else
                {
                    playlistPos++;
                    play();
                }
            }
            catch (Exception )
            {

            }

        }

        public void previous()
        {
            try
            {

                stop();
                if (playlistPos == 0)
                {
                    playlistPos = Program.mainForm.playlistview.Items.Count - 1;
                    play();
                }

                else if (CoudlntPlay)
                {
                    playlistPos -= 2;
                    play();
                    CoudlntPlay = false;
                }
                else
                {
                    playlistPos--;
                    play();

                }

            }
            catch (Exception )
            {

            }

        }

        public void clearBuffer()
        {

            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
            isReaderLoaded = false;
        }

        public  void stop()
        {

            if (waveOutDevice != null)
            {
                if (audioFileReader != null)
                {
                    audioFileReader.Dispose();
                    audioFileReader = null;
                }
                waveOutDevice.Stop();
               
                isReaderLoaded = false;
                isPlaying = false;
                explaylistPos = playlistPos;


                Program.mainForm.UITasksWhenMusicStop();

            }
        }



        public void mute()
        {
            try
            {
                if (!Muted)
                {
                    audioFileReader.Volume = 0;
                    Muted = true;
                }

            }
            catch (Exception )
            {

            }
        }

        public void unmute()
        {
            try
            {
                if (Muted)
                {

                    audioFileReader.Volume = Program.mainForm.floatVolume;
                    Muted = false;
                }

            }
            catch (Exception )
            {

            }



        }
        public void Shuffle()
        {

            if (shuffleEnabled == false)
            {
                playlistPos = 0;
                stop();

                Random rng = new Random();

                int l = shuffledPlaylist.Length;
                while (l > 1)
                {
                    l--;
                    int r = rng.Next(l + 1);
                    string value = shuffledPlaylist[r];
                    shuffledPlaylist[r] = shuffledPlaylist[l];
                    shuffledPlaylist[l] = value;

                    string valuename = shuffledFilesNames[r];
                    shuffledFilesNames[r] = shuffledFilesNames[l];
                    shuffledFilesNames[l] = valuename;

                }

                Program.mainForm.showinlistview(shuffledFilesNames);
                playingMusicPath = shuffledPlaylist[playlistPos];
                shuffleEnabled = true;
                return;
            }
            else
            {
                playlistPos = 0;
                stop();

                Program.mainForm.showinlistview(playlistNames);
                shuffleEnabled = false;
                return;
            }

        }

     
    }
}


