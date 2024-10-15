namespace AdamAsmaca2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cıkanSehir = new System.Windows.Forms.Label();
            this.olmayanHarfler = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tahminKutusu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(143, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cıkanSehir
            // 
            this.cıkanSehir.BackColor = System.Drawing.Color.DarkOrchid;
            this.cıkanSehir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cıkanSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkanSehir.Location = new System.Drawing.Point(12, 77);
            this.cıkanSehir.Name = "cıkanSehir";
            this.cıkanSehir.Size = new System.Drawing.Size(407, 65);
            this.cıkanSehir.TabIndex = 1;
            this.cıkanSehir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // olmayanHarfler
            // 
            this.olmayanHarfler.BackColor = System.Drawing.Color.DarkOrchid;
            this.olmayanHarfler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.olmayanHarfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olmayanHarfler.Location = new System.Drawing.Point(19, 363);
            this.olmayanHarfler.Name = "olmayanHarfler";
            this.olmayanHarfler.Size = new System.Drawing.Size(397, 59);
            this.olmayanHarfler.TabIndex = 2;
            this.olmayanHarfler.Click += new System.EventHandler(this.olmayanHarfler_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(129, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tahmin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrchid;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(446, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 406);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(136, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tahmin Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tahminKutusu
            // 
            this.tahminKutusu.BackColor = System.Drawing.Color.DarkOrchid;
            this.tahminKutusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahminKutusu.Location = new System.Drawing.Point(22, 239);
            this.tahminKutusu.MaxLength = 1;
            this.tahminKutusu.Name = "tahminKutusu";
            this.tahminKutusu.Size = new System.Drawing.Size(394, 34);
            this.tahminKutusu.TabIndex = 7;
            this.tahminKutusu.TextChanged += new System.EventHandler(this.tahminKutusu_TextChanged);
            this.tahminKutusu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tahminKutusu_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(87, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Olmayan Harfler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tahminKutusu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.olmayanHarfler);
            this.Controls.Add(this.cıkanSehir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adam Asmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cıkanSehir;
        private System.Windows.Forms.Label olmayanHarfler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tahminKutusu;
        private System.Windows.Forms.Label label4;
    }
}

