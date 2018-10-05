<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="regester.aspx.cs" Inherits="GP_for_seminar.pages.regester" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
        
        <div class="login_container">
            <h1>register</h1>
 
         <input type="text" id="Fname" runat="server"  placeholder="first name"/>
         <input type="text" id="Lname" runat="server" placeholder="second name"/>
         <input type="text" id="age" runat="server" placeholder="age"/>
         <input type="text" id="username" runat="server" placeholder="username" />
         <input type="password" id="pass" runat="server" placeholder="password"/>
         <input type="password" id="confirmpass" runat="server" placeholder="confirm password"/>
         <asp:Button ID="reg" CssClass="submit" runat="server" Text="register" OnClick="reg_Click1" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="rv" ControlToValidate="Fname"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ValidationGroup="rv" ControlToValidate="Lname"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"  ValidationGroup="rv" ControlToValidate="age" ></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  ValidationGroup="rv" ControlToValidate="username"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"  ValidationGroup="rv" ControlToValidate="pass" ></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"  ValidationGroup="rv" ControlToValidate="confirmpass"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ValidationGroup="rcv" ControlToCompare="pass" ControlToValidate="confirmpass"></asp:CompareValidator>
             </div>
    </div>
</asp:Content>
