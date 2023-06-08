using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace ProjekatDeoDrugi
{
    public partial class Form1 : Form
    {
        DBModel baza = new DBModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int save = baza.SaveChanges();
                MessageBox.Show("Saved " + save.ToString() + " number of records");
            }
            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            baza.Dispose();
            baza = new DBModel();

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            dgKlijenti.DataSource = baza.klijents.ToList<Klijent>();
            dgServisi.DataSource = baza.servisis.ToList<Servis>();

            Cursor = Cursors.Default;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNazivKlijenta.Text.Trim()))
            {
                lblNazivError.Text = "Naziv klijenta is required field!";
                return;
            }
            else
            {
                lblNazivError.Text = "";
            }
            if (string.IsNullOrEmpty(txtRegistarskiBroj.Text.Trim()))
            {
                lblRegistarskiError.Text = "Naziv klijenta is required field!";
                return;
            }
            else
            {
                lblRegistarskiError.Text = "";
            }
            if (string.IsNullOrEmpty(txtKontakt.Text.Trim()))
            {
                lblKontaktError.Text = "Naziv klijenta is required field!";
                return;
            }
            else
            {
                lblNazivError.Text = "";
            }
            Klijent klijent = new Klijent
            {
                NazivKlijenta = txtNazivKlijenta.Text.Trim(),
                RegistarskiBroj = txtRegistarskiBroj.Text.Trim(),
                Kontakt = txtKontakt.Text.Trim(),
                DodatniKomentar = txtDodatniKomentar.Text.Trim()
            };
            try
            {
                baza.klijents.Add(klijent);
                baza.SaveChanges();
                btnGetData_Click(null, null);
                ShowList();
                ClearForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        //Button for update client
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                int KlijentID = Convert.ToInt32(dgKlijenti.SelectedRows[0].Cells[0].Value);

                Klijent updKlijent = baza.klijents.Find(KlijentID);

                if (updKlijent == null)
                {
                    MessageBox.Show("Selected client does not exists");
                    return;
                }

                if (!string.IsNullOrEmpty(txtNazivKlijenta.Text.Trim()))
                {
                    updKlijent.NazivKlijenta = txtNazivKlijenta.Text.Trim();
                }
                if (!string.IsNullOrEmpty(txtRegistarskiBroj.Text.Trim()))
                {
                    updKlijent.RegistarskiBroj = txtRegistarskiBroj.Text.Trim();
                }
                if (!string.IsNullOrEmpty(txtKontakt.Text.Trim()))
                {
                    updKlijent.Kontakt = txtKontakt.Text.Trim();
                }
                if (!string.IsNullOrEmpty(txtDodatniKomentar.Text.Trim()))
                {
                    updKlijent.DodatniKomentar = txtDodatniKomentar.Text.Trim();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Selected client does not exists, you must select whole row!");
                return;
            }

            try
            {
                baza.klijents.AddOrUpdate();
                baza.SaveChanges();
                btnGetData_Click(null, null);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Button for delete client by id
        private void btnDeleteClientID_Click(object sender, EventArgs e)
        {
            int KlijentID = Convert.ToInt32(txtIDKlijentaZaBrisanje.Text);

            Klijent updKlijent = baza.klijents.SingleOrDefault(k => k.KlijentID == KlijentID);

            if (updKlijent == null)
            {
                MessageBox.Show("Klijent sa izabranim ID-jem ne postoiji");
                return;
            }
            try
            {
                baza.klijents.Remove(updKlijent);
                MessageBox.Show("Klijent sa id-jem " + KlijentID + " je uspesno obrisan");
                baza.SaveChanges();
                btnGetData_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Create custom fuction to clear whole form
        private void ClearForm()
        {
            txtNazivKlijenta.Text = null;
            txtRegistarskiBroj.Text = null;
            txtKontakt.Text = null;
            txtDodatniKomentar.Text = null;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }



        //Definition for Services CRUD operations
        private void btnAddService_Click(object sender, EventArgs e)
        {

            //Validations 
            if (string.IsNullOrEmpty(txtKlijentID.Text.Trim()))
            {
                lblKlijentError.Text = "Klijent ID is required field";
                return;
            }
            if (string.IsNullOrEmpty(dtDatumServisa.Text.Trim()))
            {
                lblServisError.Text = "Date is required field!";
                return;
            }

            if (string.IsNullOrEmpty(txtOpisUsluge.Text.Trim()))
            {
                lblOpisError.Text = "Description is required!";
                return;
            }

            int klijentCheck = Convert.ToInt32(txtKlijentID.Text);

            Klijent klijentId = baza.klijents.Find(klijentCheck);

            if (klijentId is null)
            {
                MessageBox.Show("Klijent does not exists");
                return;
            }


            //Instance of service object
            Servis servis = new Servis
            {
                KlijentID = Convert.ToInt32(txtKlijentID.Text.Trim()),
                DatumServisa = Convert.ToDateTime(dtDatumServisa.Text.Trim()),
                OpisUsluge = txtOpisUsluge.Text.Trim()
            };


            //Adding to database
            try
            {
                baza.servisis.Add(servis);
                baza.SaveChanges();
                ClearServicesForm();

                //Need to change this code
                btnGetData_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            try
            {
                int servisID = Convert.ToInt32(dgServisi.SelectedRows[0].Cells[0].Value);

                int klijentID = Convert.ToInt32(txtKlijentID.Text);

                var checkKlijent = baza.klijents.Find(klijentID);

                if (checkKlijent is null)
                {
                    MessageBox.Show("Selected client does not exists!");
                    return;
                }

                Servis servis = baza.servisis.Find(servisID);

                if (servis == null)
                {
                    MessageBox.Show("Selected servise does not exists");
                    return;
                }

                if (!string.IsNullOrEmpty(txtKlijentID.Text.Trim()))
                {
                    servis.KlijentID = Convert.ToInt32(txtKlijentID.Text.Trim());
                }
                if (!string.IsNullOrEmpty(dtDatumServisa.Text.Trim()))
                {
                    servis.DatumServisa = Convert.ToDateTime(dtDatumServisa.Text.Trim());
                }
                if (!string.IsNullOrEmpty(txtOpisUsluge.Text))
                {
                    servis.OpisUsluge = txtOpisUsluge.Text.Trim();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Selected service does not exists, you must select whole row!");
                return;
            }

            try
            {
                baza.servisis.AddOrUpdate();
                baza.SaveChanges();
                btnGetData_Click(null, null);
                ClearForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            int DelServices = Convert.ToInt32(txtIDSerisZaBrisanje.Text);

            Servis servis = baza.servisis.SingleOrDefault(s => s.ServisID == DelServices);

            if (servis is null)
            {
                MessageBox.Show("Service with that ID does not exists!");
                return;
            }

            try
            {
                baza.servisis.Remove(servis);
                baza.SaveChanges();
                btnGetData_Click(null, null);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ClearServicesForm()
        {
            txtKlijentID.Text = null;
            dtDatumServisa.Text = null;
            txtOpisUsluge.Text = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowList();
        }
        private void ShowList()
        {
            txtKlijentID.DataSource = baza.klijents.ToList();
            txtKlijentID.DisplayMember = "KlijentID";
            txtKlijentID.Invalidate();
        }
    }
}
