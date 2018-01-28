using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KnockKnockSwaggerApI.Controllers;

namespace KnockKnockSwaggerApI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var ctrl = new FibonacciController();
            var fibnaci = ctrl.Fibonacci(int.Parse(txtno.Text));
            Response.Write(fibnaci);
        }
    }
}