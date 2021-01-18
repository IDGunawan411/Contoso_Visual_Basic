<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Delete.aspx.vb" Inherits="Contoso_Visual_Basic.Delete2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>Data akan dihapus ?</p>
    <p>ID Enrollment : <asp:Label ID="IDEnrollment_Delete" runat="server" Text=""></asp:Label>
    <p>First Name : <asp:Label ID="IDStudent_Delete" runat="server" Text=""></asp:Label>
    <p>Title : <asp:Label ID="IDCours_Delete" runat="server" Text=""></asp:Label>
    <p>Grade : <asp:Label ID="Grade_Delete" runat="server" Text=""></asp:Label>

    <p>
        <a runat="server" href="~/Enrollment/Index">Back</a>
        <asp:Button ID="Button1" runat="server" Text="Delete" Width="130px" />
    </p>
</asp:Content>
