<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Edit.aspx.vb" Inherits="Contoso_Visual_Basic.Edit2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="h4">Edit Enrollment</p>
    
    <div>
        <p>ID Enrollment<asp:TextBox ID="IDEnrollment_Edit" runat="server" Width="330px" ReadOnly ></asp:TextBox></p>
    </div>    
    <div>
        <p>Selected Student:</p>
        <asp:DropDownList ID="ddlStudent_edit" runat="server" />
    </div>
    <div>
        <p>Selected Course:</p>
        <asp:DropDownList ID="ddlCourse_edit" runat="server" />
    </div>
    <div>
        <p>Selected Grade:</p>
        <asp:DropDownList ID="ddlGrade_edit" runat="server" />
    </div>
    
    
    <p>
        <a runat="server" href="~/Enrollment/Index">Back</a>
          <asp:Button ID="Button1" runat="server" Text="Save" Width="79px" />
   </p>
</asp:Content>
