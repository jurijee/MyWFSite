<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Overview.aspx.cs" Inherits="Overview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Repeater ID="rptrSubjectSummary" runat="server">
        <ItemTemplate>
            <table>
                <tr><th>Subject</th><th><%#Eval("Subject") %></th></tr>
                <tr><td>Teacher</td><td><%#Eval("Teacher") %></td></tr>
                <tr><td>ExamDate</td><td><%#Eval("ExamDate") %></td></tr>
            </table>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

