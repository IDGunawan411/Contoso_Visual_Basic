<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Create.aspx.vb" Inherits="Contoso_Visual_Basic.Create2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      
    <p class="h4">Add Enrollment</p>
    <p>ID Enrollment<asp:TextBox ID="IDEnrollment_Text" runat="server" Width="330px"></asp:TextBox></p>
    <div>
        <p>Selected Student:</p>
        <asp:DropDownList ID="ddlStudent" runat="server" />
    </div>
    <div>
        <p>Selected Course:</p>
        <asp:DropDownList ID="ddlCourse" runat="server" />
    </div>
    <div>
        <p>Selected Grade:</p>
        <asp:DropDownList ID="ddlGrade" runat="server" />
    </div>

    <p>&nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Save" Width="79px" />
    </p>

</asp:Content>
