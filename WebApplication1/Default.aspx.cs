using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        Class1 c = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = c.show();
        }
    }
}
