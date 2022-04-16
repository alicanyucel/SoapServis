
namespace AliCanYucel_SOAP
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
            this.btnXmlVeriGonder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHata = new System.Windows.Forms.TextBox();
            this.txtGelenCevap = new System.Windows.Forms.TextBox();
            this.btnBaglantiTest = new System.Windows.Forms.Button();
            this.btnJsonVeriGonder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXmlVeriGonder
            // 
            this.btnXmlVeriGonder.Location = new System.Drawing.Point(127, 415);
            this.btnXmlVeriGonder.Name = "btnXmlVeriGonder";
            this.btnXmlVeriGonder.Size = new System.Drawing.Size(132, 23);
            this.btnXmlVeriGonder.TabIndex = 0;
            this.btnXmlVeriGonder.Text = "XML VERİ GÖNDER";
            this.btnXmlVeriGonder.UseVisualStyleBackColor = true;
            this.btnXmlVeriGonder.Click += new System.EventHandler(this.btnXmlVeriGonder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtGelenCevap);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 396);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Response";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHata);
            this.groupBox2.Location = new System.Drawing.Point(7, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 171);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program İşelyişinde Karşılaşılan Hatalar";
            // 
            // txtHata
            // 
            this.txtHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHata.Location = new System.Drawing.Point(6, 19);
            this.txtHata.Multiline = true;
            this.txtHata.Name = "txtHata";
            this.txtHata.ReadOnly = true;
            this.txtHata.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHata.Size = new System.Drawing.Size(750, 136);
            this.txtHata.TabIndex = 4;
            this.txtHata.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtGelenCevap
            // 
            this.txtGelenCevap.Location = new System.Drawing.Point(6, 19);
            this.txtGelenCevap.Multiline = true;
            this.txtGelenCevap.Name = "txtGelenCevap";
            this.txtGelenCevap.ReadOnly = true;
            this.txtGelenCevap.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGelenCevap.Size = new System.Drawing.Size(763, 173);
            this.txtGelenCevap.TabIndex = 2;
            // 
            // btnBaglantiTest
            // 
            this.btnBaglantiTest.Location = new System.Drawing.Point(514, 415);
            this.btnBaglantiTest.Name = "btnBaglantiTest";
            this.btnBaglantiTest.Size = new System.Drawing.Size(132, 23);
            this.btnBaglantiTest.TabIndex = 3;
            this.btnBaglantiTest.Text = "BAĞLANTI TEST";
            this.btnBaglantiTest.UseVisualStyleBackColor = true;
            this.btnBaglantiTest.Click += new System.EventHandler(this.btnBaglantiTest_Click);
            // 
            // btnJsonVeriGonder
            // 
            this.btnJsonVeriGonder.Location = new System.Drawing.Point(320, 415);
            this.btnJsonVeriGonder.Name = "btnJsonVeriGonder";
            this.btnJsonVeriGonder.Size = new System.Drawing.Size(132, 23);
            this.btnJsonVeriGonder.TabIndex = 4;
            this.btnJsonVeriGonder.Text = "JSON VERİ GÖNDER";
            this.btnJsonVeriGonder.UseVisualStyleBackColor = true;
            this.btnJsonVeriGonder.Click += new System.EventHandler(this.btnJsonVeriGonder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJsonVeriGonder);
            this.Controls.Add(this.btnBaglantiTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXmlVeriGonder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXmlVeriGonder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGelenCevap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHata;
        private System.Windows.Forms.Button btnBaglantiTest;
        private System.Windows.Forms.Button btnJsonVeriGonder;
    }
}

