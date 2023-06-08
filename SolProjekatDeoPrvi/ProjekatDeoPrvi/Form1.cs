using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjekatDeoPrvi
{
    public partial class Form1 : Form
    {
        dbContextDataContext dbContextDataContext = new dbContextDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            RefreshGrid();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool Check_Length()
        {
            if (txtCompanyName.Text.Length <= 0)
            {
                lblCompany.Text = "Filed company name cannot be empty";
                return false;
            }
            if (txtContactName.Text.Length <= 0)
            {
                lblContact.Text = "Filed contact name cannot be empty";
                return false;
            }
            if (txtContactTitle.Text.Length <= 0)
            {
                lblTitle.Text = "Filed title name cannot be empty";
                return false;
            }
            if (txtAddress.Text.Length <= 0)
            {
                lblAddress.Text = "Filed address name cannot be empty";
                return false;
            }
            if (txtCity.Text.Length <= 0)
            {
                lblCity.Text = "Filed city name cannot be empty";
                return false;
            }
            if (txtRegion.Text.Length <= 0)
            {
                lblRegion.Text = "Filed region name cannot be empty";
                return false;
            }
            if (txtPostalCode.Text.Length <= 0)
            {
                lblPostal.Text = "Filed postal code name cannot be empty";
                return false;
            }
            if (txtCountry.Text.Length <= 0)
            {
                lblCountry.Text = "Filed country name cannot be empty";
                return false;
            }
            if (txtPhone.Text.Length <= 0)
            {
                lblPhone.Text = "Filed phone name cannot be empty";
                return false;
            }
            if (txtFax.Text.Length <= 0)
            {
                lblFax.Text = "Filed fax name cannot be empty";
                return false;
            }

            if (txtCompanyName.Text.Length >= 40)
            {
                lblCompany.Text = "Filed company name cannot be empty";
                return false;
            }
            if (txtContactName.Text.Length >= 30)
            {
                lblContact.Text = "Filed contact name cannot be empty";
                return false;
            }
            if (txtContactTitle.Text.Length >= 30)
            {
                lblTitle.Text = "Filed title name cannot be empty";
                return false;
            }
            if (txtAddress.Text.Length >= 60)
            {
                lblAddress.Text = "Filed address name cannot be empty";
                return false;
            }
            if (txtCity.Text.Length >= 15)
            {
                lblCity.Text = "Filed city name cannot be empty";
                return false;
            }
            if (txtRegion.Text.Length >= 15)
            {
                lblRegion.Text = "Filed region name cannot be empty";
                return false;
            }
            if (txtPostalCode.Text.Length >= 10)
            {
                lblPostal.Text = "Filed postal code name cannot be empty";
                return false;
            }
            if (txtCountry.Text.Length >= 10)
            {
                lblCountry.Text = "Filed country name cannot be empty";
                return false;
            }
            if (txtPhone.Text.Length >= 24)
            {
                lblPhone.Text = "Filed phone name cannot be empty";
                return false;
            }
            if (txtFax.Text.Length >= 24)
            {
                lblFax.Text = "Filed fax name cannot be empty";
                return false;
            }
            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool check = Check_Length();
            try
            {
                Supplier supplier = new Supplier
                {
                    companyname = txtCompanyName.Text.Trim(),
                    contactname = txtContactName.Text.Trim(),
                    contacttitle = txtContactTitle.Text.Trim(),
                    address = txtAddress.Text.Trim(),
                    city = txtCity.Text.Trim(),
                    region = txtRegion.Text.Trim(),
                    postalcode = txtPostalCode.Text.Trim(),
                    country = txtCountry.Text.Trim(),
                    phone = txtPhone.Text.Trim(),
                    fax = txtFax.Text.Trim()
                };

                if (check == true)
                {
                    dbContextDataContext.Suppliers.InsertOnSubmit(supplier);
                    MessageBox.Show("New supplier added!");
                    dbContextDataContext.SubmitChanges();

                    RefreshGrid();
                    ClearData();

                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Custom method for saving any changes
        private void RefreshGrid()
        {
            dbContextDataContext = null;
            dbContextDataContext = new dbContextDataContext();
            dgData.DataSource = null;
            dgData.DataSource = dbContextDataContext.Suppliers;

        }

        private void ClearData()
        {
            txtCompanyName.Text = "";
            txtContactName.Text = "";
            txtContactTitle.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtRegion.Text = "";
            txtPostalCode.Text = "";
            txtCountry.Text = "";
            txtPhone.Text = "";
            txtFax.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int supplierId = Convert.ToInt32(txtSupplierID.Text);

            Supplier supplierDelete = dbContextDataContext.Suppliers.SingleOrDefault(s => s.supplierid == supplierId);

            if (supplierDelete == null)
            {
                MessageBox.Show("Supplier does not exists! ");
                return;
            }
            try
            {
                dbContextDataContext.Suppliers.DeleteOnSubmit(supplierDelete);
                dbContextDataContext.SubmitChanges();
                RefreshGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(updSupplierID.Text);

            try
            {
                Supplier supplierChange = dbContextDataContext.Suppliers.SingleOrDefault(s => s.supplierid == supplierID);

                if (supplierChange == null)
                {
                    MessageBox.Show("Supplier does not exists");
                    return;
                }
                supplierChange.companyname = updtxtCompany.Text;
                supplierChange.contactname = updtxtContact.Text;
                supplierChange.contacttitle = updtxtTitle.Text;
                supplierChange.address = updtxtAddress.Text;
                supplierChange.city = updtxtCity.Text;
                supplierChange.region = updtxtRegion.Text;
                supplierChange.postalcode = updtxtPostal.Text;
                supplierChange.country = updtxtCountry.Text;
                supplierChange.phone = updtxtPhone.Text;
                supplierChange.fax = updtxtFax.Text;

                dbContextDataContext.SubmitChanges();

                RefreshGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnCityFilter_Click(object sender, EventArgs e)
        {
            FilterCity form = new FilterCity();

            this.Enabled = false;
            form.Show();


            form.FormClosed += (se, der) =>
            {
                this.Enabled = true;
            };
        }
    }
}
