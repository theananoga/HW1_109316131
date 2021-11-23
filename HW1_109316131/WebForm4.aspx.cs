using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW1_109316131
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double height = 0, weight = 0, bmi = 0;
            int age = 0, systolic = 0, diastolic = 0, frequency = 0, duration = 0 ;

            if (Session["ID"] != null)
            {
                string id = (String)Session["ID"];

                result.Text += "Name : " + Request.Cookies[id]["tbName"] + "<br>";
                result.Text += "ID Number : " + Session["ID"].ToString() + "<br>";
                result.Text += "NHI Number : " + Session["NHI"].ToString() + "<br>";
                result.Text += "Sex : " + Request.Cookies[id]["rblSex"] + "<br>";
                result.Text += "Birthdate : " + Request.Cookies[id]["tbBirthdate"] + "<br>";
                result.Text += "Phone Number : " + Request.Cookies[id]["tbPhone"] + "<br>";


                result.Text += "Height : " + Request.Cookies[id]["tbHeight"] + " CM<br>";
                result.Text += "Weight : " + Request.Cookies[id]["tbWeight"] + " KG<br>";

                height = Convert.ToDouble(Request.Cookies[id]["tbHeight"]);
                weight = Convert.ToDouble(Request.Cookies[id]["tbWeight"]);

                height = height / 100;

                bmi = weight / (height * height);

                if (bmi >= 24)
                {
                    result.Text += "BMI : " + Math.Round(bmi,2) + " You are overweight<br>";
                }
                else if (bmi < 18.5)
                {
                    result.Text += "BMI : " + Math.Round(bmi, 2) + " You are underweight<br>";
                }
                else
                {
                    result.Text += "BMI : " + Math.Round(bmi, 2) + " Normal<br>";
                }


                result.Text += "Systolic : " + Request.Cookies[id]["tbSystolic"] + "<br>";
                result.Text += "Diastolic : " + Request.Cookies[id]["tbDiastolic"] + "<br>";

                age = Convert.ToInt32(Request.Cookies[id]["tbBirthdate"]);
                systolic = Convert.ToInt32(Request.Cookies[id]["tbSystolic"]);
                diastolic = Convert.ToInt32(Request.Cookies[id]["tbDiastolic"]);

                if (age >= 65)
                {
                    if (systolic > 130 && diastolic > 90)
                    {
                        result.Text += "Warning! high blood pressure<br>";
                    }
                    else
                    {
                        result.Text += "No high blood pressure<br>";
                    }
                }
                else if(age>0 && age < 65)
                {
                    if (systolic > 120 && diastolic > 80)
                    {
                        result.Text += "Warning! high blood pressure<br>";
                    }
                    else
                    {
                        result.Text += "No high blood pressure<br>";
                    }
                }

                result.Text += "Exercise Frequency : " + Request.Cookies[id]["rblFrequency"].ToString() + "<br>";
                result.Text += "Exercise Duration : " + Request.Cookies[id]["tbDuration"].ToString() + "<br>";
                frequency = Convert.ToInt32(Request.Cookies[id]["rblFrequency"]);
                duration = Convert.ToInt32(Request.Cookies[id]["tbDuration"]);

                if (age >= 65)
                {
                    if ((frequency>0&&frequency<2)&&duration<30)
                    {
                        result.Text += "Too little exercise<br>";
                    }
                    else if (frequency >= 2 && duration >= 30)
                    {
                        result.Text += "Enough exercise<br>";
                    }
                } 
                else if(age>0 && age < 65)
                {
                    if ((frequency > 0 && frequency < 3) && duration < 50)
                    {
                        result.Text += "Too little exercise<br>";
                    }
                    else if (frequency >= 3 && duration >= 50)
                    {
                        result.Text += "Enough exercise<br>";
                    }
                }


                reservation.Text += "Type of Vaccine : " + Request.Cookies[id]["ddlVaccine"] + "<br>";
                reservation.Text += "Hospital : " + Request.Cookies[id]["ddlHospital"] + "<br>";
                reservation.Text += "Date and Time : " + Request.Cookies[id]["ddTime"] + "<br>";


            }

            else
            {
                Response.Write("<script>alert('Session Expired!');</script>");
                Server.Transfer("WebForm1.aspx");
            }
        }
    }
}