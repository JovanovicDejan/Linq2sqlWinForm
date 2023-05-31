namespace ProjekatDeoPrvi
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.updtxtPhone = new System.Windows.Forms.TextBox();
            this.updtxtFax = new System.Windows.Forms.TextBox();
            this.updtxtRegion = new System.Windows.Forms.TextBox();
            this.updtxtPostal = new System.Windows.Forms.TextBox();
            this.updtxtCountry = new System.Windows.Forms.TextBox();
            this.updtxtCity = new System.Windows.Forms.TextBox();
            this.updtxtContact = new System.Windows.Forms.TextBox();
            this.updtxtTitle = new System.Windows.Forms.TextBox();
            this.updtxtAddress = new System.Windows.Forms.TextBox();
            this.updtxtCompany = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.updSupplierID = new System.Windows.Forms.TextBox();
            this.btnCityFilter = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Navy;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoad.Location = new System.Drawing.Point(125, 338);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(207, 62);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Get Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgData.Location = new System.Drawing.Point(21, 12);
            this.dgData.Name = "dgData";
            this.dgData.ReadOnly = true;
            this.dgData.Size = new System.Drawing.Size(473, 309);
            this.dgData.TabIndex = 1;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(615, 120);
            this.txtCompanyName.MaxLength = 40;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(615, 259);
            this.txtAddress.MaxLength = 60;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(615, 215);
            this.txtContactTitle.MaxLength = 30;
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(100, 20);
            this.txtContactTitle.TabIndex = 3;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(615, 165);
            this.txtContactName.MaxLength = 30;
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(100, 20);
            this.txtContactName.TabIndex = 2;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(865, 120);
            this.txtRegion.MaxLength = 15;
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(100, 20);
            this.txtRegion.TabIndex = 6;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(865, 165);
            this.txtPostalCode.MaxLength = 10;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 7;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(865, 215);
            this.txtCountry.MaxLength = 15;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(615, 309);
            this.txtCity.MaxLength = 15;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(865, 259);
            this.txtPhone.MaxLength = 24;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(865, 309);
            this.txtFax.MaxLength = 24;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Company name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Contact name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Title :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Address: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "City : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fax :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Phone :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(774, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Country :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(774, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Postal code : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(774, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Region: ";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Green;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInsert.Location = new System.Drawing.Point(650, 369);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(221, 67);
            this.btnInsert.TabIndex = 28;
            this.btnInsert.Text = "Insert Supplier";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(96, 449);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 63);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete supplier By ID";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 539);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "SupplierID :";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(195, 536);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierID.TabIndex = 22;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(1171, 369);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(207, 67);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Update Supplier";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1282, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Fax :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1282, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Phone :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1282, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Country :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1282, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Postal code : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1282, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Region: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1021, 316);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "City : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1021, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Address: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1021, 218);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Title :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1021, 168);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Contact name:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1021, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Company name:";
            // 
            // updtxtPhone
            // 
            this.updtxtPhone.Location = new System.Drawing.Point(1373, 259);
            this.updtxtPhone.MaxLength = 24;
            this.updtxtPhone.Name = "updtxtPhone";
            this.updtxtPhone.Size = new System.Drawing.Size(100, 20);
            this.updtxtPhone.TabIndex = 19;
            // 
            // updtxtFax
            // 
            this.updtxtFax.Location = new System.Drawing.Point(1373, 309);
            this.updtxtFax.MaxLength = 24;
            this.updtxtFax.Name = "updtxtFax";
            this.updtxtFax.Size = new System.Drawing.Size(100, 20);
            this.updtxtFax.TabIndex = 20;
            // 
            // updtxtRegion
            // 
            this.updtxtRegion.Location = new System.Drawing.Point(1373, 120);
            this.updtxtRegion.MaxLength = 15;
            this.updtxtRegion.Name = "updtxtRegion";
            this.updtxtRegion.Size = new System.Drawing.Size(100, 20);
            this.updtxtRegion.TabIndex = 16;
            // 
            // updtxtPostal
            // 
            this.updtxtPostal.Location = new System.Drawing.Point(1373, 165);
            this.updtxtPostal.MaxLength = 10;
            this.updtxtPostal.Name = "updtxtPostal";
            this.updtxtPostal.Size = new System.Drawing.Size(100, 20);
            this.updtxtPostal.TabIndex = 17;
            // 
            // updtxtCountry
            // 
            this.updtxtCountry.Location = new System.Drawing.Point(1373, 215);
            this.updtxtCountry.MaxLength = 15;
            this.updtxtCountry.Name = "updtxtCountry";
            this.updtxtCountry.Size = new System.Drawing.Size(100, 20);
            this.updtxtCountry.TabIndex = 18;
            // 
            // updtxtCity
            // 
            this.updtxtCity.Location = new System.Drawing.Point(1123, 309);
            this.updtxtCity.MaxLength = 15;
            this.updtxtCity.Name = "updtxtCity";
            this.updtxtCity.Size = new System.Drawing.Size(100, 20);
            this.updtxtCity.TabIndex = 15;
            // 
            // updtxtContact
            // 
            this.updtxtContact.Location = new System.Drawing.Point(1123, 165);
            this.updtxtContact.MaxLength = 30;
            this.updtxtContact.Name = "updtxtContact";
            this.updtxtContact.Size = new System.Drawing.Size(100, 20);
            this.updtxtContact.TabIndex = 12;
            // 
            // updtxtTitle
            // 
            this.updtxtTitle.Location = new System.Drawing.Point(1123, 215);
            this.updtxtTitle.MaxLength = 30;
            this.updtxtTitle.Name = "updtxtTitle";
            this.updtxtTitle.Size = new System.Drawing.Size(100, 20);
            this.updtxtTitle.TabIndex = 13;
            // 
            // updtxtAddress
            // 
            this.updtxtAddress.Location = new System.Drawing.Point(1123, 259);
            this.updtxtAddress.MaxLength = 60;
            this.updtxtAddress.Name = "updtxtAddress";
            this.updtxtAddress.Size = new System.Drawing.Size(100, 20);
            this.updtxtAddress.TabIndex = 14;
            // 
            // updtxtCompany
            // 
            this.updtxtCompany.Location = new System.Drawing.Point(1123, 120);
            this.updtxtCompany.MaxLength = 40;
            this.updtxtCompany.Name = "updtxtCompany";
            this.updtxtCompany.Size = new System.Drawing.Size(100, 20);
            this.updtxtCompany.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(561, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(348, 42);
            this.label22.TabIndex = 53;
            this.label22.Text = "INSERT SUPPLIER";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1112, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(364, 42);
            this.label23.TabIndex = 54;
            this.label23.Text = "UPDATE SUPPLIER";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1168, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 13);
            this.label24.TabIndex = 56;
            this.label24.Text = "Supplier ID :";
            // 
            // updSupplierID
            // 
            this.updSupplierID.Location = new System.Drawing.Point(1270, 70);
            this.updSupplierID.Name = "updSupplierID";
            this.updSupplierID.Size = new System.Drawing.Size(100, 20);
            this.updSupplierID.TabIndex = 21;
            // 
            // btnCityFilter
            // 
            this.btnCityFilter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCityFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCityFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCityFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCityFilter.Location = new System.Drawing.Point(917, 486);
            this.btnCityFilter.Name = "btnCityFilter";
            this.btnCityFilter.Size = new System.Drawing.Size(235, 66);
            this.btnCityFilter.TabIndex = 57;
            this.btnCityFilter.Text = "Search by Filter";
            this.btnCityFilter.UseVisualStyleBackColor = false;
            this.btnCityFilter.Click += new System.EventHandler(this.btnCityFilter_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(647, 143);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(0, 13);
            this.lblCompany.TabIndex = 58;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(647, 188);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(0, 13);
            this.lblContact.TabIndex = 59;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(647, 238);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 13);
            this.lblTitle.TabIndex = 60;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(647, 282);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 13);
            this.lblAddress.TabIndex = 61;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(647, 332);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(0, 13);
            this.lblCity.TabIndex = 62;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(894, 332);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(0, 13);
            this.lblFax.TabIndex = 67;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(894, 282);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 13);
            this.lblPhone.TabIndex = 66;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(894, 238);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(0, 13);
            this.lblCountry.TabIndex = 65;
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Location = new System.Drawing.Point(894, 188);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(0, 13);
            this.lblPostal.TabIndex = 64;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(894, 143);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(0, 13);
            this.lblRegion.TabIndex = 63;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 594);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.btnCityFilter);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.updSupplierID);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.updtxtPhone);
            this.Controls.Add(this.updtxtFax);
            this.Controls.Add(this.updtxtRegion);
            this.Controls.Add(this.updtxtPostal);
            this.Controls.Add(this.updtxtCountry);
            this.Controls.Add(this.updtxtCity);
            this.Controls.Add(this.updtxtContact);
            this.Controls.Add(this.updtxtTitle);
            this.Controls.Add(this.updtxtAddress);
            this.Controls.Add(this.updtxtCompany);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.txtContactTitle);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox updtxtPhone;
        private System.Windows.Forms.TextBox updtxtFax;
        private System.Windows.Forms.TextBox updtxtRegion;
        private System.Windows.Forms.TextBox updtxtPostal;
        private System.Windows.Forms.TextBox updtxtCountry;
        private System.Windows.Forms.TextBox updtxtCity;
        private System.Windows.Forms.TextBox updtxtContact;
        private System.Windows.Forms.TextBox updtxtTitle;
        private System.Windows.Forms.TextBox updtxtAddress;
        private System.Windows.Forms.TextBox updtxtCompany;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox updSupplierID;
        private System.Windows.Forms.Button btnCityFilter;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Label lblRegion;
    }
}

