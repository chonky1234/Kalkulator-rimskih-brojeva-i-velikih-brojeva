
namespace WindowsFormsApp1
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
            this.txtBroj1 = new System.Windows.Forms.TextBox();
            this.txtBroj2 = new System.Windows.Forms.TextBox();
            this.lblResenje = new System.Windows.Forms.Label();
            this.btSabiranje = new System.Windows.Forms.Button();
            this.btOduzimanje = new System.Windows.Forms.Button();
            this.btDeljenje = new System.Windows.Forms.Button();
            this.btMnozenje = new System.Windows.Forms.Button();
            this.brMinus = new System.Windows.Forms.Button();
            this.brPuta = new System.Windows.Forms.Button();
            this.brDeljenje = new System.Windows.Forms.Button();
            this.brPlus = new System.Windows.Forms.Button();
            this.lblRimski = new System.Windows.Forms.Label();
            this.txtRimski2 = new System.Windows.Forms.TextBox();
            this.txtRimski1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBroj1
            // 
            this.txtBroj1.Location = new System.Drawing.Point(64, 58);
            this.txtBroj1.Margin = new System.Windows.Forms.Padding(4);
            this.txtBroj1.Name = "txtBroj1";
            this.txtBroj1.Size = new System.Drawing.Size(244, 22);
            this.txtBroj1.TabIndex = 0;
            // 
            // txtBroj2
            // 
            this.txtBroj2.Location = new System.Drawing.Point(64, 141);
            this.txtBroj2.Margin = new System.Windows.Forms.Padding(4);
            this.txtBroj2.Name = "txtBroj2";
            this.txtBroj2.Size = new System.Drawing.Size(244, 22);
            this.txtBroj2.TabIndex = 1;
            // 
            // lblResenje
            // 
            this.lblResenje.Location = new System.Drawing.Point(61, 230);
            this.lblResenje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResenje.Name = "lblResenje";
            this.lblResenje.Size = new System.Drawing.Size(337, 28);
            this.lblResenje.TabIndex = 2;
            this.lblResenje.Text = "label1";
            // 
            // btSabiranje
            // 
            this.btSabiranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSabiranje.Location = new System.Drawing.Point(425, 41);
            this.btSabiranje.Margin = new System.Windows.Forms.Padding(4);
            this.btSabiranje.Name = "btSabiranje";
            this.btSabiranje.Size = new System.Drawing.Size(125, 92);
            this.btSabiranje.TabIndex = 3;
            this.btSabiranje.Text = "+";
            this.btSabiranje.UseVisualStyleBackColor = true;
            this.btSabiranje.Click += new System.EventHandler(this.btSabiranje_Click);
            // 
            // btOduzimanje
            // 
            this.btOduzimanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOduzimanje.Location = new System.Drawing.Point(425, 166);
            this.btOduzimanje.Margin = new System.Windows.Forms.Padding(4);
            this.btOduzimanje.Name = "btOduzimanje";
            this.btOduzimanje.Size = new System.Drawing.Size(125, 92);
            this.btOduzimanje.TabIndex = 4;
            this.btOduzimanje.Text = "-";
            this.btOduzimanje.UseVisualStyleBackColor = true;
            this.btOduzimanje.Click += new System.EventHandler(this.btOduzimanje_Click);
            // 
            // btDeljenje
            // 
            this.btDeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeljenje.Location = new System.Drawing.Point(576, 166);
            this.btDeljenje.Margin = new System.Windows.Forms.Padding(4);
            this.btDeljenje.Name = "btDeljenje";
            this.btDeljenje.Size = new System.Drawing.Size(125, 92);
            this.btDeljenje.TabIndex = 5;
            this.btDeljenje.Text = "/";
            this.btDeljenje.UseVisualStyleBackColor = true;
            this.btDeljenje.Click += new System.EventHandler(this.btDeljenje_Click);
            // 
            // btMnozenje
            // 
            this.btMnozenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMnozenje.Location = new System.Drawing.Point(576, 41);
            this.btMnozenje.Margin = new System.Windows.Forms.Padding(4);
            this.btMnozenje.Name = "btMnozenje";
            this.btMnozenje.Size = new System.Drawing.Size(125, 92);
            this.btMnozenje.TabIndex = 6;
            this.btMnozenje.Text = "*";
            this.btMnozenje.UseVisualStyleBackColor = true;
            this.btMnozenje.Click += new System.EventHandler(this.btMnozenje_Click);
            // 
            // brMinus
            // 
            this.brMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.brMinus.Location = new System.Drawing.Point(1238, 41);
            this.brMinus.Name = "brMinus";
            this.brMinus.Size = new System.Drawing.Size(125, 92);
            this.brMinus.TabIndex = 13;
            this.brMinus.Text = "-";
            this.brMinus.UseVisualStyleBackColor = true;
            this.brMinus.Click += new System.EventHandler(this.brMinus_Click);
            // 
            // brPuta
            // 
            this.brPuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.brPuta.Location = new System.Drawing.Point(1238, 166);
            this.brPuta.Name = "brPuta";
            this.brPuta.Size = new System.Drawing.Size(125, 92);
            this.brPuta.TabIndex = 12;
            this.brPuta.Text = "*";
            this.brPuta.UseVisualStyleBackColor = true;
            this.brPuta.Click += new System.EventHandler(this.brPuta_Click);
            // 
            // brDeljenje
            // 
            this.brDeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.brDeljenje.Location = new System.Drawing.Point(1070, 166);
            this.brDeljenje.Name = "brDeljenje";
            this.brDeljenje.Size = new System.Drawing.Size(125, 92);
            this.brDeljenje.TabIndex = 11;
            this.brDeljenje.Text = "/";
            this.brDeljenje.UseVisualStyleBackColor = true;
            this.brDeljenje.Click += new System.EventHandler(this.brDeljenje_Click);
            // 
            // brPlus
            // 
            this.brPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.brPlus.Location = new System.Drawing.Point(1070, 41);
            this.brPlus.Name = "brPlus";
            this.brPlus.Size = new System.Drawing.Size(125, 92);
            this.brPlus.TabIndex = 10;
            this.brPlus.Text = "+";
            this.brPlus.UseVisualStyleBackColor = true;
            this.brPlus.Click += new System.EventHandler(this.brPlus_Click);
            // 
            // lblRimski
            // 
            this.lblRimski.Location = new System.Drawing.Point(832, 230);
            this.lblRimski.Name = "lblRimski";
            this.lblRimski.Size = new System.Drawing.Size(232, 36);
            this.lblRimski.TabIndex = 9;
            this.lblRimski.Text = "Resenje";
            this.lblRimski.Click += new System.EventHandler(this.lblRimski_Click);
            // 
            // txtRimski2
            // 
            this.txtRimski2.Location = new System.Drawing.Point(835, 141);
            this.txtRimski2.Name = "txtRimski2";
            this.txtRimski2.Size = new System.Drawing.Size(148, 22);
            this.txtRimski2.TabIndex = 8;
            this.txtRimski2.TextChanged += new System.EventHandler(this.txtRimski2_TextChanged);
            // 
            // txtRimski1
            // 
            this.txtRimski1.Location = new System.Drawing.Point(835, 58);
            this.txtRimski1.Name = "txtRimski1";
            this.txtRimski1.Size = new System.Drawing.Size(148, 22);
            this.txtRimski1.TabIndex = 7;
            this.txtRimski1.TextChanged += new System.EventHandler(this.txtRimski1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._2024_03_07_14_53_36_roman_empire_phone_wallpaper___Google_Search;
            this.pictureBox1.Location = new System.Drawing.Point(785, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(822, 793);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.maxresdefault;
            this.pictureBox2.Location = new System.Drawing.Point(-7, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(793, 793);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 790);
            this.Controls.Add(this.brMinus);
            this.Controls.Add(this.brPuta);
            this.Controls.Add(this.brDeljenje);
            this.Controls.Add(this.brPlus);
            this.Controls.Add(this.lblRimski);
            this.Controls.Add(this.txtRimski2);
            this.Controls.Add(this.txtRimski1);
            this.Controls.Add(this.btMnozenje);
            this.Controls.Add(this.btDeljenje);
            this.Controls.Add(this.btOduzimanje);
            this.Controls.Add(this.btSabiranje);
            this.Controls.Add(this.lblResenje);
            this.Controls.Add(this.txtBroj2);
            this.Controls.Add(this.txtBroj1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBroj1;
        private System.Windows.Forms.TextBox txtBroj2;
        private System.Windows.Forms.Label lblResenje;
        private System.Windows.Forms.Button btSabiranje;
        private System.Windows.Forms.Button btOduzimanje;
        private System.Windows.Forms.Button btDeljenje;
        private System.Windows.Forms.Button btMnozenje;
        private System.Windows.Forms.Button brMinus;
        private System.Windows.Forms.Button brPuta;
        private System.Windows.Forms.Button brDeljenje;
        private System.Windows.Forms.Button brPlus;
        private System.Windows.Forms.Label lblRimski;
        private System.Windows.Forms.TextBox txtRimski2;
        private System.Windows.Forms.TextBox txtRimski1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

