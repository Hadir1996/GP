<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Numbers.aspx.cs" Inherits="GP_for_seminar.pages.Numbers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <img class="back_btn" src="../images/icons/backarrow.png" onclick="window.location.href='num_Level1_lesson_practice.aspx'" />


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="alphdiv" style="width:340px" >
  
    <asp:ImageButton ID="ImageButton1" runat="server"  Width="100px" height="100px" CssClass="letters" ImageUrl="~/images/number/zero.png" OnClick="ImageButton1_Click" />
    <asp:ImageButton ID="ImageButton2" runat="server" Width="100px"  height="100px" CssClass="letters" ImageUrl="~/images/number/one.png" OnClick="ImageButton2_Click"/>
    <asp:ImageButton ID="ImageButton3" runat="server" Width="100px"  height="100px" CssClass="letters" ImageUrl="~/images/number/two.png" OnClick="ImageButton3_Click"/>
   <br />
    <asp:ImageButton ID="ImageButton4" runat="server" Width="100px"  height="100px" CssClass="letters" ImageUrl="~/images/number/theree.png" OnClick="ImageButton4_Click"/>
    <asp:ImageButton ID="ImageButton5" runat="server" Width="100px"  height="100px" CssClass="letters" ImageUrl="~/images/number/four.png" OnClick="ImageButton5_Click" />
     <asp:ImageButton ID="ImageButton6" runat="server" Width="100px"  height="100px" CssClass="letters" ImageUrl="~/images/number/five.png" OnClick="ImageButton6_Click"/>
     <br />
        <asp:ImageButton ID="ImageButton7" runat="server"  Width="100px" height="100px" CssClass="letters" ImageUrl="~/images/number/six.png" OnClick="ImageButton7_Click"/>
     <asp:ImageButton ID="ImageButton8" runat="server" Width="100px" height="100px" CssClass="letters" ImageUrl="~/images/number/seven.png" OnClick="ImageButton8_Click"/>
     <asp:ImageButton ID="ImageButton9" runat="server" Width="100px" height="100px" CssClass="letters" ImageUrl="~/images/number/eight.png" OnClick="ImageButton9_Click"/>
    <br />
        <asp:ImageButton ID="ImageButton10" runat="server" Width="100px" height="100px" CssClass="letters" ImageUrl="~/images/number/nine.png" OnClick="ImageButton10_Click"/>
      <br />

     <br />
       </div>
    
   

</asp:Content>
