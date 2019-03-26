using FluentDataDemo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FluentDataDemo.Web
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Class1 dll = new Class1();
            var dyn = dll.Temp();
            Response.Write(dyn.ID);
            Response.Write("<br />");
            Response.Write(dyn.Name);
        }
    }
}