<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Edit.aspx.vb" Inherits="Contoso_Visual_Basic.Edit1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p class="h4">Edit Student</p>
    <div>
        <p>ID Student<asp:TextBox ID="IDStudent_Edit" runat="server" Width="330px" ReadOnly ></asp:TextBox></p>
        <p>First Name<asp:TextBox ID="FirstName_Edit" runat="server" Width="363px"></asp:TextBox></p>
        <p>Last Name<asp:TextBox ID="LastName_Edit" runat="server" Width="344px"></asp:TextBox></p>  
        <p>Enrollment Date<asp:TextBox ID="Enrollment_Edit" runat="server" Width="344px" ReadOnly></asp:TextBox></p>  
    </div>
    
    <p>
          <asp:Button ID="Button1" runat="server" Text="Save" Width="79px" />
   </p>

</asp:Content>
