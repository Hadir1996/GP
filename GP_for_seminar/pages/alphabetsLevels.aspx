<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="alphabetsLevels.aspx.cs" Inherits="GP_for_seminar.pages._ِalphabetsLevels" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <img class="back_btn" src="../images/icons/backarrow.png" onclick="window.location.href='home.aspx'" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="levelcontainer">
    
          <div class="levelsoval" runat="server" onclick="window.location.href='alpha_Level1_lesson_practice.aspx'">
              <h1 class="levels_h1">Level 1</h1>
          </div> 
         
          <div class="levelsoval"  runat="server"  onclick="window.location.href='alpha_Level2_lesson_practice.aspx'" >
         <h1 class="levels_h1">Level 2</h1>
          </div>
        
        
        
    
    </div>
</asp:Content>
