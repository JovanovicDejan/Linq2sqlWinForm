using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjekatDeoPrvi
{
    public partial class FilterCity : Form
    {
        public FilterCity()
        {
            InitializeComponent();
        }

        dbContextDataContext dbContextDataContext = new dbContextDataContext();
        private void btnFilter_Click(object sender, EventArgs e)
        {
            var suppliers = from Supplier in dbContextDataContext.Suppliers where Supplier.city == txtFilter.Text orderby Supplier.companyname ascending select new { Supplier.companyname, Supplier.city };

            dgFilters.DataSource = suppliers;
        }
    }
}
