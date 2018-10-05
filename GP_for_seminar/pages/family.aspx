<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="family.aspx.cs" Inherits="GP_for_seminar.pages.family" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <img class="back_btn" src="../images/icons/backarrow.png" onclick="window.location.href='family_Level1_lesson_practice.aspx'" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="alphdiv" style="width:900px" >
  
         <asp:ImageButton ID="ImageButton7" runat="server"  Width="100px" height="200px" CssClass="letters" ImageUrl="~/images/family_level/grandfather.png" OnClick="ImageButton7_Click"/>
     
     <asp:ImageButton ID="ImageButton6" runat="server" Width="100px"  height="200px" CssClass="letters" ImageUrl="~/images/family_level/grandmother.png" OnClick="ImageButton6_Click"/>
         
       <asp:ImageButton ID="ImageButton5" runat="server" Width="100px"  height="200px" CssClass="letters" ImageUrl="~/images/family_level/mother.png" OnClick="ImageButton5_Click" />
    <asp:ImageButton ID="ImageButton4" runat="server" Width="100px"  height="200px" CssClass="letters" ImageUrl="~/images/family_level/father.png" OnClick="ImageButton4_Click"/>
    
     
         <asp:ImageButton ID="ImageButton1" runat="server"  Width="100px" height="200px" CssClass="letters" ImageUrl="~/images/family_level/baby.png" OnClick="ImageButton1_Click" />
    <asp:ImageButton ID="ImageButton2" runat="server" Width="100px"  height="200px" CssClass="letters" ImageUrl="~/images/family_level/brother.png" OnClick="ImageButton2_Click"/>
    <asp:ImageButton ID="ImageButton3" runat="server" Width="100px"  height="200px" CssClass="letters" ImageUrl="~/images/family_level/sister.png" OnClick="ImageButton3_Click" />
   <br />
        
    <br />
         </div>
    

</asp:Content>
