using IWshRuntimeLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFancyPlayer
{
    [RunInstaller(true)]
    public partial class Installer1 : Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
          
            Process.Start(System.IO.Path.GetDirectoryName(this.Context.Parameters["AssemblyPath"]) + @"\The Fancy Player.exe");
            Process.Start(System.IO.Path.GetDirectoryName(this.Context.Parameters["AssemblyPath"]) + @"\READ ME.txt");





            var shell = new WshShell();
            var shortcut = shell.CreateShortcut((Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\The Fancy Player.lnk")) as IWshShortcut;


            shortcut.Description = "Shortcut of The Fancy Player";
            shortcut.IconLocation = (System.IO.Path.GetDirectoryName(this.Context.Parameters["AssemblyPath"]) + @"\icon.ico");
            shortcut.TargetPath = (System.IO.Path.GetDirectoryName(this.Context.Parameters["AssemblyPath"]) + @"\The Fancy Player.exe");


            shortcut.Save();

        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
            System.IO.File.Delete((Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\The Fancy Player.lnk"));
            Process.Start(System.IO.Path.GetDirectoryName(this.Context.Parameters["AssemblyPath"]) + @"\deleteData.bat");
        }
    }
    
}
