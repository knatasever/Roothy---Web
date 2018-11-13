<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
     <form id="form1" runat="server">
        <div style="width=100%">
                  <div style="background-color:coral; color:aliceblue ;text-align:center;">
<h3>FATURALAR</h3>

                  </div>
						
         
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="fisTipi" HeaderText="fisTipi" SortExpression="fisTipi" />
                <asp:BoundField DataField="fisID" HeaderText="fisID" SortExpression="fisID" />
                <asp:BoundField DataField="fisNo" HeaderText="fisNo" SortExpression="fisNo" />
                <asp:BoundField DataField="tarih" HeaderText="tarih" SortExpression="tarih" />
                <asp:BoundField DataField="musKodu" HeaderText="musKodu" SortExpression="musKodu" />
                <asp:BoundField DataField="musAdi" HeaderText="musAdi" SortExpression="musAdi" />
                <asp:BoundField DataField="toplamNet" HeaderText="toplamNet" SortExpression="toplamNet" />
                <asp:BoundField DataField="aracKodu" HeaderText="aracKodu" SortExpression="aracKodu" />
                <asp:BoundField DataField="aracPlaka" HeaderText="aracPlaka" SortExpression="aracPlaka" />
                <asp:BoundField DataField="odemeTutari1" HeaderText="odemeTutari1" SortExpression="odemeTutari1" />
                <asp:BoundField DataField="tahTarih" HeaderText="tahTarih" SortExpression="tahTarih" />
            </Columns>
        </asp:GridView> 
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:McFlyRoothyConnectionString %>" SelectCommand="SELECT [fisTipi], [fisID], [fisNo], [tarih], [musKodu], [musAdi], [toplamNet], [aracKodu], [aracPlaka], [odemeTutari1], [tahTarih] FROM [Fatura]"></asp:SqlDataSource>
</div>
</form>
</asp:Content>

