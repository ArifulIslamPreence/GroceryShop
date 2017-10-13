namespace grocery_shop
{
    partial class alogin
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
            this.lblalogin = new System.Windows.Forms.Label();
            this.lblaloginnm = new System.Windows.Forms.Label();
            this.lblaloginpass = new System.Windows.Forms.Label();
            this.tbaloginnm = new System.Windows.Forms.TextBox();
            this.tbaloginpass = new System.Windows.Forms.TextBox();
            this.btnalogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblalogin
            // 
            this.lblalogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblalogin.AutoSize = true;
            this.lblalogin.BackColor = System.Drawing.Color.Transparent;
            this.lblalogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalogin.ForeColor = System.Drawing.Color.Indigo;
            this.lblalogin.Location = new System.Drawing.Point(54, 95);
            this.lblalogin.Name = "lblalogin";
            this.lblalogin.Size = new System.Drawing.Size(285, 46);
            this.lblalogin.TabIndex = 0;
            this.lblalogin.Text = "Admin Portion";
            // 
            // lblaloginnm
            // 
            this.lblaloginnm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblaloginnm.AutoSize = true;
            this.lblaloginnm.BackColor = System.Drawing.Color.Transparent;
            this.lblaloginnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaloginnm.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblaloginnm.Location = new System.Drawing.Point(59, 193);
            this.lblaloginnm.Name = "lblaloginnm";
            this.lblaloginnm.Size = new System.Drawing.Size(91, 17);
            this.lblaloginnm.TabIndex = 1;
            this.lblaloginnm.Text = "Username: ";
            // 
            // lblaloginpass
            // 
            this.lblaloginpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblaloginpass.AutoSize = true;
            this.lblaloginpass.BackColor = System.Drawing.Color.Transparent;
            this.lblaloginpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaloginpass.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblaloginpass.Location = new System.Drawing.Point(59, 263);
            this.lblaloginpass.Name = "lblaloginpass";
            this.lblaloginpass.Size = new System.Drawing.Size(87, 17);
            this.lblaloginpass.TabIndex = 2;
            this.lblaloginpass.Text = "Password: ";
            // 
            // tbaloginnm
            // 
            this.tbaloginnm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbaloginnm.BackColor = System.Drawing.Color.PowderBlue;
            this.tbaloginnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaloginnm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbaloginnm.Location = new System.Drawing.Point(156, 187);
            this.tbaloginnm.Name = "tbaloginnm";
            this.tbaloginnm.Size = new System.Drawing.Size(240, 23);
            this.tbaloginnm.TabIndex = 3;
            this.tbaloginnm.TextChanged += new System.EventHandler(this.tbaloginnm_TextChanged);
            // 
            // tbaloginpass
            // 
            this.tbaloginpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbaloginpass.BackColor = System.Drawing.Color.PowderBlue;
            this.tbaloginpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaloginpass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbaloginpass.Location = new System.Drawing.Point(152, 260);
            this.tbaloginpass.Name = "tbaloginpass";
            this.tbaloginpass.Size = new System.Drawing.Size(240, 23);
            this.tbaloginpass.TabIndex = 4;
            this.tbaloginpass.UseSystemPasswordChar = true;
            this.tbaloginpass.TextChanged += new System.EventHandler(this.tbaloginpass_TextChanged);
            // 
            // btnalogin
            // 
            this.btnalogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnalogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnalogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnalogin.Location = new System.Drawing.Point(287, 319);
            this.btnalogin.Name = "btnalogin";
            this.btnalogin.Size = new System.Drawing.Size(91, 34);
            this.btnalogin.TabIndex = 5;
            this.btnalogin.Text = "Sign In";
            this.btnalogin.UseVisualStyleBackColor = false;
            this.btnalogin.Click += new System.EventHandler(this.btnalogin_Click);
            // 
            // alogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.Black_And_White_Abstract_Flowers_Wallpaper_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.btnalogin);
            this.Controls.Add(this.tbaloginpass);
            this.Controls.Add(this.tbaloginnm);
            this.Controls.Add(this.lblaloginpass);
            this.Controls.Add(this.lblaloginnm);
            this.Controls.Add(this.lblalogin);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "alogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblalogin;
        private System.Windows.Forms.Label lblaloginnm;
        private System.Windows.Forms.Label lblaloginpass;
        private System.Windows.Forms.TextBox tbaloginnm;
        private System.Windows.Forms.TextBox tbaloginpass;
        private System.Windows.Forms.Button btnalogin;
    }
}