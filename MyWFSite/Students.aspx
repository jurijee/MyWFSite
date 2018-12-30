<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Students.aspx.cs" Inherits="Students" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <label>You're using browser:</label>
        <asp:Literal ID="ltrlTest" runat="server"/>
    </div>
    <div>
        <asp:Label Width="100" runat="server" Text="Name" />
        <asp:TextBox ID="txtName" runat="server"/>
        <asp:RequiredFieldValidator runat="server" ID="rfvStudentName" ErrorMessage="Required field." ControlToValidate="txtName" ValidationGroup="InsStudent"/>
    </div>
    <div>
        <asp:Label Width="100" runat="server" Text="Surname" />
        <asp:TextBox ID="txtSurname" runat="server"/>
        <asp:RequiredFieldValidator runat="server" ID="rfvStudentSurname" ErrorMessage="Required field." ControlToValidate="txtSurname" ValidationGroup="InsStudent"/>
    </div>
    <div>
        <asp:Label Width="100" runat="server" Text="Grade" />
        <asp:TextBox ID="txtGrade" runat="server"/>
        <asp:RangeValidator ID="rngvalGrade" runat="server" ErrorMessage="Please insert values 1-5." ControlToValidate="txtGrade" Type="Integer" MinimumValue="1" MaximumValue="5" />
    </div>
    <div>
        <asp:Label Width="100" runat="server" Text="Subject" />
        <asp:DropDownList ID="ddlSubjectDrop" runat="server">
            <asp:ListItem>

            </asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server" ID="rfvDropDown" ErrorMessage="Required field." InitialValue="--PLEASE SELECT--" ControlToValidate="ddlSubjectDrop" ValidationGroup="InsStudent"/>
    </div>
    <div>
        <asp:Button ID="btnImportStudentInfo" runat="server" Text="ImportStudentInfo" ValidationGroup="InsStudent" OnClick="btnImportStudentInfo_Click"/>
    </div>
        <div>
        <asp:literal ID="ltrTest" runat="server" />
    </div>
    <div>
        <asp:CheckBox ID="chckBox" runat="server" text="DeleteStudents" AutoPostBack="True" OnCheckedChanged="chckBox_CheckedChanged"/>
        <asp:Button ID="btnDelStudents" runat="server" Text ="DeleteStudents" OnClick="btnDelStudents_Click"/>
    </div>
</asp:Content>

