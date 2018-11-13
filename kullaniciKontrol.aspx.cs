using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kullaniciKontrol : System.Web.UI.Page
{
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        Result r = new Result();
        try
        {
            string kullaniciKodu = Request.Form["ARACKODU"];
            string kullaniciSifre = Request.Form["Password"];
            SqlConnection cnn = new SqlConnection("Server=94.73.148.3;Database=McFlyRoothy;User=Hakan;Password=RootHy.11;");
            SqlCommand cmm = new SqlCommand("Select  kullaniciAdi from kullanici where kullaniciKodu='" + kullaniciKodu + "'and kullaniciSifre='" + kullaniciSifre + "'", cnn);
            cnn.Open();
            cmm.ExecuteNonQuery();
            dr = cmm.ExecuteReader();
            if (dr.Read() )
            {
                r.ARACPLAKA=dr[0].ToString();
            }
            else
            {
                r.ARACPLAKA = "false";
            }
            cnn.Close();
        }
        catch
        {
            r.ARACPLAKA = "false";
        }
        JavaScriptSerializer jsSeri = new JavaScriptSerializer();
        String strJson = jsSeri.Serialize(r);
        Response.Write(strJson);
    }
    public class Result
    {
        public String ARACPLAKA;
    }
    public class _post
    {
        public String kullaniciAdi { get; set; }
    }
}