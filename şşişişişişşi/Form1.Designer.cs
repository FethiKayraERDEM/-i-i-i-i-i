namespace şşişişişişşi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.Btna = new System.Windows.Forms.RadioButton();
            this.BtnC = new System.Windows.Forms.RadioButton();
            this.BtnB = new System.Windows.Forms.RadioButton();
            this.BtnD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lblsoruno = new System.Windows.Forms.Label();
            this.Lbldogru = new System.Windows.Forms.Label();
            this.Lblyanlis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(332, 158);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(111, 64);
            this.BtnSonraki.TabIndex = 1;
            this.BtnSonraki.Text = "Sonraki";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // Btna
            // 
            this.Btna.AutoSize = true;
            this.Btna.Location = new System.Drawing.Point(21, 169);
            this.Btna.Name = "Btna";
            this.Btna.Size = new System.Drawing.Size(32, 17);
            this.Btna.TabIndex = 2;
            this.Btna.TabStop = true;
            this.Btna.Text = "A";
            this.Btna.UseVisualStyleBackColor = true;
            this.Btna.CheckedChanged += new System.EventHandler(this.Btna_CheckedChanged);
            // 
            // BtnC
            // 
            this.BtnC.AutoSize = true;
            this.BtnC.Location = new System.Drawing.Point(21, 216);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(32, 17);
            this.BtnC.TabIndex = 3;
            this.BtnC.TabStop = true;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.CheckedChanged += new System.EventHandler(this.BtnC_CheckedChanged);
            // 
            // BtnB
            // 
            this.BtnB.AutoSize = true;
            this.BtnB.Location = new System.Drawing.Point(213, 169);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(32, 17);
            this.BtnB.TabIndex = 4;
            this.BtnB.TabStop = true;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.CheckedChanged += new System.EventHandler(this.BtnB_CheckedChanged);
            // 
            // BtnD
            // 
            this.BtnD.AutoSize = true;
            this.BtnD.Location = new System.Drawing.Point(213, 216);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(33, 17);
            this.BtnD.TabIndex = 5;
            this.BtnD.TabStop = true;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.CheckedChanged += new System.EventHandler(this.BtnD_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SoruNo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yanlış:";
            // 
            // Lblsoruno
            // 
            this.Lblsoruno.AutoSize = true;
            this.Lblsoruno.Location = new System.Drawing.Point(403, 54);
            this.Lblsoruno.Name = "Lblsoruno";
            this.Lblsoruno.Size = new System.Drawing.Size(13, 13);
            this.Lblsoruno.TabIndex = 8;
            this.Lblsoruno.Text = "0";
            // 
            // Lbldogru
            // 
            this.Lbldogru.AutoSize = true;
            this.Lbldogru.Location = new System.Drawing.Point(403, 90);
            this.Lbldogru.Name = "Lbldogru";
            this.Lbldogru.Size = new System.Drawing.Size(13, 13);
            this.Lbldogru.TabIndex = 11;
            this.Lbldogru.Text = "0";
            // 
            // Lblyanlis
            // 
            this.Lblyanlis.AutoSize = true;
            this.Lblyanlis.Location = new System.Drawing.Point(403, 122);
            this.Lblyanlis.Name = "Lblyanlis";
            this.Lblyanlis.Size = new System.Drawing.Size(13, 13);
            this.Lblyanlis.TabIndex = 10;
            this.Lblyanlis.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(332, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbldogru);
            this.Controls.Add(this.Lblyanlis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lblsoruno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.Btna);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.RadioButton Btna;
        private System.Windows.Forms.RadioButton BtnC;
        private System.Windows.Forms.RadioButton BtnB;
        private System.Windows.Forms.RadioButton BtnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lblsoruno;
        private System.Windows.Forms.Label Lbldogru;
        private System.Windows.Forms.Label Lblyanlis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

