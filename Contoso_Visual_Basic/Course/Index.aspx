<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Index.aspx.vb" Inherits="Contoso_Visual_Basic.Index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <p class="h3">Course</p>
        <a runat="server" href="~/Course/Create">Create</a>
   <div class="row">
        <div class="col-md-4">
            <p>Search title : </p>
            <p><asp:TextBox ID="Title_Sr" runat="server" Width="330px"></asp:TextBox></p>
            
            <p>Search Credit from : </p>
            <p><asp:TextBox ID="Credit_Sr_From" runat="server" Width="330px" ></asp:TextBox></p>
            
            <p>Search Credit to : </p>
            <p><asp:TextBox ID="Credit_Sr_To" runat="server" Width="330px" ></asp:TextBox></p>
            <p><asp:Button ID="Bt_Search" runat="server" Text="Search" Width="79px" /></p>
        </div>
        <div class="col-md-4">
            <p>Short By ID Course : </p>
            <p><asp:Button ID="IDCourse_ASC" CssClass="btn btn-primary btn-xs" runat="server" Text="ASC" Width="50px" />
               <asp:Button ID="IDCourse_DESC" CssClass="btn btn-primary btn-xs" runat="server" Text="DESC" Width="50px" /></p>

            <p>Short By Title : </p>
            <p><asp:Button ID="Titile_ASC" CssClass="btn btn-primary btn-xs" runat="server" Text="ASC" Width="50px" />
                <asp:Button ID="Titile_DESC" CssClass="btn btn-primary btn-xs" runat="server" Text="DESC" Width="50px" /></p>
            
            <p>Short By Credits : </p>
            <p><asp:Button ID="Credit_ASC" CssClass="btn btn-primary btn-xs" runat="server" Text="ASC" Width="50px" />
                <asp:Button ID="Credit_DESC" CssClass="btn btn-primary btn-xs" runat="server" Text="DESC" Width="50px" /></p>
        </div>

    </div>
      <div class="GridView">
        <asp:GridView CssClass="table" ID="GridView" runat="server" AutoGenerateColumns="false" 
            AllowPaging="true" AllowSorting="true" PageSize="3" RowStyle-BorderWidth="1" Width="570px">
           <Columns>
                <asp:BoundField DataField="ID_Course" HeaderText="ID Course"></asp:BoundField>
                <asp:BoundField DataField="Title" HeaderText="Title" />
                <asp:BoundField DataField="Credits" HeaderText="Credits" />
                <asp:HyperLinkField Text="Detail" DataNavigateUrlFields="ID_Course" DataNavigateUrlFormatString="~/Course/Detail?id={0}"/>
                <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="ID_Course" DataNavigateUrlFormatString="~/Course/Edit?id={0}"/>
                <asp:HyperLinkField Text="Hapus" DataNavigateUrlFields="ID_Course" DataNavigateUrlFormatString="~/Course/Delete?id={0}"/>
            </Columns>
              <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NumericFirstLast" />

            <RowStyle BorderWidth="1px"></RowStyle>
        </asp:GridView>
      </div>

</asp:Content>
