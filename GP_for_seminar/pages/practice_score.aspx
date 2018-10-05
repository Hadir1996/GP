<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="practice_score.aspx.cs" Inherits="GP_for_seminar.pages.practice_score" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css" >
    
body{
    overflow-x:hidden;
}
       
     
.progress{
    height:50px;
    border-radius:50px;
    box-shadow:none;
    padding-right:5px;
    padding-left:5px;
    padding-top:5px;
    padding-bottom:1px;
    margin-bottom:30px;
    
    background:#808080;
    overflow:visible;
   
}
.progress .progress-bar
{
    box-shadow:none;
    position:relative;
    border-radius:20px;
    background:#e95095;
    color:#e95095;
    animation:animate-positive 2s;
    margin:auto 0;
    
    
}
.progress .progress-title
{
    font-size:17px;
    font-weight:700;
    color:aliceblue;
    text-transform:uppercase;
    margin:0;
    padding:12px;
    
    
   
}
.progress .progress-value{
    text-align:center;
    width:45px;
    height:33px;
    line-height:35px;
    background:#f5f5f5;
    border-radius:50px;
    box-shadow: 0 1px 1px rgba(0,0,0,0.2);
    font-weight:bold;
    color:#e95095;
 
      position: absolute;
    top:5px;
    right:2px;
    font-size:14px;
}
.progress_container{
    margin-left:370px;

}
@keyframes animate-positive{
    0%{
        width:0%;
    }
}
.p_score{
    margin-top:10%;
    margin-bottom:20px;
    margin-left:5%;
}
.ok_btn{
    width:150px;
    padding:10px;
    margin-left:40%;
    border-radius:10px;
    background-color:#e8b6b6;
    cursor:pointer;
}
.labelcss{
 margin-left:43%;color:#996633; font-family:sans-serif;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div class="p_score">
        <asp:Label ID="score" runat="server" Text="score" BorderColor="#996633" ForeColor="#996633" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ></asp:Label>
    </div>
      
            <div>
      <div class="progress_container" style="margin:0 auto;width:50% " >
            <div class="progress">
                <div class="progress-bar"  id="prog_bar" runat="server" >
                    <h3 class="progress-title">score</h3>
                    <div class="progress-value" id="prog_val" runat="server" >
                    </div>
                   <div style="clear:both;"></div>

                </div>
            </div>

        </div>
                <div >
                    <h1 class="labelcss" id="rate" runat="server">verygood</h1>
                    <div><h2 class="labelcss" style="display:inline-block" >correct:</h2><h2 style="display:inline-block" id="corect" runat="server">correct</h2></div>
                    <div><h2 class="labelcss" style="display:inline-block">Total:</h2><h2 style="display:inline-block" id="tot" runat="server">total</h2></div>

                    <asp:Button ID="ok" runat="server" Text="OK" CssClass="ok_btn" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="#996633" OnClick="ok_Click"/>

                </div>
                
    </div>
    
    
</asp:Content>
