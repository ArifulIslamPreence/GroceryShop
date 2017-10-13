namespace grocery_shop
{
    partial class F
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
            this.btncategory = new System.Windows.Forms.Button();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblselectcategory = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btncategory
            // 
            this.btncategory.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btncategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategory.Location = new System.Drawing.Point(777, 383);
            this.btncategory.Name = "btncategory";
            this.btncategory.Size = new System.Drawing.Size(75, 34);
            this.btncategory.TabIndex = 0;
            this.btncategory.Text = "Next";
            this.btncategory.UseVisualStyleBackColor = false;
            this.btncategory.Click += new System.EventHandler(this.btncategory_Click);
            // 
            // lblcategory
            // 
            this.lblcategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcategory.AutoSize = true;
            this.lblcategory.BackColor = System.Drawing.Color.Transparent;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.ForeColor = System.Drawing.Color.Indigo;
            this.lblcategory.Location = new System.Drawing.Point(64, 89);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(416, 46);
            this.lblcategory.TabIndex = 1;
            this.lblcategory.Text = "Welcome to the shop";
            // 
            // lblselectcategory
            // 
            this.lblselectcategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblselectcategory.AutoSize = true;
            this.lblselectcategory.BackColor = System.Drawing.Color.Transparent;
            this.lblselectcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectcategory.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblselectcategory.Location = new System.Drawing.Point(66, 158);
            this.lblselectcategory.Name = "lblselectcategory";
            this.lblselectcategory.Size = new System.Drawing.Size(223, 31);
            this.lblselectcategory.TabIndex = 2;
            this.lblselectcategory.Text = "Select Category";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 272);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 33);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.simple_elegant_widescreen_hd_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblselectcategory);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.btncategory);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "F";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncategory;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblselectcategory;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}