using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_Part_2
{
    public partial class ExamResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.Cookies["Email"].Value;
            string user = (Request.Cookies["Email"].Value).ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment2ConnectionString"].ConnectionString);
            string sqlquery = "select Quetions.Qid,Quetions.Quetion,Quetions.CorrectAns,Answers.email,Answers.YourAnswer from Quetions left join Answers on Quetions.Qid = Answers.Qid where Answers.email = @User";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.Parameters.AddWithValue("@User", user);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();


        }
    }
}