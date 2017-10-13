namespace grocery_shop
{
    partial class editionf
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
            this.lbledition = new System.Windows.Forms.Label();
            this.lbleditionselect = new System.Windows.Forms.Label();
            this.btneditionback = new System.Windows.Forms.Button();
            this.btneditionnext = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbledition
            // 
            this.lbledition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbledition.AutoSize = true;
            this.lbledition.BackColor = System.Drawing.Color.Transparent;
            this.lbledition.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledition.ForeColor = System.Drawing.Color.Indigo;
            this.lbledition.Location = new System.Drawing.Point(73, 57);
            this.lbledition.Name = "lbledition";
            this.lbledition.Size = new System.Drawing.Size(405, 46);
            this.lbledition.TabIndex = 0;
            this.lbledition.Text = "Product Modification";
            // 
            // lbleditionselect
            // 
            this.lbleditionselect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbleditionselect.AutoSize = true;
            this.lbleditionselect.BackColor = System.Drawing.Color.Transparent;
            this.lbleditionselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleditionselect.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbleditionselect.Location = new System.Drawing.Point(361, 127);
            this.lbleditionselect.Name = "lbleditionselect";
            this.lbleditionselect.Size = new System.Drawing.Size(167, 25);
            this.lbleditionselect.TabIndex = 1;
            this.lbleditionselect.Text = "Select Category";
            // 
            // btneditionback
            // 
            this.btneditionback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btneditionback.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btneditionback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditionback.Location = new System.Drawing.Point(83, 394);
            this.btneditionback.Name = "btneditionback";
            this.btneditionback.Size = new System.Drawing.Size(75, 36);
            this.btneditionback.TabIndex = 3;
            this.btneditionback.Text = "Back";
            this.btneditionback.UseVisualStyleBackColor = false;
            this.btneditionback.Click += new System.EventHandler(this.btneditionback_Click);
            // 
            // btneditionnext
            // 
            this.btneditionnext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btneditionnext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btneditionnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditionnext.Location = new System.Drawing.Point(777, 394);
            this.btneditionnext.Name = "btneditionnext";
            this.btneditionnext.Size = new System.Drawing.Size(75, 36);
            this.btneditionnext.TabIndex = 4;
            this.btneditionnext.Text = "Next";
            this.btneditionnext.UseVisualStyleBackColor = false;
            this.btneditionnext.Click += new System.EventHandler(this.btneditionnext_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(332, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 33);
            this.comboBox1.TabIndex = 8;
            // 
            // editionf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.floral_wallpaper_wallpapers_trippy_black_simple_white;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btneditionnext);
            this.Controls.Add(this.btneditionback);
            this.Controls.Add(this.lbleditionselect);
            this.Controls.Add(this.lbledition);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "editionf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.Load += new System.EventHandler(this.editionf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbledition;
        private System.Windows.Forms.Label lbleditionselect;
        private System.Windows.Forms.Button btneditionback;
        private System.Windows.Forms.Button btneditionnext;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}