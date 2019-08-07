namespace TheFancyPlayer
{
    partial class Donate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.labelThanks = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnOpenLink = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtBoxGmail = new Bunifu.Framework.UI.BunifuTextbox();
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
            this.LblHeader.Size = new System.Drawing.Size(251, 22);
            this.LblHeader.TabIndex = 4;
            this.LblHeader.Text = "The Fancy Player - Donate";
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
            // labelThanks
            // 
            this.labelThanks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelThanks.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThanks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelThanks.Location = new System.Drawing.Point(76, 113);
            this.labelThanks.Name = "labelThanks";
            this.labelThanks.Size = new System.Drawing.Size(513, 49);
            this.labelThanks.TabIndex = 5;
            this.labelThanks.Text = "Payments are currently disabled. ";
            // 
            // btnOpenLink
            // 
            this.btnOpenLink.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnOpenLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnOpenLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenLink.BorderRadius = 0;
            this.btnOpenLink.ButtonText = "   Open The Link";
            this.btnOpenLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenLink.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpenLink.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenLink.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOpenLink.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpenLink.Iconimage = global::TheFancyPlayer.Properties.Resources.ForwardArrowGreen;
            this.btnOpenLink.Iconimage_right = null;
            this.btnOpenLink.Iconimage_right_Selected = null;
            this.btnOpenLink.Iconimage_Selected = null;
            this.btnOpenLink.IconMarginLeft = 0;
            this.btnOpenLink.IconMarginRight = 0;
            this.btnOpenLink.IconRightVisible = true;
            this.btnOpenLink.IconRightZoom = 0D;
            this.btnOpenLink.IconVisible = true;
            this.btnOpenLink.IconZoom = 60D;
            this.btnOpenLink.IsTab = false;
            this.btnOpenLink.Location = new System.Drawing.Point(410, 244);
            this.btnOpenLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenLink.Name = "btnOpenLink";
            this.btnOpenLink.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnOpenLink.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(191)))), ((int)(((byte)(87)))));
            this.btnOpenLink.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpenLink.selected = false;
            this.btnOpenLink.Size = new System.Drawing.Size(225, 43);
            this.btnOpenLink.TabIndex = 4;
            this.btnOpenLink.Text = "   Open The Link";
            this.btnOpenLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenLink.Textcolor = System.Drawing.Color.White;
            this.btnOpenLink.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenLink.Click += new System.EventHandler(this.btnOpenLink_Click);
            // 
            // TxtBoxGmail
            // 
            this.TxtBoxGmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.TxtBoxGmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtBoxGmail.BackgroundImage")));
            this.TxtBoxGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtBoxGmail.Enabled = false;
            this.TxtBoxGmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxGmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(191)))), ((int)(((byte)(87)))));
            this.TxtBoxGmail.Icon = ((System.Drawing.Image)(resources.GetObject("TxtBoxGmail.Icon")));
            this.TxtBoxGmail.Location = new System.Drawing.Point(29, 233);
            this.TxtBoxGmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtBoxGmail.Name = "TxtBoxGmail";
            this.TxtBoxGmail.Padding = new System.Windows.Forms.Padding(1);
            this.TxtBoxGmail.Size = new System.Drawing.Size(343, 66);
            this.TxtBoxGmail.TabIndex = 2;
            this.TxtBoxGmail.text = "                  DISABLED";
            // 
            // Donate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(648, 348);
            this.Controls.Add(this.labelThanks);
            this.Controls.Add(this.btnOpenLink);
            this.Controls.Add(this.TxtBoxGmail);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Donate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDonate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuTextbox TxtBoxGmail;
        private Bunifu.Framework.UI.BunifuCustomLabel LblHeader;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpenLink;
        private Bunifu.Framework.UI.BunifuCustomLabel labelThanks;
    }
}