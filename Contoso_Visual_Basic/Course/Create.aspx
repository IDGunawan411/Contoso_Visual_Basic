<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Create.aspx.vb" Inherits="Contoso_Visual_Basic.Create1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p class="h4">Add Course</p>
    <p>ID Course<asp:TextBox ID="IDCourse_Text" runat="server" Width="330px" required></asp:TextBox></p>
    <p>Title<asp:TextBox ID="Title_Text" runat="server" Width="363px"></asp:TextBox></p>
    <p>Credits<asp:TextBox Type="Number" ID="Credits_Text" runat="server" Width="344px"></asp:TextBox></p>  
   
    <p>&nbsp;</p>
    <p>
        <a runat="server" href="~/Course/Index">Back</a>
        <asp:Button ID="Button1" runat="server" Text="Save" Width="79px" />
    </p>
    

</asp:Content>
