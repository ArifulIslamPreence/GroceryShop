namespace grocery_shop
{
    partial class aboutf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutf));
            this.lblaboutus = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.btnaboutok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblaboutus
            // 
            this.lblaboutus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblaboutus.AutoSize = true;
            this.lblaboutus.BackColor = System.Drawing.Color.Transparent;
            this.lblaboutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaboutus.ForeColor = System.Drawing.Color.Indigo;
            this.lblaboutus.Location = new System.Drawing.Point(65, 78);
            this.lblaboutus.Name = "lblaboutus";
            this.lblaboutus.Size = new System.Drawing.Size(193, 46);
            this.lblaboutus.TabIndex = 0;
            this.lblaboutus.Text = "About Us";
            // 
            // lbldescription
            // 
            this.lbldescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldescription.AutoSize = true;
            this.lbldescription.BackColor = System.Drawing.Color.Transparent;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbldescription.Location = new System.Drawing.Point(70, 124);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(726, 323);
            this.lbldescription.TabIndex = 1;
            this.lbldescription.Text = resources.GetString("lbldescription.Text");
            this.lbldescription.Click += new System.EventHandler(this.lbldescription_Click);
            // 
            // btnaboutok
            // 
            this.btnaboutok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnaboutok.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnaboutok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaboutok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnaboutok.Location = new System.Drawing.Point(770, 394);
            this.btnaboutok.Name = "btnaboutok";
            this.btnaboutok.Size = new System.Drawing.Size(82, 31);
            this.btnaboutok.TabIndex = 2;
            this.btnaboutok.Text = "OK!";
            this.btnaboutok.UseVisualStyleBackColor = false;
            this.btnaboutok.Click += new System.EventHandler(this.btnaboutok_Click);
            // 
            // aboutf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources._67842821_black_abstract_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.btnaboutok);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblaboutus);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "aboutf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblaboutus;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Button btnaboutok;
    }
}