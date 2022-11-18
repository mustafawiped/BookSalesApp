namespace tryprojectpoffor
{
    partial class adminform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grboxDestekPanel = new System.Windows.Forms.GroupBox();
            this.txtCevapYazi = new System.Windows.Forms.RichTextBox();
            this.btnCevapVer = new System.Windows.Forms.Button();
            this.btnTalepSil = new System.Windows.Forms.Button();
            this.btnTalepGoster = new System.Windows.Forms.Button();
            this.destekTalepleri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblrutbe = new System.Windows.Forms.Label();
            this.grboxYonetim = new System.Windows.Forms.GroupBox();
            this.cmboxRutbe = new System.Windows.Forms.ComboBox();
            this.btnYetkiVer = new System.Windows.Forms.Button();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.btnEpostadegistir = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.btnYetkiAl = new System.Windows.Forms.Button();
            this.btnYasakla = new System.Windows.Forms.Button();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.lblKadi = new System.Windows.Forms.Label();
            this.kullanicilistesi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.grboxDestekPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destekTalepleri)).BeginInit();
            this.grboxYonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // grboxDestekPanel
            // 
            this.grboxDestekPanel.Controls.Add(this.txtCevapYazi);
            this.grboxDestekPanel.Controls.Add(this.btnCevapVer);
            this.grboxDestekPanel.Controls.Add(this.btnTalepSil);
            this.grboxDestekPanel.Controls.Add(this.btnTalepGoster);
            this.grboxDestekPanel.Controls.Add(this.destekTalepleri);
            this.grboxDestekPanel.ForeColor = System.Drawing.Color.White;
            this.grboxDestekPanel.Location = new System.Drawing.Point(12, 30);
            this.grboxDestekPanel.Name = "grboxDestekPanel";
            this.grboxDestekPanel.Size = new System.Drawing.Size(768, 194);
            this.grboxDestekPanel.TabIndex = 0;
            this.grboxDestekPanel.TabStop = false;
            this.grboxDestekPanel.Text = "Destek Paneli";
            // 
            // txtCevapYazi
            // 
            this.txtCevapYazi.Location = new System.Drawing.Point(6, 116);
            this.txtCevapYazi.Name = "txtCevapYazi";
            this.txtCevapYazi.Size = new System.Drawing.Size(211, 70);
            this.txtCevapYazi.TabIndex = 25;
            this.txtCevapYazi.Text = "";
            // 
            // btnCevapVer
            // 
            this.btnCevapVer.ForeColor = System.Drawing.Color.Black;
            this.btnCevapVer.Location = new System.Drawing.Point(43, 85);
            this.btnCevapVer.Name = "btnCevapVer";
            this.btnCevapVer.Size = new System.Drawing.Size(130, 27);
            this.btnCevapVer.TabIndex = 24;
            this.btnCevapVer.Text = "Talebe Cevap Ver";
            this.btnCevapVer.UseVisualStyleBackColor = true;
            this.btnCevapVer.Click += new System.EventHandler(this.btnCevapVer_Click);
            // 
            // btnTalepSil
            // 
            this.btnTalepSil.ForeColor = System.Drawing.Color.Black;
            this.btnTalepSil.Location = new System.Drawing.Point(43, 52);
            this.btnTalepSil.Name = "btnTalepSil";
            this.btnTalepSil.Size = new System.Drawing.Size(130, 27);
            this.btnTalepSil.TabIndex = 23;
            this.btnTalepSil.Text = "Talebi Sil";
            this.btnTalepSil.UseVisualStyleBackColor = true;
            this.btnTalepSil.Click += new System.EventHandler(this.btnTalepSil_Click);
            // 
            // btnTalepGoster
            // 
            this.btnTalepGoster.ForeColor = System.Drawing.Color.Black;
            this.btnTalepGoster.Location = new System.Drawing.Point(43, 19);
            this.btnTalepGoster.Name = "btnTalepGoster";
            this.btnTalepGoster.Size = new System.Drawing.Size(130, 27);
            this.btnTalepGoster.TabIndex = 22;
            this.btnTalepGoster.Text = "Talep Metnini Göster";
            this.btnTalepGoster.UseVisualStyleBackColor = true;
            this.btnTalepGoster.Click += new System.EventHandler(this.btnTalepGoster_Click);
            // 
            // destekTalepleri
            // 
            this.destekTalepleri.AllowUserToAddRows = false;
            this.destekTalepleri.AllowUserToDeleteRows = false;
            this.destekTalepleri.AllowUserToResizeColumns = false;
            this.destekTalepleri.AllowUserToResizeRows = false;
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.Black;
            this.destekTalepleri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.destekTalepleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.destekTalepleri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.destekTalepleri.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.destekTalepleri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.destekTalepleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.destekTalepleri.DefaultCellStyle = dataGridViewCellStyle43;
            this.destekTalepleri.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.destekTalepleri.GridColor = System.Drawing.Color.White;
            this.destekTalepleri.Location = new System.Drawing.Point(235, 12);
            this.destekTalepleri.MultiSelect = false;
            this.destekTalepleri.Name = "destekTalepleri";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.destekTalepleri.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.destekTalepleri.RowHeadersVisible = false;
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.Blue;
            this.destekTalepleri.RowsDefaultCellStyle = dataGridViewCellStyle45;
            this.destekTalepleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.destekTalepleri.Size = new System.Drawing.Size(527, 174);
            this.destekTalepleri.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "kitapçım.com.tr Yönetim Paneline Hoşgeldiniz!           Rütbeniz =  ";
            // 
            // lblrutbe
            // 
            this.lblrutbe.AutoSize = true;
            this.lblrutbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblrutbe.ForeColor = System.Drawing.Color.Black;
            this.lblrutbe.Location = new System.Drawing.Point(467, 6);
            this.lblrutbe.Name = "lblrutbe";
            this.lblrutbe.Size = new System.Drawing.Size(0, 20);
            this.lblrutbe.TabIndex = 2;
            // 
            // grboxYonetim
            // 
            this.grboxYonetim.Controls.Add(this.cmboxRutbe);
            this.grboxYonetim.Controls.Add(this.btnYetkiVer);
            this.grboxYonetim.Controls.Add(this.txtEposta);
            this.grboxYonetim.Controls.Add(this.btnEpostadegistir);
            this.grboxYonetim.Controls.Add(this.txtSifre);
            this.grboxYonetim.Controls.Add(this.btnSifreDegistir);
            this.grboxYonetim.Controls.Add(this.btnYetkiAl);
            this.grboxYonetim.Controls.Add(this.btnYasakla);
            this.grboxYonetim.Controls.Add(this.txtKadi);
            this.grboxYonetim.Controls.Add(this.lblKadi);
            this.grboxYonetim.Controls.Add(this.kullanicilistesi);
            this.grboxYonetim.ForeColor = System.Drawing.Color.White;
            this.grboxYonetim.Location = new System.Drawing.Point(12, 230);
            this.grboxYonetim.Name = "grboxYonetim";
            this.grboxYonetim.Size = new System.Drawing.Size(768, 228);
            this.grboxYonetim.TabIndex = 3;
            this.grboxYonetim.TabStop = false;
            this.grboxYonetim.Text = "Kullanıcı Yönetimi";
            // 
            // cmboxRutbe
            // 
            this.cmboxRutbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboxRutbe.FormattingEnabled = true;
            this.cmboxRutbe.Items.AddRange(new object[] {
            "Yetki Seçiniz!",
            "Destek Ekibi",
            "Yonetici"});
            this.cmboxRutbe.Location = new System.Drawing.Point(598, 175);
            this.cmboxRutbe.Name = "cmboxRutbe";
            this.cmboxRutbe.Size = new System.Drawing.Size(156, 32);
            this.cmboxRutbe.TabIndex = 36;
            // 
            // btnYetkiVer
            // 
            this.btnYetkiVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiVer.ForeColor = System.Drawing.Color.Black;
            this.btnYetkiVer.Location = new System.Drawing.Point(421, 175);
            this.btnYetkiVer.Name = "btnYetkiVer";
            this.btnYetkiVer.Size = new System.Drawing.Size(156, 34);
            this.btnYetkiVer.TabIndex = 35;
            this.btnYetkiVer.Text = "Yetki Ver";
            this.btnYetkiVer.UseVisualStyleBackColor = true;
            this.btnYetkiVer.Click += new System.EventHandler(this.btnYetkiVer_Click);
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Location = new System.Drawing.Point(589, 65);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(172, 24);
            this.txtEposta.TabIndex = 34;
            // 
            // btnEpostadegistir
            // 
            this.btnEpostadegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEpostadegistir.ForeColor = System.Drawing.Color.Black;
            this.btnEpostadegistir.Location = new System.Drawing.Point(598, 95);
            this.btnEpostadegistir.Name = "btnEpostadegistir";
            this.btnEpostadegistir.Size = new System.Drawing.Size(156, 34);
            this.btnEpostadegistir.TabIndex = 33;
            this.btnEpostadegistir.Text = "Eposta Değiştir";
            this.btnEpostadegistir.UseVisualStyleBackColor = true;
            this.btnEpostadegistir.Click += new System.EventHandler(this.btnEpostadegistir_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(412, 65);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(172, 24);
            this.txtSifre.TabIndex = 32;
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreDegistir.ForeColor = System.Drawing.Color.Black;
            this.btnSifreDegistir.Location = new System.Drawing.Point(421, 95);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(156, 34);
            this.btnSifreDegistir.TabIndex = 31;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = true;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // btnYetkiAl
            // 
            this.btnYetkiAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiAl.ForeColor = System.Drawing.Color.Black;
            this.btnYetkiAl.Location = new System.Drawing.Point(421, 135);
            this.btnYetkiAl.Name = "btnYetkiAl";
            this.btnYetkiAl.Size = new System.Drawing.Size(156, 34);
            this.btnYetkiAl.TabIndex = 30;
            this.btnYetkiAl.Text = "Yetkisini Al";
            this.btnYetkiAl.UseVisualStyleBackColor = true;
            this.btnYetkiAl.Click += new System.EventHandler(this.btnYetkiAl_Click);
            // 
            // btnYasakla
            // 
            this.btnYasakla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYasakla.ForeColor = System.Drawing.Color.Black;
            this.btnYasakla.Location = new System.Drawing.Point(598, 135);
            this.btnYasakla.Name = "btnYasakla";
            this.btnYasakla.Size = new System.Drawing.Size(156, 34);
            this.btnYasakla.TabIndex = 29;
            this.btnYasakla.Text = "Yasakla";
            this.btnYasakla.UseVisualStyleBackColor = true;
            this.btnYasakla.Click += new System.EventHandler(this.btnYasakla_Click);
            // 
            // txtKadi
            // 
            this.txtKadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKadi.Location = new System.Drawing.Point(557, 16);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(172, 24);
            this.txtKadi.TabIndex = 28;
            this.txtKadi.TextChanged += new System.EventHandler(this.txtKadi_TextChanged);
            // 
            // lblKadi
            // 
            this.lblKadi.AutoSize = true;
            this.lblKadi.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKadi.Location = new System.Drawing.Point(455, 16);
            this.lblKadi.Name = "lblKadi";
            this.lblKadi.Size = new System.Drawing.Size(107, 23);
            this.lblKadi.TabIndex = 27;
            this.lblKadi.Text = "Kullanıcı Adı = ";
            // 
            // kullanicilistesi
            // 
            this.kullanicilistesi.AllowUserToAddRows = false;
            this.kullanicilistesi.AllowUserToDeleteRows = false;
            this.kullanicilistesi.AllowUserToResizeColumns = false;
            this.kullanicilistesi.AllowUserToResizeRows = false;
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.Black;
            this.kullanicilistesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            this.kullanicilistesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kullanicilistesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kullanicilistesi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kullanicilistesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.kullanicilistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kullanicilistesi.DefaultCellStyle = dataGridViewCellStyle48;
            this.kullanicilistesi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kullanicilistesi.GridColor = System.Drawing.Color.White;
            this.kullanicilistesi.Location = new System.Drawing.Point(6, 17);
            this.kullanicilistesi.MultiSelect = false;
            this.kullanicilistesi.Name = "kullanicilistesi";
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kullanicilistesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.kullanicilistesi.RowHeadersVisible = false;
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.Blue;
            this.kullanicilistesi.RowsDefaultCellStyle = dataGridViewCellStyle50;
            this.kullanicilistesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kullanicilistesi.Size = new System.Drawing.Size(400, 203);
            this.kullanicilistesi.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(706, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(793, 470);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grboxYonetim);
            this.Controls.Add(this.lblrutbe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grboxDestekPanel);
            this.Name = "adminform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kitapçım.com || Yönetim Paneli";
            this.Load += new System.EventHandler(this.adminform_Load);
            this.grboxDestekPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destekTalepleri)).EndInit();
            this.grboxYonetim.ResumeLayout(false);
            this.grboxYonetim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxDestekPanel;
        private System.Windows.Forms.RichTextBox txtCevapYazi;
        private System.Windows.Forms.Button btnCevapVer;
        private System.Windows.Forms.Button btnTalepSil;
        private System.Windows.Forms.Button btnTalepGoster;
        private System.Windows.Forms.DataGridView destekTalepleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrutbe;
        private System.Windows.Forms.GroupBox grboxYonetim;
        private System.Windows.Forms.DataGridView kullanicilistesi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmboxRutbe;
        private System.Windows.Forms.Button btnYetkiVer;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Button btnEpostadegistir;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnSifreDegistir;
        private System.Windows.Forms.Button btnYetkiAl;
        private System.Windows.Forms.Button btnYasakla;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.Label lblKadi;
    }
}