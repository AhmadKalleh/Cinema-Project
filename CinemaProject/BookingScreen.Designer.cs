namespace CinemaProject
{
    partial class BookingScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberOfTicketes = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.cbShowTimes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfTicketes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Ticketes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(55, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price One Ticket :";
            // 
            // NumberOfTicketes
            // 
            this.NumberOfTicketes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NumberOfTicketes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.NumberOfTicketes.BorderRadius = 15;
            this.NumberOfTicketes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberOfTicketes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumberOfTicketes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumberOfTicketes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumberOfTicketes.DisabledState.Parent = this.NumberOfTicketes;
            this.NumberOfTicketes.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.NumberOfTicketes.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.NumberOfTicketes.FillColor = System.Drawing.Color.Gainsboro;
            this.NumberOfTicketes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.NumberOfTicketes.FocusedState.Parent = this.NumberOfTicketes;
            this.NumberOfTicketes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfTicketes.ForeColor = System.Drawing.Color.Black;
            this.NumberOfTicketes.Location = new System.Drawing.Point(401, 114);
            this.NumberOfTicketes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberOfTicketes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumberOfTicketes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfTicketes.Name = "NumberOfTicketes";
            this.NumberOfTicketes.ShadowDecoration.Parent = this.NumberOfTicketes;
            this.NumberOfTicketes.Size = new System.Drawing.Size(106, 43);
            this.NumberOfTicketes.TabIndex = 4;
            this.NumberOfTicketes.TextOffset = new System.Drawing.Point(10, 0);
            this.NumberOfTicketes.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.NumberOfTicketes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfTicketes.ValueChanged += new System.EventHandler(this.NumberOfTicketes_ValueChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.lbPrice.Location = new System.Drawing.Point(378, 193);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(100, 34);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Price ";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.lbTotalPrice.Location = new System.Drawing.Point(287, 277);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(182, 34);
            this.lbTotalPrice.TabIndex = 6;
            this.lbTotalPrice.Text = "Total Price ";
            // 
            // cbShowTimes
            // 
            this.cbShowTimes.Animated = true;
            this.cbShowTimes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbShowTimes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbShowTimes.BorderRadius = 15;
            this.cbShowTimes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbShowTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShowTimes.FillColor = System.Drawing.Color.Gainsboro;
            this.cbShowTimes.FocusedColor = System.Drawing.Color.Empty;
            this.cbShowTimes.FocusedState.Parent = this.cbShowTimes;
            this.cbShowTimes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowTimes.ForeColor = System.Drawing.Color.Black;
            this.cbShowTimes.FormattingEnabled = true;
            this.cbShowTimes.HoverState.Parent = this.cbShowTimes;
            this.cbShowTimes.ItemHeight = 30;
            this.cbShowTimes.ItemsAppearance.Parent = this.cbShowTimes;
            this.cbShowTimes.Location = new System.Drawing.Point(281, 50);
            this.cbShowTimes.Name = "cbShowTimes";
            this.cbShowTimes.ShadowDecoration.Parent = this.cbShowTimes;
            this.cbShowTimes.Size = new System.Drawing.Size(280, 36);
            this.cbShowTimes.TabIndex = 7;
            // 
            // btnOrder
            // 
            this.btnOrder.Animated = true;
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnOrder.BorderRadius = 20;
            this.btnOrder.BorderThickness = 2;
            this.btnOrder.CheckedState.Parent = this.btnOrder;
            this.btnOrder.CustomImages.Parent = this.btnOrder;
            this.btnOrder.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnOrder.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnOrder.HoverState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.Parent = this.btnOrder;
            this.btnOrder.Location = new System.Drawing.Point(599, 341);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.ShadowDecoration.BorderRadius = 21;
            this.btnOrder.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnOrder.ShadowDecoration.Enabled = true;
            this.btnOrder.ShadowDecoration.Parent = this.btnOrder;
            this.btnOrder.Size = new System.Drawing.Size(195, 65);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // BookingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(841, 437);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cbShowTimes);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.NumberOfTicketes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingScreen";
            this.Text = "BookingScreen";
            this.Load += new System.EventHandler(this.BookingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfTicketes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumberOfTicketes;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbTotalPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cbShowTimes;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
    }
}