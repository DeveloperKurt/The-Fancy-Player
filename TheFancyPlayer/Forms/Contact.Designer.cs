namespace TheFancyPlayer
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btnGithub = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGmail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtBoxGitHub = new Bunifu.Framework.UI.BunifuTextbox();
            this.TxtBoxGmail = new Bunifu.Framework.UI.BunifuTextbox();
            this.labelThanks = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.LblHeader);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 55);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.LblHeader.Location = new System.Drawing.Point(172, 19);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(259, 22);
            this.LblHeader.TabIndex = 4;
            this.LblHeader.Text = "The Fancy Player - Contact";
            this.LblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(545, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btn_exit.Location = new System.Drawing.Point(595, 14);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(41, 32);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGithub.BorderRadius = 0;
            this.btnGithub.ButtonText = "   Open The Link";
            this.btnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGithub.DisabledColor = System.Drawing.Color.Gray;
            this.btnGithub.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGithub.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGithub.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGithub.Iconimage = global::TheFancyPlayer.Properties.Resources.ForwardArrow;
            this.btnGithub.Iconimage_right = null;
            this.btnGithub.Iconimage_right_Selected = null;
            this.btnGithub.Iconimage_Selected = null;
            this.btnGithub.IconMarginLeft = 0;
            this.btnGithub.IconMarginRight = 0;
            this.btnGithub.IconRightVisible = true;
            this.btnGithub.IconRightZoom = 0D;
            this.btnGithub.IconVisible = true;
            this.btnGithub.IconZoom = 60D;
            this.btnGithub.IsTab = false;
            this.btnGithub.Location = new System.Drawing.Point(392, 161);
            this.btnGithub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnGithub.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnGithub.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGithub.selected = false;
            this.btnGithub.Size = new System.Drawing.Size(225, 43);
            this.btnGithub.TabIndex = 5;
            this.btnGithub.Text = "   Open The Link";
            this.btnGithub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGithub.Textcolor = System.Drawing.Color.White;
            this.btnGithub.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnGmail
            // 
            this.btnGmail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnGmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGmail.BorderRadius = 0;
            this.btnGmail.ButtonText = "   Copy To Clipboard";
            this.btnGmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGmail.DisabledColor = System.Drawing.Color.Gray;
            this.btnGmail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGmail.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGmail.Iconimage = global::TheFancyPlayer.Properties.Resources.ForwardArrow;
            this.btnGmail.Iconimage_right = null;
            this.btnGmail.Iconimage_right_Selected = null;
            this.btnGmail.Iconimage_Selected = null;
            this.btnGmail.IconMarginLeft = 0;
            this.btnGmail.IconMarginRight = 0;
            this.btnGmail.IconRightVisible = true;
            this.btnGmail.IconRightZoom = 0D;
            this.btnGmail.IconVisible = true;
            this.btnGmail.IconZoom = 60D;
            this.btnGmail.IsTab = false;
            this.btnGmail.Location = new System.Drawing.Point(392, 266);
            this.btnGmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnGmail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnGmail.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGmail.selected = false;
            this.btnGmail.Size = new System.Drawing.Size(225, 43);
            this.btnGmail.TabIndex = 4;
            this.btnGmail.Text = "   Copy To Clipboard";
            this.btnGmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGmail.Textcolor = System.Drawing.Color.White;
            this.btnGmail.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // TxtBoxGitHub
            // 
            this.TxtBoxGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.TxtBoxGitHub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtBoxGitHub.BackgroundImage")));
            this.TxtBoxGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtBoxGitHub.Enabled = false;
            this.TxtBoxGitHub.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(223)))));
            this.TxtBoxGitHub.Icon = ((System.Drawing.Image)(resources.GetObject("TxtBoxGitHub.Icon")));
            this.TxtBoxGitHub.Location = new System.Drawing.Point(27, 151);
            this.TxtBoxGitHub.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtBoxGitHub.Name = "TxtBoxGitHub";
            this.TxtBoxGitHub.Size = new System.Drawing.Size(335, 66);
            this.TxtBoxGitHub.TabIndex = 2;
            this.TxtBoxGitHub.text = "https://github.com/DeveloperKurt";
            // 
            // TxtBoxGmail
            // 
            this.TxtBoxGmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.TxtBoxGmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtBoxGmail.BackgroundImage")));
            this.TxtBoxGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtBoxGmail.Enabled = false;
            this.TxtBoxGmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxGmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(223)))));
            this.TxtBoxGmail.Icon = ((System.Drawing.Image)(resources.GetObject("TxtBoxGmail.Icon")));
            this.TxtBoxGmail.Location = new System.Drawing.Point(27, 255);
            this.TxtBoxGmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtBoxGmail.Name = "TxtBoxGmail";
            this.TxtBoxGmail.Size = new System.Drawing.Size(335, 66);
            this.TxtBoxGmail.TabIndex = 1;
            this.TxtBoxGmail.text = "mustafakurt.business@gmail.com";
            // 
            // labelThanks
            // 
            this.labelThanks.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThanks.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelThanks.Location = new System.Drawing.Point(238, 74);
            this.labelThanks.Name = "labelThanks";
            this.labelThanks.Size = new System.Drawing.Size(179, 38);
            this.labelThanks.TabIndex = 8;
            this.labelThanks.Text = "My Accounts :";
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(648, 370);
            this.Controls.Add(this.labelThanks);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.btnGmail);
            this.Controls.Add(this.TxtBoxGitHub);
            this.Controls.Add(this.TxtBoxGmail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContact";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuTextbox TxtBoxGmail;
        private Bunifu.Framework.UI.BunifuTextbox TxtBoxGitHub;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeader;
        private Bunifu.Framework.UI.BunifuFlatButton btnGmail;
        private Bunifu.Framework.UI.BunifuFlatButton btnGithub;
        private Bunifu.Framework.UI.BunifuCustomLabel labelThanks;
    }
}