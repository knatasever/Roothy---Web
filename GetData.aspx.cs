using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

public partial class AlınanHakan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ARACKODU = Request.Form["ARACKODU"];/*.QueryString*/
        //string SevkID = Request.QueryString["SevkID"];
        //SevkID = "BEH1";
        //string ARACKODU = "003";
        SqlConnection cnn = new SqlConnection("Server=94.73.148.3;Database=McFlyRoothy;User=Hakan;Password=RootHy.11;");
        
        SqlCommand cmm = new SqlCommand("SELECT  fa.musKodu,fa.musAdi, mu.adres, fa.fisNo, fa.preselKodu,fa.dagiticiKodu,fa.odemeTipi1,fa.odemeTipi2,fa.odemeTutari1,fa.odemeTutari2,fa.toplamNet,fa.aracKodu,fa.aracPlaka,fa.sevkNo FROM Musteri mu  inner JOIN Fatura fa  ON mu.Adi=fa.musAdi and mu.kodu=fa.musKodu WHERE fa.aracKodu=" + ARACKODU + " ORDER BY fa.fisNo", cnn);
        
        // fisNoya göre sıralamayı unutma 
        SqlDataReader dr;
        cnn.Open();
        dr = cmm.ExecuteReader();
        //GridView1.DataSource = dr;
        //GridView1.DataBind();
        Bill u = new Bill();
        List<clsFaturalar> lstFaturalar = new List<clsFaturalar>();

        while (dr.Read())

        {

                                     //  !!!!! adres çekilecek unutma

            clsFaturalar uye1 = new clsFaturalar();
            uye1.sevkNo= (dr["sevkNo"].ToString());
            uye1.aracPlaka = (dr["aracPlaka"].ToString());
            uye1.fisNo = (dr["fisNo"].ToString());
            uye1.musKodu = (dr["musKodu"].ToString());
            uye1.musAdi = (dr["musAdi"].ToString());
            uye1.adres = (dr["adres"].ToString());
            uye1.preselKodu = (dr["preselKodu"].ToString());
            uye1.aracKodu = (dr["aracKodu"].ToString());
           
            uye1.odemeTipi1 = (dr["odemeTipi1"].ToString());
            uye1.odemeTipi2 = (dr["odemeTipi2"].ToString());
            uye1.odemeTutari1 = (dr["odemeTutari1"].ToString());
            uye1.odemeTutari2 = (dr["odemeTutari2"].ToString());
            uye1.toplamNet = (dr["toplamNet"].ToString());
            lstFaturalar.Add(uye1);
            u.Bills = lstFaturalar;

            //trial[i] = new clsFaturalar();
            //trial[i].sevkNo = dr["sevkNo"].ToString();
            //trial[i].FisNo = dr["fisNo"].ToString();
            //trial[i].MusKodu = dr["musKodu"].ToString();
            //trial[i].OdemeTipi = dr["odemeTipi"].ToString();
            //trial[i].OdemeTutari1 = dr["odemeTutari1"].ToString();
            //i++;
        }
        JavaScriptSerializer jsSeri = new JavaScriptSerializer();
        String strJson = jsSeri.Serialize(u);
        Response.Write(strJson);
    }
    public class Bill
    {
        public IList<clsFaturalar> Bills{ get; set; }
    }
    public class clsFaturalar
    {
        public String fisNo { get; set; }
        public String musKodu { get; set; }
        public String musAdi { get; set; }
        public String adres { get; set; }
        public String odemeTipi1 { get; set; }
        public String odemeTutari1 { get; set; }
        public String odemeTipi2 { get; set; }
        public String odemeTutari2 { get; set; }
        public String toplamNet { get; set; }
        public String preselKodu { get; set; }
        public String aracKodu{ get; set; }

    public String aracPlaka { get; set; }
        public String sevkNo { get; set; }






    }








    //public void fnUyeler()
    //{
    //    List<clsUyeler> lstUyeler = new List<clsUyeler>();

    //    clsUyeler uye1 = new clsUyeler();
    //    uye1.kullanici_ID = 1;
    //    uye1.kullanici_adi = "ontedi";
    //    uye1.e_posta = "deneme@deneme.com";
    //    uye1.adi = "Serkan";
    //    uye1.soyadi = "TOGAL";
    //    uye1.dogum_tarihi = "1985-23-02";
    //    lstUyeler.Add(uye1);

    //    clsUyeler uye2 = new clsUyeler();
    //    uye2.kullanici_ID = 2;
    //    uye2.kullanici_adi = "ahmet";
    //    uye2.e_posta = "ahmet@ahmet.com";
    //    uye2.adi = "Ahmet";
    //    uye2.soyadi = "BÜYÜK";
    //    uye2.dogum_tarihi = "1985-11-11";
    //    lstUyeler.Add(uye2);

    //    clsUyeler uye3 = new clsUyeler();
    //    uye3.kullanici_ID = 3;
    //    uye3.kullanici_adi = "kullanici_adi_yok";
    //    uye3.e_posta = "isimsiz@cu.edu.tr";
    //    uye3.adi = "Hacı";
    //    uye3.soyadi = "KARLI";
    //    uye3.dogum_tarihi = "1999-10-30";
    //    lstUyeler.Add(uye3);

    //    JavaScriptSerializer jsSeri = new JavaScriptSerializer();
    //    String strJson = jsSeri.Serialize(lstUyeler);
    //    Response.Write(strJson);
    //}


}