<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Detail.aspx.vb" Inherits="Contoso_Visual_Basic.Detail1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <p>Enrollment Detail</p>
    <p>ID Enrollment : <asp:Label ID="IDEnrollment_Detail" runat="server" Text=""></asp:Label>
    <p>First Name : <asp:Label ID="IDStudent_Detail" runat="server" Text=""></asp:Label>
    <p>Title : <asp:Label ID="IDCours_Detail" runat="server" Text=""></asp:Label>
    <p>Grade : <asp:Label ID="Grade_Detail" runat="server" Text=""></asp:Label>

    <p>
        <a runat="server" href="~/Enrollment/Index">Back</a>
    </p>
</asp:Content>
