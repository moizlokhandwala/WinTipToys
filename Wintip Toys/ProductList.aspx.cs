using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wintip_Toys.Models;

namespace Wintip_Toys
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            
            ProductContext _db = new ProductContext();
            IQueryable<Product> products = _db.Products;
            if(categoryId.HasValue && categoryId > 0)
            {
                products = products.Where(cat => cat.CategoryID == categoryId);
            }
            return products;
        }
    }
}