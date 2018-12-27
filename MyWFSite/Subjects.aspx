<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Subjects.aspx.cs" Inherits="Subjects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <label>Subject</label>
        <asp:TextBox ID="txtSubject" runat="server"/>
    </div>
    <div>
        <label>Teacher</label>
        <asp:TextBox ID="txtTeacher" runat="server"/>
    </div>
    <div>
        <label>Date of exam</label>  
        <asp:Calendar ID="cldrExamDate" runat="server"/>   
    </div>
</asp:Content>

