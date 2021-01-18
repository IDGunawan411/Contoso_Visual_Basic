<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Edit.aspx.vb" Inherits="Contoso_Visual_Basic.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p class="h4">Edit Course</p>
    
    <div>
        <p>ID Course<asp:TextBox ID="IDCourse_Edit" runat="server" Width="330px" ReadOnly ></asp:TextBox></p>
        <p>Title<asp:TextBox ID="Title_Edit" runat="server" Width="363px"></asp:TextBox></p>
        <p>Credits<asp:TextBox Type="Number" ID="Credits_Edit" runat="server" Width="344px"></asp:TextBox></p>  
    </div>
    
    <p>
        <a runat="server" href="~/Course/Index">Back</a>
          <asp:Button ID="Button1" runat="server" Text="Save" Width="79px" />
   </p>
</asp:Content>
