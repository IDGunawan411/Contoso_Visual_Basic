<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Delete.aspx.vb" Inherits="Contoso_Visual_Basic.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       
    <p>Data Akan di hapus ?</p>
    <p>ID Course : <asp:Label ID="IDCourse_Delete" runat="server" Text=""></asp:Label>
    <p>Title : <asp:Label ID="Title_Delete" runat="server" Text=""></asp:Label>
    <p>Credits : <asp:Label ID="Credits_Delete" runat="server" Text=""></asp:Label>

    <p>
        <a runat="server" href="~/Course/Index">Back</a>

    <asp:Button ID="Button1" runat="server" Text="Delete" Width="130px" />
    </p>

</asp:Content>
