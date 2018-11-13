<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="musteriler.aspx.cs" Inherits="musteriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
         <div style="width=100%">
                  <div style="background-color:coral; color:aliceblue ;text-align:center;">
<h3>MÜŞTERİLER</h3>

                  </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="kodu" HeaderText="kodu" SortExpression="kodu" />
            <asp:BoundField DataField="MerkezKodu" HeaderText="MerkezKodu" SortExpression="MerkezKodu" />
            <asp:BoundField DataField="adi" HeaderText="adi" SortExpression="adi" />
            <asp:BoundField DataField="il" HeaderText="il" SortExpression="il" />
            <asp:BoundField DataField="zincir" HeaderText="zincir" SortExpression="zincir" />
            <asp:BoundField DataField="telefon" HeaderText="telefon" SortExpression="telefon" />
            <asp:BoundField DataField="tipKodu" HeaderText="tipKodu" SortExpression="tipKodu" />
            <asp:BoundField DataField="tipAdi" HeaderText="tipAdi" SortExpression="tipAdi" />
            <asp:BoundField DataField="kanalKodu" HeaderText="kanalKodu" SortExpression="kanalKodu" />
            <asp:BoundField DataField="kanalAdi" HeaderText="kanalAdi" SortExpression="kanalAdi" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:McFlyRoothyConnectionString %>" SelectCommand="SELECT [ID], [kodu], [MerkezKodu], [adi], [il], [zincir], [telefon], [tipKodu], [tipAdi], [kanalKodu], [kanalAdi] FROM [Musteri]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:McFlyRoothyConnectionString %>" SelectCommand="SELECT [kodu], [adi], [kdv], [ID], [tipi], [fiyat], [unite], [agirlik], [hacim] FROM [Urun]"></asp:SqlDataSource>
</div>

    </form>
    
</asp:Content>

