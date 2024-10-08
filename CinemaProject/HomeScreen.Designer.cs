namespace CinemaProject
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnTickets = new Guna.UI2.WinForms.Guna2Button();
            this.btnMovies = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelScreen = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 100;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(174, 916);
            this.guna2Panel1.TabIndex = 10;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 30;
            this.guna2Panel2.Controls.Add(this.btnLogout);
            this.guna2Panel2.Controls.Add(this.btnProfile);
            this.guna2Panel2.Controls.Add(this.btnTickets);
            this.guna2Panel2.Controls.Add(this.btnMovies);
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.guna2Panel2.Location = new System.Drawing.Point(29, 35);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(144, 834);
            this.guna2Panel2.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 30;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(33, 630);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(106, 100);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Animated = true;
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnProfile.BorderRadius = 30;
            this.btnProfile.BorderThickness = 1;
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfile.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfile.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.CheckedState.Image")));
            this.btnProfile.CheckedState.Parent = this.btnProfile;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.CustomImages.Parent = this.btnProfile;
            this.btnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.HoverState.Parent = this.btnProfile;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageSize = new System.Drawing.Size(50, 50);
            this.btnProfile.Location = new System.Drawing.Point(35, 452);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.ShadowDecoration.Parent = this.btnProfile;
            this.btnProfile.Size = new System.Drawing.Size(106, 100);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.UseTransparentBackground = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.Animated = true;
            this.btnTickets.BackColor = System.Drawing.Color.Transparent;
            this.btnTickets.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnTickets.BorderRadius = 30;
            this.btnTickets.BorderThickness = 1;
            this.btnTickets.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTickets.CheckedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnTickets.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnTickets.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnTickets.CheckedState.Image")));
            this.btnTickets.CheckedState.Parent = this.btnTickets;
            this.btnTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTickets.CustomImages.Parent = this.btnTickets;
            this.btnTickets.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnTickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTickets.ForeColor = System.Drawing.Color.White;
            this.btnTickets.HoverState.Parent = this.btnTickets;
            this.btnTickets.Image = ((System.Drawing.Image)(resources.GetObject("btnTickets.Image")));
            this.btnTickets.ImageSize = new System.Drawing.Size(50, 50);
            this.btnTickets.Location = new System.Drawing.Point(35, 305);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.ShadowDecoration.Parent = this.btnTickets;
            this.btnTickets.Size = new System.Drawing.Size(106, 100);
            this.btnTickets.TabIndex = 3;
            this.btnTickets.UseTransparentBackground = true;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Animated = true;
            this.btnMovies.BackColor = System.Drawing.Color.Transparent;
            this.btnMovies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnMovies.BorderRadius = 35;
            this.btnMovies.BorderThickness = 1;
            this.btnMovies.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMovies.Checked = true;
            this.btnMovies.CheckedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnMovies.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnMovies.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnMovies.CheckedState.Image")));
            this.btnMovies.CheckedState.Parent = this.btnMovies;
            this.btnMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovies.CustomBorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnMovies.CustomImages.Parent = this.btnMovies;
            this.btnMovies.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnMovies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMovies.ForeColor = System.Drawing.Color.White;
            this.btnMovies.HoverState.Parent = this.btnMovies;
            this.btnMovies.Image = ((System.Drawing.Image)(resources.GetObject("btnMovies.Image")));
            this.btnMovies.ImageSize = new System.Drawing.Size(50, 50);
            this.btnMovies.Location = new System.Drawing.Point(35, 158);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.ShadowDecoration.Parent = this.btnMovies;
            this.btnMovies.Size = new System.Drawing.Size(106, 100);
            this.btnMovies.TabIndex = 0;
            this.btnMovies.UseTransparentBackground = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PanelScreen
            // 
            this.PanelScreen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelScreen.Location = new System.Drawing.Point(174, 0);
            this.PanelScreen.Name = "PanelScreen";
            this.PanelScreen.ShadowDecoration.Parent = this.PanelScreen;
            this.PanelScreen.Size = new System.Drawing.Size(1482, 916);
            this.PanelScreen.TabIndex = 11;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1656, 916);
            this.Controls.Add(this.PanelScreen);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnMovies;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnTickets;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelScreen;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}