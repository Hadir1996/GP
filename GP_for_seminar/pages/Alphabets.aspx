<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Alphabets.aspx.cs" Inherits="GP_for_seminar.pages.Alphabets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
       

     <img class="back_btn" src="../images/icons/backarrow.png" onclick="onclickfn()" />
<script type="text/javascript">

    function onclickfn()
    {
        var levelno = document.getElementById("levnom").value;
        if(levelno=="1")
        {
            window.location.href = 'alpha_Level1_lesson_practice.aspx'
        }
        else if(levelno=="2")
        {
            window.location.href = 'alpha_Level2_lesson_practice.aspx'

        }
    }

</script>  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="alphdiv" >
  
      <asp:ImageButton ID="ImageButton1" runat="server"  Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/A.png" OnClick="ImageButton1_Click1" />
    <asp:ImageButton ID="ImageButton2" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/B.png" OnClick="ImageButton2_Click"/>
    <asp:ImageButton ID="ImageButton3" runat="server" Width="100px"   CssClass="letters" ImageUrl="~/images/alphabet/C.png" OnClick="ImageButton3_Click" />
    <asp:ImageButton ID="ImageButton4" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/D.png" OnClick="ImageButton4_Click"/>
    <asp:ImageButton ID="ImageButton5" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/E.png" OnClick="ImageButton5_Click" />
  <br />
     <asp:ImageButton ID="ImageButton6" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/F.png" OnClick="ImageButton6_Click"/>
     <asp:ImageButton ID="ImageButton7" runat="server"  Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/G.png" OnClick="ImageButton7_Click"/>
     <asp:ImageButton ID="ImageButton8" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/H.png" OnClick="ImageButton8_Click"/>
     <asp:ImageButton ID="ImageButton9" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/I.png" OnClick="ImageButton9_Click"/>
    <asp:ImageButton ID="ImageButton10" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/J.png" OnClick="ImageButton10_Click"/>
      <br />
    <asp:ImageButton ID="ImageButton11" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/K.png" OnClick="ImageButton11_Click"/>
    <asp:ImageButton ID="ImageButton12" runat="server" Width="100px" CssClass="letters" ImageUrl="~/images/alphabet/L.png" OnClick="ImageButton12_Click"/>
    <asp:ImageButton ID="ImageButton13" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/M.png" OnClick="ImageButton13_Click"/>
     <asp:ImageButton ID="ImageButton14" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/N.png" OnClick="ImageButton14_Click"/>
     <asp:ImageButton ID="ImageButton15" runat="server" Width="100px" CssClass="letters" ImageUrl="~/images/alphabet/O.png" OnClick="ImageButton15_Click"/>
    <br />
     <asp:ImageButton ID="ImageButton16" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/P.png" OnClick="ImageButton16_Click"/>
      <asp:ImageButton ID="ImageButton17" runat="server" Width="100px" CssClass="letters" ImageUrl="~/images/alphabet/Q.png" OnClick="ImageButton17_Click" />
    <asp:ImageButton ID="ImageButton18" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/R.png" OnClick="ImageButton18_Click"/>
    <asp:ImageButton ID="ImageButton19" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/S.png" OnClick="ImageButton19_Click"/>
    <asp:ImageButton ID="ImageButton20" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/T.png" OnClick="ImageButton20_Click"/>
      <br />
    <asp:ImageButton ID="ImageButton21" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/U.png" OnClick="ImageButton21_Click"/>
     <asp:ImageButton ID="ImageButton22" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/V.png" OnClick="ImageButton22_Click"/>
     <asp:ImageButton ID="ImageButton23" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/W.png" OnClick="ImageButton23_Click"/>
     <asp:ImageButton ID="ImageButton24" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/X.png" OnClick="ImageButton24_Click"/>   
    <asp:ImageButton ID="ImageButton25" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/Y.png" OnClick="ImageButton25_Click"/>
      <br />
     <asp:ImageButton ID="ImageButton26" runat="server" Width="100px"  CssClass="letters" ImageUrl="~/images/alphabet/Z.png" OnClick="ImageButton26_Click"/>
    
      <br />
       </div>

</asp:Content>
