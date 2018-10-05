<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="color.aspx.cs" Inherits="GP_for_seminar.pages.color" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <img class="back_btn" src="../images/icons/backarrow.png" onclick="window.location.href='color_Level1_lesson_practice.aspx'" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="alphdiv" style="width:400px" >
  
    <asp:ImageButton ID="ImageButton1" runat="server"  Width="120px"  Height="160px"  CssClass="letters" ImageUrl="~/images/Colours/black.png" OnClick="ImageButton1_Click" />
    <asp:ImageButton ID="ImageButton2" runat="server" Width="120px" Height="160px" CssClass="letters" ImageUrl="~/images/Colours/blue2.png" OnClick="ImageButton2_Click"/>
    <asp:ImageButton ID="ImageButton3" runat="server" Width="120px" Height="160px"  CssClass="letters" ImageUrl="~/images/Colours/brpwn.png" OnClick="ImageButton3_Click" />
      <br />
       <asp:ImageButton ID="ImageButton4" runat="server" Width="120px"  Height="160px" CssClass="letters" ImageUrl="~/images/Colours/gray.png" OnClick="ImageButton4_Click"/>
    <asp:ImageButton ID="ImageButton5" runat="server" Width="120px"  Height="160px" CssClass="letters" ImageUrl="~/images/Colours/green.png" OnClick="ImageButton5_Click" />
     <asp:ImageButton ID="ImageButton6" runat="server" Width="120px" Height="160px"  CssClass="letters" ImageUrl="~/images/Colours/orange.png" OnClick="ImageButton6_Click"/>
       <br />
       <asp:ImageButton ID="ImageButton7" runat="server"  Width="120px" Height="160px"  CssClass="letters" ImageUrl="~/images/Colours/pink.png" OnClick="ImageButton7_Click"/>
     <asp:ImageButton ID="ImageButton8" runat="server" Width="120px"  Height="160px" CssClass="letters" ImageUrl="~/images/Colours/purple.png" OnClick="ImageButton8_Click"/>
     <asp:ImageButton ID="ImageButton9" runat="server" Width="120px"  Height="160px" CssClass="letters" ImageUrl="~/images/Colours/red.png" OnClick="ImageButton9_Click"/>
      <br />
       <asp:ImageButton ID="ImageButton10" runat="server" Width="120px"  Height="160px" CssClass="letters" ImageUrl="~/images/Colours/white.png" OnClick="ImageButton10_Click"/>
         <asp:ImageButton ID="ImageButton11" runat="server" Width="120px"  Height="160px" CssClass="letters" ImageUrl="~/images/Colours/yellow.png" OnClick="ImageButton11_Click"/>
      <br />

      <br />
    </div>
    
</asp:Content>
