<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Practice.aspx.cs" Inherits="GP_for_seminar.pages.Practice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   
     <div class="mySlides" style="width:200px; height:250px; margin-left:30px ; margin-top:110px; float:left;  background: rgba(0,0,0,0.2);" >
    <table>
        <tr>
            
            <td style=" padding:20px 10px 10px 10px ; font-size:x-large; font-weight:bold;"><asp:Label ID="sco" runat="server" Text="score"></asp:Label> </td>
            <td style=" padding:20px 10px 10px 10px; font-size:x-large; font-weight:bold;"><asp:Label ID="scores" runat="server"  Text="0"></asp:Label> </td>

        </tr>
        <tr>
            
            <td style=" padding:20px 10px 10px 10px; font-size:x-large; font-weight:bold;"><asp:Label ID="corrct" runat="server" Text="correct"></asp:Label>
                          <asp:Image ID="Image2" runat="server" style="width:20px;height:20px; margin:0px 10px;" ImageUrl="~/images/icons/googmood.png" />

            </td>
              <td style=" padding:20px 10px 10px 10px ; font-size:x-large; font-weight:bold;"><asp:Label ID="corrctres" runat="server" Text="0"></asp:Label> </td>

        </tr>
          <tr>
            
            <td style=" padding:20px 10px 10px 10px; font-size:x-large; font-weight:bold;"><asp:Label ID="wrng" runat="server" Text="wrong"></asp:Label>
                            <asp:Image ID="Image3" runat="server" style="width:20px; margin:0px 10px;" ImageUrl="~/images/icons/sad.png" />

            </td>
              <td style=" padding:20px 10px 10px 10px; font-size:x-large; font-weight:bold;"><asp:Label ID="wrngres" runat="server" Text="0"></asp:Label> </td>

        </tr>

    </table>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mySlides" style="width:900px; height:50px; margin-left:250px; margin-top:100px;  background: rgba(0,0,0,0.2);  border-radius: 20px;" >
              <asp:ImageButton ID="listen" runat="server" style=" margin-left:50px; width:50px;height:40px;margin-top:5px; "  ImageUrl="~/images/background/speake.png" OnClick="replayvoice_Click" />
              <asp:ImageButton ID="hint" runat="server" style=" margin-left:150px; width:50px;height:40px;margin-top:5px; "  ImageUrl="~/images/background/question-mark.png" ToolTip="hi girls" OnClick="hint_Click"  />
              <asp:ImageButton ID="reply" runat="server" style=" margin-left:250px; width:50px;height:40px;margin-top:5px; "  ImageUrl="~/images/icons/replay.png" OnClick="reply_Click" />
               <asp:ImageButton ID="nextQ" runat="server" style=" margin-left:150px; width:50px;height:40px;margin-top:5px; "  ImageUrl="~/images/icons/rightarrow.png" OnClick="nextQ_Click" />


</div>
    
     <div class="mySlides" style="width:900px; height:150px; margin-left:250px; margin-top:10px;  background: rgba(0,0,0,0.2);  border-radius: 20px; padding-bottom:100px; padding-top:100px;" >

     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="ImageButton1" runat="server"  Width="100px"  CssClass="letters" ImageUrl="" OnClick="ImageButton1_Click"    />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="ImageButton2" runat="server" Width="100px"  CssClass="letters" ImageUrl="" OnClick="ImageButton2_Click"  />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="ImageButton3" runat="server" Width="100px"   CssClass="letters" ImageUrl="" OnClick="ImageButton3_Click"  />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="ImageButton4" runat="server" Width="100px"  CssClass="letters" ImageUrl="" OnClick="ImageButton4_Click"   />  
       
    <br />  
        <asp:Label ID="Label1" runat="server" Text=" " Style="color:green"  ></asp:Label>
         <asp:Label ID="Label2" runat="server" Text=" " Style="color:red" ></asp:Label>
        <asp:Label ID="Label3" runat="server" Text=" " Style="color:chartreuse" ></asp:Label>
        
          </div>	


</asp:Content>
