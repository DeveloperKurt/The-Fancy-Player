using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFancyPlayer
{
    public static class File_Operations
    {
       
        public static string folderpath { get; set; }// music folder path
        private static String DataPath;

      

        public static bool getmusicfolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                   
                    folderpath = fbd.SelectedPath;
                    GetFiles(folderpath);
               
                    return true;

                }
                else return false;
            }
        }

        public static void GetFiles(string Fpath)
        {
            
            MainForm._playlistNames = Directory.GetFiles(Fpath, "*mp3").Select(Path.GetFileNameWithoutExtension).ToArray();
            MainForm._playlist = Directory.GetFiles(Fpath, "*.mp3");
            MainForm._shuffledPlaylist = Directory.GetFiles(Fpath, "*.mp3");
            MainForm._shuffledFilesNames = Directory.GetFiles(Fpath, "*.mp3").Select(Path.GetFileNameWithoutExtension).ToArray();
        }
        public static void StoreMusicPath(string Musicpath)
        {
            DataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DataPath += "\\TheFancyPlayer\\";
            if (!File.Exists(DataPath))
                Directory.CreateDirectory(DataPath);

             File.WriteAllText(DataPath + "Data.dat", Musicpath);
           

        }

       public static void storeImageLocation(string CustomImageLocation)
        {
            DataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DataPath += "\\TheFancyPlayer\\";
             if (!File.Exists("CustomImageLocation"))
                Directory.CreateDirectory(DataPath);

            File.WriteAllText(DataPath + "CustomImageLocation.dat", CustomImageLocation);
        }

        public static string CheckCustomImage()
        {
            DataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DataPath += "\\TheFancyPlayer\\CustomImageLocation.dat";
            if (File.Exists(DataPath) && File.ReadAllText(DataPath) != "")
                return File.ReadLines(DataPath).Skip(0).Take(1).First().ToString();
            else
            {
                Console.WriteLine("Error while reading database");
                return null;
            }

        }

        public static string GetMusicPath()
        {
            DataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DataPath += "\\TheFancyPlayer\\Data.dat";
            if (File.Exists(DataPath) && File.ReadAllText(DataPath) != "")
                return File.ReadLines(DataPath).Skip(0).Take(1).First().ToString();
            else
            {
               Console.WriteLine("Error while reading database");
                return null;
            }

        }

    }
}
