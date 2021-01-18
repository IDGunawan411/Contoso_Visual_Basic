<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Delete.aspx.vb" Inherits="Contoso_Visual_Basic.Delete1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <p>ID Student : <asp:Label ID="IDStudent_Delete" runat="server" Text=""></asp:Label>
    <p>First Name : <asp:Label ID="FirstName_Delete" runat="server" Text=""></asp:Label>
    <p>Last Name : <asp:Label ID="LastName_Delete" runat="server" Text=""></asp:Label>
    <p>Enrollment Date : <asp:Label ID="Enrollment_Delete" runat="server" Text=""></asp:Label>

    <p>
        <a runat="server" href="~/Student/Index">Back</a>
        <asp:Button ID="Button1" runat="server" Text="Delete" Width="130px" />
    </p>
</asp:Content>
