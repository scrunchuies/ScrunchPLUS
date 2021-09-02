
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
            this.LoginMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LoginExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // LoginMinimize
            // 
            this.LoginMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginMinimize.BorderRadius = 4;
            this.LoginMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.LoginMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.LoginMinimize.HoverState.Parent = this.LoginMinimize;
            this.LoginMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.LoginMinimize.Location = new System.Drawing.Point(1018, 0);
            this.LoginMinimize.Name = "LoginMinimize";
            this.LoginMinimize.ShadowDecoration.Parent = this.LoginMinimize;
            this.LoginMinimize.Size = new System.Drawing.Size(45, 29);
            this.LoginMinimize.TabIndex = 41;
            // 
            // LoginExit
            // 
            this.LoginExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginExit.BorderRadius = 4;
            this.LoginExit.CustomClick = true;
            this.LoginExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.LoginExit.HoverState.Parent = this.LoginExit;
            this.LoginExit.IconColor = System.Drawing.Color.Gainsboro;
            this.LoginExit.Location = new System.Drawing.Point(1063, 0);
            this.LoginExit.Name = "LoginExit";
            this.LoginExit.ShadowDecoration.Parent = this.LoginExit;
            this.LoginExit.Size = new System.Drawing.Size(45, 29);
            this.LoginExit.TabIndex = 40;
            this.LoginExit.Click += new System.EventHandler(this.LoginExit_Click);
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
            this.DragControl.TargetControl = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1108, 646);
            this.Controls.Add(this.LoginMinimize);
            this.Controls.Add(this.LoginExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox LoginMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox LoginExit;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}