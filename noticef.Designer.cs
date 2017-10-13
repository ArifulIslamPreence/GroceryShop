namespace grocery_shop
{
    partial class noticef
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
            this.lblnoticeadmin = new System.Windows.Forms.Label();
            this.btnnotice = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnoticeadmin
            // 
            this.lblnoticeadmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnoticeadmin.AutoSize = true;
            this.lblnoticeadmin.BackColor = System.Drawing.Color.Transparent;
            this.lblnoticeadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoticeadmin.ForeColor = System.Drawing.Color.Indigo;
            this.lblnoticeadmin.Location = new System.Drawing.Point(60, 76);
            this.lblnoticeadmin.Name = "lblnoticeadmin";
            this.lblnoticeadmin.Size = new System.Drawing.Size(253, 31);
            this.lblnoticeadmin.TabIndex = 0;
            this.lblnoticeadmin.Text = "Notice from Admin";
            // 
            // btnnotice
            // 
            this.btnnotice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnnotice.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnnotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotice.Location = new System.Drawing.Point(777, 384);
            this.btnnotice.Name = "btnnotice";
            this.btnnotice.Size = new System.Drawing.Size(75, 33);
            this.btnnotice.TabIndex = 2;
            this.btnnotice.Text = "Next";
            this.btnnotice.UseVisualStyleBackColor = false;
            this.btnnotice.Click += new System.EventHandler(this.btnnotice_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(66, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(739, 30);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(85, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "SEE NOTICE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noticef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.Black_Minimal_minimalistic_HD_wallpapers1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnnotice);
            this.Controls.Add(this.lblnoticeadmin);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "noticef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnoticeadmin;
        private System.Windows.Forms.Button btnnotice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}