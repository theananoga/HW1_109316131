using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW1_109316131
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void confirm_Click(object sender, EventArgs e)
        {
            Session["ID"] = tbId.Text;
            Session["NHI"] = tbNhi.Text;
            Server.Transfer("WebForm2.aspx");
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbNhi.Text = "";
        }
    }
}