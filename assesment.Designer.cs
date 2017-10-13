namespace grocery_shop
{
    partial class assesment
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
            this.lblassesment = new System.Windows.Forms.Label();
            this.dgassesment = new System.Windows.Forms.DataGridView();
            this.btnassesmentback = new System.Windows.Forms.Button();
            this.btnassesmentnext = new System.Windows.Forms.Button();
            this.lblassesmentprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgassesment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblassesment
            // 
            this.lblassesment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblassesment.AutoSize = true;
            this.lblassesment.BackColor = System.Drawing.Color.Transparent;
            this.lblassesment.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassesment.ForeColor = System.Drawing.Color.Indigo;
            this.lblassesment.Location = new System.Drawing.Point(75, 78);
            this.lblassesment.Name = "lblassesment";
            this.lblassesment.Size = new System.Drawing.Size(306, 46);
            this.lblassesment.TabIndex = 0;
            this.lblassesment.Text = "Full Assesment";
            // 
            // dgassesment
            // 
            this.dgassesment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgassesment.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgassesment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgassesment.Location = new System.Drawing.Point(83, 150);
            this.dgassesment.Name = "dgassesment";
            this.dgassesment.ReadOnly = true;
            this.dgassesment.Size = new System.Drawing.Size(354, 234);
            this.dgassesment.TabIndex = 2;
            this.dgassesment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgassesment_CellContentClick);
            // 
            // btnassesmentback
            // 
            this.btnassesmentback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnassesmentback.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnassesmentback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassesmentback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnassesmentback.Location = new System.Drawing.Point(83, 407);
            this.btnassesmentback.Name = "btnassesmentback";
            this.btnassesmentback.Size = new System.Drawing.Size(75, 28);
            this.btnassesmentback.TabIndex = 3;
            this.btnassesmentback.Text = "Back";
            this.btnassesmentback.UseVisualStyleBackColor = false;
            this.btnassesmentback.Click += new System.EventHandler(this.btnassesmentback_Click);
            // 
            // btnassesmentnext
            // 
            this.btnassesmentnext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnassesmentnext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnassesmentnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassesmentnext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnassesmentnext.Location = new System.Drawing.Point(777, 407);
            this.btnassesmentnext.Name = "btnassesmentnext";
            this.btnassesmentnext.Size = new System.Drawing.Size(75, 28);
            this.btnassesmentnext.TabIndex = 4;
            this.btnassesmentnext.Text = "Next";
            this.btnassesmentnext.UseVisualStyleBackColor = false;
            this.btnassesmentnext.Click += new System.EventHandler(this.btnassesmentnext_Click);
            // 
            // lblassesmentprice
            // 
            this.lblassesmentprice.AutoSize = true;
            this.lblassesmentprice.BackColor = System.Drawing.Color.Transparent;
            this.lblassesmentprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassesmentprice.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblassesmentprice.Location = new System.Drawing.Point(496, 216);
            this.lblassesmentprice.Name = "lblassesmentprice";
            this.lblassesmentprice.Size = new System.Drawing.Size(197, 25);
            this.lblassesmentprice.TabIndex = 5;
            this.lblassesmentprice.Text = "Total Amount (Tk. ) : ";
            this.lblassesmentprice.Click += new System.EventHandler(this.lblassesmentprice_Click);
            // 
            // assesment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.download_dark_simple_fresh_new_wallpaper_full_hd_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.lblassesmentprice);
            this.Controls.Add(this.btnassesmentnext);
            this.Controls.Add(this.btnassesmentback);
            this.Controls.Add(this.dgassesment);
            this.Controls.Add(this.lblassesment);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "assesment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.Load += new System.EventHandler(this.assesment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgassesment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblassesment;
        private System.Windows.Forms.DataGridView dgassesment;
        private System.Windows.Forms.Button btnassesmentback;
        private System.Windows.Forms.Button btnassesmentnext;
        private System.Windows.Forms.Label lblassesmentprice;
    }
}