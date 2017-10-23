namespace we3.tamagotchi
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gelukLabel = new System.Windows.Forms.Label();
            this.hongerLabel = new System.Windows.Forms.Label();
            this.intelligentieLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Naam";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 214);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geluk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Honger:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Intelligentie:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+Spelen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SpeelEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "+Eten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EetEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "+Leren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LeerEvent);
            // 
            // gelukLabel
            // 
            this.gelukLabel.AutoSize = true;
            this.gelukLabel.Location = new System.Drawing.Point(61, 260);
            this.gelukLabel.Name = "gelukLabel";
            this.gelukLabel.Size = new System.Drawing.Size(35, 13);
            this.gelukLabel.TabIndex = 9;
            this.gelukLabel.Text = "label4";
            // 
            // hongerLabel
            // 
            this.hongerLabel.AutoSize = true;
            this.hongerLabel.Location = new System.Drawing.Point(68, 286);
            this.hongerLabel.Name = "hongerLabel";
            this.hongerLabel.Size = new System.Drawing.Size(35, 13);
            this.hongerLabel.TabIndex = 10;
            this.hongerLabel.Text = "label4";
            // 
            // intelligentieLabel
            // 
            this.intelligentieLabel.AutoSize = true;
            this.intelligentieLabel.Location = new System.Drawing.Point(86, 313);
            this.intelligentieLabel.Name = "intelligentieLabel";
            this.intelligentieLabel.Size = new System.Drawing.Size(35, 13);
            this.intelligentieLabel.TabIndex = 11;
            this.intelligentieLabel.Text = "label4";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Launch Time UI";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statusLabel.Location = new System.Drawing.Point(139, 8);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 23);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "label4";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 406);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.intelligentieLabel);
            this.Controls.Add(this.hongerLabel);
            this.Controls.Add(this.gelukLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label gelukLabel;
        private System.Windows.Forms.Label hongerLabel;
        private System.Windows.Forms.Label intelligentieLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label statusLabel;
    }
}

