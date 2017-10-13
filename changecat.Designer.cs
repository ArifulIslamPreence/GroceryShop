namespace grocery_shop
{
    partial class changecat
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
            this.tbchangecat = new System.Windows.Forms.TextBox();
            this.lblchangecat = new System.Windows.Forms.Label();
            this.btndelcat = new System.Windows.Forms.Button();
            this.btninsertcat = new System.Windows.Forms.Button();
            this.btncatback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbchangecat
            // 
            this.tbchangecat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbchangecat.BackColor = System.Drawing.Color.PowderBlue;
            this.tbchangecat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbchangecat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbchangecat.Location = new System.Drawing.Point(382, 223);
            this.tbchangecat.Name = "tbchangecat";
            this.tbchangecat.Size = new System.Drawing.Size(183, 30);
            this.tbchangecat.TabIndex = 0;
            // 
            // lblchangecat
            // 
            this.lblchangecat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblchangecat.AutoSize = true;
            this.lblchangecat.BackColor = System.Drawing.Color.Transparent;
            this.lblchangecat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchangecat.ForeColor = System.Drawing.Color.Indigo;
            this.lblchangecat.Location = new System.Drawing.Point(340, 149);
            this.lblchangecat.Name = "lblchangecat";
            this.lblchangecat.Size = new System.Drawing.Size(265, 31);
            this.lblchangecat.TabIndex = 1;
            this.lblchangecat.Text = "Enter category name";
            // 
            // btndelcat
            // 
            this.btndelcat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndelcat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btndelcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelcat.Location = new System.Drawing.Point(346, 302);
            this.btndelcat.Name = "btndelcat";
            this.btndelcat.Size = new System.Drawing.Size(75, 33);
            this.btndelcat.TabIndex = 2;
            this.btndelcat.Text = "Delete";
            this.btndelcat.UseVisualStyleBackColor = false;
            this.btndelcat.Click += new System.EventHandler(this.btndelcat_Click);
            // 
            // btninsertcat
            // 
            this.btninsertcat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btninsertcat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btninsertcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertcat.Location = new System.Drawing.Point(513, 302);
            this.btninsertcat.Name = "btninsertcat";
            this.btninsertcat.Size = new System.Drawing.Size(75, 34);
            this.btninsertcat.TabIndex = 3;
            this.btninsertcat.Text = "Insert";
            this.btninsertcat.UseVisualStyleBackColor = false;
            this.btninsertcat.Click += new System.EventHandler(this.btninsertcat_Click);
            // 
            // btncatback
            // 
            this.btncatback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncatback.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btncatback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatback.Location = new System.Drawing.Point(72, 396);
            this.btncatback.Name = "btncatback";
            this.btncatback.Size = new System.Drawing.Size(75, 31);
            this.btncatback.TabIndex = 4;
            this.btncatback.Text = "Back";
            this.btncatback.UseVisualStyleBackColor = false;
            this.btncatback.Click += new System.EventHandler(this.btncatback_Click);
            // 
            // changecat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.black_minimalistic_waves_black_background_wallpaper_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.btncatback);
            this.Controls.Add(this.btninsertcat);
            this.Controls.Add(this.btndelcat);
            this.Controls.Add(this.lblchangecat);
            this.Controls.Add(this.tbchangecat);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "changecat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbchangecat;
        private System.Windows.Forms.Label lblchangecat;
        private System.Windows.Forms.Button btndelcat;
        private System.Windows.Forms.Button btninsertcat;
        private System.Windows.Forms.Button btncatback;
    }
}