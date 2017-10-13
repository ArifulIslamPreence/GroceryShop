namespace grocery_shop
{
    partial class rawitemsf
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
            this.lblraw = new System.Windows.Forms.Label();
            this.lblrawselect = new System.Windows.Forms.Label();
            this.cbraw = new System.Windows.Forms.ComboBox();
            this.lblrawquantity = new System.Windows.Forms.Label();
            this.udraw = new System.Windows.Forms.NumericUpDown();
            this.btnrawback = new System.Windows.Forms.Button();
            this.btnrawdone = new System.Windows.Forms.Button();
            this.btnrawnext = new System.Windows.Forms.Button();
            this.dgraw = new System.Windows.Forms.DataGridView();
            this.btnrawclear = new System.Windows.Forms.Button();
            this.lblrawselected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgraw)).BeginInit();
            this.SuspendLayout();
            // 
            // lblraw
            // 
            this.lblraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblraw.AutoSize = true;
            this.lblraw.BackColor = System.Drawing.Color.Transparent;
            this.lblraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraw.ForeColor = System.Drawing.Color.Indigo;
            this.lblraw.Location = new System.Drawing.Point(73, 81);
            this.lblraw.Name = "lblraw";
            this.lblraw.Size = new System.Drawing.Size(215, 46);
            this.lblraw.TabIndex = 0;
            this.lblraw.Text = "Raw items";
            // 
            // lblrawselect
            // 
            this.lblrawselect.AutoSize = true;
            this.lblrawselect.BackColor = System.Drawing.Color.Transparent;
            this.lblrawselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrawselect.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblrawselect.Location = new System.Drawing.Point(78, 136);
            this.lblrawselect.Name = "lblrawselect";
            this.lblrawselect.Size = new System.Drawing.Size(130, 25);
            this.lblrawselect.TabIndex = 1;
            this.lblrawselect.Text = "Select items";
            // 
            // cbraw
            // 
            this.cbraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbraw.BackColor = System.Drawing.Color.PowderBlue;
            this.cbraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbraw.FormattingEnabled = true;
            this.cbraw.Location = new System.Drawing.Point(83, 197);
            this.cbraw.Name = "cbraw";
            this.cbraw.Size = new System.Drawing.Size(205, 24);
            this.cbraw.TabIndex = 2;
            // 
            // lblrawquantity
            // 
            this.lblrawquantity.AutoSize = true;
            this.lblrawquantity.BackColor = System.Drawing.Color.Transparent;
            this.lblrawquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrawquantity.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblrawquantity.Location = new System.Drawing.Point(367, 136);
            this.lblrawquantity.Name = "lblrawquantity";
            this.lblrawquantity.Size = new System.Drawing.Size(93, 25);
            this.lblrawquantity.TabIndex = 3;
            this.lblrawquantity.Text = "Quantity";
            // 
            // udraw
            // 
            this.udraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.udraw.BackColor = System.Drawing.Color.PowderBlue;
            this.udraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udraw.Location = new System.Drawing.Point(354, 197);
            this.udraw.Name = "udraw";
            this.udraw.Size = new System.Drawing.Size(120, 23);
            this.udraw.TabIndex = 4;
            // 
            // btnrawback
            // 
            this.btnrawback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnrawback.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnrawback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrawback.Location = new System.Drawing.Point(83, 407);
            this.btnrawback.Name = "btnrawback";
            this.btnrawback.Size = new System.Drawing.Size(75, 30);
            this.btnrawback.TabIndex = 5;
            this.btnrawback.Text = "Back";
            this.btnrawback.UseVisualStyleBackColor = false;
            this.btnrawback.Click += new System.EventHandler(this.btnrawback_Click);
            // 
            // btnrawdone
            // 
            this.btnrawdone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnrawdone.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnrawdone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrawdone.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnrawdone.Location = new System.Drawing.Point(372, 264);
            this.btnrawdone.Name = "btnrawdone";
            this.btnrawdone.Size = new System.Drawing.Size(75, 28);
            this.btnrawdone.TabIndex = 6;
            this.btnrawdone.Text = "Add";
            this.btnrawdone.UseVisualStyleBackColor = false;
            this.btnrawdone.Click += new System.EventHandler(this.btnrawdone_Click);
            // 
            // btnrawnext
            // 
            this.btnrawnext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnrawnext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnrawnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrawnext.Location = new System.Drawing.Point(777, 394);
            this.btnrawnext.Name = "btnrawnext";
            this.btnrawnext.Size = new System.Drawing.Size(75, 30);
            this.btnrawnext.TabIndex = 7;
            this.btnrawnext.Text = "Next";
            this.btnrawnext.UseVisualStyleBackColor = false;
            this.btnrawnext.Click += new System.EventHandler(this.btnrawnext_Click_1);
            // 
            // dgraw
            // 
            this.dgraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgraw.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgraw.Location = new System.Drawing.Point(612, 105);
            this.dgraw.Name = "dgraw";
            this.dgraw.ReadOnly = true;
            this.dgraw.Size = new System.Drawing.Size(240, 263);
            this.dgraw.TabIndex = 8;
            this.dgraw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgraw_CellContentClick);
            // 
            // btnrawclear
            // 
            this.btnrawclear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnrawclear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnrawclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrawclear.Location = new System.Drawing.Point(612, 393);
            this.btnrawclear.Name = "btnrawclear";
            this.btnrawclear.Size = new System.Drawing.Size(75, 31);
            this.btnrawclear.TabIndex = 9;
            this.btnrawclear.Text = "Delete";
            this.btnrawclear.UseVisualStyleBackColor = false;
            this.btnrawclear.Click += new System.EventHandler(this.btnrawclear_Click_1);
            // 
            // lblrawselected
            // 
            this.lblrawselected.AutoSize = true;
            this.lblrawselected.BackColor = System.Drawing.Color.Transparent;
            this.lblrawselected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrawselected.Location = new System.Drawing.Point(666, 81);
            this.lblrawselected.Name = "lblrawselected";
            this.lblrawselected.Size = new System.Drawing.Size(132, 17);
            this.lblrawselected.TabIndex = 10;
            this.lblrawselected.Text = "Your selected items";
            // 
            // rawitemsf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.Batman_Rise_Minimal_Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.lblrawselected);
            this.Controls.Add(this.btnrawclear);
            this.Controls.Add(this.dgraw);
            this.Controls.Add(this.btnrawnext);
            this.Controls.Add(this.btnrawdone);
            this.Controls.Add(this.btnrawback);
            this.Controls.Add(this.udraw);
            this.Controls.Add(this.lblrawquantity);
            this.Controls.Add(this.cbraw);
            this.Controls.Add(this.lblrawselect);
            this.Controls.Add(this.lblraw);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "rawitemsf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.Load += new System.EventHandler(this.rawitemsf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblraw;
        private System.Windows.Forms.Label lblrawselect;
        private System.Windows.Forms.ComboBox cbraw;
        private System.Windows.Forms.Label lblrawquantity;
        private System.Windows.Forms.NumericUpDown udraw;
        private System.Windows.Forms.Button btnrawback;
        private System.Windows.Forms.Button btnrawdone;
        private System.Windows.Forms.Button btnrawnext;
        private System.Windows.Forms.DataGridView dgraw;
        private System.Windows.Forms.Button btnrawclear;
        private System.Windows.Forms.Label lblrawselected;
    }
}