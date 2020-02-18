namespace LaraCroftOsirisTrainer
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCurrentAmmo = new System.Windows.Forms.Label();
            this.chckAmmo = new System.Windows.Forms.CheckBox();
            this.chkHealth = new System.Windows.Forms.CheckBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGems = new System.Windows.Forms.Label();
            this.txtGems = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblCurrentAmmo
            // 
            this.lblCurrentAmmo.AutoSize = true;
            this.lblCurrentAmmo.Location = new System.Drawing.Point(88, 86);
            this.lblCurrentAmmo.Name = "lblCurrentAmmo";
            this.lblCurrentAmmo.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentAmmo.TabIndex = 4;
            this.lblCurrentAmmo.Text = "label1";
            // 
            // chckAmmo
            // 
            this.chckAmmo.AutoSize = true;
            this.chckAmmo.Location = new System.Drawing.Point(22, 86);
            this.chckAmmo.Name = "chckAmmo";
            this.chckAmmo.Size = new System.Drawing.Size(55, 17);
            this.chckAmmo.TabIndex = 5;
            this.chckAmmo.Text = "Ammo";
            this.chckAmmo.UseVisualStyleBackColor = true;
            // 
            // chkHealth
            // 
            this.chkHealth.AutoSize = true;
            this.chkHealth.Location = new System.Drawing.Point(22, 118);
            this.chkHealth.Name = "chkHealth";
            this.chkHealth.Size = new System.Drawing.Size(57, 17);
            this.chkHealth.TabIndex = 7;
            this.chkHealth.Text = "Health";
            this.chkHealth.UseVisualStyleBackColor = true;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(88, 118);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(35, 13);
            this.lblHealth.TabIndex = 6;
            this.lblHealth.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gems";
            // 
            // lblGems
            // 
            this.lblGems.AutoSize = true;
            this.lblGems.Location = new System.Drawing.Point(59, 159);
            this.lblGems.Name = "lblGems";
            this.lblGems.Size = new System.Drawing.Size(35, 13);
            this.lblGems.TabIndex = 9;
            this.lblGems.Text = "label1";
            // 
            // txtGems
            // 
            this.txtGems.Location = new System.Drawing.Point(100, 156);
            this.txtGems.Name = "txtGems";
            this.txtGems.Size = new System.Drawing.Size(43, 20);
            this.txtGems.TabIndex = 10;
            this.txtGems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(151, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 220);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtGems);
            this.Controls.Add(this.lblGems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkHealth);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.chckAmmo);
            this.Controls.Add(this.lblCurrentAmmo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCurrentAmmo;
        private System.Windows.Forms.CheckBox chckAmmo;
        private System.Windows.Forms.CheckBox chkHealth;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGems;
        private System.Windows.Forms.TextBox txtGems;
        private System.Windows.Forms.Button button3;
    }
}

