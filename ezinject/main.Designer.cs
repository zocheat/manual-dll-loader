namespace ezinjectv1
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.close = new System.Windows.Forms.Label();
            this.topmenu = new System.Windows.Forms.Panel();
            this.menu_txt = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.inject_btn = new System.Windows.Forms.Button();
            this.welcome_txt = new System.Windows.Forms.Label();
            this.inject_pnl = new System.Windows.Forms.Panel();
            this.inject_pnl_3 = new System.Windows.Forms.Panel();
            this.inject_pnl_2 = new System.Windows.Forms.Panel();
            this.info_txt = new System.Windows.Forms.Label();
            this.buildinfo_txt = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.youtube_text = new System.Windows.Forms.Label();
            this.youtube = new System.Windows.Forms.Button();
            this.website = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_lext = new System.Windows.Forms.Panel();
            this.topmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.inject_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(264, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 19);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // topmenu
            // 
            this.topmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(75)))));
            this.topmenu.Controls.Add(this.menu_txt);
            this.topmenu.Controls.Add(this.minimize);
            this.topmenu.Controls.Add(this.close);
            this.topmenu.Controls.Add(this.icon);
            this.topmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.topmenu.Location = new System.Drawing.Point(0, 0);
            this.topmenu.Name = "topmenu";
            this.topmenu.Size = new System.Drawing.Size(284, 19);
            this.topmenu.TabIndex = 2;
            this.topmenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topmenu_MouseDown);
            // 
            // menu_txt
            // 
            this.menu_txt.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_txt.ForeColor = System.Drawing.Color.White;
            this.menu_txt.Location = new System.Drawing.Point(20, 0);
            this.menu_txt.Name = "menu_txt";
            this.menu_txt.Size = new System.Drawing.Size(147, 19);
            this.menu_txt.TabIndex = 3;
            this.menu_txt.Text = " ezinject - GitHub Demo";
            this.menu_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minimize
            // 
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(244, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(20, 19);
            this.minimize.TabIndex = 2;
            this.minimize.Text = " -";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // icon
            // 
            this.icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.icon.Image = global::ezinject.Properties.Resources.zocheat_500x500_dragon_notext;
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(20, 19);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 3;
            this.icon.TabStop = false;
            // 
            // inject_btn
            // 
            this.inject_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inject_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.inject_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.inject_btn.Location = new System.Drawing.Point(69, 3);
            this.inject_btn.Name = "inject_btn";
            this.inject_btn.Size = new System.Drawing.Size(148, 39);
            this.inject_btn.TabIndex = 3;
            this.inject_btn.Text = "INJECT";
            this.inject_btn.UseVisualStyleBackColor = true;
            this.inject_btn.Click += new System.EventHandler(this.inject_btn_Click);
            // 
            // welcome_txt
            // 
            this.welcome_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcome_txt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_txt.ForeColor = System.Drawing.Color.White;
            this.welcome_txt.Location = new System.Drawing.Point(0, 19);
            this.welcome_txt.Name = "welcome_txt";
            this.welcome_txt.Size = new System.Drawing.Size(284, 42);
            this.welcome_txt.TabIndex = 4;
            this.welcome_txt.Text = "Welcome to ezinject!";
            this.welcome_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inject_pnl
            // 
            this.inject_pnl.Controls.Add(this.inject_pnl_3);
            this.inject_pnl.Controls.Add(this.inject_pnl_2);
            this.inject_pnl.Controls.Add(this.inject_btn);
            this.inject_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.inject_pnl.Location = new System.Drawing.Point(0, 61);
            this.inject_pnl.Name = "inject_pnl";
            this.inject_pnl.Size = new System.Drawing.Size(284, 48);
            this.inject_pnl.TabIndex = 5;
            // 
            // inject_pnl_3
            // 
            this.inject_pnl_3.Dock = System.Windows.Forms.DockStyle.Right;
            this.inject_pnl_3.Location = new System.Drawing.Point(221, 0);
            this.inject_pnl_3.Name = "inject_pnl_3";
            this.inject_pnl_3.Size = new System.Drawing.Size(63, 48);
            this.inject_pnl_3.TabIndex = 5;
            // 
            // inject_pnl_2
            // 
            this.inject_pnl_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.inject_pnl_2.Location = new System.Drawing.Point(0, 0);
            this.inject_pnl_2.Name = "inject_pnl_2";
            this.inject_pnl_2.Size = new System.Drawing.Size(63, 48);
            this.inject_pnl_2.TabIndex = 4;
            // 
            // info_txt
            // 
            this.info_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_txt.ForeColor = System.Drawing.Color.Red;
            this.info_txt.Location = new System.Drawing.Point(0, 109);
            this.info_txt.Name = "info_txt";
            this.info_txt.Size = new System.Drawing.Size(284, 14);
            this.info_txt.TabIndex = 7;
            this.info_txt.Text = "we are not responsible for anything.";
            this.info_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buildinfo_txt
            // 
            this.buildinfo_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.buildinfo_txt.ForeColor = System.Drawing.Color.Red;
            this.buildinfo_txt.Location = new System.Drawing.Point(0, 123);
            this.buildinfo_txt.Name = "buildinfo_txt";
            this.buildinfo_txt.Size = new System.Drawing.Size(284, 14);
            this.buildinfo_txt.TabIndex = 8;
            this.buildinfo_txt.Text = "build for GitHub";
            this.buildinfo_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copyright
            // 
            this.copyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.copyright.ForeColor = System.Drawing.Color.White;
            this.copyright.Location = new System.Drawing.Point(0, 197);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(284, 22);
            this.copyright.TabIndex = 9;
            this.copyright.Text = "copyright zocheat.me all rights reserved.";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // youtube_text
            // 
            this.youtube_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.youtube_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.youtube_text.ForeColor = System.Drawing.Color.White;
            this.youtube_text.Location = new System.Drawing.Point(0, 137);
            this.youtube_text.Name = "youtube_text";
            this.youtube_text.Size = new System.Drawing.Size(284, 23);
            this.youtube_text.TabIndex = 10;
            this.youtube_text.Text = "check our youtube and website for more and updates";
            this.youtube_text.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // youtube
            // 
            this.youtube.Dock = System.Windows.Forms.DockStyle.Left;
            this.youtube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.youtube.Font = new System.Drawing.Font("Arial", 12F);
            this.youtube.ForeColor = System.Drawing.Color.Red;
            this.youtube.Location = new System.Drawing.Point(15, 0);
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(120, 28);
            this.youtube.TabIndex = 11;
            this.youtube.Text = "YOUTUBE";
            this.youtube.UseVisualStyleBackColor = true;
            this.youtube.Click += new System.EventHandler(this.youtube_Click);
            // 
            // website
            // 
            this.website.Dock = System.Windows.Forms.DockStyle.Right;
            this.website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.website.Font = new System.Drawing.Font("Arial", 12F);
            this.website.ForeColor = System.Drawing.Color.Red;
            this.website.Location = new System.Drawing.Point(149, 0);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(120, 28);
            this.website.TabIndex = 12;
            this.website.Text = "WEBSITE";
            this.website.UseVisualStyleBackColor = true;
            this.website.Click += new System.EventHandler(this.website_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.youtube);
            this.panel1.Controls.Add(this.website);
            this.panel1.Controls.Add(this.panel_right);
            this.panel1.Controls.Add(this.panel_lext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 28);
            this.panel1.TabIndex = 13;
            // 
            // panel_right
            // 
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(269, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(15, 28);
            this.panel_right.TabIndex = 14;
            // 
            // panel_lext
            // 
            this.panel_lext.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lext.Location = new System.Drawing.Point(0, 0);
            this.panel_lext.Name = "panel_lext";
            this.panel_lext.Size = new System.Drawing.Size(15, 28);
            this.panel_lext.TabIndex = 13;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.youtube_text);
            this.Controls.Add(this.buildinfo_txt);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.info_txt);
            this.Controls.Add(this.inject_pnl);
            this.Controls.Add(this.welcome_txt);
            this.Controls.Add(this.topmenu);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ezinject";
            this.topmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.inject_pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel topmenu;
        private System.Windows.Forms.Label menu_txt;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button inject_btn;
        private System.Windows.Forms.Label welcome_txt;
        private System.Windows.Forms.Panel inject_pnl;
        private System.Windows.Forms.Panel inject_pnl_2;
        private System.Windows.Forms.Panel inject_pnl_3;
        private System.Windows.Forms.Label info_txt;
        private System.Windows.Forms.Label buildinfo_txt;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label youtube_text;
        private System.Windows.Forms.Button youtube;
        private System.Windows.Forms.Button website;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel panel_lext;
    }
}

