namespace grocery_shop
{
    partial class action2f
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
            this.lblaction2 = new System.Windows.Forms.Label();
            this.lblaction2msg = new System.Windows.Forms.Label();
            this.btnaction2send = new System.Windows.Forms.Button();
            this.btnaction2done = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblaction2
            // 
            this.lblaction2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblaction2.AutoSize = true;
            this.lblaction2.BackColor = System.Drawing.Color.Transparent;
            this.lblaction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaction2.ForeColor = System.Drawing.Color.Indigo;
            this.lblaction2.Location = new System.Drawing.Point(69, 88);
            this.lblaction2.Name = "lblaction2";
            this.lblaction2.Size = new System.Drawing.Size(139, 46);
            this.lblaction2.TabIndex = 0;
            this.lblaction2.Text = "Action";
            // 
            // lblaction2msg
            // 
            this.lblaction2msg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblaction2msg.AutoSize = true;
            this.lblaction2msg.BackColor = System.Drawing.Color.Transparent;
            this.lblaction2msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaction2msg.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblaction2msg.Location = new System.Drawing.Point(76, 169);
            this.lblaction2msg.Name = "lblaction2msg";
            this.lblaction2msg.Size = new System.Drawing.Size(132, 25);
            this.lblaction2msg.TabIndex = 4;
            this.lblaction2msg.Text = "Message Box";
            // 
            // btnaction2send
            // 
            this.btnaction2send.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnaction2send.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnaction2send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaction2send.Location = new System.Drawing.Point(83, 407);
            this.btnaction2send.Name = "btnaction2send";
            this.btnaction2send.Size = new System.Drawing.Size(75, 30);
            this.btnaction2send.TabIndex = 5;
            this.btnaction2send.Text = "Send";
            this.btnaction2send.UseVisualStyleBackColor = false;
            this.btnaction2send.Click += new System.EventHandler(this.btnaction2send_Click);
            // 
            // btnaction2done
            // 
            this.btnaction2done.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnaction2done.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnaction2done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaction2done.Location = new System.Drawing.Point(775, 407);
            this.btnaction2done.Name = "btnaction2done";
            this.btnaction2done.Size = new System.Drawing.Size(75, 30);
            this.btnaction2done.TabIndex = 6;
            this.btnaction2done.Text = "Done";
            this.btnaction2done.UseVisualStyleBackColor = false;
            this.btnaction2done.Click += new System.EventHandler(this.btnaction2done_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.PowderBlue;
            this.textBox1.Location = new System.Drawing.Point(81, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(767, 30);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // action2f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources.Black_and_White_Wallpaper_Designs_Background_Download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnaction2done);
            this.Controls.Add(this.btnaction2send);
            this.Controls.Add(this.lblaction2msg);
            this.Controls.Add(this.lblaction2);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "action2f";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblaction2;
        private System.Windows.Forms.Label lblaction2msg;
        private System.Windows.Forms.Button btnaction2send;
        private System.Windows.Forms.Button btnaction2done;
        private System.Windows.Forms.TextBox textBox1;
    }
}