<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Lessons.aspx.cs" Inherits="GP_for_seminar.pages.Lessons" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="slider"> 
    <div class="mySlides" style="width:900px; height:50px; margin-left:250px; margin-top:100px;" >
       <asp:ImageButton ID="ImageButton3"  style="width:30px;height:30px;float:right; margin-right:70px;"  runat="server" ImageUrl="~/images/icons/xmark.png" OnClick="ImageButton3_Click"  />


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
        

</div>
   <div class="mySlides" style="width:900px; height:200px; position:relative;margin-left:250px; margin-top:10px;  background: rgba(0,0,0,0.2);  border-radius: 20px; padding-bottom:100px; padding-top:100px;" >
    
          
        <asp:ImageButton ID="capital" runat="server" CssClass="cap"  style="width:450px; height:196px; float:left;" OnClick="capital_Click" />
       <asp:ImageButton ID="small" runat="server" style="width:450px; height:192px; float:right; "  CssClass="sm" OnClick="small_Click"/>
        </div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="prev" runat="server" Text="<" CssClass="prev" OnClick="prev_Click" />
       <asp:Button ID="next" runat="server" Text=">"  CssClass="next" ForeColor="#333333" OnClick="next_Click"  />
       </div>

</asp:Content>
