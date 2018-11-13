using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

public partial class alınan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Result r = new Result();
        try
        {
            /*
            string tahTarih = "09:45";
            DateTime tahTarih1 = DateTime.Now;
            string tahTarih = tahTarih1.ToString("HH:mm");
            string tahTarih = DateTime.Now.ToLongTimeString();
            string fisNo = Request.Form["FISNO"];
            string odemeTipi1 = Request.Form["ODEMETIPI1"];
            string odemeTipi2 = Request.Form["ODEMETIPI2"];
            string odemeTutari1 = Request.Form["TUTAR1"];
            string odemeTutari2 = Request.Form["TUTAR2"];
            */
            string[] fisNo = Request.Form.GetValues("FISNO");
            string[] odemeTipi1 = Request.Form.GetValues("ODEMETIPI1");
            string[] odemeTipi2 = Request.Form.GetValues("ODEMETIPI2");
            string[] odemeTutari1 = Request.Form.GetValues("ODEMETUTAR1");
            string[] odemeTutari2 = Request.Form.GetValues("ODEMETUTAR2");
            DateTime tahTarih = DateTime.Now;

            SqlConnection cnn = new SqlConnection("Server=94.73.148.3;Database=McFlyRoothy;User=Hakan;Password=RootHy.11;");
            cnn.Open();
            for (int i = 0; i < fisNo.Length; i++)
            {
                SqlCommand cmm = new SqlCommand("UpDate  Fatura  SET odemeTipi1='" + odemeTipi1[i] + "', odemeTutari1= '" + odemeTutari1[i].Replace(",",".") + "', odemeTipi2='" + odemeTipi2[i] + "', odemeTutari2='" + odemeTutari2[i].Replace(",", ".") + "', tahTarih='" + tahTarih + "' WHERE fisNo='" + fisNo[i] + "'", cnn);
                cmm.ExecuteNonQuery();
            }
            cnn.Close();
            r.result = "true";
        }
        catch
        {
            r.result = "false";
        }
        JavaScriptSerializer jsSeri = new JavaScriptSerializer();
        String strJson = jsSeri.Serialize(r);
        Response.Write(strJson);
    }
    public class Result
    {
        public String result;
    }
}