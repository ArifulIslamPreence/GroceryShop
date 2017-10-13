namespace grocery_shop
{
    partial class toyf
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
            this.lbltoy = new System.Windows.Forms.Label();
            this.lbltoyselect = new System.Windows.Forms.Label();
            this.lbltoyquantity = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.udtoy = new System.Windows.Forms.NumericUpDown();
            this.btntoyback = new System.Windows.Forms.Button();
            this.btntoydone = new System.Windows.Forms.Button();
            this.btntoynext = new System.Windows.Forms.Button();
            this.btntoyclear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbltoyselected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udtoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltoy
            // 
            this.lbltoy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltoy.AutoSize = true;
            this.lbltoy.BackColor = System.Drawing.Color.Transparent;
            this.lbltoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoy.ForeColor = System.Drawing.Color.Indigo;
            this.lbltoy.Location = new System.Drawing.Point(73, 57);
            this.lbltoy.Name = "lbltoy";
            this.lbltoy.Size = new System.Drawing.Size(203, 46);
            this.lbltoy.TabIndex = 0;
            this.lbltoy.Text = "Toy Items";
            // 
            // lbltoyselect
            // 
            this.lbltoyselect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltoyselect.AutoSize = true;
            this.lbltoyselect.BackColor = System.Drawing.Color.Transparent;
            this.lbltoyselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoyselect.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbltoyselect.Location = new System.Drawing.Point(78, 136);
            this.lbltoyselect.Name = "lbltoyselect";
            this.lbltoyselect.Size = new System.Drawing.Size(119, 25);
            this.lbltoyselect.TabIndex = 1;
            this.lbltoyselect.Text = "Select item";
            // 
            // lbltoyquantity
            // 
            this.lbltoyquantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltoyquantity.AutoSize = true;
            this.lbltoyquantity.BackColor = System.Drawing.Color.Transparent;
            this.lbltoyquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoyquantity.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbltoyquantity.Location = new System.Drawing.Point(367, 136);
            this.lbltoyquantity.Name = "lbltoyquantity";
            this.lbltoyquantity.Size = new System.Drawing.Size(93, 25);
            this.lbltoyquantity.TabIndex = 2;
            this.lbltoyquantity.Text = "Quantity";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // udtoy
            // 
            this.udtoy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.udtoy.BackColor = System.Drawing.Color.PowderBlue;
            this.udtoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udtoy.Location = new System.Drawing.Point(359, 201);
            this.udtoy.Name = "udtoy";
            this.udtoy.Size = new System.Drawing.Size(120, 23);
            this.udtoy.TabIndex = 4;
            this.udtoy.ValueChanged += new System.EventHandler(this.udtoy_ValueChanged);
            // 
            // btntoyback
            // 
            this.btntoyback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntoyback.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btntoyback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoyback.Location = new System.Drawing.Point(83, 407);
            this.btntoyback.Name = "btntoyback";
            this.btntoyback.Size = new System.Drawing.Size(75, 27);
            this.btntoyback.TabIndex = 5;
            this.btntoyback.Text = "Back";
            this.btntoyback.UseVisualStyleBackColor = false;
            this.btntoyback.Click += new System.EventHandler(this.btntoyback_Click);
            // 
            // btntoydone
            // 
            this.btntoydone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntoydone.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btntoydone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoydone.Location = new System.Drawing.Point(372, 264);
            this.btntoydone.Name = "btntoydone";
            this.btntoydone.Size = new System.Drawing.Size(75, 30);
            this.btntoydone.TabIndex = 6;
            this.btntoydone.Text = "Add";
            this.btntoydone.UseVisualStyleBackColor = false;
            this.btntoydone.Click += new System.EventHandler(this.btntoydone_Click);
            // 
            // btntoynext
            // 
            this.btntoynext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntoynext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btntoynext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoynext.Location = new System.Drawing.Point(777, 394);
            this.btntoynext.Name = "btntoynext";
            this.btntoynext.Size = new System.Drawing.Size(75, 40);
            this.btntoynext.TabIndex = 7;
            this.btntoynext.Text = "Next";
            this.btntoynext.UseVisualStyleBackColor = false;
            this.btntoynext.Click += new System.EventHandler(this.btntoynext_Click);
            // 
            // btntoyclear
            // 
            this.btntoyclear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntoyclear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btntoyclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoyclear.Location = new System.Drawing.Point(610, 393);
            this.btntoyclear.Name = "btntoyclear";
            this.btntoyclear.Size = new System.Drawing.Size(75, 41);
            this.btntoyclear.TabIndex = 8;
            this.btntoyclear.Text = "Delete";
            this.btntoyclear.UseVisualStyleBackColor = false;
            this.btntoyclear.Click += new System.EventHandler(this.btntoyclear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(616, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 252);
            this.dataGridView1.TabIndex = 9;
            // 
            // lbltoyselected
            // 
            this.lbltoyselected.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltoyselected.AutoSize = true;
            this.lbltoyselected.BackColor = System.Drawing.Color.Transparent;
            this.lbltoyselected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoyselected.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltoyselected.Location = new System.Drawing.Point(679, 86);
            this.lbltoyselected.Name = "lbltoyselected";
            this.lbltoyselected.Size = new System.Drawing.Size(132, 17);
            this.lbltoyselected.TabIndex = 10;
            this.lbltoyselected.Text = "Your selected items";
            // 
            // toyf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources._7688_curve_simplicity;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.lbltoyselected);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntoyclear);
            this.Controls.Add(this.btntoynext);
            this.Controls.Add(this.btntoydone);
            this.Controls.Add(this.btntoyback);
            this.Controls.Add(this.udtoy);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbltoyquantity);
            this.Controls.Add(this.lbltoyselect);
            this.Controls.Add(this.lbltoy);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "toyf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.Load += new System.EventHandler(this.toyf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udtoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltoy;
        private System.Windows.Forms.Label lbltoyselect;
        private System.Windows.Forms.Label lbltoyquantity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown udtoy;
        private System.Windows.Forms.Button btntoyback;
        private System.Windows.Forms.Button btntoydone;
        private System.Windows.Forms.Button btntoynext;
        private System.Windows.Forms.Button btntoyclear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltoyselected;
    }
}