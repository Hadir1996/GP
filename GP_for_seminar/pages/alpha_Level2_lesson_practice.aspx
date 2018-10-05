<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="alpha_Level2_lesson_practice.aspx.cs" Inherits="GP_for_seminar.pages.alpha_Level2_lesson_practice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <img class="back_btn" src="../images/icons/backarrow.png" onclick="window.location.href='alphabetsLevels.aspx'" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="levelcontainer">

          <div class="levelsoval" runat="server" onclick="window.location.href='Alphabets.aspx?levelno=2'">
              <h1 class="levels_h1">Lesson 1</h1>
          </div> 
         
          <div class="levelsoval"  runat="server" onclick="window.location.href='Practice.aspx?levelno=2&leveltype=Alphabets&practiceno=1'" >
         <h1 class="levels_h1">Practice 1</h1>
          </div>
               <div class="levelsoval"  runat="server" onclick="window.location.href='practice_2.aspx?levelno=2&leveltype=Alphabets&practiceno=2'" >
         <h1 class="levels_h1">Practice 2</h1>
          </div>
          <div class="levelsoval"  runat="server" onclick="window.location.href='Practice3.aspx?levelno=2&leveltype=Alphabets&practiceno=3'" >
         <h1 class="levels_h1">Practice 3</h1>
          </div>
    
    </div>

</asp:Content>
