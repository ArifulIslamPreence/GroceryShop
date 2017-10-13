namespace grocery_shop
{
    partial class qsnf
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
            this.btnqsna = new System.Windows.Forms.Button();
            this.btnqsnc = new System.Windows.Forms.Button();
            this.lblqsna = new System.Windows.Forms.Label();
            this.lblqsnc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnqsna
            // 
            this.btnqsna.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnqsna.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnqsna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqsna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnqsna.Location = new System.Drawing.Point(174, 186);
            this.btnqsna.Name = "btnqsna";
            this.btnqsna.Size = new System.Drawing.Size(114, 42);
            this.btnqsna.TabIndex = 0;
            this.btnqsna.Text = "Enter";
            this.btnqsna.UseVisualStyleBackColor = false;
            this.btnqsna.Click += new System.EventHandler(this.btnqsna_Click);
            // 
            // btnqsnc
            // 
            this.btnqsnc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnqsnc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnqsnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqsnc.Location = new System.Drawing.Point(615, 186);
            this.btnqsnc.Name = "btnqsnc";
            this.btnqsnc.Size = new System.Drawing.Size(120, 42);
            this.btnqsnc.TabIndex = 1;
            this.btnqsnc.Text = "Enter";
            this.btnqsnc.UseVisualStyleBackColor = false;
            this.btnqsnc.Click += new System.EventHandler(this.btnqsnc_Click);
            // 
            // lblqsna
            // 
            this.lblqsna.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblqsna.AutoSize = true;
            this.lblqsna.BackColor = System.Drawing.Color.Transparent;
            this.lblqsna.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqsna.ForeColor = System.Drawing.Color.Indigo;
            this.lblqsna.Location = new System.Drawing.Point(145, 97);
            this.lblqsna.Name = "lblqsna";
            this.lblqsna.Size = new System.Drawing.Size(196, 31);
            this.lblqsna.TabIndex = 2;
            this.lblqsna.Text = "Admin Portion";
            // 
            // lblqsnc
            // 
            this.lblqsnc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblqsnc.AutoSize = true;
            this.lblqsnc.BackColor = System.Drawing.Color.Transparent;
            this.lblqsnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqsnc.ForeColor = System.Drawing.Color.Indigo;
            this.lblqsnc.Location = new System.Drawing.Point(561, 97);
            this.lblqsnc.Name = "lblqsnc";
            this.lblqsnc.Size = new System.Drawing.Size(241, 31);
            this.lblqsnc.TabIndex = 3;
            this.lblqsnc.Text = "Cusotmer Portion";
            // 
            // qsnf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.Black_And_White_Abstract_Flowers_Wallpaper_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.lblqsnc);
            this.Controls.Add(this.lblqsna);
            this.Controls.Add(this.btnqsnc);
            this.Controls.Add(this.btnqsna);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "qsnf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnqsna;
        private System.Windows.Forms.Button btnqsnc;
        private System.Windows.Forms.Label lblqsna;
        private System.Windows.Forms.Label lblqsnc;
    }
}