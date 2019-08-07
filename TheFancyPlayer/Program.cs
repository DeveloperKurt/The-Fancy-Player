using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace TheFancyPlayer
{
   public static class Program
    {
        static Mutex mutex;

         [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

   
        static bool IsSingleInstance()
        {
            try
            {
                // Try to open existing mutex.
                Mutex.OpenExisting("The Fancy Player");
            }
            catch
            {
           
                Program.mutex = new Mutex(true, "The Fancy Player");

                // Only one instance.
                return true;
            }
            // More than one instance.
            return false;
        }


        public static MainForm mainForm;
    
        [STAThread]
        public static void Main(string[] args)
        {
            if (!IsSingleInstance())
            {
                Process[] proc = Process.GetProcessesByName("The Fancy Player"); 
                if (proc.Count() > 0)
                    SetForegroundWindow(proc[1].MainWindowHandle); // if there is another instance running, show its window.(proc[0] is our procces so we type proc[1]

             System.Environment.Exit(1);
            }
         
            Application.EnableVisualStyles();
            mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
