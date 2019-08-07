using System.Drawing;

namespace TheFancyPlayer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStayOnTop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChangeImage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnConctact = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShuffle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFolder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.currentDuration = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.playlistview = new System.Windows.Forms.ListView();
            this.Playlist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalDuration = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelCurrentPlaying = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.playbacktimebar = new Bunifu.Framework.UI.BunifuSlider();
            this.soundbar = new Bunifu.Framework.UI.BunifuSlider();
            this.txtBoxSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnVolume = new Bunifu.Framework.UI.BunifuImageButton();
            this.previousButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.nextButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.playpauseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.search_ShowNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.buttonAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playpauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ShowNext)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuImageButton4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_exit);
            this.panelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // bunifuCustomLabel1
            // 
            resources.ApplyResources(this.bunifuCustomLabel1, "bunifuCustomLabel1");
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Black;
            this.buttonAnimation.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuCustomLabel1_MouseDown);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Black;
            this.panelAnimator.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.bunifuImageButton4, "bunifuImageButton4");
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnimation.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnimation.SetDecoration(this.btn_exit, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btn_exit, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btn_exit, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.btnStayOnTop);
            this.panel2.Controls.Add(this.btnChangeImage);
            this.panel2.Controls.Add(this.logo);
            this.panel2.Controls.Add(this.btnConctact);
            this.panel2.Controls.Add(this.btnShuffle);
            this.panel2.Controls.Add(this.btnFolder);
            this.panel2.Controls.Add(this.btnmenu);
            this.panelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // btnStayOnTop
            // 
            this.btnStayOnTop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnStayOnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            resources.ApplyResources(this.btnStayOnTop, "btnStayOnTop");
            this.btnStayOnTop.BorderRadius = 0;
            this.btnStayOnTop.ButtonText = "  Stay On Top";
            this.btnStayOnTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnimation.SetDecoration(this.btnStayOnTop, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnStayOnTop, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnStayOnTop, BunifuAnimatorNS.DecorationType.None);
            this.btnStayOnTop.DisabledColor = System.Drawing.Color.Gray;
            this.btnStayOnTop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStayOnTop.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStayOnTop.Iconimage")));
            this.btnStayOnTop.Iconimage_right = null;
            this.btnStayOnTop.Iconimage_right_Selected = null;
            this.btnStayOnTop.Iconimage_Selected = null;
            this.btnStayOnTop.IconMarginLeft = 0;
            this.btnStayOnTop.IconMarginRight = 0;
            this.btnStayOnTop.IconRightVisible = true;
            this.btnStayOnTop.IconRightZoom = 0D;
            this.btnStayOnTop.IconVisible = true;
            this.btnStayOnTop.IconZoom = 50D;
            this.btnStayOnTop.IsTab = true;
            this.btnStayOnTop.Name = "btnStayOnTop";
            this.btnStayOnTop.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnStayOnTop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnStayOnTop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStayOnTop.selected = false;
            this.btnStayOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStayOnTop.Textcolor = System.Drawing.Color.White;
            this.btnStayOnTop.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStayOnTop.Click += new System.EventHandler(this.btnStayOnTop_Click);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            resources.ApplyResources(this.btnChangeImage, "btnChangeImage");
            this.btnChangeImage.BorderRadius = 0;
            this.btnChangeImage.ButtonText = "    Change Image";
            this.btnChangeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnimation.SetDecoration(this.btnChangeImage, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnChangeImage, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnChangeImage, BunifuAnimatorNS.DecorationType.None);
            this.btnChangeImage.DisabledColor = System.Drawing.Color.Gray;
            this.btnChangeImage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChangeImage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChangeImage.Iconimage")));
            this.btnChangeImage.Iconimage_right = null;
            this.btnChangeImage.Iconimage_right_Selected = null;
            this.btnChangeImage.Iconimage_Selected = null;
            this.btnChangeImage.IconMarginLeft = 0;
            this.btnChangeImage.IconMarginRight = 0;
            this.btnChangeImage.IconRightVisible = true;
            this.btnChangeImage.IconRightZoom = 0D;
            this.btnChangeImage.IconVisible = true;
            this.btnChangeImage.IconZoom = 50D;
            this.btnChangeImage.IsTab = true;
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnChangeImage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnChangeImage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChangeImage.selected = false;
            this.btnChangeImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangeImage.Textcolor = System.Drawing.Color.White;
            this.btnChangeImage.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // logo
            // 
            this.buttonAnimation.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.logo, "logo");
            this.logo.Image = global::TheFancyPlayer.Properties.Resources.pauseBackground;
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // btnConctact
            // 
            this.btnConctact.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnConctact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            resources.ApplyResources(this.btnConctact, "btnConctact");
            this.btnConctact.BorderRadius = 0;
            this.btnConctact.ButtonText = "  Contact";
            this.btnConctact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnimation.SetDecoration(this.btnConctact, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnConctact, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnConctact, BunifuAnimatorNS.DecorationType.None);
            this.btnConctact.DisabledColor = System.Drawing.Color.Gray;
            this.btnConctact.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConctact.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConctact.Iconimage")));
            this.btnConctact.Iconimage_right = null;
            this.btnConctact.Iconimage_right_Selected = null;
            this.btnConctact.Iconimage_Selected = null;
            this.btnConctact.IconMarginLeft = 0;
            this.btnConctact.IconMarginRight = 0;
            this.btnConctact.IconRightVisible = true;
            this.btnConctact.IconRightZoom = 0D;
            this.btnConctact.IconVisible = true;
            this.btnConctact.IconZoom = 50D;
            this.btnConctact.IsTab = true;
            this.btnConctact.Name = "btnConctact";
            this.btnConctact.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnConctact.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnConctact.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConctact.selected = false;
            this.btnConctact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConctact.Textcolor = System.Drawing.Color.White;
            this.btnConctact.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConctact.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            resources.ApplyResources(this.btnShuffle, "btnShuffle");
            this.btnShuffle.BorderRadius = 0;
            this.btnShuffle.ButtonText = "  Shuffle";
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnimation.SetDecoration(this.btnShuffle, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnShuffle, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnShuffle, BunifuAnimatorNS.DecorationType.None);
            this.btnShuffle.DisabledColor = System.Drawing.Color.Gray;
            this.btnShuffle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShuffle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Iconimage")));
            this.btnShuffle.Iconimage_right = null;
            this.btnShuffle.Iconimage_right_Selected = null;
            this.btnShuffle.Iconimage_Selected = null;
            this.btnShuffle.IconMarginLeft = 0;
            this.btnShuffle.IconMarginRight = 0;
            this.btnShuffle.IconRightVisible = true;
            this.btnShuffle.IconRightZoom = 0D;
            this.btnShuffle.IconVisible = true;
            this.btnShuffle.IconZoom = 50D;
            this.btnShuffle.IsTab = true;
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnShuffle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnShuffle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShuffle.selected = false;
            this.btnShuffle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShuffle.Textcolor = System.Drawing.Color.White;
            this.btnShuffle.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            resources.ApplyResources(this.btnFolder, "btnFolder");
            this.btnFolder.BorderRadius = 0;
            this.btnFolder.ButtonText = "    Add Music Folder";
            this.btnFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnimation.SetDecoration(this.btnFolder, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnFolder, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnFolder, BunifuAnimatorNS.DecorationType.None);
            this.btnFolder.DisabledColor = System.Drawing.Color.Gray;
            this.btnFolder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFolder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFolder.Iconimage")));
            this.btnFolder.Iconimage_right = null;
            this.btnFolder.Iconimage_right_Selected = null;
            this.btnFolder.Iconimage_Selected = null;
            this.btnFolder.IconMarginLeft = 0;
            this.btnFolder.IconMarginRight = 0;
            this.btnFolder.IconRightVisible = true;
            this.btnFolder.IconRightZoom = 0D;
            this.btnFolder.IconVisible = true;
            this.btnFolder.IconZoom = 50D;
            this.btnFolder.IsTab = true;
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnFolder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnFolder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFolder.selected = false;
            this.btnFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFolder.Textcolor = System.Drawing.Color.White;
            this.btnFolder.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.Black;
            this.panelAnimator.SetDecoration(this.btnmenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnmenu, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.btnmenu, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.btnmenu, "btnmenu");
            this.btnmenu.ImageActive = null;
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.TabStop = false;
            this.btnmenu.Zoom = 10;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.panelAnimator.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 1;
            animation9.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 2F;
            animation9.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation9;
            this.panelAnimator.Interval = 8;
            this.panelAnimator.MaxAnimationTime = 300;
            // 
            // currentDuration
            // 
            resources.ApplyResources(this.currentDuration, "currentDuration");
            this.buttonAnimation.SetDecoration(this.currentDuration, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.currentDuration, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.currentDuration, BunifuAnimatorNS.DecorationType.None);
            this.currentDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.currentDuration.Name = "currentDuration";
            // 
            // playlistview
            // 
            this.playlistview.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.playlistview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.playlistview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Playlist});
            this.panelAnimator.SetDecoration(this.playlistview, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.playlistview, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.playlistview, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.playlistview, "playlistview");
            this.playlistview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(114)))));
            this.playlistview.FullRowSelect = true;
            this.playlistview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.playlistview.Name = "playlistview";
            this.playlistview.TileSize = new System.Drawing.Size(5, 5);
            this.playlistview.UseCompatibleStateImageBehavior = false;
            this.playlistview.View = System.Windows.Forms.View.Details;
            this.playlistview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playlistview_MouseClick);
            // 
            // Playlist
            // 
            resources.ApplyResources(this.Playlist, "Playlist");
            // 
            // totalDuration
            // 
            resources.ApplyResources(this.totalDuration, "totalDuration");
            this.buttonAnimation.SetDecoration(this.totalDuration, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.totalDuration, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.totalDuration, BunifuAnimatorNS.DecorationType.None);
            this.totalDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.totalDuration.Name = "totalDuration";
            // 
            // labelCurrentPlaying
            // 
            this.buttonAnimation.SetDecoration(this.labelCurrentPlaying, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.labelCurrentPlaying, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.labelCurrentPlaying, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.labelCurrentPlaying, "labelCurrentPlaying");
            this.labelCurrentPlaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.labelCurrentPlaying.Name = "labelCurrentPlaying";
            // 
            // playbacktimebar
            // 
            this.playbacktimebar.BackColor = System.Drawing.Color.Transparent;
            this.playbacktimebar.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.playbacktimebar.BorderRadius = 5;
            this.LogoAnimator.SetDecoration(this.playbacktimebar, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.playbacktimebar, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.playbacktimebar, BunifuAnimatorNS.DecorationType.None);
            this.playbacktimebar.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.playbacktimebar, "playbacktimebar");
            this.playbacktimebar.MaximumValue = 100;
            this.playbacktimebar.Name = "playbacktimebar";
            this.playbacktimebar.Value = 0;
            this.playbacktimebar.ValueChanged += new System.EventHandler(this.playbacktimebar_ValueChanged);
            // 
            // soundbar
            // 
            this.soundbar.BackColor = System.Drawing.Color.Transparent;
            this.soundbar.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soundbar.BorderRadius = 8;
            this.LogoAnimator.SetDecoration(this.soundbar, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.soundbar, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.soundbar, BunifuAnimatorNS.DecorationType.None);
            this.soundbar.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.soundbar, "soundbar");
            this.soundbar.MaximumValue = 100;
            this.soundbar.Name = "soundbar";
            this.soundbar.Value = 50;
            this.soundbar.ValueChanged += new System.EventHandler(this.soundbar_ValueChanged);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.txtBoxSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.txtBoxSearch.BorderThickness = 3;
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonAnimation.SetDecoration(this.txtBoxSearch, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.txtBoxSearch, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.txtBoxSearch, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.txtBoxSearch, "txtBoxSearch");
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxSearch.isPassword = false;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSearch.Enter += new System.EventHandler(this.txtBoxSearch_Enter);
            this.txtBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelAnimator.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.ImageActive = null;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelAnimator.SetDecoration(this.btnVolume, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnVolume, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.btnVolume, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.btnVolume, "btnVolume");
            this.btnVolume.ImageActive = null;
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.TabStop = false;
            this.btnVolume.Zoom = 10;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            resources.ApplyResources(this.previousButton, "previousButton");
            this.panelAnimator.SetDecoration(this.previousButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.previousButton, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.previousButton, BunifuAnimatorNS.DecorationType.None);
            this.previousButton.ImageActive = null;
            this.previousButton.Name = "previousButton";
            this.previousButton.TabStop = false;
            this.previousButton.Zoom = 10;
            this.previousButton.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            resources.ApplyResources(this.nextButton, "nextButton");
            this.panelAnimator.SetDecoration(this.nextButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.nextButton, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.nextButton, BunifuAnimatorNS.DecorationType.None);
            this.nextButton.ImageActive = null;
            this.nextButton.Name = "nextButton";
            this.nextButton.TabStop = false;
            this.nextButton.Zoom = 10;
            this.nextButton.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // playpauseButton
            // 
            this.playpauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelAnimator.SetDecoration(this.playpauseButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.playpauseButton, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.playpauseButton, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.playpauseButton, "playpauseButton");
            this.playpauseButton.ImageActive = null;
            this.playpauseButton.Name = "playpauseButton";
            this.playpauseButton.TabStop = false;
            this.playpauseButton.Zoom = 10;
            this.playpauseButton.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // search_ShowNext
            // 
            this.search_ShowNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelAnimator.SetDecoration(this.search_ShowNext, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.search_ShowNext, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this.search_ShowNext, BunifuAnimatorNS.DecorationType.None);
            this.search_ShowNext.Image = global::TheFancyPlayer.Properties.Resources.ForwardArrow;
            this.search_ShowNext.ImageActive = null;
            resources.ApplyResources(this.search_ShowNext, "search_ShowNext");
            this.search_ShowNext.Name = "search_ShowNext";
            this.search_ShowNext.TabStop = false;
            this.search_ShowNext.Zoom = 10;
            this.search_ShowNext.Click += new System.EventHandler(this.search_ShowNext_Click);
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(30);
            animation8.RotateCoeff = 0.5F;
            animation8.RotateLimit = 0.2F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation8;
            this.LogoAnimator.Interval = 7;
            this.LogoAnimator.MaxAnimationTime = 300;
            this.LogoAnimator.TimeStep = 0.01F;
            // 
            // buttonAnimation
            // 
            this.buttonAnimation.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.buttonAnimation.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(30);
            animation7.RotateCoeff = 0.5F;
            animation7.RotateLimit = 0.2F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.buttonAnimation.DefaultAnimation = animation7;
            this.buttonAnimation.Interval = 6;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.search_ShowNext);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.soundbar);
            this.Controls.Add(this.playbacktimebar);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.labelCurrentPlaying);
            this.Controls.Add(this.totalDuration);
            this.Controls.Add(this.playlistview);
            this.Controls.Add(this.currentDuration);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.playpauseButton);
            this.Controls.Add(this.panel1);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.buttonAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playpauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_ShowNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private Bunifu.Framework.UI.BunifuImageButton playpauseButton;
        private Bunifu.Framework.UI.BunifuImageButton nextButton;
        private Bunifu.Framework.UI.BunifuImageButton previousButton;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton btnmenu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnFolder;
        private Bunifu.Framework.UI.BunifuFlatButton btnShuffle;
        private Bunifu.Framework.UI.BunifuFlatButton btnConctact;
        private System.Windows.Forms.PictureBox logo;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition buttonAnimation;
        public System.Windows.Forms.ListView playlistview;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ColumnHeader Playlist;
        public Bunifu.Framework.UI.BunifuCustomLabel totalDuration;
        public Bunifu.Framework.UI.BunifuCustomLabel currentDuration;
        public Bunifu.Framework.UI.BunifuCustomLabel labelCurrentPlaying;
        public Bunifu.Framework.UI.BunifuSlider playbacktimebar;
        private Bunifu.Framework.UI.BunifuFlatButton btnChangeImage;
        private Bunifu.Framework.UI.BunifuFlatButton btnStayOnTop;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBoxSearch;
        public Bunifu.Framework.UI.BunifuSlider soundbar;
        public Bunifu.Framework.UI.BunifuImageButton btnVolume;
        public System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton search_ShowNext;
    }
}

