
namespace YazarEserDB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAnasayfaEserAciklama = new System.Windows.Forms.TextBox();
            this.lstAnasayfaEserler = new System.Windows.Forms.ListBox();
            this.pboYazarFoto = new System.Windows.Forms.PictureBox();
            this.cmbAnasayfaYazarlar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.grpYazar = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtResimYolu = new System.Windows.Forms.TextBox();
            this.txtTamAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstEserler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEserIcerik = new System.Windows.Forms.TextBox();
            this.cmbEserYazarlar = new System.Windows.Forms.ComboBox();
            this.txtEserBaslik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEserEkle = new System.Windows.Forms.Button();
            this.btnEserIptal = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYazarFoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grpYazar.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Coral;
            this.tabPage1.Controls.Add(this.txtAnasayfaEserAciklama);
            this.tabPage1.Controls.Add(this.lstAnasayfaEserler);
            this.tabPage1.Controls.Add(this.pboYazarFoto);
            this.tabPage1.Controls.Add(this.cmbAnasayfaYazarlar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Anasayfa";
            // 
            // txtAnasayfaEserAciklama
            // 
            this.txtAnasayfaEserAciklama.BackColor = System.Drawing.Color.Sienna;
            this.txtAnasayfaEserAciklama.Location = new System.Drawing.Point(312, 200);
            this.txtAnasayfaEserAciklama.Multiline = true;
            this.txtAnasayfaEserAciklama.Name = "txtAnasayfaEserAciklama";
            this.txtAnasayfaEserAciklama.ReadOnly = true;
            this.txtAnasayfaEserAciklama.Size = new System.Drawing.Size(472, 221);
            this.txtAnasayfaEserAciklama.TabIndex = 4;
            // 
            // lstAnasayfaEserler
            // 
            this.lstAnasayfaEserler.BackColor = System.Drawing.Color.RosyBrown;
            this.lstAnasayfaEserler.FormattingEnabled = true;
            this.lstAnasayfaEserler.Location = new System.Drawing.Point(312, 40);
            this.lstAnasayfaEserler.Name = "lstAnasayfaEserler";
            this.lstAnasayfaEserler.Size = new System.Drawing.Size(472, 121);
            this.lstAnasayfaEserler.TabIndex = 3;
            this.lstAnasayfaEserler.SelectedIndexChanged += new System.EventHandler(this.lstAnasayfaEserler_SelectedIndexChanged);
            // 
            // pboYazarFoto
            // 
            this.pboYazarFoto.Location = new System.Drawing.Point(11, 40);
            this.pboYazarFoto.Name = "pboYazarFoto";
            this.pboYazarFoto.Size = new System.Drawing.Size(274, 378);
            this.pboYazarFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboYazarFoto.TabIndex = 2;
            this.pboYazarFoto.TabStop = false;
            // 
            // cmbAnasayfaYazarlar
            // 
            this.cmbAnasayfaYazarlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnasayfaYazarlar.FormattingEnabled = true;
            this.cmbAnasayfaYazarlar.Location = new System.Drawing.Point(83, 13);
            this.cmbAnasayfaYazarlar.Name = "cmbAnasayfaYazarlar";
            this.cmbAnasayfaYazarlar.Size = new System.Drawing.Size(202, 21);
            this.cmbAnasayfaYazarlar.TabIndex = 1;
            this.cmbAnasayfaYazarlar.SelectedIndexChanged += new System.EventHandler(this.cmbAnasayfaYazarlar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(309, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Eser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(309, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Eserler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yazarlar";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OrangeRed;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lstYazarlar);
            this.tabPage2.Controls.Add(this.grpYazar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yazarlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "YAZARLAR";
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.BackColor = System.Drawing.Color.DarkGray;
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.Location = new System.Drawing.Point(3, 209);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(783, 212);
            this.lstYazarlar.TabIndex = 5;
            this.lstYazarlar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstYazarlar_KeyDown_1);
            this.lstYazarlar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstYazarlar_MouseDoubleClick_1);
            // 
            // grpYazar
            // 
            this.grpYazar.Controls.Add(this.btnIptal);
            this.grpYazar.Controls.Add(this.btnEkle);
            this.grpYazar.Controls.Add(this.txtResimYolu);
            this.grpYazar.Controls.Add(this.txtTamAd);
            this.grpYazar.Controls.Add(this.label1);
            this.grpYazar.Controls.Add(this.label2);
            this.grpYazar.Location = new System.Drawing.Point(8, 6);
            this.grpYazar.Name = "grpYazar";
            this.grpYazar.Size = new System.Drawing.Size(354, 162);
            this.grpYazar.TabIndex = 2;
            this.grpYazar.TabStop = false;
            this.grpYazar.Text = "Yazar Ekle";
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(156, 105);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(87, 29);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(249, 105);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 29);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtResimYolu
            // 
            this.txtResimYolu.Location = new System.Drawing.Point(129, 65);
            this.txtResimYolu.Name = "txtResimYolu";
            this.txtResimYolu.Size = new System.Drawing.Size(214, 20);
            this.txtResimYolu.TabIndex = 3;
            // 
            // txtTamAd
            // 
            this.txtTamAd.Location = new System.Drawing.Point(129, 29);
            this.txtTamAd.Name = "txtTamAd";
            this.txtTamAd.Size = new System.Drawing.Size(214, 20);
            this.txtTamAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resim Yolu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tam Ad :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkOrange;
            this.tabPage3.Controls.Add(this.btnEserIptal);
            this.tabPage3.Controls.Add(this.btnEserEkle);
            this.tabPage3.Controls.Add(this.lstEserler);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eserler";
            // 
            // lstEserler
            // 
            this.lstEserler.BackColor = System.Drawing.Color.BurlyWood;
            this.lstEserler.FormattingEnabled = true;
            this.lstEserler.Location = new System.Drawing.Point(295, 69);
            this.lstEserler.Name = "lstEserler";
            this.lstEserler.Size = new System.Drawing.Size(489, 342);
            this.lstEserler.TabIndex = 1;
            this.lstEserler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstEserler_KeyDown);
            this.lstEserler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstEserler_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEserIcerik);
            this.groupBox1.Controls.Add(this.cmbEserYazarlar);
            this.groupBox1.Controls.Add(this.txtEserBaslik);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eser Ekle";
            // 
            // txtEserIcerik
            // 
            this.txtEserIcerik.BackColor = System.Drawing.Color.BurlyWood;
            this.txtEserIcerik.Location = new System.Drawing.Point(9, 98);
            this.txtEserIcerik.Multiline = true;
            this.txtEserIcerik.Name = "txtEserIcerik";
            this.txtEserIcerik.Size = new System.Drawing.Size(263, 306);
            this.txtEserIcerik.TabIndex = 3;
            // 
            // cmbEserYazarlar
            // 
            this.cmbEserYazarlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEserYazarlar.FormattingEnabled = true;
            this.cmbEserYazarlar.Location = new System.Drawing.Point(95, 63);
            this.cmbEserYazarlar.Name = "cmbEserYazarlar";
            this.cmbEserYazarlar.Size = new System.Drawing.Size(177, 21);
            this.cmbEserYazarlar.TabIndex = 2;
            // 
            // txtEserBaslik
            // 
            this.txtEserBaslik.Location = new System.Drawing.Point(95, 32);
            this.txtEserBaslik.Name = "txtEserBaslik";
            this.txtEserBaslik.Size = new System.Drawing.Size(177, 20);
            this.txtEserBaslik.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Yazar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Eser Başlık";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(292, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Eserler";
            // 
            // btnEserEkle
            // 
            this.btnEserEkle.Location = new System.Drawing.Point(188, 422);
            this.btnEserEkle.Name = "btnEserEkle";
            this.btnEserEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEserEkle.TabIndex = 4;
            this.btnEserEkle.Text = "Eser Ekle";
            this.btnEserEkle.UseVisualStyleBackColor = true;
            this.btnEserEkle.Click += new System.EventHandler(this.btnEserEkle_Click);
            // 
            // btnEserIptal
            // 
            this.btnEserIptal.Location = new System.Drawing.Point(107, 422);
            this.btnEserIptal.Name = "btnEserIptal";
            this.btnEserIptal.Size = new System.Drawing.Size(75, 23);
            this.btnEserIptal.TabIndex = 4;
            this.btnEserIptal.Text = "İPTAL";
            this.btnEserIptal.UseVisualStyleBackColor = true;
            this.btnEserIptal.Click += new System.EventHandler(this.btnEserIptal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYazarFoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpYazar.ResumeLayout(false);
            this.grpYazar.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstYazarlar;
        private System.Windows.Forms.GroupBox grpYazar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtResimYolu;
        private System.Windows.Forms.TextBox txtTamAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnasayfaEserAciklama;
        private System.Windows.Forms.ListBox lstAnasayfaEserler;
        private System.Windows.Forms.PictureBox pboYazarFoto;
        private System.Windows.Forms.ComboBox cmbAnasayfaYazarlar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstEserler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEserIcerik;
        private System.Windows.Forms.ComboBox cmbEserYazarlar;
        private System.Windows.Forms.TextBox txtEserBaslik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEserIptal;
        private System.Windows.Forms.Button btnEserEkle;
    }
}

