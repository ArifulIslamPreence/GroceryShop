namespace grocery_shop
{
    partial class adminf
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
            this.gbadmin = new System.Windows.Forms.GroupBox();
            this.rbchangecat = new System.Windows.Forms.RadioButton();
            this.rbcheck = new System.Windows.Forms.RadioButton();
            this.rbedition = new System.Windows.Forms.RadioButton();
            this.lbladmin = new System.Windows.Forms.Label();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnadminback = new System.Windows.Forms.Button();
            this.gbadmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbadmin
            // 
            this.gbadmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbadmin.BackColor = System.Drawing.Color.Transparent;
            this.gbadmin.Controls.Add(this.rbchangecat);
            this.gbadmin.Controls.Add(this.rbcheck);
            this.gbadmin.Controls.Add(this.rbedition);
            this.gbadmin.Location = new System.Drawing.Point(271, 172);
            this.gbadmin.Name = "gbadmin";
            this.gbadmin.Size = new System.Drawing.Size(399, 205);
            this.gbadmin.TabIndex = 0;
            this.gbadmin.TabStop = false;
            this.gbadmin.Enter += new System.EventHandler(this.gbadmin_Enter);
            // 
            // rbchangecat
            // 
            this.rbchangecat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbchangecat.AutoSize = true;
            this.rbchangecat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbchangecat.ForeColor = System.Drawing.Color.DarkBlue;
            this.rbchangecat.Location = new System.Drawing.Point(87, 143);
            this.rbchangecat.Name = "rbchangecat";
            this.rbchangecat.Size = new System.Drawing.Size(239, 35);
            this.rbchangecat.TabIndex = 2;
            this.rbchangecat.TabStop = true;
            this.rbchangecat.Text = "Modify catagory";
            this.rbchangecat.UseVisualStyleBackColor = true;
            // 
            // rbcheck
            // 
            this.rbcheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbcheck.AutoSize = true;
            this.rbcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcheck.ForeColor = System.Drawing.Color.DarkBlue;
            this.rbcheck.Location = new System.Drawing.Point(87, 76);
            this.rbcheck.Name = "rbcheck";
            this.rbcheck.Size = new System.Drawing.Size(246, 35);
            this.rbcheck.TabIndex = 1;
            this.rbcheck.TabStop = true;
            this.rbcheck.Text = "Purchase Check";
            this.rbcheck.UseVisualStyleBackColor = true;
            this.rbcheck.CheckedChanged += new System.EventHandler(this.rbcheck_CheckedChanged);
            // 
            // rbedition
            // 
            this.rbedition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbedition.AutoSize = true;
            this.rbedition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbedition.ForeColor = System.Drawing.Color.DarkBlue;
            this.rbedition.Location = new System.Drawing.Point(87, 9);
            this.rbedition.Name = "rbedition";
            this.rbedition.Size = new System.Drawing.Size(298, 35);
            this.rbedition.TabIndex = 0;
            this.rbedition.TabStop = true;
            this.rbedition.Text = "Product Modification";
            this.rbedition.UseVisualStyleBackColor = true;
            // 
            // lbladmin
            // 
            this.lbladmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbladmin.AutoSize = true;
            this.lbladmin.BackColor = System.Drawing.Color.Transparent;
            this.lbladmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.ForeColor = System.Drawing.Color.Indigo;
            this.lbladmin.Location = new System.Drawing.Point(73, 84);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(257, 46);
            this.lbladmin.TabIndex = 1;
            this.lbladmin.Text = "Admin Panel";
            // 
            // btnadmin
            // 
            this.btnadmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadmin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadmin.Location = new System.Drawing.Point(777, 385);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(75, 41);
            this.btnadmin.TabIndex = 2;
            this.btnadmin.Text = "Next";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnadminback
            // 
            this.btnadminback.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnadminback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadminback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadminback.Location = new System.Drawing.Point(81, 385);
            this.btnadminback.Name = "btnadminback";
            this.btnadminback.Size = new System.Drawing.Size(75, 40);
            this.btnadminback.TabIndex = 3;
            this.btnadminback.Text = "Back";
            this.btnadminback.UseVisualStyleBackColor = false;
            this.btnadminback.Click += new System.EventHandler(this.btnadminback_Click);
            // 
            // adminf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.IMG_319726;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.btnadminback);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.lbladmin);
            this.Controls.Add(this.gbadmin);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "adminf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.gbadmin.ResumeLayout(false);
            this.gbadmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbadmin;
        private System.Windows.Forms.RadioButton rbcheck;
        private System.Windows.Forms.RadioButton rbedition;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnadminback;
        private System.Windows.Forms.RadioButton rbchangecat;
    }
}