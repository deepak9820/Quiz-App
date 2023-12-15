using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_Part_2
{
    public partial class QuetionPage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment2ConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Quetion,Opt1,Opt2,Opt3,Opt4,CorrectAns from Quetions where Qid=@id",con);
                cmd.Parameters.AddWithValue("@id",1);
                SqlDataReader da = cmd.ExecuteReader();
                while(da.Read())
                {
                   
                    Label2.Text = da.GetValue(0).ToString();
                    RadioButton1.Text = da.GetValue(1).ToString();
                    RadioButton2.Text = da.GetValue(2).ToString();
                    RadioButton3.Text = da.GetValue(3).ToString();
                    RadioButton4.Text = da.GetValue(4).ToString();

                }
                Session["count"] = 2;
                Session["count1"] = 1;
            }
        }
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment2ConnectionString"].ConnectionString);
            con.Open();
            //store answer in user database
            string answer = String.Empty;
            if (RadioButton1.Checked)
            {
                answer = (RadioButton1.Text).ToString();
            }
            else if (RadioButton2.Checked)
            {
                answer = (RadioButton2.Text).ToString();

            }
            else if (RadioButton3.Checked)
            {
                answer= (RadioButton3.Text).ToString();
            }
            else if (RadioButton4.Checked)
            {
                answer=(RadioButton4.Text).ToString();  
            }

            

           
            SqlCommand cd = new SqlCommand("insert into Answers values(@email,@ans,@qid)", con);
            cd.Parameters.AddWithValue("@email", Request.Cookies["Email"].Value);
            cd.Parameters.AddWithValue("@ans", answer);
            cd.Parameters.AddWithValue("@qid",(int)Session["count1"]);
            Session["count1"] = (int)Session["count1"] + 1;
            cd.ExecuteNonQuery();
            //proceed to next quetion
            if ((int)Session["count"] == 5)
            {
                Button1.Text = "Submit";
            }

            if((int)Session["count"] == 6)
            {
                Session.Abandon();
                Response.Redirect("ExamResult.aspx");
            }

            
            SqlCommand cmd = new SqlCommand("Select Quetion,Opt1,Opt2,Opt3,Opt4,CorrectAns from Quetions where Qid=@id", con);
            cmd.Parameters.AddWithValue("@id", (int)Session["count"]);
            Session["count"]=(int)Session["count"]+1;
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {

                Label2.Text = da.GetValue(0).ToString();
                RadioButton1.Text = da.GetValue(1).ToString();
                RadioButton2.Text = da.GetValue(2).ToString();
                RadioButton3.Text = da.GetValue(3).ToString();
                RadioButton4.Text = da.GetValue(4).ToString();

            }

            
        }
    }
}