namespace grocery_shop
{
    partial class purchasef
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
            this.lblpurchase = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnpurchaseback = new System.Windows.Forms.Button();
            this.btnpurchasenext = new System.Windows.Forms.Button();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpurchase
            // 
            this.lblpurchase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblpurchase.AutoSize = true;
            this.lblpurchase.BackColor = System.Drawing.Color.Transparent;
            this.lblpurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpurchase.ForeColor = System.Drawing.Color.Indigo;
            this.lblpurchase.Location = new System.Drawing.Point(73, 57);
            this.lblpurchase.Name = "lblpurchase";
            this.lblpurchase.Size = new System.Drawing.Size(328, 46);
            this.lblpurchase.TabIndex = 0;
            this.lblpurchase.Text = "Purchase Check";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(430, 263);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnpurchaseback
            // 
            this.btnpurchaseback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnpurchaseback.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnpurchaseback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurchaseback.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnpurchaseback.Location = new System.Drawing.Point(81, 394);
            this.btnpurchaseback.Name = "btnpurchaseback";
            this.btnpurchaseback.Size = new System.Drawing.Size(75, 31);
            this.btnpurchaseback.TabIndex = 2;
            this.btnpurchaseback.Text = "Back";
            this.btnpurchaseback.UseVisualStyleBackColor = false;
            this.btnpurchaseback.Click += new System.EventHandler(this.btnpurchaseback_Click);
            // 
            // btnpurchasenext
            // 
            this.btnpurchasenext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnpurchasenext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnpurchasenext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurchasenext.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnpurchasenext.Location = new System.Drawing.Point(777, 394);
            this.btnpurchasenext.Name = "btnpurchasenext";
            this.btnpurchasenext.Size = new System.Drawing.Size(75, 31);
            this.btnpurchasenext.TabIndex = 3;
            this.btnpurchasenext.Text = "Next";
            this.btnpurchasenext.UseVisualStyleBackColor = false;
            this.btnpurchasenext.Click += new System.EventHandler(this.btnpurchasenext_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(541, 106);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 4;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(731, 106);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 5;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroButton1.BackColor = System.Drawing.Color.PowderBlue;
            this.metroButton1.Location = new System.Drawing.Point(661, 195);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Done";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(710, 285);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(587, 285);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Total Sale: ";
            // 
            // purchasef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.tumblr_static_dark_background_simple_black_and_white_liniar_background_hd_1920x10801;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.btnpurchasenext);
            this.Controls.Add(this.btnpurchaseback);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblpurchase);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "purchasef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.Load += new System.EventHandler(this.purchasef_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpurchase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnpurchaseback;
        private System.Windows.Forms.Button btnpurchasenext;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}