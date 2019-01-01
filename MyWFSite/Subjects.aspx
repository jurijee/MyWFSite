<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Subjects.aspx.cs" Inherits="Subjects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:Label Width="100" runat="server" Text="Subject" />
        <asp:TextBox ID="txtSubject" runat="server"/>
        <asp:RequiredFieldValidator runat="server" ID="rfvSubject" ErrorMessage="Required field." ControlToValidate="txtSubject" ValidationGroup="Grp1"/>
    </div>
    <div>
        <asp:Label Width="100" runat="server" Text="Teacher" />
        <asp:TextBox ID="txtTeacher" runat="server"/>
        <asp:RequiredFieldValidator runat="server" ID="rfvTeacher" ErrorMessage="Required field." ControlToValidate="txtTeacher" ValidationGroup="Grp1"/>
    </div>
    <div>
        <asp:Label Width="300" runat="server" Text="Exam date (not required)" /> 
        <asp:Calendar ID="cldrExamDate" runat="server" FirstDayOfWeek="Monday" WeekendDayStyle-BackColor="SpringGreen" TodayDayStyle-BackColor="Teal"/>   
        <asp:Label ID="lblTest" runat="server" Text="" />
    </div>
    <div>
        <asp:Button ID="btnImportSubjectInfo" CssClass="btn" runat="server" Text="ImportSubjectInfo" OnClick="btnImportSubjectInfo_Click" ValidationGroup="Grp1"/>
    </div>
    <div>
        <asp:Label runat="server" Text="Please confirm deletion by clicking on checkbox first." /><br>
        <asp:CheckBox ID="chckSubBox" runat="server" text="DeleteSubjects" AutoPostBack="True" OnCheckedChanged="chckSubBox_CheckedChanged" />
        <asp:Button ID="btnDelSubjects" CssClass="btn" runat="server" Text ="DeleteSubjects" OnClick="btnDelSubjects_Click"/>
    </div>
</asp:Content>

