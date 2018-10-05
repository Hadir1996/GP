<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GP_for_seminar.pages.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container">
        <div class="login_container">
     <h1> login</h1>
 
           <input type="text" id="login_username" runat="server" placeholder="username"/>
            <input type="password" id="login_pass" runat="server" placeholder="password"  />
            <asp:Button ID="Log" CssClass="submit" runat="server" Text="login" OnClick="Log_Click"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=""  CssClass="validation" ControlToValidate="login_username" ValidationGroup="v"></asp:RequiredFieldValidator>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="v" ControlToValidate="login_pass"></asp:RequiredFieldValidator>
   </div>
        </div>
        
    
</asp:Content>
