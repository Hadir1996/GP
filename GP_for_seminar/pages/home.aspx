<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="GP_for_seminar.pages.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="hcontainer">
    
          <div class="oval" runat="server" onclick="window.location.href='alphabetsLevels.aspx'">
          <img src="../images/background/abcs.png" class="homeimg"  runat="server"/>
              <h1 class="home_h1">alphabets</h1>
          </div> 
         
          <div class="oval"  runat="server" onclick="window.location.href='numbersLevels.aspx'">
          <img src="~/images/background/123.png"  class="homeimg" runat="server"/>
              <h1 class="home_h1">Numbers</h1>
          </div>
        
         <div class="oval" runat="server" onclick="window.location.href='Familylevels.aspx'">
          <img src="../images/background/Family.PNG"  class="homeimg" runat="server" />
              <h1 class="home_h1">Family</h1>
          </div>
        
         <div class="oval" runat="server" onclick="window.location.href='colorLevels.aspx'" >
          <img src="../images/background/colours.jpg" class="homeimg" runat="server"  />
              <h1 class="home_h1">Colours</h1>
          </div>
        
         <div class="oval" runat="server" onclick="window.location.href='sllevels.aspx'">
          <img src="../images/background/abcs.png" class="homeimg"  runat="server" />
              <h1 class="home_h1">Sign Language</h1>
          </div>
      
         
    
    </div>
</asp:Content>
