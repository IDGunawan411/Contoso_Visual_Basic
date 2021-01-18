<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Index.aspx.vb" Inherits="Contoso_Visual_Basic.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p class="h3">Student</p>

    <a runat="server" href="~/Student/Create">Create</a>
    <div class="row">
        <div class="col-md-4">
            <p>Search FirstName : </p>
            <p><asp:TextBox ID="FirstName_Sr" runat="server" Width="330px" ></asp:TextBox></p>
            
            <p>Search LastName : </p>
            <p><asp:TextBox ID="LastName_Sr" runat="server" Width="330px" ></asp:TextBox></p>
            
            <p>Search EnrollmentDate : </p>
            <p><asp:TextBox ID="Enrollment_Sr" runat="server" Width="330px" Type="date" ></asp:TextBox></p>
    
            <p><asp:Button ID="Bt_Search" runat="server" Text="Search" Width="79px" /></p>
        </div>
    
        <div class="col-md-4">
            <span>Short By ID Student : </span>
            <p><asp:Button ID="IDStudent_ASC" CssClass="btn btn-primary btn-xs" runat="server" Text="ASC" Width="50px" />
                <asp:Button ID="IDStudent_DESC" CssClass="btn btn-primary btn-xs" runat="server" Text="DESC" Width="50px" /></p>

            <span>Short By FirstName : </span>
            <p><asp:Button ID="FirstName_ASC" CssClass="btn btn-primary btn-xs" runat="server" Text="ASC" Width="50px" />
                <asp:Button ID="FirstName_DESC" CssClass="btn btn-primary btn-xs" runat="server" Text="DESC" Width="50px" /></p>
            
            <span>Short By LastName : </span>
            <p><asp:Button ID="LastName_ASC" CssClass="btn btn-primary btn-xs" runat="server" Text="ASC" Width="50px" />
                <asp:Button ID="LastName_DESC" CssClass="btn btn-primary btn-xs" runat="server" Text="DESC" Width="50px" /></p>

            <span>Short By Enrollment : </span>
            <p><asp:Button ID="Enrollment_ASC" CssClass="btn btn-primary btn-xs" runat="server" Text="ASC" Width="50px" />
                <asp:Button ID="Enrollment_DESC" CssClass="btn btn-primary btn-xs" runat="server" Text="DESC" Width="50px" /></p>
       </div>
    </div>

     <div class="GridView">
        <asp:GridView CssClass="table" ID="GridView" runat="server" AutoGenerateColumns="false" 
            AllowPaging="true" PageSize="3" RowStyle-BorderWidth="1" Width="570px">
            <Columns>
                <%--<asp:templatefield itemstyle-width="150px" headertext="customer id" sortexpression="customerid">
                    <itemtemplate>
                        
                    </itemtemplate>
                </asp:templatefield>--%>
                <asp:BoundField DataField="ID_Student" HeaderText="ID Student" />
                <asp:BoundField DataField="First_Name" HeaderText="First Name" />
                <asp:BoundField DataField="Last_Name" HeaderText="Last Name" />
                <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date" />
                <asp:HyperLinkField Text="Detail" DataNavigateUrlFields="ID_Student" DataNavigateUrlFormatString="~/Student/Detail?id={0}" />
                <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="ID_Student" DataNavigateUrlFormatString="~/Student/Edit?id={0}" />
                <asp:HyperLinkField Text="Hapus" DataNavigateUrlFields="ID_Student" DataNavigateUrlFormatString="~/Student/Delete?id={0}" />
            </Columns>
        </asp:GridView>
      </div>

    <%--  <div class="GridView1">
         <asp:Table CssClass="table" ID="GridView1" runat="server" AutoGenerateColumns="false" 
            AllowPaging="true" PageSize="3" RowStyle-BorderWidth="1" Width="570px">
             <asp:TableHeaderRow>
                 <asp:TableHeaderCell>ID Student</asp:TableHeaderCell>
                 <asp:TableHeaderCell>First Name</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Last Name</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Enrollment</asp:TableHeaderCell>
             </asp:TableHeaderRow>
             <asp:TableRow>
                 <asp:TableCell><%# Eval("ID_Student")%></asp:TableCell>
                 <asp:TableCell><%# Eval("First_Name")%></asp:TableCell>
                 <asp:TableCell><%# Eval("Last_Name")%></asp:TableCell>
                 <asp:TableCell><%# Eval("EnrollmentDate")%></asp:TableCell>
             </asp:TableRow>
         </asp:Table>
      </div>--%>
   <br />
</asp:Content>