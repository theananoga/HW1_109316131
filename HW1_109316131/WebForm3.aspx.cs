using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW1_109316131
{
    public partial class WebForm3 : System.Web.UI.Page
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
                    if (Request.Cookies[id] != null)
                    {
                        tbHeight.Text = Request.Cookies[id]["tbHeight"];
                        tbWeight.Text = Request.Cookies[id]["tbWeight"];
                        tbSystolic.Text = Request.Cookies[id]["tbSystolic"];
                        tbDiastolic.Text = Request.Cookies[id]["tbDiastolic"];
                        rblFrequency.SelectedValue = Request.Cookies[id]["rblFrequency"];
                        tbDuration.Text = Request.Cookies[id]["tbDuration"];

                        ddlVaccine.SelectedValue = Request.Cookies[id]["ddlVaccine"];
                        ddlHospital.SelectedValue = Request.Cookies[id]["ddlHospital"];
                        ddlTime.SelectedValue = Request.Cookies[id]["ddTime"];

                    }
                    else
                    {
                        tbHeight.Text = "";
                        tbWeight.Text = "";
                        tbSystolic.Text = "";
                        tbDiastolic.Text = "";
                        rblFrequency.Items.Clear();
                        tbDuration.Text = "";

                        ddlVaccine.Items.Clear();
                        ddlHospital.Items.Clear();
                        ddlTime.Items.Clear();
                    }
                }


            }
            else
            {
                Response.Write("<script>alert('Session Expired!');</script>");
                Server.Transfer("WebForm1.aspx");
            }
        }

        protected void save_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {

                    string id = (string)Session["ID"];

                    Response.Cookies[id]["tbHeight"] = tbHeight.Text;
                    Response.Cookies[id]["tbWeight"] = tbWeight.Text;
                    Response.Cookies[id]["tbSystolic"] = tbSystolic.Text;
                    Response.Cookies[id]["tbDiastolic"] = tbDiastolic.Text;
                    Response.Cookies[id]["rblFrequency"] = rblFrequency.SelectedItem.Text;
                    Response.Cookies[id]["tbDuration"] = tbDuration.Text;

                    Response.Cookies[id]["ddlVaccine"] = ddlVaccine.SelectedItem.Text;
                    Response.Cookies[id]["ddlHospital"] = ddlHospital.SelectedItem.Text;
                    Response.Cookies[id]["ddTime"] = ddlTime.SelectedItem.Text;


            }
            else
            {
                Response.Write("<script>alert('Session Expired!');</script>");
                Server.Transfer("WebForm1.aspx");
            }
        }

        protected void ddlHospital_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlHospital.SelectedValue == "1")
            {
                ddlTime.Items.Add(new ListItem("==Choose Date and Time==", "0"));
                ddlTime.Items.Add(new ListItem("2021/11/26 09:00-10.00", "1"));
                ddlTime.Items.Add(new ListItem("2021/11/26 10:00-11.00", "2"));
                ddlTime.Items.Add(new ListItem("2021/11/26 13:00-14.00", "3"));
                ddlTime.Items.Add(new ListItem("2021/11/26 14:00-15.00", "4"));
                ddlTime.Items.Add(new ListItem("2021/11/27 09:00-10.00", "5"));
                ddlTime.Items.Add(new ListItem("2021/11/27 10:00-11.00", "6"));
                ddlTime.Items.Add(new ListItem("2021/11/27 13:00-14.00", "7"));
                ddlTime.Items.Add(new ListItem("2021/11/27 14:00-15.00", "8"));
                ddlTime.Items.Add(new ListItem("2021/11/28 09:00-10.00", "9"));
                ddlTime.Items.Add(new ListItem("2021/11/28 10:00-11.00", "10"));
                ddlTime.Items.Add(new ListItem("2021/11/28 13:00-14.00", "11"));
                ddlTime.Items.Add(new ListItem("2021/11/28 14:00-15.00", "12"));

                ddlTime.Visible = true;

            }
            else if (ddlHospital.SelectedValue == "2")
            {
                ddlTime.Items.Add(new ListItem("==Choose Date and Time==", "0"));
                ddlTime.Items.Add(new ListItem("2021/11/29 09:00-10.00", "1"));
                ddlTime.Items.Add(new ListItem("2021/11/29 10:00-11.00", "2"));
                ddlTime.Items.Add(new ListItem("2021/11/29 13:00-14.00", "3"));
                ddlTime.Items.Add(new ListItem("2021/11/29 14:00-15.00", "4"));
                ddlTime.Items.Add(new ListItem("2021/11/30 09:00-10.00", "5"));
                ddlTime.Items.Add(new ListItem("2021/11/30 10:00-11.00", "6"));
                ddlTime.Items.Add(new ListItem("2021/11/30 13:00-14.00", "7"));
                ddlTime.Items.Add(new ListItem("2021/11/30 14:00-15.00", "8"));
                ddlTime.Items.Add(new ListItem("2021/12/1 09:00-10.00", "9"));
                ddlTime.Items.Add(new ListItem("2021/12/1 10:00-11.00", "10"));
                ddlTime.Items.Add(new ListItem("2021/12/1 13:00-14.00", "11"));
                ddlTime.Items.Add(new ListItem("2021/12/1 14:00-15.00", "12"));

                ddlTime.Visible = true;
            }
            else if (ddlHospital.SelectedValue == "3")
            {
                ddlTime.Items.Add(new ListItem("==Choose Date and Time==", "0"));
                ddlTime.Items.Add(new ListItem("2021/12/2 09:00-10.00", "1"));
                ddlTime.Items.Add(new ListItem("2021/12/2 10:00-11.00", "2"));
                ddlTime.Items.Add(new ListItem("2021/12/2 13:00-14.00", "3"));
                ddlTime.Items.Add(new ListItem("2021/12/2 14:00-15.00", "4"));
                ddlTime.Items.Add(new ListItem("2021/12/3 09:00-10.00", "5"));
                ddlTime.Items.Add(new ListItem("2021/12/3 10:00-11.00", "6"));
                ddlTime.Items.Add(new ListItem("2021/12/3 13:00-14.00", "7"));
                ddlTime.Items.Add(new ListItem("2021/12/3 14:00-15.00", "8"));
                ddlTime.Items.Add(new ListItem("2021/12/4 09:00-10.00", "9"));
                ddlTime.Items.Add(new ListItem("2021/12/4 10:00-11.00", "10"));
                ddlTime.Items.Add(new ListItem("2021/12/4 13:00-14.00", "11"));
                ddlTime.Items.Add(new ListItem("2021/12/4 14:00-15.00", "12"));

                ddlTime.Visible = true;
            }
            else if (ddlHospital.SelectedValue == "4")
            {
                ddlTime.Items.Add(new ListItem("==Choose Date and Time==", "0"));
                ddlTime.Items.Add(new ListItem("2021/12/5 09:00-10.00", "1"));
                ddlTime.Items.Add(new ListItem("2021/12/5 10:00-11.00", "2"));
                ddlTime.Items.Add(new ListItem("2021/12/5 13:00-14.00", "3"));
                ddlTime.Items.Add(new ListItem("2021/12/5 14:00-15.00", "4"));
                ddlTime.Items.Add(new ListItem("2021/12/6 09:00-10.00", "5"));
                ddlTime.Items.Add(new ListItem("2021/12/6 10:00-11.00", "6"));
                ddlTime.Items.Add(new ListItem("2021/12/6 13:00-14.00", "7"));
                ddlTime.Items.Add(new ListItem("2021/12/6 14:00-15.00", "8"));
                ddlTime.Items.Add(new ListItem("2021/12/7 09:00-10.00", "9"));
                ddlTime.Items.Add(new ListItem("2021/12/7 10:00-11.00", "10"));
                ddlTime.Items.Add(new ListItem("2021/12/7 13:00-14.00", "11"));
                ddlTime.Items.Add(new ListItem("2021/12/7 14:00-15.00", "12"));

                ddlTime.Visible = true;
            }
            else if (ddlHospital.SelectedValue == "5")
            {
                ddlTime.Items.Add(new ListItem("==Choose Date and Time==", "0"));
                ddlTime.Items.Add(new ListItem("2021/12/8 09:00-10.00", "1"));
                ddlTime.Items.Add(new ListItem("2021/12/8 10:00-11.00", "2"));
                ddlTime.Items.Add(new ListItem("2021/12/8 13:00-14.00", "3"));
                ddlTime.Items.Add(new ListItem("2021/12/8 14:00-15.00", "4"));
                ddlTime.Items.Add(new ListItem("2021/12/9 09:00-10.00", "5"));
                ddlTime.Items.Add(new ListItem("2021/12/9 10:00-11.00", "6"));
                ddlTime.Items.Add(new ListItem("2021/12/9 13:00-14.00", "7"));
                ddlTime.Items.Add(new ListItem("2021/12/9 14:00-15.00", "8"));
                ddlTime.Items.Add(new ListItem("2021/12/10 09:00-10.00", "9"));
                ddlTime.Items.Add(new ListItem("2021/12/10 10:00-11.00", "10"));
                ddlTime.Items.Add(new ListItem("2021/12/10 13:00-14.00", "11"));
                ddlTime.Items.Add(new ListItem("2021/12/10 14:00-15.00", "12"));

                ddlTime.Visible = true;
            }
            else if (ddlHospital.SelectedValue == "6")
            {
                ddlTime.Items.Add(new ListItem("==Choose Date and Time==", "0"));
                ddlTime.Items.Add(new ListItem("2021/12/11 09:00-10.00", "1"));
                ddlTime.Items.Add(new ListItem("2021/12/11 10:00-11.00", "2"));
                ddlTime.Items.Add(new ListItem("2021/12/11 13:00-14.00", "3"));
                ddlTime.Items.Add(new ListItem("2021/12/11 14:00-15.00", "4"));
                ddlTime.Items.Add(new ListItem("2021/12/12 09:00-10.00", "5"));
                ddlTime.Items.Add(new ListItem("2021/12/12 10:00-11.00", "6"));
                ddlTime.Items.Add(new ListItem("2021/12/12 13:00-14.00", "7"));
                ddlTime.Items.Add(new ListItem("2021/12/12 14:00-15.00", "8"));
                ddlTime.Items.Add(new ListItem("2021/12/13 09:00-10.00", "9"));
                ddlTime.Items.Add(new ListItem("2021/12/13 10:00-11.00", "10"));
                ddlTime.Items.Add(new ListItem("2021/12/13 13:00-14.00", "11"));
                ddlTime.Items.Add(new ListItem("2021/12/13 14:00-15.00", "12"));

                ddlTime.Visible = true;
            }
            else if (ddlHospital.SelectedValue == "7")
            {
                ddlTime.Items.Add(new ListItem("==Choose Date and Time==", "0"));
                ddlTime.Items.Add(new ListItem("2021/12/14 09:00-10.00", "1"));
                ddlTime.Items.Add(new ListItem("2021/12/14 10:00-11.00", "2"));
                ddlTime.Items.Add(new ListItem("2021/12/14 13:00-14.00", "3"));
                ddlTime.Items.Add(new ListItem("2021/12/14 14:00-15.00", "4"));
                ddlTime.Items.Add(new ListItem("2021/12/15 09:00-10.00", "5"));
                ddlTime.Items.Add(new ListItem("2021/12/15 10:00-11.00", "6"));
                ddlTime.Items.Add(new ListItem("2021/12/15 13:00-14.00", "7"));
                ddlTime.Items.Add(new ListItem("2021/12/15 14:00-15.00", "8"));
                ddlTime.Items.Add(new ListItem("2021/12/16 09:00-10.00", "9"));
                ddlTime.Items.Add(new ListItem("2021/12/16 10:00-11.00", "10"));
                ddlTime.Items.Add(new ListItem("2021/12/16 13:00-14.00", "11"));
                ddlTime.Items.Add(new ListItem("2021/12/16 14:00-15.00", "12"));

                ddlTime.Visible = true;
            }
            else if (ddlHospital.SelectedValue == "8")
            {
                ddlTime.Items.Add(new ListItem("==Choose Date and Time==", "0"));
                ddlTime.Items.Add(new ListItem("2021/12/17 09:00-10.00", "1"));
                ddlTime.Items.Add(new ListItem("2021/12/17 10:00-11.00", "2"));
                ddlTime.Items.Add(new ListItem("2021/12/17 13:00-14.00", "3"));
                ddlTime.Items.Add(new ListItem("2021/12/17 14:00-15.00", "4"));
                ddlTime.Items.Add(new ListItem("2021/12/18 09:00-10.00", "5"));
                ddlTime.Items.Add(new ListItem("2021/12/18 10:00-11.00", "6"));
                ddlTime.Items.Add(new ListItem("2021/12/18 13:00-14.00", "7"));
                ddlTime.Items.Add(new ListItem("2021/12/18 14:00-15.00", "8"));
                ddlTime.Items.Add(new ListItem("2021/12/19 09:00-10.00", "9"));
                ddlTime.Items.Add(new ListItem("2021/12/19 10:00-11.00", "10"));
                ddlTime.Items.Add(new ListItem("2021/12/19 13:00-14.00", "11"));
                ddlTime.Items.Add(new ListItem("2021/12/19 14:00-15.00", "12"));

                ddlTime.Visible = true;
            }

        }

        protected void confirm_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm4.aspx");
        }

        protected void rblFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblFrequency.SelectedValue == "0")
            {
                tbDuration.Text = "0";
                tbDuration.Enabled = false;
            }
        }
    }
}
