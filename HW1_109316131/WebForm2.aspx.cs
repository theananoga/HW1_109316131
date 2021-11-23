using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW1_109316131
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {

                tbId.Text = Session["ID"].ToString();
                tbId.Enabled = false;
                tbNhi.Text = Session["NHI"].ToString();
                tbNhi.Enabled = false;


      
                string id = (string)Session["ID"];

                if (!Page.IsPostBack)
                {          
                    CompareValidator1.ValueToCompare ="<%= DateTime.Today.ToShortString() %>";

                    if (Request.Cookies[id] != null)
                    {
                        tbName.Text = Request.Cookies[id]["tbName"];
                        rblSex.SelectedValue = Request.Cookies[id]["rblSex"];
                        tbBirthdate.Text = Request.Cookies[id]["tbBirthdate"];
                        tbPhone.Text = Request.Cookies[id]["tbPhone"];
                        tbAddress.Text = Request.Cookies[id]["tbAddress"];
                        tbEmail.Text = Request.Cookies[id]["tbEmail"];

                    }
                    else
                    {
                        tbName.Text = "";
                        rblSex.Items.Clear();
                        tbBirthdate.Text = "";
                        tbPhone.Text = "";
                        tbAddress.Text = "";
                        tbEmail.Text = "";
                    }
                }


            }
            else
            {
                Response.Write("<script>alert('Session Expired!');</script>");
                Server.Transfer("WebForm1.aspx");
            }
        }


        protected void next_Click(object sender, EventArgs e)
        {
            //must isi data n pencet save
            string id = (string)Session["ID"];
            if (Request.Cookies[id]["tbName"] != null && Request.Cookies[id]["rblSex"] != null && Request.Cookies[id]["tbBirthdate"] != null && Request.Cookies[id]["tbPhone"] != null && Request.Cookies[id]["tbAddress"] != null && Request.Cookies[id]["tbEmail"] != null)
            {
                Server.Transfer("WebForm3.aspx");
            }
            else
            {
                Label1.Visible = true;
            }

        }

        protected void save_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                string id = (string)Session["ID"];


                Response.Cookies[id]["tbName"] = tbName.Text;
                Response.Cookies[id]["rblSex"] = rblSex.SelectedValue;
                Response.Cookies[id]["tbBirthdate"] = tbBirthdate.Text;
                Response.Cookies[id]["tbPhone"] = tbPhone.Text;
                Response.Cookies[id]["tbAddress"] = tbAddress.Text;
                Response.Cookies[id]["tbEmail"] = tbEmail.Text;

            }

            else
            {
                Response.Write("<script>alert('Session Expired!');</script>");
                Server.Transfer("WebForm1.aspx");
            }
        }
        //protected void CustomValidator1_ServerValidate1(object source, ServerValidateEventArgs args)
        //{
        //    CustomValidator1.IsValid = DateTime.ParseExact(tbBirthdate.Text, "dd/MM/yyyy");
        
        //}
    }
}