<%@ Page Title="Create" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Create.aspx.vb" Inherits="Contoso_Visual_Basic.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="h4">Add Student</p>
    
    <p>ID Student<asp:TextBox ID="TextBox1" runat="server" Width="330px" required></asp:TextBox></p>
    <p>First Name<asp:TextBox ID="TextBox2" runat="server" Width="329px"></asp:TextBox></p>
    <p>Last Name<asp:TextBox ID="TextBox3" runat="server" Width="330px"></asp:TextBox></p>   
   
    <p>Enrollment Date<asp:TextBox value="" ID="TextBox4" runat="server" Width="301px" ReadOnly></asp:TextBox>
    <p>&nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" Width="79px" />
    </p>

</asp:Content>
