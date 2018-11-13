using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kullanici : System.Web.UI.Page
{

    SqlConnection cnn = new SqlConnection("Server=94.73.148.3;Database=McFlyRoothy;User=Hakan;Password=RootHy.11;");

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmm= new SqlCommand("Select * from kullanici ", cnn);
        SqlDataReader dr;
        cnn.Open();
        dr = cmm.ExecuteReader();
        //GridView1.DataSource = dr;
        //GridView1.DataBind();
        //cnn.Close();
        //cnn.Dispose();
        User u = new User();
        List<clsKullanici> lstKullanicilar = new List<clsKullanici>(); 

        while (dr.Read())
        {
            clsKullanici kullanici = new clsKullanici();
            kullanici.kullaniciKodu = (dr["kullaniciKodu"].ToString());
            kullanici.kullaniciAdi = (dr["kullaniciAdi"].ToString());
            kullanici.kullaniciSifre = (dr["kullaniciSifre"].ToString());
          
            lstKullanicilar.Add(kullanici);
            u.Users = lstKullanicilar;

        }
        JavaScriptSerializer jsSeri = new JavaScriptSerializer();
        String strJson = jsSeri.Serialize(u);
        Response.Write(strJson);

    }
         public class User

    {
        public IList<clsKullanici> Users { get; set; }
    }

    public class clsKullanici
    {
        public String kullaniciKodu { get; set; }
        public String kullaniciAdi { get; set; }
        public String kullaniciSifre { get; set; }

    }



}