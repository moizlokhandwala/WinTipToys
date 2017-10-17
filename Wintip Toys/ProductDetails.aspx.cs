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
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public Product GetProduct([QueryString("productID")] int? productId )
        //{
        //    var _db = new ProductContext();
        //    var product = _db.Products.Where(p => p.ProductID == productId).FirstOrDefault();

        //    return product;
        //}

        public IQueryable<Product> GetProduct([QueryString("productID")] int? productId)
        {
            var _db = new ProductContext();
            IQueryable<Product> query = _db.Products;
            if (productId.HasValue && productId > 0)
            {
                query = query.Where(p => p.ProductID == productId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}