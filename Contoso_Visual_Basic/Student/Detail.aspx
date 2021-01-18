<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Detail.aspx.vb" Inherits="Contoso_Visual_Basic.Detail2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>ID Student : <asp:Label ID="IDStudent_Detail" runat="server" Text=""></asp:Label>
    <p>First Name : <asp:Label ID="FirstName_Detail" runat="server" Text=""></asp:Label>
    <p>Last Name : <asp:Label ID="LastName_Detail" runat="server" Text=""></asp:Label>
    <p>Enrollment Date : <asp:Label ID="Enrollment_Detail" runat="server" Text=""></asp:Label>

    <p>
        <a runat="server" href="~/Student/Index">Back</a>
    </p>

</asp:Content>
