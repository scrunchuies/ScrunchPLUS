
using System.Drawing;

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
            this.DragControlTop = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this.labelWelcomeSettings = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPFPSettings = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelLimitPFP = new System.Windows.Forms.Label();
            this.UploadPfpBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelDiscordStatusSub = new System.Windows.Forms.Label();
            this.labelDiscordStatus = new System.Windows.Forms.Label();
            this.DiscordStatusBtn = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labelAutoLogonSub = new System.Windows.Forms.Label();
            this.labelAutoLogon = new System.Windows.Forms.Label();
            this.AutoLogonBtn = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labelWelcomeMain = new System.Windows.Forms.Label();
            this.pictureBoxPFPMain = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.DragControlMain = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControlSettings = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPFPSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPFPMain)).BeginInit();
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
            // DragControlTop
            // 
            this.DragControlTop.TargetControl = this.panelTop;
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
            this.iconCurrentChildForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            this.panelMain.Controls.Add(this.labelWelcomeMain);
            this.panelMain.Controls.Add(this.pictureBoxPFPMain);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(888, 646);
            this.panelMain.TabIndex = 1;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.labelWelcomeSettings);
            this.panelSettings.Controls.Add(this.label7);
            this.panelSettings.Controls.Add(this.label6);
            this.panelSettings.Controls.Add(this.label5);
            this.panelSettings.Controls.Add(this.label4);
            this.panelSettings.Controls.Add(this.label3);
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Controls.Add(this.pictureBoxPFPSettings);
            this.panelSettings.Controls.Add(this.labelLimitPFP);
            this.panelSettings.Controls.Add(this.UploadPfpBtn);
            this.panelSettings.Controls.Add(this.labelDiscordStatusSub);
            this.panelSettings.Controls.Add(this.labelDiscordStatus);
            this.panelSettings.Controls.Add(this.DiscordStatusBtn);
            this.panelSettings.Controls.Add(this.labelAutoLogonSub);
            this.panelSettings.Controls.Add(this.labelAutoLogon);
            this.panelSettings.Controls.Add(this.AutoLogonBtn);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 75);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(888, 571);
            this.panelSettings.TabIndex = 1;
            // 
            // labelWelcomeSettings
            // 
            this.labelWelcomeSettings.AutoSize = true;
            this.labelWelcomeSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelWelcomeSettings.Location = new System.Drawing.Point(90, 35);
            this.labelWelcomeSettings.Name = "labelWelcomeSettings";
            this.labelWelcomeSettings.Size = new System.Drawing.Size(174, 30);
            this.labelWelcomeSettings.TabIndex = 20;
            this.labelWelcomeSettings.Text = "Welcome back...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(17, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(17, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(17, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(17, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(17, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(17, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "...";
            // 
            // pictureBoxPFPSettings
            // 
            this.pictureBoxPFPSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPFPSettings.FillColor = System.Drawing.Color.Gray;
            this.pictureBoxPFPSettings.ImageRotate = 0F;
            this.pictureBoxPFPSettings.Location = new System.Drawing.Point(20, 18);
            this.pictureBoxPFPSettings.Name = "pictureBoxPFPSettings";
            this.pictureBoxPFPSettings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxPFPSettings.ShadowDecoration.Parent = this.pictureBoxPFPSettings;
            this.pictureBoxPFPSettings.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxPFPSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPFPSettings.TabIndex = 9;
            this.pictureBoxPFPSettings.TabStop = false;
            this.pictureBoxPFPSettings.UseTransparentBackground = true;
            // 
            // labelLimitPFP
            // 
            this.labelLimitPFP.AutoSize = true;
            this.labelLimitPFP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLimitPFP.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLimitPFP.Location = new System.Drawing.Point(22, 264);
            this.labelLimitPFP.Name = "labelLimitPFP";
            this.labelLimitPFP.Size = new System.Drawing.Size(132, 17);
            this.labelLimitPFP.TabIndex = 8;
            this.labelLimitPFP.Text = "*Image limited to 1MB";
            // 
            // UploadPfpBtn
            // 
            this.UploadPfpBtn.Animated = true;
            this.UploadPfpBtn.BorderRadius = 2;
            this.UploadPfpBtn.CheckedState.Parent = this.UploadPfpBtn;
            this.UploadPfpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadPfpBtn.CustomImages.Parent = this.UploadPfpBtn;
            this.UploadPfpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UploadPfpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UploadPfpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UploadPfpBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UploadPfpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UploadPfpBtn.DisabledState.Parent = this.UploadPfpBtn;
            this.UploadPfpBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(140)))), ((int)(((byte)(244)))));
            this.UploadPfpBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.UploadPfpBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.UploadPfpBtn.ForeColor = System.Drawing.Color.White;
            this.UploadPfpBtn.HoverState.Parent = this.UploadPfpBtn;
            this.UploadPfpBtn.Location = new System.Drawing.Point(20, 224);
            this.UploadPfpBtn.Name = "UploadPfpBtn";
            this.UploadPfpBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.UploadPfpBtn.ShadowDecoration.Parent = this.UploadPfpBtn;
            this.UploadPfpBtn.Size = new System.Drawing.Size(144, 37);
            this.UploadPfpBtn.TabIndex = 6;
            this.UploadPfpBtn.Text = "Upload picture";
            this.UploadPfpBtn.Click += new System.EventHandler(this.UploadPfpBtn_Click);
            // 
            // labelDiscordStatusSub
            // 
            this.labelDiscordStatusSub.AutoSize = true;
            this.labelDiscordStatusSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscordStatusSub.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDiscordStatusSub.Location = new System.Drawing.Point(34, 524);
            this.labelDiscordStatusSub.Name = "labelDiscordStatusSub";
            this.labelDiscordStatusSub.Size = new System.Drawing.Size(434, 13);
            this.labelDiscordStatusSub.TabIndex = 5;
            this.labelDiscordStatusSub.Text = "When app is open, it will display on your discord that you are playing ScrunchPLUS";
            // 
            // labelDiscordStatus
            // 
            this.labelDiscordStatus.AutoSize = true;
            this.labelDiscordStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscordStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDiscordStatus.Location = new System.Drawing.Point(32, 499);
            this.labelDiscordStatus.Name = "labelDiscordStatus";
            this.labelDiscordStatus.Size = new System.Drawing.Size(181, 25);
            this.labelDiscordStatus.TabIndex = 4;
            this.labelDiscordStatus.Text = "Show discord status";
            // 
            // DiscordStatusBtn
            // 
            this.DiscordStatusBtn.Animated = true;
            this.DiscordStatusBtn.AutoRoundedCorners = true;
            this.DiscordStatusBtn.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.DiscordStatusBtn.CheckedState.BorderRadius = 11;
            this.DiscordStatusBtn.CheckedState.FillColor = System.Drawing.Color.Green;
            this.DiscordStatusBtn.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.DiscordStatusBtn.CheckedState.InnerBorderRadius = 7;
            this.DiscordStatusBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DiscordStatusBtn.CheckedState.Parent = this.DiscordStatusBtn;
            this.DiscordStatusBtn.Location = new System.Drawing.Point(821, 511);
            this.DiscordStatusBtn.Name = "DiscordStatusBtn";
            this.DiscordStatusBtn.ShadowDecoration.Parent = this.DiscordStatusBtn;
            this.DiscordStatusBtn.Size = new System.Drawing.Size(45, 25);
            this.DiscordStatusBtn.TabIndex = 3;
            this.DiscordStatusBtn.UncheckedState.BorderColor = System.Drawing.Color.Peru;
            this.DiscordStatusBtn.UncheckedState.BorderRadius = 11;
            this.DiscordStatusBtn.UncheckedState.FillColor = System.Drawing.Color.Peru;
            this.DiscordStatusBtn.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.DiscordStatusBtn.UncheckedState.InnerBorderRadius = 7;
            this.DiscordStatusBtn.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.DiscordStatusBtn.UncheckedState.Parent = this.DiscordStatusBtn;
            this.DiscordStatusBtn.CheckedChanged += new System.EventHandler(this.DiscordStatusBtn_CheckedChanged);
            // 
            // labelAutoLogonSub
            // 
            this.labelAutoLogonSub.AutoSize = true;
            this.labelAutoLogonSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoLogonSub.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAutoLogonSub.Location = new System.Drawing.Point(34, 465);
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
            this.labelAutoLogon.Location = new System.Drawing.Point(32, 440);
            this.labelAutoLogon.Name = "labelAutoLogon";
            this.labelAutoLogon.Size = new System.Drawing.Size(181, 25);
            this.labelAutoLogon.TabIndex = 1;
            this.labelAutoLogon.Text = "Login automatically";
            // 
            // AutoLogonBtn
            // 
            this.AutoLogonBtn.Animated = true;
            this.AutoLogonBtn.AutoRoundedCorners = true;
            this.AutoLogonBtn.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.AutoLogonBtn.CheckedState.BorderRadius = 11;
            this.AutoLogonBtn.CheckedState.FillColor = System.Drawing.Color.Green;
            this.AutoLogonBtn.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AutoLogonBtn.CheckedState.InnerBorderRadius = 7;
            this.AutoLogonBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.AutoLogonBtn.CheckedState.Parent = this.AutoLogonBtn;
            this.AutoLogonBtn.Location = new System.Drawing.Point(821, 452);
            this.AutoLogonBtn.Name = "AutoLogonBtn";
            this.AutoLogonBtn.ShadowDecoration.Parent = this.AutoLogonBtn;
            this.AutoLogonBtn.Size = new System.Drawing.Size(45, 25);
            this.AutoLogonBtn.TabIndex = 0;
            this.AutoLogonBtn.UncheckedState.BorderColor = System.Drawing.Color.Peru;
            this.AutoLogonBtn.UncheckedState.BorderRadius = 11;
            this.AutoLogonBtn.UncheckedState.FillColor = System.Drawing.Color.Peru;
            this.AutoLogonBtn.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AutoLogonBtn.UncheckedState.InnerBorderRadius = 7;
            this.AutoLogonBtn.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.AutoLogonBtn.UncheckedState.Parent = this.AutoLogonBtn;
            this.AutoLogonBtn.CheckedChanged += new System.EventHandler(this.AutoLogonBtn_CheckedChanged);
            // 
            // labelWelcomeMain
            // 
            this.labelWelcomeMain.AutoSize = true;
            this.labelWelcomeMain.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelWelcomeMain.Location = new System.Drawing.Point(90, 110);
            this.labelWelcomeMain.Name = "labelWelcomeMain";
            this.labelWelcomeMain.Size = new System.Drawing.Size(174, 30);
            this.labelWelcomeMain.TabIndex = 22;
            this.labelWelcomeMain.Text = "Welcome back...";
            // 
            // pictureBoxPFPMain
            // 
            this.pictureBoxPFPMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPFPMain.FillColor = System.Drawing.Color.Gray;
            this.pictureBoxPFPMain.ImageRotate = 0F;
            this.pictureBoxPFPMain.Location = new System.Drawing.Point(20, 93);
            this.pictureBoxPFPMain.Name = "pictureBoxPFPMain";
            this.pictureBoxPFPMain.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxPFPMain.ShadowDecoration.Parent = this.pictureBoxPFPMain;
            this.pictureBoxPFPMain.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxPFPMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPFPMain.TabIndex = 21;
            this.pictureBoxPFPMain.TabStop = false;
            this.pictureBoxPFPMain.UseTransparentBackground = true;
            // 
            // DragControlMain
            // 
            this.DragControlMain.TargetControl = this.panelMain;
            // 
            // DragControlSettings
            // 
            this.DragControlSettings.TargetControl = this.panelSettings;
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
            this.panelMain.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPFPSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPFPMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2DragControl DragControlTop;
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
        private System.Windows.Forms.Label labelDiscordStatusSub;
        private System.Windows.Forms.Label labelDiscordStatus;
        private Guna.UI2.WinForms.Guna2ToggleSwitch DiscordStatusBtn;
        private Guna.UI2.WinForms.Guna2DragControl DragControlMain;
        private Guna.UI2.WinForms.Guna2DragControl DragControlSettings;
        private Guna.UI2.WinForms.Guna2GradientButton UploadPfpBtn;
        private System.Windows.Forms.Label labelLimitPFP;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxPFPSettings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWelcomeSettings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelWelcomeMain;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxPFPMain;
    }
}