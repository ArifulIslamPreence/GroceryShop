namespace grocery_shop
{
    partial class greetingsf
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
            this.lblgreetings = new System.Windows.Forms.Label();
            this.btngreetings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgreetings
            // 
            this.lblgreetings.AutoSize = true;
            this.lblgreetings.BackColor = System.Drawing.Color.Transparent;
            this.lblgreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgreetings.ForeColor = System.Drawing.Color.Indigo;
            this.lblgreetings.Location = new System.Drawing.Point(115, 216);
            this.lblgreetings.Name = "lblgreetings";
            this.lblgreetings.Size = new System.Drawing.Size(685, 63);
            this.lblgreetings.TabIndex = 0;
            this.lblgreetings.Text = "Thank you for shopping by";
            // 
            // btngreetings
            // 
            this.btngreetings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btngreetings.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btngreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngreetings.Location = new System.Drawing.Point(415, 316);
            this.btngreetings.Name = "btngreetings";
            this.btngreetings.Size = new System.Drawing.Size(108, 31);
            this.btngreetings.TabIndex = 1;
            this.btngreetings.Text = "Done";
            this.btngreetings.UseVisualStyleBackColor = false;
            this.btngreetings.Click += new System.EventHandler(this.btngreetings_Click);
            // 
            // greetingsf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.IMG_237187;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.btngreetings);
            this.Controls.Add(this.lblgreetings);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "greetingsf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgreetings;
        private System.Windows.Forms.Button btngreetings;
    }
}