using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string myname = Request.Form["first_name_txt"];
        Label1.Text = myname;
        /*
        string n = String.Format("{0}", Request.Form["text1"]);
         Label1.Text = n;


         SqlConnection baglan = new SqlConnection();

         baglan.ConnectionString = "Server = 94.73.148.3; Database = McFlyRoothy; User = Hakan; Password = RootHy.11";

         baglan.Open();



         SqlCommand com = new SqlCommand("Select * from web_kullanici where kadi='" + TextBox2.Text + "'and sifre='" + TextBox1.Text + "'", baglan);

         SqlDataReader dr = com.ExecuteReader();
         string kadi = text1.value;
         string sifre = text2.value;


         if (dr.Read())

         {
             Session.Add("kadi", kadi);
             Session.Add("sifre", sifre);
             Page.Response.Redirect("~/index.aspx");



         }
         else
         {
             Page.Response.Redirect("~/login.aspx");
         }
         */
    }
}