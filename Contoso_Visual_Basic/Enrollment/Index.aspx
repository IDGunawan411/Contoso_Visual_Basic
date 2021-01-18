<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Index.aspx.vb" Inherits="Contoso_Visual_Basic.Index2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <p class="h3">Enrollment</p>

    <a runat="server" href="~/Enrollment/Create">Create</a>
      <div class="row">
        <div class="col-md-4">
            <p>Search FirstName : </p>
            <p><asp:TextBox ID="FirstName_Sr" runat="server" Width="330px" ></asp:TextBox></p>
            
            <p>Search Title : </p>
            <p><asp:TextBox ID="Title_Sr" runat="server" Width="330px" ></asp:TextBox></p>
            
            <p>Selected Grade: </p>
            <p><asp:DropDownList ID="ddlGrade_sr" runat="server" /></p>
            <p><asp:Button ID="Bt_Search" runat="server" Text="Search" Width="79px" /></p>
        </div>
        <div class="col-md-4">
            <p>Short By ID Enrollment : </p>
            <p><asp:Button ID="IDEnrollment_ASC" class="btn btn-primary btn-xs" runat="server" Text="ASC" Width="50px" />
               <asp:Button ID="IDEnrollment_DESC" class="btn btn-primary btn-xs" runat="server" Text="DESC" Width="50px" /></p>
            
            <p>Short By FirstName : </p>
            <p><asp:Button ID="FirstName_ASC" class="btn btn-primary btn-xs" runat="server" Text="ASC" Width="50px" />
                <asp:Button ID="FirstName_DESC" class="btn btn-primary btn-xs" runat="server" Text="DESC" Width="50px" /></p>

            <p>Short By Title : </p>
            <p><asp:Button ID="Title_ASC" class="btn btn-primary btn-xs" runat="server" Text="ASC" Width="50px" />
                <asp:Button ID="Title_DESC" class="btn btn-primary btn-xs" runat="server" Text="DESC" Width="50px" /></p>
            
            <p>Short By Grade : </p>
            <p><asp:Button ID="Grade_ASC" class="btn btn-primary btn-xs" runat="server" Text="ASC" Width="50px" />
                <asp:Button ID="Grade_DESC" class="btn btn-primary btn-xs" runat="server" Text="DESC" Width="50px" /></p>
        </div>
      </div>

      <div class="GridView">
        <asp:GridView CssClass="table" ID="GridView" runat="server" AutoGenerateColumns="False" 
            AllowPaging="True" PageSize="3" RowStyle-BorderWidth="1" Width="570px">
            <Columns>
                <asp:BoundField DataField="ID_Enrollment" HeaderText="ID Enrollment" />
                <asp:BoundField DataField="First_Name" HeaderText="First Name" />
                <asp:BoundField DataField="Title" HeaderText="Title" />
                <asp:BoundField DataField="Grade" HeaderText="Grade" />
                <asp:HyperLinkField Text="Detail" DataNavigateUrlFields="ID_Enrollment" DataNavigateUrlFormatString="~/Enrollment/Detail?id={0}"/>
                <asp:HyperLinkField DataNavigateUrlFields="ID_Enrollment, ID_Student, ID_Course, Grade"
                    DataNavigateUrlFormatString="~/Enrollment/Edit?EID={0}&SID={1}&CID={2}&Grade={3}"  
                      Text="Edit" />
                <asp:HyperLinkField Text="Hapus" DataNavigateUrlFields="ID_Enrollment" DataNavigateUrlFormatString="~/Enrollment/Delete?id={0}"/>
            </Columns>
            <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NumericFirstLast" />

            <RowStyle BorderWidth="1px"></RowStyle>
        </asp:GridView>
      </div>
</asp:Content>
