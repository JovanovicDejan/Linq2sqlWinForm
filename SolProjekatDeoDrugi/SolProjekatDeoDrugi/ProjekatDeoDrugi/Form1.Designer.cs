namespace ProjekatDeoDrugi
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.dgKlijenti = new System.Windows.Forms.DataGridView();
            this.dgServisi = new System.Windows.Forms.DataGridView();
            this.txtNazivKlijenta = new System.Windows.Forms.TextBox();
            this.txtRegistarskiBroj = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtDodatniKomentar = new System.Windows.Forms.TextBox();
            this.txtOpisUsluge = new System.Windows.Forms.TextBox();
            this.dtDatumServisa = new System.Windows.Forms.DateTimePicker();
            this.txtIDKlijentaZaBrisanje = new System.Windows.Forms.TextBox();
            this.btnDeleteClientID = new System.Windows.Forms.Button();
            this.txtIDSerisZaBrisanje = new System.Windows.Forms.TextBox();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNazivError = new System.Windows.Forms.Label();
            this.lblRegistarskiError = new System.Windows.Forms.Label();
            this.lblKontaktError = new System.Windows.Forms.Label();
            this.lblDodatniKomentarError = new System.Windows.Forms.Label();
            this.lblKlijentError = new System.Windows.Forms.Label();
            this.lblServisError = new System.Windows.Forms.Label();
            this.lblOpisError = new System.Windows.Forms.Label();
            this.servisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumServisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisUslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivKlijentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registarskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatniKomentarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtKlijentID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgKlijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(968, 46);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(751, 46);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(186, 47);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Get DATA";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(214, 271);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(136, 29);
            this.btnAddClient.TabIndex = 2;
            this.btnAddClient.Text = "Add client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(214, 316);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(136, 29);
            this.btnUpdateClient.TabIndex = 3;
            this.btnUpdateClient.Text = "Update client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(214, 589);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(136, 29);
            this.btnAddService.TabIndex = 4;
            this.btnAddService.Text = "Add service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(214, 634);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(136, 29);
            this.btnUpdateService.TabIndex = 5;
            this.btnUpdateService.Text = "Update Service";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // dgKlijenti
            // 
            this.dgKlijenti.AllowUserToDeleteRows = false;
            this.dgKlijenti.AutoGenerateColumns = false;
            this.dgKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klijentIDDataGridViewTextBoxColumn,
            this.nazivKlijentaDataGridViewTextBoxColumn,
            this.registarskiBrojDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn,
            this.dodatniKomentarDataGridViewTextBoxColumn});
            this.dgKlijenti.DataSource = this.klijentBindingSource;
            this.dgKlijenti.Location = new System.Drawing.Point(571, 134);
            this.dgKlijenti.MultiSelect = false;
            this.dgKlijenti.Name = "dgKlijenti";
            this.dgKlijenti.ReadOnly = true;
            this.dgKlijenti.Size = new System.Drawing.Size(543, 188);
            this.dgKlijenti.TabIndex = 6;
            // 
            // dgServisi
            // 
            this.dgServisi.AutoGenerateColumns = false;
            this.dgServisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServisi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servisIDDataGridViewTextBoxColumn,
            this.klijentIDDataGridViewTextBoxColumn1,
            this.datumServisaDataGridViewTextBoxColumn,
            this.opisUslugeDataGridViewTextBoxColumn});
            this.dgServisi.DataSource = this.servisBindingSource;
            this.dgServisi.Location = new System.Drawing.Point(571, 430);
            this.dgServisi.Name = "dgServisi";
            this.dgServisi.Size = new System.Drawing.Size(445, 188);
            this.dgServisi.TabIndex = 7;
            // 
            // txtNazivKlijenta
            // 
            this.txtNazivKlijenta.Location = new System.Drawing.Point(223, 26);
            this.txtNazivKlijenta.Name = "txtNazivKlijenta";
            this.txtNazivKlijenta.Size = new System.Drawing.Size(112, 20);
            this.txtNazivKlijenta.TabIndex = 8;
            // 
            // txtRegistarskiBroj
            // 
            this.txtRegistarskiBroj.Location = new System.Drawing.Point(223, 82);
            this.txtRegistarskiBroj.Name = "txtRegistarskiBroj";
            this.txtRegistarskiBroj.Size = new System.Drawing.Size(112, 20);
            this.txtRegistarskiBroj.TabIndex = 9;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(223, 142);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(112, 20);
            this.txtKontakt.TabIndex = 10;
            // 
            // txtDodatniKomentar
            // 
            this.txtDodatniKomentar.Location = new System.Drawing.Point(223, 196);
            this.txtDodatniKomentar.Name = "txtDodatniKomentar";
            this.txtDodatniKomentar.Size = new System.Drawing.Size(112, 20);
            this.txtDodatniKomentar.TabIndex = 11;
            // 
            // txtOpisUsluge
            // 
            this.txtOpisUsluge.Location = new System.Drawing.Point(223, 534);
            this.txtOpisUsluge.Name = "txtOpisUsluge";
            this.txtOpisUsluge.Size = new System.Drawing.Size(112, 20);
            this.txtOpisUsluge.TabIndex = 13;
            // 
            // dtDatumServisa
            // 
            this.dtDatumServisa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatumServisa.Location = new System.Drawing.Point(223, 465);
            this.dtDatumServisa.Name = "dtDatumServisa";
            this.dtDatumServisa.Size = new System.Drawing.Size(112, 20);
            this.dtDatumServisa.TabIndex = 14;
            // 
            // txtIDKlijentaZaBrisanje
            // 
            this.txtIDKlijentaZaBrisanje.Location = new System.Drawing.Point(402, 167);
            this.txtIDKlijentaZaBrisanje.Name = "txtIDKlijentaZaBrisanje";
            this.txtIDKlijentaZaBrisanje.Size = new System.Drawing.Size(112, 20);
            this.txtIDKlijentaZaBrisanje.TabIndex = 16;
            // 
            // btnDeleteClientID
            // 
            this.btnDeleteClientID.Location = new System.Drawing.Point(393, 203);
            this.btnDeleteClientID.Name = "btnDeleteClientID";
            this.btnDeleteClientID.Size = new System.Drawing.Size(136, 29);
            this.btnDeleteClientID.TabIndex = 15;
            this.btnDeleteClientID.Text = "Delete client By ID";
            this.btnDeleteClientID.UseVisualStyleBackColor = true;
            this.btnDeleteClientID.Click += new System.EventHandler(this.btnDeleteClientID_Click);
            // 
            // txtIDSerisZaBrisanje
            // 
            this.txtIDSerisZaBrisanje.Location = new System.Drawing.Point(417, 472);
            this.txtIDSerisZaBrisanje.Name = "txtIDSerisZaBrisanje";
            this.txtIDSerisZaBrisanje.Size = new System.Drawing.Size(112, 20);
            this.txtIDSerisZaBrisanje.TabIndex = 18;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(408, 541);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(136, 29);
            this.btnDeleteService.TabIndex = 17;
            this.btnDeleteService.Text = "Delete service by ID";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Naziv klijenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Registarski broj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kontakt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Dodatni komentar: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Opis usluge:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Datum servisa: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Klijent ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Unesite ID servisa za brisanje: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Unesite ID klijenta za brisanje:";
            // 
            // lblNazivError
            // 
            this.lblNazivError.AutoSize = true;
            this.lblNazivError.Location = new System.Drawing.Point(251, 53);
            this.lblNazivError.Name = "lblNazivError";
            this.lblNazivError.Size = new System.Drawing.Size(0, 13);
            this.lblNazivError.TabIndex = 28;
            // 
            // lblRegistarskiError
            // 
            this.lblRegistarskiError.AutoSize = true;
            this.lblRegistarskiError.Location = new System.Drawing.Point(251, 110);
            this.lblRegistarskiError.Name = "lblRegistarskiError";
            this.lblRegistarskiError.Size = new System.Drawing.Size(0, 13);
            this.lblRegistarskiError.TabIndex = 29;
            // 
            // lblKontaktError
            // 
            this.lblKontaktError.AutoSize = true;
            this.lblKontaktError.Location = new System.Drawing.Point(251, 170);
            this.lblKontaktError.Name = "lblKontaktError";
            this.lblKontaktError.Size = new System.Drawing.Size(0, 13);
            this.lblKontaktError.TabIndex = 30;
            this.lblKontaktError.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblDodatniKomentarError
            // 
            this.lblDodatniKomentarError.AutoSize = true;
            this.lblDodatniKomentarError.Location = new System.Drawing.Point(251, 228);
            this.lblDodatniKomentarError.Name = "lblDodatniKomentarError";
            this.lblDodatniKomentarError.Size = new System.Drawing.Size(0, 13);
            this.lblDodatniKomentarError.TabIndex = 31;
            // 
            // lblKlijentError
            // 
            this.lblKlijentError.AutoSize = true;
            this.lblKlijentError.Location = new System.Drawing.Point(251, 437);
            this.lblKlijentError.Name = "lblKlijentError";
            this.lblKlijentError.Size = new System.Drawing.Size(41, 13);
            this.lblKlijentError.TabIndex = 32;
            this.lblKlijentError.Text = "label10";
            // 
            // lblServisError
            // 
            this.lblServisError.AutoSize = true;
            this.lblServisError.Location = new System.Drawing.Point(251, 498);
            this.lblServisError.Name = "lblServisError";
            this.lblServisError.Size = new System.Drawing.Size(41, 13);
            this.lblServisError.TabIndex = 33;
            this.lblServisError.Text = "label11";
            // 
            // lblOpisError
            // 
            this.lblOpisError.AutoSize = true;
            this.lblOpisError.Location = new System.Drawing.Point(251, 557);
            this.lblOpisError.Name = "lblOpisError";
            this.lblOpisError.Size = new System.Drawing.Size(41, 13);
            this.lblOpisError.TabIndex = 34;
            this.lblOpisError.Text = "label12";
            // 
            // servisIDDataGridViewTextBoxColumn
            // 
            this.servisIDDataGridViewTextBoxColumn.DataPropertyName = "ServisID";
            this.servisIDDataGridViewTextBoxColumn.HeaderText = "ServisID";
            this.servisIDDataGridViewTextBoxColumn.Name = "servisIDDataGridViewTextBoxColumn";
            // 
            // klijentIDDataGridViewTextBoxColumn1
            // 
            this.klijentIDDataGridViewTextBoxColumn1.DataPropertyName = "KlijentID";
            this.klijentIDDataGridViewTextBoxColumn1.HeaderText = "KlijentID";
            this.klijentIDDataGridViewTextBoxColumn1.Name = "klijentIDDataGridViewTextBoxColumn1";
            // 
            // datumServisaDataGridViewTextBoxColumn
            // 
            this.datumServisaDataGridViewTextBoxColumn.DataPropertyName = "DatumServisa";
            this.datumServisaDataGridViewTextBoxColumn.HeaderText = "DatumServisa";
            this.datumServisaDataGridViewTextBoxColumn.Name = "datumServisaDataGridViewTextBoxColumn";
            // 
            // opisUslugeDataGridViewTextBoxColumn
            // 
            this.opisUslugeDataGridViewTextBoxColumn.DataPropertyName = "OpisUsluge";
            this.opisUslugeDataGridViewTextBoxColumn.HeaderText = "OpisUsluge";
            this.opisUslugeDataGridViewTextBoxColumn.Name = "opisUslugeDataGridViewTextBoxColumn";
            // 
            // servisBindingSource
            // 
            this.servisBindingSource.DataSource = typeof(ProjekatDeoDrugi.Servis);
            // 
            // klijentIDDataGridViewTextBoxColumn
            // 
            this.klijentIDDataGridViewTextBoxColumn.DataPropertyName = "KlijentID";
            this.klijentIDDataGridViewTextBoxColumn.HeaderText = "KlijentID";
            this.klijentIDDataGridViewTextBoxColumn.Name = "klijentIDDataGridViewTextBoxColumn";
            this.klijentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivKlijentaDataGridViewTextBoxColumn
            // 
            this.nazivKlijentaDataGridViewTextBoxColumn.DataPropertyName = "NazivKlijenta";
            this.nazivKlijentaDataGridViewTextBoxColumn.HeaderText = "NazivKlijenta";
            this.nazivKlijentaDataGridViewTextBoxColumn.Name = "nazivKlijentaDataGridViewTextBoxColumn";
            this.nazivKlijentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registarskiBrojDataGridViewTextBoxColumn
            // 
            this.registarskiBrojDataGridViewTextBoxColumn.DataPropertyName = "RegistarskiBroj";
            this.registarskiBrojDataGridViewTextBoxColumn.HeaderText = "RegistarskiBroj";
            this.registarskiBrojDataGridViewTextBoxColumn.Name = "registarskiBrojDataGridViewTextBoxColumn";
            this.registarskiBrojDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            this.kontaktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dodatniKomentarDataGridViewTextBoxColumn
            // 
            this.dodatniKomentarDataGridViewTextBoxColumn.DataPropertyName = "DodatniKomentar";
            this.dodatniKomentarDataGridViewTextBoxColumn.HeaderText = "DodatniKomentar";
            this.dodatniKomentarDataGridViewTextBoxColumn.Name = "dodatniKomentarDataGridViewTextBoxColumn";
            this.dodatniKomentarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataSource = typeof(ProjekatDeoDrugi.Klijent);
            // 
            // klijentBindingSource1
            // 
            this.klijentBindingSource1.DataSource = typeof(ProjekatDeoDrugi.Klijent);
            // 
            // txtKlijentID
            // 
            this.txtKlijentID.FormattingEnabled = true;
            this.txtKlijentID.Location = new System.Drawing.Point(223, 402);
            this.txtKlijentID.Name = "txtKlijentID";
            this.txtKlijentID.Size = new System.Drawing.Size(112, 21);
            this.txtKlijentID.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 675);
            this.Controls.Add(this.txtKlijentID);
            this.Controls.Add(this.lblOpisError);
            this.Controls.Add(this.lblServisError);
            this.Controls.Add(this.lblKlijentError);
            this.Controls.Add(this.lblDodatniKomentarError);
            this.Controls.Add(this.lblKontaktError);
            this.Controls.Add(this.lblRegistarskiError);
            this.Controls.Add(this.lblNazivError);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDSerisZaBrisanje);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.txtIDKlijentaZaBrisanje);
            this.Controls.Add(this.btnDeleteClientID);
            this.Controls.Add(this.dtDatumServisa);
            this.Controls.Add(this.txtOpisUsluge);
            this.Controls.Add(this.txtDodatniKomentar);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtRegistarskiBroj);
            this.Controls.Add(this.txtNazivKlijenta);
            this.Controls.Add(this.dgServisi);
            this.Controls.Add(this.dgKlijenti);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKlijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.DataGridView dgKlijenti;
        private System.Windows.Forms.DataGridView dgServisi;
        private System.Windows.Forms.TextBox txtNazivKlijenta;
        private System.Windows.Forms.TextBox txtRegistarskiBroj;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtDodatniKomentar;
        private System.Windows.Forms.TextBox txtOpisUsluge;
        private System.Windows.Forms.DateTimePicker dtDatumServisa;
        private System.Windows.Forms.TextBox txtIDKlijentaZaBrisanje;
        private System.Windows.Forms.Button btnDeleteClientID;
        private System.Windows.Forms.TextBox txtIDSerisZaBrisanje;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNazivError;
        private System.Windows.Forms.Label lblRegistarskiError;
        private System.Windows.Forms.Label lblKontaktError;
        private System.Windows.Forms.Label lblDodatniKomentarError;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivKlijentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registarskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatniKomentarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumServisaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisUslugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource servisBindingSource;
        private System.Windows.Forms.Label lblKlijentError;
        private System.Windows.Forms.Label lblServisError;
        private System.Windows.Forms.BindingSource klijentBindingSource1;
        private System.Windows.Forms.Label lblOpisError;
        private System.Windows.Forms.ComboBox txtKlijentID;
    }
}

