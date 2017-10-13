namespace grocery_shop
{
    partial class additionf
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
            this.lbladdition = new System.Windows.Forms.Label();
            this.lbladdmore = new System.Windows.Forms.Label();
            this.btnaddyes = new System.Windows.Forms.Button();
            this.btnaddno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbladdition
            // 
            this.lbladdition.AutoSize = true;
            this.lbladdition.BackColor = System.Drawing.Color.Transparent;
            this.lbladdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdition.ForeColor = System.Drawing.Color.Indigo;
            this.lbladdition.Location = new System.Drawing.Point(73, 99);
            this.lbladdition.Name = "lbladdition";
            this.lbladdition.Size = new System.Drawing.Size(268, 46);
            this.lbladdition.TabIndex = 0;
            this.lbladdition.Text = "New Addition";
            // 
            // lbladdmore
            // 
            this.lbladdmore.AutoSize = true;
            this.lbladdmore.BackColor = System.Drawing.Color.Transparent;
            this.lbladdmore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdmore.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbladdmore.Location = new System.Drawing.Point(76, 207);
            this.lbladdmore.Name = "lbladdmore";
            this.lbladdmore.Size = new System.Drawing.Size(280, 25);
            this.lbladdmore.TabIndex = 1;
            this.lbladdmore.Text = "Do you want to add more item?";
            // 
            // btnaddyes
            // 
            this.btnaddyes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnaddyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddyes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnaddyes.Location = new System.Drawing.Point(81, 289);
            this.btnaddyes.Name = "btnaddyes";
            this.btnaddyes.Size = new System.Drawing.Size(75, 30);
            this.btnaddyes.TabIndex = 2;
            this.btnaddyes.Text = "Yes";
            this.btnaddyes.UseVisualStyleBackColor = false;
            this.btnaddyes.Click += new System.EventHandler(this.btnaddyes_Click);
            // 
            // btnaddno
            // 
            this.btnaddno.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnaddno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddno.Location = new System.Drawing.Point(266, 289);
            this.btnaddno.Name = "btnaddno";
            this.btnaddno.Size = new System.Drawing.Size(75, 30);
            this.btnaddno.TabIndex = 3;
            this.btnaddno.Text = "No";
            this.btnaddno.UseVisualStyleBackColor = false;
            this.btnaddno.Click += new System.EventHandler(this.btnaddno_Click);
            // 
            // additionf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.aWGtP9F;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.btnaddno);
            this.Controls.Add(this.btnaddyes);
            this.Controls.Add(this.lbladdmore);
            this.Controls.Add(this.lbladdition);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "additionf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdition;
        private System.Windows.Forms.Label lbladdmore;
        private System.Windows.Forms.Button btnaddyes;
        private System.Windows.Forms.Button btnaddno;
    }
}