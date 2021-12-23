namespace BtlATBM
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonMaHoa = new System.Windows.Forms.Button();
            this.buttonGiauTin = new System.Windows.Forms.Button();
            this.buttonLayTin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGiaiMa = new System.Windows.Forms.Button();
            this.textBoxBrowse = new System.Windows.Forms.TextBox();
            this.textBoxThongTin = new System.Windows.Forms.TextBox();
            this.textBoxMaHoa = new System.Windows.Forms.TextBox();
            this.textBoxGiaiMa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(148, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(43, 221);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(90, 27);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonMaHoa
            // 
            this.buttonMaHoa.Location = new System.Drawing.Point(43, 302);
            this.buttonMaHoa.Name = "buttonMaHoa";
            this.buttonMaHoa.Size = new System.Drawing.Size(89, 25);
            this.buttonMaHoa.TabIndex = 2;
            this.buttonMaHoa.Text = "Ma Hoa";
            this.buttonMaHoa.UseVisualStyleBackColor = true;
            this.buttonMaHoa.Click += new System.EventHandler(this.buttonMaHoa_Click);
            // 
            // buttonGiauTin
            // 
            this.buttonGiauTin.Location = new System.Drawing.Point(151, 345);
            this.buttonGiauTin.Name = "buttonGiauTin";
            this.buttonGiauTin.Size = new System.Drawing.Size(98, 26);
            this.buttonGiauTin.TabIndex = 3;
            this.buttonGiauTin.Text = "Giau Tin";
            this.buttonGiauTin.UseVisualStyleBackColor = true;
            this.buttonGiauTin.Click += new System.EventHandler(this.buttonGiauTin_Click);
            // 
            // buttonLayTin
            // 
            this.buttonLayTin.Location = new System.Drawing.Point(285, 345);
            this.buttonLayTin.Name = "buttonLayTin";
            this.buttonLayTin.Size = new System.Drawing.Size(107, 25);
            this.buttonLayTin.TabIndex = 4;
            this.buttonLayTin.Text = "Lay Tin";
            this.buttonLayTin.UseVisualStyleBackColor = true;
            this.buttonLayTin.Click += new System.EventHandler(this.buttonLayTin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thong Tin";
            // 
            // buttonGiaiMa
            // 
            this.buttonGiaiMa.Location = new System.Drawing.Point(44, 384);
            this.buttonGiaiMa.Name = "buttonGiaiMa";
            this.buttonGiaiMa.Size = new System.Drawing.Size(89, 23);
            this.buttonGiaiMa.TabIndex = 6;
            this.buttonGiaiMa.Text = "Giai Ma";
            this.buttonGiaiMa.UseVisualStyleBackColor = true;
            this.buttonGiaiMa.Click += new System.EventHandler(this.buttonGiaiMa_Click);
            // 
            // textBoxBrowse
            // 
            this.textBoxBrowse.Location = new System.Drawing.Point(150, 221);
            this.textBoxBrowse.Name = "textBoxBrowse";
            this.textBoxBrowse.Size = new System.Drawing.Size(259, 20);
            this.textBoxBrowse.TabIndex = 7;
            // 
            // textBoxThongTin
            // 
            this.textBoxThongTin.Location = new System.Drawing.Point(151, 261);
            this.textBoxThongTin.Name = "textBoxThongTin";
            this.textBoxThongTin.Size = new System.Drawing.Size(256, 20);
            this.textBoxThongTin.TabIndex = 8;
            // 
            // textBoxMaHoa
            // 
            this.textBoxMaHoa.Location = new System.Drawing.Point(148, 305);
            this.textBoxMaHoa.Name = "textBoxMaHoa";
            this.textBoxMaHoa.Size = new System.Drawing.Size(259, 20);
            this.textBoxMaHoa.TabIndex = 9;
            // 
            // textBoxGiaiMa
            // 
            this.textBoxGiaiMa.Location = new System.Drawing.Point(150, 387);
            this.textBoxGiaiMa.Name = "textBoxGiaiMa";
            this.textBoxGiaiMa.Size = new System.Drawing.Size(258, 20);
            this.textBoxGiaiMa.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.textBoxGiaiMa);
            this.Controls.Add(this.textBoxMaHoa);
            this.Controls.Add(this.textBoxThongTin);
            this.Controls.Add(this.textBoxBrowse);
            this.Controls.Add(this.buttonGiaiMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLayTin);
            this.Controls.Add(this.buttonGiauTin);
            this.Controls.Add(this.buttonMaHoa);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "AES";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonMaHoa;
        private System.Windows.Forms.Button buttonGiauTin;
        private System.Windows.Forms.Button buttonLayTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGiaiMa;
        private System.Windows.Forms.TextBox textBoxBrowse;
        private System.Windows.Forms.TextBox textBoxThongTin;
        private System.Windows.Forms.TextBox textBoxMaHoa;
        private System.Windows.Forms.TextBox textBoxGiaiMa;
    }
}

