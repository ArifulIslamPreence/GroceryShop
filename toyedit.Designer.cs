namespace grocery_shop
{
    partial class toyedit
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
            this.lbltoyedit = new System.Windows.Forms.Label();
            this.lbltoynmprc = new System.Windows.Forms.Label();
            this.tbtoyedit = new System.Windows.Forms.TextBox();
            this.btntoydelete = new System.Windows.Forms.Button();
            this.btntoyinsert = new System.Windows.Forms.Button();
            this.btntoyeditback = new System.Windows.Forms.Button();
            this.tbtoyprice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltoyedit
            // 
            this.lbltoyedit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltoyedit.AutoSize = true;
            this.lbltoyedit.BackColor = System.Drawing.Color.Transparent;
            this.lbltoyedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoyedit.ForeColor = System.Drawing.Color.Indigo;
            this.lbltoyedit.Location = new System.Drawing.Point(73, 57);
            this.lbltoyedit.Name = "lbltoyedit";
            this.lbltoyedit.Size = new System.Drawing.Size(420, 46);
            this.lbltoyedit.TabIndex = 0;
            this.lbltoyedit.Text = "Toy item modification";
            // 
            // lbltoynmprc
            // 
            this.lbltoynmprc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltoynmprc.AutoSize = true;
            this.lbltoynmprc.BackColor = System.Drawing.Color.Transparent;
            this.lbltoynmprc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoynmprc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbltoynmprc.Location = new System.Drawing.Point(382, 140);
            this.lbltoynmprc.Name = "lbltoynmprc";
            this.lbltoynmprc.Size = new System.Drawing.Size(165, 25);
            this.lbltoynmprc.TabIndex = 1;
            this.lbltoynmprc.Text = "Name and Price";
            // 
            // tbtoyedit
            // 
            this.tbtoyedit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbtoyedit.BackColor = System.Drawing.Color.PowderBlue;
            this.tbtoyedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtoyedit.Location = new System.Drawing.Point(208, 192);
            this.tbtoyedit.Name = "tbtoyedit";
            this.tbtoyedit.Size = new System.Drawing.Size(213, 30);
            this.tbtoyedit.TabIndex = 2;
            // 
            // btntoydelete
            // 
            this.btntoydelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntoydelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btntoydelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoydelete.Location = new System.Drawing.Point(346, 253);
            this.btntoydelete.Name = "btntoydelete";
            this.btntoydelete.Size = new System.Drawing.Size(75, 34);
            this.btntoydelete.TabIndex = 3;
            this.btntoydelete.Text = "Delete";
            this.btntoydelete.UseVisualStyleBackColor = false;
            this.btntoydelete.Click += new System.EventHandler(this.btntoydelete_Click);
            // 
            // btntoyinsert
            // 
            this.btntoyinsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntoyinsert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btntoyinsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoyinsert.Location = new System.Drawing.Point(507, 253);
            this.btntoyinsert.Name = "btntoyinsert";
            this.btntoyinsert.Size = new System.Drawing.Size(75, 34);
            this.btntoyinsert.TabIndex = 4;
            this.btntoyinsert.Text = "insert";
            this.btntoyinsert.UseVisualStyleBackColor = false;
            this.btntoyinsert.Click += new System.EventHandler(this.btntoyinsert_Click);
            // 
            // btntoyeditback
            // 
            this.btntoyeditback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntoyeditback.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btntoyeditback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoyeditback.Location = new System.Drawing.Point(83, 407);
            this.btntoyeditback.Name = "btntoyeditback";
            this.btntoyeditback.Size = new System.Drawing.Size(75, 28);
            this.btntoyeditback.TabIndex = 5;
            this.btntoyeditback.Text = "Back";
            this.btntoyeditback.UseVisualStyleBackColor = false;
            this.btntoyeditback.Click += new System.EventHandler(this.btntoyeditback_Click);
            // 
            // tbtoyprice
            // 
            this.tbtoyprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbtoyprice.BackColor = System.Drawing.Color.PowderBlue;
            this.tbtoyprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtoyprice.Location = new System.Drawing.Point(507, 192);
            this.tbtoyprice.Name = "tbtoyprice";
            this.tbtoyprice.Size = new System.Drawing.Size(200, 30);
            this.tbtoyprice.TabIndex = 6;
            // 
            // toyedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.wallpaper_2382590;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.tbtoyprice);
            this.Controls.Add(this.btntoyeditback);
            this.Controls.Add(this.btntoyinsert);
            this.Controls.Add(this.btntoydelete);
            this.Controls.Add(this.tbtoyedit);
            this.Controls.Add(this.lbltoynmprc);
            this.Controls.Add(this.lbltoyedit);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "toyedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltoyedit;
        private System.Windows.Forms.Label lbltoynmprc;
        private System.Windows.Forms.TextBox tbtoyedit;
        private System.Windows.Forms.Button btntoydelete;
        private System.Windows.Forms.Button btntoyinsert;
        private System.Windows.Forms.Button btntoyeditback;
        private System.Windows.Forms.TextBox tbtoyprice;
    }
}