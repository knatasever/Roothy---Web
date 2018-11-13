<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="urunler.aspx.cs" Inherits="urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
         <div style="width=100%">
                  <div style="background-color:coral; color:aliceblue ;text-align:center;">
<h3></h3>

                  </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="kodu" HeaderText="kodu" SortExpression="kodu" />
            <asp:BoundField DataField="adi" HeaderText="adi" SortExpression="adi" />
            <asp:BoundField DataField="kdv" HeaderText="kdv" SortExpression="kdv" />
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="tipi" HeaderText="tipi" SortExpression="tipi" />
            <asp:BoundField DataField="fiyat" HeaderText="fiyat" SortExpression="fiyat" />
            <asp:BoundField DataField="unite" HeaderText="unite" SortExpression="unite" />
            <asp:BoundField DataField="agirlik" HeaderText="agirlik" SortExpression="agirlik" />
            <asp:BoundField DataField="hacim" HeaderText="hacim" SortExpression="hacim" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:McFlyRoothyConnectionString %>" SelectCommand="SELECT [kodu], [adi], [kdv], [ID], [tipi], [fiyat], [unite], [agirlik], [hacim] FROM [Urun]"></asp:SqlDataSource>
   </div> </form>

</asp:Content>

