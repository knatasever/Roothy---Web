using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class urunler : System.Web.UI.Page
{
    SqlConnection cnn = new SqlConnection("Server=94.73.148.3;Database=McFlyRoothy;User=Hakan;Password=RootHy.11;");

    protected void Page_Load(object sender, EventArgs e)
    {
        /*  SqlCommand cmm = new SqlCommand("Select * from urun ", cnn);
       SqlDataReader dr;
       cnn.Open();
       dr = cmm.ExecuteReader();
       GridView1.DataSource = dr;
       GridView1.DataBind();
       cnn.Close();
       cnn.Dispose();
       */


    }
}