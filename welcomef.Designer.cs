using MetroFramework.Controls;

namespace grocery_shop
{
    partial class welcome
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
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnwelcome = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblwelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.Indigo;
            this.lblwelcome.Location = new System.Drawing.Point(239, 109);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(469, 104);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Welcome";
            this.lblwelcome.Click += new System.EventHandler(this.lblwelcome_Click);
            // 
            // btnwelcome
            // 
            this.btnwelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnwelcome.BackColor = System.Drawing.Color.GreenYellow;
            this.btnwelcome.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnwelcome.ForeColor = System.Drawing.Color.Indigo;
            this.btnwelcome.Highlight = true;
            this.btnwelcome.Location = new System.Drawing.Point(383, 267);
            this.btnwelcome.Name = "btnwelcome";
            this.btnwelcome.Size = new System.Drawing.Size(153, 44);
            this.btnwelcome.Style = MetroFramework.MetroColorStyle.Green;
            this.btnwelcome.TabIndex = 1;
            this.btnwelcome.Text = "Enter";
            this.btnwelcome.UseSelectable = true;
            this.btnwelcome.UseStyleColors = true;
            this.btnwelcome.Click += new System.EventHandler(this.btnwelcome_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::grocery_shop.Properties.Resources._347956_abstract_dark_simple_red_736x459;
            this.BackImage = global::grocery_shop.Properties.Resources.IMG_237187__2_;
            this.ClientSize = new System.Drawing.Size(918, 479);
            this.Controls.Add(this.btnwelcome);
            this.Controls.Add(this.lblwelcome);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Do The Shopping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.welcome_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.welcome_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private MetroButton  btnwelcome;
    }
}

