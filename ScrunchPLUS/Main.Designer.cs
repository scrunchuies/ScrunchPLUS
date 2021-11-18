
namespace ScrunchPLUS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.MainMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MainExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.SettingsBtn = new FontAwesome.Sharp.IconButton();
            this.ExtraBtn = new FontAwesome.Sharp.IconButton();
            this.NewsBtn = new FontAwesome.Sharp.IconButton();
            this.ChatBtn = new FontAwesome.Sharp.IconButton();
            this.GamesBtn = new FontAwesome.Sharp.IconButton();
            this.DashboardBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.labelAutoLogonSub = new System.Windows.Forms.Label();
            this.labelAutoLogon = new System.Windows.Forms.Label();
            this.AutoLogonBtn = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShadowForm
            // 
            this.ShadowForm.TargetForm = this;
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 12;
            this.Elipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.panelTop;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.MainMinimize);
            this.panelTop.Controls.Add(this.MainExit);
            this.panelTop.Controls.Add(this.iconCurrentChildForm);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(888, 75);
            this.panelTop.TabIndex = 0;
            // 
            // MainMinimize
            // 
            this.MainMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMinimize.Animated = true;
            this.MainMinimize.BorderRadius = 4;
            this.MainMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MainMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.MainMinimize.HoverState.Parent = this.MainMinimize;
            this.MainMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.MainMinimize.Location = new System.Drawing.Point(798, 0);
            this.MainMinimize.Name = "MainMinimize";
            this.MainMinimize.ShadowDecoration.Parent = this.MainMinimize;
            this.MainMinimize.Size = new System.Drawing.Size(45, 29);
            this.MainMinimize.TabIndex = 41;
            // 
            // MainExit
            // 
            this.MainExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainExit.Animated = true;
            this.MainExit.BorderRadius = 4;
            this.MainExit.CustomClick = true;
            this.MainExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.MainExit.HoverState.Parent = this.MainExit;
            this.MainExit.IconColor = System.Drawing.Color.Gainsboro;
            this.MainExit.Location = new System.Drawing.Point(843, 0);
            this.MainExit.Name = "MainExit";
            this.MainExit.ShadowDecoration.Parent = this.MainExit;
            this.MainExit.Size = new System.Drawing.Size(45, 29);
            this.MainExit.TabIndex = 40;
            this.MainExit.Click += new System.EventHandler(this.MainExit_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.iconCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCurrentChildForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 32;
            this.iconCurrentChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconCurrentChildForm.Size = new System.Drawing.Size(193, 51);
            this.iconCurrentChildForm.TabIndex = 4;
            this.iconCurrentChildForm.Text = "Home";
            this.iconCurrentChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCurrentChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconCurrentChildForm.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.SettingsBtn);
            this.panelMenu.Controls.Add(this.ExtraBtn);
            this.panelMenu.Controls.Add(this.NewsBtn);
            this.panelMenu.Controls.Add(this.ChatBtn);
            this.panelMenu.Controls.Add(this.GamesBtn);
            this.panelMenu.Controls.Add(this.DashboardBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 646);
            this.panelMenu.TabIndex = 0;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingsBtn.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.SettingsBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.SettingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsBtn.IconSize = 32;
            this.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 586);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SettingsBtn.Size = new System.Drawing.Size(220, 60);
            this.SettingsBtn.TabIndex = 6;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // ExtraBtn
            // 
            this.ExtraBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExtraBtn.FlatAppearance.BorderSize = 0;
            this.ExtraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtraBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExtraBtn.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.ExtraBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.ExtraBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExtraBtn.IconSize = 32;
            this.ExtraBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExtraBtn.Location = new System.Drawing.Point(0, 380);
            this.ExtraBtn.Name = "ExtraBtn";
            this.ExtraBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ExtraBtn.Size = new System.Drawing.Size(220, 60);
            this.ExtraBtn.TabIndex = 5;
            this.ExtraBtn.Text = "Coming Soon...";
            this.ExtraBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExtraBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExtraBtn.UseVisualStyleBackColor = true;
            this.ExtraBtn.Click += new System.EventHandler(this.ExtraBtn_Click);
            // 
            // NewsBtn
            // 
            this.NewsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewsBtn.FlatAppearance.BorderSize = 0;
            this.NewsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.NewsBtn.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.NewsBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.NewsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NewsBtn.IconSize = 32;
            this.NewsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewsBtn.Location = new System.Drawing.Point(0, 320);
            this.NewsBtn.Name = "NewsBtn";
            this.NewsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.NewsBtn.Size = new System.Drawing.Size(220, 60);
            this.NewsBtn.TabIndex = 4;
            this.NewsBtn.Text = "News";
            this.NewsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewsBtn.UseVisualStyleBackColor = true;
            this.NewsBtn.Click += new System.EventHandler(this.NewsBtn_Click);
            // 
            // ChatBtn
            // 
            this.ChatBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatBtn.FlatAppearance.BorderSize = 0;
            this.ChatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ChatBtn.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.ChatBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.ChatBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChatBtn.IconSize = 32;
            this.ChatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChatBtn.Location = new System.Drawing.Point(0, 260);
            this.ChatBtn.Name = "ChatBtn";
            this.ChatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ChatBtn.Size = new System.Drawing.Size(220, 60);
            this.ChatBtn.TabIndex = 3;
            this.ChatBtn.Text = "Chat";
            this.ChatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChatBtn.UseVisualStyleBackColor = true;
            this.ChatBtn.Click += new System.EventHandler(this.ChatBtn_Click);
            // 
            // GamesBtn
            // 
            this.GamesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GamesBtn.FlatAppearance.BorderSize = 0;
            this.GamesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamesBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamesBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.GamesBtn.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.GamesBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.GamesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GamesBtn.IconSize = 32;
            this.GamesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GamesBtn.Location = new System.Drawing.Point(0, 200);
            this.GamesBtn.Name = "GamesBtn";
            this.GamesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.GamesBtn.Size = new System.Drawing.Size(220, 60);
            this.GamesBtn.TabIndex = 2;
            this.GamesBtn.Text = "Games";
            this.GamesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GamesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GamesBtn.UseVisualStyleBackColor = true;
            this.GamesBtn.Click += new System.EventHandler(this.GamesBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.DashboardBtn.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            this.DashboardBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.DashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DashboardBtn.IconSize = 32;
            this.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.Location = new System.Drawing.Point(0, 140);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.DashboardBtn.Size = new System.Drawing.Size(220, 60);
            this.DashboardBtn.TabIndex = 1;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.HomeBtn);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(3, 3);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(214, 134);
            this.HomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelSettings);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(888, 646);
            this.panelMain.TabIndex = 1;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.labelAutoLogonSub);
            this.panelSettings.Controls.Add(this.labelAutoLogon);
            this.panelSettings.Controls.Add(this.AutoLogonBtn);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 75);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(888, 571);
            this.panelSettings.TabIndex = 1;
            // 
            // labelAutoLogonSub
            // 
            this.labelAutoLogonSub.AutoSize = true;
            this.labelAutoLogonSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoLogonSub.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAutoLogonSub.Location = new System.Drawing.Point(20, 47);
            this.labelAutoLogonSub.Name = "labelAutoLogonSub";
            this.labelAutoLogonSub.Size = new System.Drawing.Size(359, 13);
            this.labelAutoLogonSub.TabIndex = 2;
            this.labelAutoLogonSub.Text = "On app startup, logs in automatically instead of manually logging in";
            // 
            // labelAutoLogon
            // 
            this.labelAutoLogon.AutoSize = true;
            this.labelAutoLogon.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoLogon.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAutoLogon.Location = new System.Drawing.Point(18, 22);
            this.labelAutoLogon.Name = "labelAutoLogon";
            this.labelAutoLogon.Size = new System.Drawing.Size(181, 25);
            this.labelAutoLogon.TabIndex = 1;
            this.labelAutoLogon.Text = "Login automatically";
            // 
            // AutoLogonBtn
            // 
            this.AutoLogonBtn.Animated = true;
            this.AutoLogonBtn.AutoRoundedCorners = true;
            this.AutoLogonBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AutoLogonBtn.CheckedState.BorderRadius = 11;
            this.AutoLogonBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AutoLogonBtn.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AutoLogonBtn.CheckedState.InnerBorderRadius = 7;
            this.AutoLogonBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.AutoLogonBtn.CheckedState.Parent = this.AutoLogonBtn;
            this.AutoLogonBtn.Location = new System.Drawing.Point(807, 34);
            this.AutoLogonBtn.Name = "AutoLogonBtn";
            this.AutoLogonBtn.ShadowDecoration.Parent = this.AutoLogonBtn;
            this.AutoLogonBtn.Size = new System.Drawing.Size(45, 25);
            this.AutoLogonBtn.TabIndex = 0;
            this.AutoLogonBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoLogonBtn.UncheckedState.BorderRadius = 11;
            this.AutoLogonBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoLogonBtn.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AutoLogonBtn.UncheckedState.InnerBorderRadius = 7;
            this.AutoLogonBtn.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.AutoLogonBtn.UncheckedState.Parent = this.AutoLogonBtn;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1108, 646);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panelTop.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ExtraBtn;
        private FontAwesome.Sharp.IconButton NewsBtn;
        private FontAwesome.Sharp.IconButton ChatBtn;
        private FontAwesome.Sharp.IconButton GamesBtn;
        private FontAwesome.Sharp.IconButton DashboardBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox HomeBtn;
        private FontAwesome.Sharp.IconButton SettingsBtn;
        private FontAwesome.Sharp.IconButton iconCurrentChildForm;
        private Guna.UI2.WinForms.Guna2ControlBox MainMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox MainExit;
        private System.Windows.Forms.Panel panelSettings;
        private Guna.UI2.WinForms.Guna2ToggleSwitch AutoLogonBtn;
        private System.Windows.Forms.Label labelAutoLogonSub;
        private System.Windows.Forms.Label labelAutoLogon;
    }
}