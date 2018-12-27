<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Students.aspx.cs" Inherits="Students" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <label>Name</label>
        <asp:TextBox ID="txtName" runat="server"/>
    </div>
    <div>
        <label>Surname</label>
        <asp:TextBox ID="txtSurname" runat="server"/>
    </div>
    <div>
        <label>Grade</label>
        <asp:TextBox ID="txtGrade" runat="server"/>
    </div>
</asp:Content>

