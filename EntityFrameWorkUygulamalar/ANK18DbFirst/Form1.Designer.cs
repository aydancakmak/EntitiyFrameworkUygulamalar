namespace ANK18DbFirst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCalisanlar = new DataGridView();
            btnEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            lblSecilen = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            lblAra = new Label();
            txtAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).BeginInit();
            SuspendLayout();
            // 
            // dgvCalisanlar
            // 
            dgvCalisanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCalisanlar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCalisanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalisanlar.Location = new Point(86, 68);
            dgvCalisanlar.Name = "dgvCalisanlar";
            dgvCalisanlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCalisanlar.Size = new Size(636, 198);
            dgvCalisanlar.TabIndex = 0;
            dgvCalisanlar.CellClick += dgvCalisanlar_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Gainsboro;
            btnEkle.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEkle.ForeColor = Color.Indigo;
            btnEkle.Location = new Point(131, 390);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(92, 37);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(86, 303);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 2;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(86, 335);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 3;
            label2.Text = "Soyad :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(172, 301);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(172, 333);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 5;
            // 
            // lblSecilen
            // 
            lblSecilen.AutoSize = true;
            lblSecilen.BackColor = Color.Transparent;
            lblSecilen.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSecilen.ForeColor = Color.DarkGreen;
            lblSecilen.Location = new Point(86, 269);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(127, 21);
            lblSecilen.TabIndex = 6;
            lblSecilen.Text = "SEÇİLEN KİŞİ :";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Gold;
            btnGuncelle.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.ForeColor = Color.Black;
            btnGuncelle.Location = new Point(498, 390);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(112, 37);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Salmon;
            btnSil.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSil.ForeColor = Color.DarkRed;
            btnSil.Location = new Point(310, 390);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(92, 37);
            btnSil.TabIndex = 8;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // lblAra
            // 
            lblAra.BackColor = Color.Transparent;
            lblAra.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAra.ForeColor = Color.DarkGreen;
            lblAra.Location = new Point(392, 31);
            lblAra.Name = "lblAra";
            lblAra.Size = new Size(100, 23);
            lblAra.TabIndex = 9;
            lblAra.Text = "ARANAN :";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(498, 31);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(224, 23);
            txtAra.TabIndex = 10;
            txtAra.TextChanged += textAra_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAra);
            Controls.Add(lblAra);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(lblSecilen);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(dgvCalisanlar);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "slm alkın";
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCalisanlar;
        private Button btnEkle;
        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label lblSecilen;
        private Button btnGuncelle;
        private Button btnSil;
        private Label lblAra;
        private TextBox txtAra;
    }
}
