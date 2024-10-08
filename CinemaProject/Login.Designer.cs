namespace CinemaProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.lbWaitTimer = new System.Windows.Forms.Label();
            this.lbWait2 = new System.Windows.Forms.Label();
            this.lbWait = new System.Windows.Forms.Label();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.txtPasswordLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGoToCreateAccount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtUsernameLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnLogin.BorderRadius = 25;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnLogin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnLogin.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(62, 430);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.BorderRadius = 31;
            this.btnLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(487, 70);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(164, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Forget Username orPassword ?\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(162, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 58);
            this.label5.TabIndex = 16;
            this.label5.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(296, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 58);
            this.label4.TabIndex = 15;
            this.label4.Text = "Login";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel.Controls.Add(this.lbWaitTimer);
            this.Panel.Controls.Add(this.lbWait2);
            this.Panel.Controls.Add(this.lbWait);
            this.Panel.Controls.Add(this.pbEye);
            this.Panel.Controls.Add(this.txtPasswordLogin);
            this.Panel.Controls.Add(this.btnLogin);
            this.Panel.Controls.Add(this.btnGoToCreateAccount);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.txtUsernameLogin);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.Parent = this.Panel;
            this.Panel.Size = new System.Drawing.Size(653, 761);
            this.Panel.TabIndex = 25;
            // 
            // lbWaitTimer
            // 
            this.lbWaitTimer.AutoSize = true;
            this.lbWaitTimer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitTimer.ForeColor = System.Drawing.Color.Black;
            this.lbWaitTimer.Location = new System.Drawing.Point(246, 714);
            this.lbWaitTimer.Name = "lbWaitTimer";
            this.lbWaitTimer.Size = new System.Drawing.Size(32, 23);
            this.lbWaitTimer.TabIndex = 27;
            this.lbWaitTimer.Text = "59";
            this.lbWaitTimer.Visible = false;
            // 
            // lbWait2
            // 
            this.lbWait2.AutoSize = true;
            this.lbWait2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWait2.ForeColor = System.Drawing.Color.Black;
            this.lbWait2.Location = new System.Drawing.Point(275, 714);
            this.lbWait2.Name = "lbWait2";
            this.lbWait2.Size = new System.Drawing.Size(201, 23);
            this.lbWait2.TabIndex = 26;
            this.lbWait2.Text = "Seconds To Try Again";
            this.lbWait2.Visible = false;
            // 
            // lbWait
            // 
            this.lbWait.AutoSize = true;
            this.lbWait.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWait.ForeColor = System.Drawing.Color.Black;
            this.lbWait.Location = new System.Drawing.Point(136, 714);
            this.lbWait.Name = "lbWait";
            this.lbWait.Size = new System.Drawing.Size(121, 23);
            this.lbWait.TabIndex = 25;
            this.lbWait.Text = "Please Wait \r\n";
            this.lbWait.Visible = false;
            // 
            // pbEye
            // 
            this.pbEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEye.Image = global::CinemaProject.Properties.Resources.eye1;
            this.pbEye.Location = new System.Drawing.Point(496, 311);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(33, 38);
            this.pbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEye.TabIndex = 24;
            this.pbEye.TabStop = false;
            this.pbEye.Tag = "Closed";
            this.pbEye.Click += new System.EventHandler(this.pbEye_Click);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Animated = true;
            this.txtPasswordLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPasswordLogin.BorderRadius = 25;
            this.txtPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordLogin.DefaultText = "";
            this.txtPasswordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordLogin.DisabledState.Parent = this.txtPasswordLogin;
            this.txtPasswordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordLogin.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPasswordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPasswordLogin.FocusedState.Parent = this.txtPasswordLogin;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPasswordLogin.HoverState.Parent = this.txtPasswordLogin;
            this.txtPasswordLogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPasswordLogin.IconLeft")));
            this.txtPasswordLogin.IconLeftOffset = new System.Drawing.Point(16, 0);
            this.txtPasswordLogin.IconLeftSize = new System.Drawing.Size(45, 40);
            this.txtPasswordLogin.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtPasswordLogin.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtPasswordLogin.Location = new System.Drawing.Point(62, 290);
            this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '\0';
            this.txtPasswordLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.txtPasswordLogin.PlaceholderText = "Password";
            this.txtPasswordLogin.SelectedText = "";
            this.txtPasswordLogin.ShadowDecoration.BorderRadius = 26;
            this.txtPasswordLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPasswordLogin.ShadowDecoration.Parent = this.txtPasswordLogin;
            this.txtPasswordLogin.Size = new System.Drawing.Size(492, 74);
            this.txtPasswordLogin.TabIndex = 23;
            this.txtPasswordLogin.TextOffset = new System.Drawing.Point(20, 0);
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            // 
            // btnGoToCreateAccount
            // 
            this.btnGoToCreateAccount.Animated = true;
            this.btnGoToCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToCreateAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnGoToCreateAccount.BorderRadius = 24;
            this.btnGoToCreateAccount.BorderThickness = 1;
            this.btnGoToCreateAccount.CheckedState.Parent = this.btnGoToCreateAccount;
            this.btnGoToCreateAccount.CustomImages.Parent = this.btnGoToCreateAccount;
            this.btnGoToCreateAccount.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoToCreateAccount.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnGoToCreateAccount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnGoToCreateAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnGoToCreateAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnGoToCreateAccount.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnGoToCreateAccount.HoverState.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToCreateAccount.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnGoToCreateAccount.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToCreateAccount.HoverState.Image")));
            this.btnGoToCreateAccount.HoverState.Parent = this.btnGoToCreateAccount;
            this.btnGoToCreateAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToCreateAccount.Image")));
            this.btnGoToCreateAccount.ImageOffset = new System.Drawing.Point(80, 0);
            this.btnGoToCreateAccount.Location = new System.Drawing.Point(142, 626);
            this.btnGoToCreateAccount.Name = "btnGoToCreateAccount";
            this.btnGoToCreateAccount.ShadowDecoration.BorderRadius = 28;
            this.btnGoToCreateAccount.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnGoToCreateAccount.ShadowDecoration.Enabled = true;
            this.btnGoToCreateAccount.ShadowDecoration.Parent = this.btnGoToCreateAccount;
            this.btnGoToCreateAccount.Size = new System.Drawing.Size(318, 60);
            this.btnGoToCreateAccount.TabIndex = 21;
            this.btnGoToCreateAccount.Text = "Create Account";
            this.btnGoToCreateAccount.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnGoToCreateAccount.Click += new System.EventHandler(this.btnGoToCreateAccount_Click);
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Animated = true;
            this.txtUsernameLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtUsernameLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtUsernameLogin.BorderRadius = 25;
            this.txtUsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameLogin.DefaultText = "";
            this.txtUsernameLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsernameLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameLogin.DisabledState.Parent = this.txtUsernameLogin;
            this.txtUsernameLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameLogin.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsernameLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtUsernameLogin.FocusedState.Parent = this.txtUsernameLogin;
            this.txtUsernameLogin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameLogin.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtUsernameLogin.HoverState.Parent = this.txtUsernameLogin;
            this.txtUsernameLogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsernameLogin.IconLeft")));
            this.txtUsernameLogin.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtUsernameLogin.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtUsernameLogin.Location = new System.Drawing.Point(62, 162);
            this.txtUsernameLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.PasswordChar = '\0';
            this.txtUsernameLogin.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
            this.txtUsernameLogin.PlaceholderText = "Username";
            this.txtUsernameLogin.SelectedText = "";
            this.txtUsernameLogin.ShadowDecoration.BorderRadius = 26;
            this.txtUsernameLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtUsernameLogin.ShadowDecoration.Parent = this.txtUsernameLogin;
            this.txtUsernameLogin.Size = new System.Drawing.Size(492, 74);
            this.txtUsernameLogin.TabIndex = 17;
            this.txtUsernameLogin.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(653, 761);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2GradientButton btnGoToCreateAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtUsernameLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordLogin;
        private System.Windows.Forms.PictureBox pbEye;
        private Guna.UI2.WinForms.Guna2Panel Panel;
        private System.Windows.Forms.Label lbWaitTimer;
        private System.Windows.Forms.Label lbWait2;
        private System.Windows.Forms.Label lbWait;
        private System.Windows.Forms.Timer timer1;
    }
}