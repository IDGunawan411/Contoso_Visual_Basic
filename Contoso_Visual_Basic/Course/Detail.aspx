<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Detail.aspx.vb" Inherits="Contoso_Visual_Basic.Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
           
    <p>Course Detail</p>
    <p>ID Course : <asp:Label ID="IDCourse_Delete" runat="server" Text=""></asp:Label>
    <p>Title : <asp:Label ID="Title_Delete" runat="server" Text=""></asp:Label>
    <p>Credits : <asp:Label ID="Credits_Delete" runat="server" Text=""></asp:Label>

    <p><a runat="server" href="~/Course/Index">Back</a></p>
</asp:Content>
