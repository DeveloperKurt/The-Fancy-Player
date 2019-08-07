namespace TheFancyPlayer
{
    partial class MiniWidget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniWidget));
            this.btnChangeUI = new Bunifu.Framework.UI.BunifuImageButton();
            this.previousButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.nextButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.playpauseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelCurrentPlaying = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playpauseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeUI
            // 
            this.btnChangeUI.BackColor = System.Drawing.Color.Black;
            this.btnChangeUI.Image = global::TheFancyPlayer.Properties.Resources.arrowDown;
            this.btnChangeUI.ImageActive = null;
            this.btnChangeUI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChangeUI.Location = new System.Drawing.Point(264, 60);
            this.btnChangeUI.Name = "btnChangeUI";
            this.btnChangeUI.Size = new System.Drawing.Size(28, 25);
            this.btnChangeUI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChangeUI.TabIndex = 9;
            this.btnChangeUI.TabStop = false;
            this.btnChangeUI.Zoom = 10;
            this.btnChangeUI.Click += new System.EventHandler(this.btnChangeUI_Click_1);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.Black;
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.ImageActive = null;
            this.previousButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.previousButton.Location = new System.Drawing.Point(59, 50);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(43, 37);
            this.previousButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previousButton.TabIndex = 12;
            this.previousButton.TabStop = false;
            this.previousButton.Zoom = 10;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Black;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.ImageActive = null;
            this.nextButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nextButton.Location = new System.Drawing.Point(192, 50);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(43, 37);
            this.nextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextButton.TabIndex = 11;
            this.nextButton.TabStop = false;
            this.nextButton.Zoom = 10;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // playpauseButton
            // 
            this.playpauseButton.BackColor = System.Drawing.Color.Black;
            this.playpauseButton.Image = ((System.Drawing.Image)(resources.GetObject("playpauseButton.Image")));
            this.playpauseButton.ImageActive = null;
            this.playpauseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.playpauseButton.Location = new System.Drawing.Point(121, 38);
            this.playpauseButton.Name = "playpauseButton";
            this.playpauseButton.Size = new System.Drawing.Size(50, 49);
            this.playpauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playpauseButton.TabIndex = 10;
            this.playpauseButton.TabStop = false;
            this.playpauseButton.Zoom = 10;
            this.playpauseButton.Click += new System.EventHandler(this.playpauseButton_Click);
            // 
            // labelCurrentPlaying
            // 
            this.labelCurrentPlaying.Font = new System.Drawing.Font("Century Gothic", 9.7F);
            this.labelCurrentPlaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.labelCurrentPlaying.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCurrentPlaying.Location = new System.Drawing.Point(12, 17);
            this.labelCurrentPlaying.Name = "labelCurrentPlaying";
            this.labelCurrentPlaying.Size = new System.Drawing.Size(271, 14);
            this.labelCurrentPlaying.TabIndex = 17;
            this.labelCurrentPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCurrentPlaying.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCurrentPlaying_MouseDown);
            // 
            // MiniWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(297, 89);
            this.Controls.Add(this.labelCurrentPlaying);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.playpauseButton);
            this.Controls.Add(this.btnChangeUI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiniWidget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniWidget";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MiniWidget_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MiniWidget_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playpauseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnChangeUI;
        private Bunifu.Framework.UI.BunifuImageButton previousButton;
        private Bunifu.Framework.UI.BunifuImageButton nextButton;
        private Bunifu.Framework.UI.BunifuImageButton playpauseButton;
        public Bunifu.Framework.UI.BunifuCustomLabel labelCurrentPlaying;
    }
}