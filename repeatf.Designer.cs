namespace grocery_shop
{
    partial class repeatf
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
            this.lblrepeat = new System.Windows.Forms.Label();
            this.btnrepeatyes = new System.Windows.Forms.Button();
            this.btnrepeatno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblrepeat
            // 
            this.lblrepeat.AutoSize = true;
            this.lblrepeat.BackColor = System.Drawing.Color.Transparent;
            this.lblrepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrepeat.ForeColor = System.Drawing.Color.Indigo;
            this.lblrepeat.Location = new System.Drawing.Point(248, 135);
            this.lblrepeat.Name = "lblrepeat";
            this.lblrepeat.Size = new System.Drawing.Size(404, 31);
            this.lblrepeat.TabIndex = 0;
            this.lblrepeat.Text = "Want to perform action again?";
            // 
            // btnrepeatyes
            // 
            this.btnrepeatyes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnrepeatyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrepeatyes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnrepeatyes.Location = new System.Drawing.Point(254, 228);
            this.btnrepeatyes.Name = "btnrepeatyes";
            this.btnrepeatyes.Size = new System.Drawing.Size(115, 33);
            this.btnrepeatyes.TabIndex = 1;
            this.btnrepeatyes.Text = "Yes";
            this.btnrepeatyes.UseVisualStyleBackColor = false;
            this.btnrepeatyes.Click += new System.EventHandler(this.btnrepeatyes_Click);
            // 
            // btnrepeatno
            // 
            this.btnrepeatno.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnrepeatno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrepeatno.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnrepeatno.Location = new System.Drawing.Point(535, 228);
            this.btnrepeatno.Name = "btnrepeatno";
            this.btnrepeatno.Size = new System.Drawing.Size(117, 33);
            this.btnrepeatno.TabIndex = 2;
            this.btnrepeatno.Text = "No";
            this.btnrepeatno.UseVisualStyleBackColor = false;
            this.btnrepeatno.Click += new System.EventHandler(this.btnrepeatno_Click);
            // 
            // repeatf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.background_black_blue_abstract_wallpapers_images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.btnrepeatno);
            this.Controls.Add(this.btnrepeatyes);
            this.Controls.Add(this.lblrepeat);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "repeatf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrepeat;
        private System.Windows.Forms.Button btnrepeatyes;
        private System.Windows.Forms.Button btnrepeatno;
    }
}