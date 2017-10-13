namespace grocery_shop
{
    partial class clogin
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
            this.lblclogin = new System.Windows.Forms.Label();
            this.lblcloginnm = new System.Windows.Forms.Label();
            this.lblcloginpass = new System.Windows.Forms.Label();
            this.tbcloginnm = new System.Windows.Forms.TextBox();
            this.tbcloginpass = new System.Windows.Forms.TextBox();
            this.lblcloginsnup = new System.Windows.Forms.LinkLabel();
            this.btnclogin = new System.Windows.Forms.Button();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // lblclogin
            // 
            this.lblclogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblclogin.AutoSize = true;
            this.lblclogin.BackColor = System.Drawing.Color.Transparent;
            this.lblclogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclogin.ForeColor = System.Drawing.Color.Indigo;
            this.lblclogin.Location = new System.Drawing.Point(508, 68);
            this.lblclogin.Name = "lblclogin";
            this.lblclogin.Size = new System.Drawing.Size(348, 46);
            this.lblclogin.TabIndex = 0;
            this.lblclogin.Text = "Customer Portion";
            // 
            // lblcloginnm
            // 
            this.lblcloginnm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcloginnm.AutoSize = true;
            this.lblcloginnm.BackColor = System.Drawing.Color.Transparent;
            this.lblcloginnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcloginnm.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblcloginnm.Location = new System.Drawing.Point(513, 149);
            this.lblcloginnm.Name = "lblcloginnm";
            this.lblcloginnm.Size = new System.Drawing.Size(91, 17);
            this.lblcloginnm.TabIndex = 1;
            this.lblcloginnm.Text = "Username: ";
            // 
            // lblcloginpass
            // 
            this.lblcloginpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcloginpass.AutoSize = true;
            this.lblcloginpass.BackColor = System.Drawing.Color.Transparent;
            this.lblcloginpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcloginpass.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblcloginpass.Location = new System.Drawing.Point(516, 208);
            this.lblcloginpass.Name = "lblcloginpass";
            this.lblcloginpass.Size = new System.Drawing.Size(77, 17);
            this.lblcloginpass.TabIndex = 2;
            this.lblcloginpass.Text = "Password";
            // 
            // tbcloginnm
            // 
            this.tbcloginnm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbcloginnm.BackColor = System.Drawing.Color.PowderBlue;
            this.tbcloginnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcloginnm.Location = new System.Drawing.Point(610, 149);
            this.tbcloginnm.Name = "tbcloginnm";
            this.tbcloginnm.Size = new System.Drawing.Size(243, 23);
            this.tbcloginnm.TabIndex = 3;
            this.tbcloginnm.TextChanged += new System.EventHandler(this.tbcloginnm_TextChanged);
            // 
            // tbcloginpass
            // 
            this.tbcloginpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbcloginpass.BackColor = System.Drawing.Color.PowderBlue;
            this.tbcloginpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcloginpass.Location = new System.Drawing.Point(610, 208);
            this.tbcloginpass.Name = "tbcloginpass";
            this.tbcloginpass.Size = new System.Drawing.Size(243, 23);
            this.tbcloginpass.TabIndex = 4;
            this.tbcloginpass.UseSystemPasswordChar = true;
            this.tbcloginpass.TextChanged += new System.EventHandler(this.tbcloginpass_TextChanged);
            // 
            // lblcloginsnup
            // 
            this.lblcloginsnup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcloginsnup.AutoSize = true;
            this.lblcloginsnup.BackColor = System.Drawing.Color.Transparent;
            this.lblcloginsnup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcloginsnup.LinkColor = System.Drawing.Color.DarkBlue;
            this.lblcloginsnup.Location = new System.Drawing.Point(513, 267);
            this.lblcloginsnup.Name = "lblcloginsnup";
            this.lblcloginsnup.Size = new System.Drawing.Size(234, 17);
            this.lblcloginsnup.TabIndex = 5;
            this.lblcloginsnup.TabStop = true;
            this.lblcloginsnup.Text = "Don\'t have an account yet?Sign Up!";
            this.lblcloginsnup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblcloginsnup_LinkClicked);
            // 
            // btnclogin
            // 
            this.btnclogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnclogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnclogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclogin.Location = new System.Drawing.Point(748, 311);
            this.btnclogin.Name = "btnclogin";
            this.btnclogin.Size = new System.Drawing.Size(87, 34);
            this.btnclogin.TabIndex = 6;
            this.btnclogin.Text = "Sign In";
            this.btnclogin.UseVisualStyleBackColor = false;
            this.btnclogin.Click += new System.EventHandler(this.btnclogin_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLink1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.metroLink1.Location = new System.Drawing.Point(53, 412);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(148, 23);
            this.metroLink1.TabIndex = 8;
            this.metroLink1.Text = "Rules and About Us";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // clogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.Black_And_White_Abstract_Flowers_Wallpaper_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.btnclogin);
            this.Controls.Add(this.lblcloginsnup);
            this.Controls.Add(this.tbcloginpass);
            this.Controls.Add(this.tbcloginnm);
            this.Controls.Add(this.lblcloginpass);
            this.Controls.Add(this.lblcloginnm);
            this.Controls.Add(this.lblclogin);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "clogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblclogin;
        private System.Windows.Forms.Label lblcloginnm;
        private System.Windows.Forms.Label lblcloginpass;
        private System.Windows.Forms.TextBox tbcloginnm;
        private System.Windows.Forms.TextBox tbcloginpass;
        private System.Windows.Forms.LinkLabel lblcloginsnup;
        private System.Windows.Forms.Button btnclogin;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}