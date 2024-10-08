namespace CinemaProject
{
    partial class CommentsScreen
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
            this.txtComment = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSendComment = new Guna.UI2.WinForms.Guna2Button();
            this.CommentsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbNoComments = new System.Windows.Forms.Label();
            this.Comment1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.CommentsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.Animated = true;
            this.txtComment.BackColor = System.Drawing.Color.Transparent;
            this.txtComment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtComment.BorderRadius = 20;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.DefaultText = "";
            this.txtComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.DisabledState.Parent = this.txtComment;
            this.txtComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.txtComment.FocusedState.Parent = this.txtComment;
            this.txtComment.ForeColor = System.Drawing.Color.Black;
            this.txtComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.txtComment.HoverState.Parent = this.txtComment;
            this.txtComment.Location = new System.Drawing.Point(13, 354);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PlaceholderText = "Write a Comment ..";
            this.txtComment.SelectedText = "";
            this.txtComment.ShadowDecoration.BorderRadius = 21;
            this.txtComment.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtComment.ShadowDecoration.Enabled = true;
            this.txtComment.ShadowDecoration.Parent = this.txtComment;
            this.txtComment.Size = new System.Drawing.Size(654, 60);
            this.txtComment.TabIndex = 0;
            this.txtComment.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // btnSendComment
            // 
            this.btnSendComment.Animated = true;
            this.btnSendComment.BackColor = System.Drawing.Color.Transparent;
            this.btnSendComment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnSendComment.BorderRadius = 20;
            this.btnSendComment.BorderThickness = 2;
            this.btnSendComment.CheckedState.Parent = this.btnSendComment;
            this.btnSendComment.CustomImages.Parent = this.btnSendComment;
            this.btnSendComment.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendComment.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnSendComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnSendComment.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnSendComment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnSendComment.HoverState.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendComment.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSendComment.HoverState.Parent = this.btnSendComment;
            this.btnSendComment.Location = new System.Drawing.Point(693, 354);
            this.btnSendComment.Name = "btnSendComment";
            this.btnSendComment.ShadowDecoration.BorderRadius = 21;
            this.btnSendComment.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnSendComment.ShadowDecoration.Enabled = true;
            this.btnSendComment.ShadowDecoration.Parent = this.btnSendComment;
            this.btnSendComment.Size = new System.Drawing.Size(154, 60);
            this.btnSendComment.TabIndex = 4;
            this.btnSendComment.Text = "Send Comment";
            this.btnSendComment.Click += new System.EventHandler(this.btnSendComment_Click);
            // 
            // CommentsPanel
            // 
            this.CommentsPanel.AutoScroll = true;
            this.CommentsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CommentsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.CommentsPanel.BorderRadius = 20;
            this.CommentsPanel.Controls.Add(this.guna2Panel1);
            this.CommentsPanel.Controls.Add(this.lbNoComments);
            this.CommentsPanel.Controls.Add(this.Comment1);
            this.CommentsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CommentsPanel.Location = new System.Drawing.Point(0, 0);
            this.CommentsPanel.Name = "CommentsPanel";
            this.CommentsPanel.ShadowDecoration.Parent = this.CommentsPanel;
            this.CommentsPanel.Size = new System.Drawing.Size(859, 347);
            this.CommentsPanel.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 301);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(859, 46);
            this.guna2Panel1.TabIndex = 7;
            // 
            // lbNoComments
            // 
            this.lbNoComments.AutoSize = true;
            this.lbNoComments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoComments.ForeColor = System.Drawing.Color.Black;
            this.lbNoComments.Location = new System.Drawing.Point(294, 143);
            this.lbNoComments.Name = "lbNoComments";
            this.lbNoComments.Size = new System.Drawing.Size(261, 38);
            this.lbNoComments.TabIndex = 0;
            this.lbNoComments.Text = "No Comments !";
            this.lbNoComments.Visible = false;
            // 
            // Comment1
            // 
            this.Comment1.Animated = true;
            this.Comment1.BackColor = System.Drawing.Color.Transparent;
            this.Comment1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Comment1.BorderRadius = 20;
            this.Comment1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Comment1.DefaultText = "";
            this.Comment1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Comment1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Comment1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Comment1.DisabledState.Parent = this.Comment1;
            this.Comment1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Comment1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Comment1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Comment1.FocusedState.Parent = this.Comment1;
            this.Comment1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment1.ForeColor = System.Drawing.Color.Black;
            this.Comment1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.Comment1.HoverState.Parent = this.Comment1;
            this.Comment1.Location = new System.Drawing.Point(33, 39);
            this.Comment1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Comment1.Multiline = true;
            this.Comment1.Name = "Comment1";
            this.Comment1.PasswordChar = '\0';
            this.Comment1.PlaceholderText = "";
            this.Comment1.ReadOnly = true;
            this.Comment1.SelectedText = "";
            this.Comment1.ShadowDecoration.BorderRadius = 21;
            this.Comment1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.Comment1.ShadowDecoration.Parent = this.Comment1;
            this.Comment1.Size = new System.Drawing.Size(781, 66);
            this.Comment1.TabIndex = 6;
            this.Comment1.TextOffset = new System.Drawing.Point(20, 0);
            this.Comment1.Visible = false;
            // 
            // CommentsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(859, 418);
            this.Controls.Add(this.CommentsPanel);
            this.Controls.Add(this.btnSendComment);
            this.Controls.Add(this.txtComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommentsScreen";
            this.Text = "CommentsScreen";
            this.Load += new System.EventHandler(this.CommentsScreen_Load);
            this.CommentsPanel.ResumeLayout(false);
            this.CommentsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtComment;
        private Guna.UI2.WinForms.Guna2Button btnSendComment;
        private Guna.UI2.WinForms.Guna2Panel CommentsPanel;
        private System.Windows.Forms.Label lbNoComments;
        private Guna.UI2.WinForms.Guna2TextBox Comment1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}