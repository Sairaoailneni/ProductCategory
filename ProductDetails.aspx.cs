using ProductCategory.Models;
using ProductCategory.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductCategory
{
    public partial class ProductDetails : System.Web.UI.Page
    {

        ProductDetailsRepository productDetailsRepository = new ProductDetailsRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadData();

            }

        }


        private void LoadData()
        {

            gvProductDetails.DataSource = productDetailsRepository.GetData();
            gvProductDetails.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ProductDetail product = new ProductDetail();
           // product.Id = Convert.ToInt32(txtProductId.Text);
            product.Product = txtProduct.Text;
            product.Category = ddlCategory.SelectedValue.ToString();
            product.Mrp = Convert.ToInt32(txtPrice.Text);
            product.Tax = Convert.ToInt32(txtTax.Text);
            product.TaxType = txtInclusive.Text;
            product.TaxType = txtExclusive.Text;
            product.IsActive = chkIsActive.Checked;
            string result = productDetailsRepository.AddData(product);

            LoadData();

        }
    }
}