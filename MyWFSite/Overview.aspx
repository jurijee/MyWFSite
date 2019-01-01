<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Overview.aspx.cs" Inherits="Overview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Welcome to the short subject overview page</h2>
    <div>
        <asp:Label Width="300" runat="server" Text="You're using browser:" />
        <asp:Literal ID="ltrlTest" runat="server"/>
    </div>
    <p>here is a short list created by repeater and HTML table</p>
    <asp:Repeater ID="rptrSubjectSummary" runat="server">
        <ItemTemplate>
            <div class="rptr">
                <table>
                    <tr><th>Subject</th><th><%#Eval("Subject") %></th></tr>
                    <tr><td>Teacher</td><td><%#Eval("Teacher") %></td></tr>
                    <tr><td>ExamDate</td><td><%# string.Format("{0:d/M/yyyy}", Eval("ExamDate")) %></td></tr>
                </table>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

