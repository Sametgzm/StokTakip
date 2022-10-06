namespace StokKontrol
{
    partial class frmSatis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgSatis = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGiyim = new System.Windows.Forms.Label();
            this.lblKitap = new System.Windows.Forms.Label();
            this.lblTeknoloji = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKazanç = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSatis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgSatis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 278);
            this.panel1.TabIndex = 0;
            // 
            // dgSatis
            // 
            this.dgSatis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.dgSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSatis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Adres,
            this.Column3,
            this.Column6,
            this.Column5});
            this.dgSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSatis.Location = new System.Drawing.Point(0, 0);
            this.dgSatis.Name = "dgSatis";
            this.dgSatis.Size = new System.Drawing.Size(744, 278);
            this.dgSatis.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(254)))), ((int)(((byte)(222)))));
            this.groupBox1.Controls.Add(this.lblGiyim);
            this.groupBox1.Controls.Add(this.lblKitap);
            this.groupBox1.Controls.Add(this.lblTeknoloji);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(32, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satılan Ürünler";
            // 
            // lblGiyim
            // 
            this.lblGiyim.AutoSize = true;
            this.lblGiyim.Location = new System.Drawing.Point(129, 110);
            this.lblGiyim.Name = "lblGiyim";
            this.lblGiyim.Size = new System.Drawing.Size(0, 18);
            this.lblGiyim.TabIndex = 5;
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Location = new System.Drawing.Point(128, 70);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(0, 18);
            this.lblKitap.TabIndex = 4;
            // 
            // lblTeknoloji
            // 
            this.lblTeknoloji.AutoSize = true;
            this.lblTeknoloji.Location = new System.Drawing.Point(128, 35);
            this.lblTeknoloji.Name = "lblTeknoloji";
            this.lblTeknoloji.Size = new System.Drawing.Size(0, 18);
            this.lblTeknoloji.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giyim-Aksesuar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teknoloji :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(199)))), ((int)(((byte)(252)))));
            this.groupBox2.Controls.Add(this.lblKazanç);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Italic);
            this.groupBox2.Location = new System.Drawing.Point(478, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 144);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gelir Tablosu";
            // 
            // lblKazanç
            // 
            this.lblKazanç.AutoSize = true;
            this.lblKazanç.Location = new System.Drawing.Point(144, 65);
            this.lblKazanç.Name = "lblKazanç";
            this.lblKazanç.Size = new System.Drawing.Size(0, 18);
            this.lblKazanç.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Kazanç :";
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSatis.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Italic);
            this.btnSatis.Location = new System.Drawing.Point(337, 302);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(109, 40);
            this.btnSatis.TabIndex = 3;
            this.btnSatis.Text = "Listele";
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Italic);
            this.btnEkle.Location = new System.Drawing.Point(337, 367);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 40);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Müşteri";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün";
            this.Column2.Name = "Column2";
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Kategori";
            this.Adres.Name = "Adres";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adet";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fiyat";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adres";
            this.Column5.Name = "Column5";
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(139)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(744, 485);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSatis";
            this.Text = "Satış";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSatis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgSatis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGiyim;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.Label lblTeknoloji;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblKazanç;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}