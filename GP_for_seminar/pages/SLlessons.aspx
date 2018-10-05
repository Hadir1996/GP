<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SLlessons.aspx.cs" Inherits="GP_for_seminar.pages.SLlessons" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="mySlides" style="width:900px; height:19px; margin-left:250px; margin-top:100px;" >
       <asp:ImageButton ID="ImageButton3"  style="width:30px;height:30px;float:right; margin-right:70px;"  runat="server" ImageUrl="~/images/icons/xmark.png" OnClick="ImageButton3_Click"   />

</div> 
    <div class="mySlides" style="width:900px; height:200px; margin-left:250px; margin-top:0px;  border-radius: 20px; padding-bottom:100px; padding-top:100px;" >
       <video  autoplay style="width: 824px; height: 400px; margin-left: 46px; margin-top: 0px">
         <source ID="video" src="" runat="server" type="video/mp4"/>
         <source src=" " type="video/ogg"/>
            Your browser does not support the video tag.
          </video> 
     </div>
</asp:Content>
