namespace CinemaProject
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.btnCreateAccount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.lbWait = new System.Windows.Forms.Label();
            this.Loading = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.txtCardNumberSignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPINCodeSignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullNameSignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPasswordSignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsernameSignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Animated = true;
            this.btnCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnCreateAccount.BorderRadius = 20;
            this.btnCreateAccount.CheckedState.Parent = this.btnCreateAccount;
            this.btnCreateAccount.CustomImages.Parent = this.btnCreateAccount;
            this.btnCreateAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnCreateAccount.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnCreateAccount.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnCreateAccount.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnCreateAccount.HoverState.Parent = this.btnCreateAccount;
            this.btnCreateAccount.Location = new System.Drawing.Point(76, 608);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.ShadowDecoration.BorderRadius = 21;
            this.btnCreateAccount.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnCreateAccount.ShadowDecoration.Parent = this.btnCreateAccount;
            this.btnCreateAccount.Size = new System.Drawing.Size(477, 59);
            this.btnCreateAccount.TabIndex = 23;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(136, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 58);
            this.label6.TabIndex = 20;
            this.label6.Text = "User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(274, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 58);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sing up";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.Black;
            this.lbLogin.Location = new System.Drawing.Point(474, 704);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(57, 23);
            this.lbLogin.TabIndex = 27;
            this.lbLogin.Text = "Login\r\n";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel.Controls.Add(this.lbWait);
            this.Panel.Controls.Add(this.Loading);
            this.Panel.Controls.Add(this.pbEye);
            this.Panel.Controls.Add(this.lbLogin);
            this.Panel.Controls.Add(this.txtCardNumberSignUp);
            this.Panel.Controls.Add(this.txtPINCodeSignUp);
            this.Panel.Controls.Add(this.txtFullNameSignUp);
            this.Panel.Controls.Add(this.btnCreateAccount);
            this.Panel.Controls.Add(this.txtPasswordSignUp);
            this.Panel.Controls.Add(this.txtUsernameSignUp);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.Parent = this.Panel;
            this.Panel.Size = new System.Drawing.Size(653, 761);
            this.Panel.TabIndex = 29;
            // 
            // lbWait
            // 
            this.lbWait.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWait.ForeColor = System.Drawing.Color.Black;
            this.lbWait.Location = new System.Drawing.Point(54, 176);
            this.lbWait.Name = "lbWait";
            this.lbWait.Size = new System.Drawing.Size(534, 118);
            this.lbWait.TabIndex = 30;
            this.lbWait.Text = "Please Wait Seconds while Preparing                            Your Account";
            this.lbWait.Visible = false;
            // 
            // Loading
            // 
            this.Loading.Animated = true;
            this.Loading.AnimationSpeed = 1F;
            this.Loading.FillThickness = 10;
            this.Loading.Location = new System.Drawing.Point(263, 308);
            this.Loading.Name = "Loading";
            this.Loading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.Loading.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.Loading.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Loading.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Loading.ProgressThickness = 10;
            this.Loading.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Loading.ShadowDecoration.Parent = this.Loading;
            this.Loading.Size = new System.Drawing.Size(95, 84);
            this.Loading.TabIndex = 29;
            this.Loading.Value = 20;
            this.Loading.Visible = false;
            // 
            // pbEye
            // 
            this.pbEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEye.Image = global::CinemaProject.Properties.Resources.eye1;
            this.pbEye.Location = new System.Drawing.Point(499, 230);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(32, 29);
            this.pbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEye.TabIndex = 28;
            this.pbEye.TabStop = false;
            this.pbEye.Tag = "Closed";
            this.pbEye.Click += new System.EventHandler(this.pbEye_Click);
            // 
            // txtCardNumberSignUp
            // 
            this.txtCardNumberSignUp.Animated = true;
            this.txtCardNumberSignUp.BackColor = System.Drawing.Color.Transparent;
            this.txtCardNumberSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtCardNumberSignUp.BorderRadius = 22;
            this.txtCardNumberSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCardNumberSignUp.DefaultText = "";
            this.txtCardNumberSignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCardNumberSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCardNumberSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCardNumberSignUp.DisabledState.Parent = this.txtCardNumberSignUp;
            this.txtCardNumberSignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCardNumberSignUp.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCardNumberSignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtCardNumberSignUp.FocusedState.Parent = this.txtCardNumberSignUp;
            this.txtCardNumberSignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumberSignUp.ForeColor = System.Drawing.Color.Black;
            this.txtCardNumberSignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtCardNumberSignUp.HoverState.Parent = this.txtCardNumberSignUp;
            this.txtCardNumberSignUp.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtCardNumberSignUp.IconLeft")));
            this.txtCardNumberSignUp.IconLeftOffset = new System.Drawing.Point(25, 0);
            this.txtCardNumberSignUp.IconLeftSize = new System.Drawing.Size(35, 30);
            this.txtCardNumberSignUp.Location = new System.Drawing.Point(76, 493);
            this.txtCardNumberSignUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCardNumberSignUp.MaxLength = 19;
            this.txtCardNumberSignUp.Name = "txtCardNumberSignUp";
            this.txtCardNumberSignUp.PasswordChar = '\0';
            this.txtCardNumberSignUp.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.txtCardNumberSignUp.PlaceholderText = "Card ID";
            this.txtCardNumberSignUp.SelectedText = "";
            this.txtCardNumberSignUp.ShadowDecoration.BorderRadius = 26;
            this.txtCardNumberSignUp.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtCardNumberSignUp.ShadowDecoration.Parent = this.txtCardNumberSignUp;
            this.txtCardNumberSignUp.Size = new System.Drawing.Size(474, 60);
            this.txtCardNumberSignUp.TabIndex = 26;
            this.txtCardNumberSignUp.TextOffset = new System.Drawing.Point(23, 0);
            this.txtCardNumberSignUp.TextChanged += new System.EventHandler(this.txtCardNumberSignUp_TextChanged);
            this.txtCardNumberSignUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNumberSignUp_KeyPress);
            // 
            // txtPINCodeSignUp
            // 
            this.txtPINCodeSignUp.Animated = true;
            this.txtPINCodeSignUp.BackColor = System.Drawing.Color.Transparent;
            this.txtPINCodeSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPINCodeSignUp.BorderRadius = 22;
            this.txtPINCodeSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPINCodeSignUp.DefaultText = "";
            this.txtPINCodeSignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPINCodeSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPINCodeSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPINCodeSignUp.DisabledState.Parent = this.txtPINCodeSignUp;
            this.txtPINCodeSignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPINCodeSignUp.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPINCodeSignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPINCodeSignUp.FocusedState.Parent = this.txtPINCodeSignUp;
            this.txtPINCodeSignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPINCodeSignUp.ForeColor = System.Drawing.Color.Black;
            this.txtPINCodeSignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPINCodeSignUp.HoverState.Parent = this.txtPINCodeSignUp;
            this.txtPINCodeSignUp.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPINCodeSignUp.IconLeft")));
            this.txtPINCodeSignUp.IconLeftOffset = new System.Drawing.Point(22, -1);
            this.txtPINCodeSignUp.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtPINCodeSignUp.Location = new System.Drawing.Point(76, 400);
            this.txtPINCodeSignUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPINCodeSignUp.MaxLength = 6;
            this.txtPINCodeSignUp.Name = "txtPINCodeSignUp";
            this.txtPINCodeSignUp.PasswordChar = '\0';
            this.txtPINCodeSignUp.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.txtPINCodeSignUp.PlaceholderText = "PIN Code";
            this.txtPINCodeSignUp.SelectedText = "";
            this.txtPINCodeSignUp.ShadowDecoration.BorderRadius = 26;
            this.txtPINCodeSignUp.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPINCodeSignUp.ShadowDecoration.Parent = this.txtPINCodeSignUp;
            this.txtPINCodeSignUp.Size = new System.Drawing.Size(474, 60);
            this.txtPINCodeSignUp.TabIndex = 25;
            this.txtPINCodeSignUp.TextOffset = new System.Drawing.Point(21, 0);
            this.txtPINCodeSignUp.TextChanged += new System.EventHandler(this.txtPINCodeSignUp_TextChanged);
            this.txtPINCodeSignUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPINCodeSignUp_KeyPress);
            // 
            // txtFullNameSignUp
            // 
            this.txtFullNameSignUp.Animated = true;
            this.txtFullNameSignUp.BackColor = System.Drawing.Color.Transparent;
            this.txtFullNameSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtFullNameSignUp.BorderRadius = 22;
            this.txtFullNameSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullNameSignUp.DefaultText = "";
            this.txtFullNameSignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullNameSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullNameSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullNameSignUp.DisabledState.Parent = this.txtFullNameSignUp;
            this.txtFullNameSignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullNameSignUp.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFullNameSignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtFullNameSignUp.FocusedState.Parent = this.txtFullNameSignUp;
            this.txtFullNameSignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullNameSignUp.ForeColor = System.Drawing.Color.Black;
            this.txtFullNameSignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtFullNameSignUp.HoverState.Parent = this.txtFullNameSignUp;
            this.txtFullNameSignUp.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtFullNameSignUp.IconLeft")));
            this.txtFullNameSignUp.IconLeftOffset = new System.Drawing.Point(22, 4);
            this.txtFullNameSignUp.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txtFullNameSignUp.Location = new System.Drawing.Point(76, 308);
            this.txtFullNameSignUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFullNameSignUp.Name = "txtFullNameSignUp";
            this.txtFullNameSignUp.PasswordChar = '\0';
            this.txtFullNameSignUp.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.txtFullNameSignUp.PlaceholderText = "Full name";
            this.txtFullNameSignUp.SelectedText = "";
            this.txtFullNameSignUp.ShadowDecoration.BorderRadius = 26;
            this.txtFullNameSignUp.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtFullNameSignUp.ShadowDecoration.Parent = this.txtFullNameSignUp;
            this.txtFullNameSignUp.Size = new System.Drawing.Size(474, 60);
            this.txtFullNameSignUp.TabIndex = 24;
            this.txtFullNameSignUp.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.Animated = true;
            this.txtPasswordSignUp.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPasswordSignUp.BorderRadius = 22;
            this.txtPasswordSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordSignUp.DefaultText = "";
            this.txtPasswordSignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordSignUp.DisabledState.Parent = this.txtPasswordSignUp;
            this.txtPasswordSignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordSignUp.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPasswordSignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPasswordSignUp.FocusedState.Parent = this.txtPasswordSignUp;
            this.txtPasswordSignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignUp.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordSignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPasswordSignUp.HoverState.Parent = this.txtPasswordSignUp;
            this.txtPasswordSignUp.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPasswordSignUp.IconLeft")));
            this.txtPasswordSignUp.IconLeftOffset = new System.Drawing.Point(16, 0);
            this.txtPasswordSignUp.IconLeftSize = new System.Drawing.Size(45, 40);
            this.txtPasswordSignUp.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtPasswordSignUp.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtPasswordSignUp.Location = new System.Drawing.Point(76, 214);
            this.txtPasswordSignUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.PasswordChar = '\0';
            this.txtPasswordSignUp.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.txtPasswordSignUp.PlaceholderText = "Password";
            this.txtPasswordSignUp.SelectedText = "";
            this.txtPasswordSignUp.ShadowDecoration.BorderRadius = 26;
            this.txtPasswordSignUp.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtPasswordSignUp.ShadowDecoration.Parent = this.txtPasswordSignUp;
            this.txtPasswordSignUp.Size = new System.Drawing.Size(474, 60);
            this.txtPasswordSignUp.TabIndex = 22;
            this.txtPasswordSignUp.TextOffset = new System.Drawing.Point(20, 0);
            this.txtPasswordSignUp.UseSystemPasswordChar = true;
            // 
            // txtUsernameSignUp
            // 
            this.txtUsernameSignUp.Animated = true;
            this.txtUsernameSignUp.BackColor = System.Drawing.Color.Transparent;
            this.txtUsernameSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtUsernameSignUp.BorderRadius = 22;
            this.txtUsernameSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameSignUp.DefaultText = "";
            this.txtUsernameSignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsernameSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameSignUp.DisabledState.Parent = this.txtUsernameSignUp;
            this.txtUsernameSignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameSignUp.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsernameSignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtUsernameSignUp.FocusedState.Parent = this.txtUsernameSignUp;
            this.txtUsernameSignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignUp.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameSignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtUsernameSignUp.HoverState.Parent = this.txtUsernameSignUp;
            this.txtUsernameSignUp.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsernameSignUp.IconLeft")));
            this.txtUsernameSignUp.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtUsernameSignUp.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtUsernameSignUp.Location = new System.Drawing.Point(76, 122);
            this.txtUsernameSignUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUsernameSignUp.Name = "txtUsernameSignUp";
            this.txtUsernameSignUp.PasswordChar = '\0';
            this.txtUsernameSignUp.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUsernameSignUp.PlaceholderText = "Username";
            this.txtUsernameSignUp.SelectedText = "";
            this.txtUsernameSignUp.ShadowDecoration.BorderRadius = 26;
            this.txtUsernameSignUp.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtUsernameSignUp.ShadowDecoration.Parent = this.txtUsernameSignUp;
            this.txtUsernameSignUp.Size = new System.Drawing.Size(474, 60);
            this.txtUsernameSignUp.TabIndex = 21;
            this.txtUsernameSignUp.TextOffset = new System.Drawing.Point(20, 0);
            this.txtUsernameSignUp.Leave += new System.EventHandler(this.txtUsernameSignUp_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(653, 761);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCardNumberSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtPINCodeSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtFullNameSignUp;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreateAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtUsernameSignUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.PictureBox pbEye;
        private Guna.UI2.WinForms.Guna2Panel Panel;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Loading;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbWait;
    }
}