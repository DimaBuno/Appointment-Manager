using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacebookShop
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public object FbShopWeb { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //clientDBDataContext db = new clientDBDataContext();

            //client tebl = new client
            //{
            //    Name = TextBox1.Text,
            //    Email = TextBox2.Text,
            //    Telephone = TextBox3.Text
            //};

            SqlDataSource1.Insert();

            //db.InsertOnSubmit(tebl);

            //db.SubmitChanges();

            Response.Redirect("/FbShopWeb.aspx");

        }
    }
}