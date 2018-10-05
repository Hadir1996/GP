<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Practice3.aspx.cs" Inherits="GP_for_seminar.pages.Practice3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript"   >
 
var SpeechRecognition = SpeechRecognition || webkitSpeechRecognition
var SpeechGrammarList = SpeechGrammarList || webkitSpeechGrammarList
var SpeechRecognitionEvent = SpeechRecognitionEvent || webkitSpeechRecognitionEvent
     
var grammarAlpha = '#JSGF V1.0; grammar phonetics; public<phonetic> = A | B | C | D | E | F |G | H | I | J | K | L | M | N | O | P | Q | R | S | T | U | V | W | X | Y | Z;'
var grammarNumbers = '#JSGF V1.0; grammar phonetics; public<phonetic> = zero|one|two|three|four|five|six|seven|eight|nine|ten;'
var grammarColor = '#JSGF V1.0; grammar phonetics; public<phonetic> = red|blue|black|white|green|purple|pink|yellow|orange|gray|brown ;'
var grammarFamily = '#JSGF V1.0; grammar phonetics; public<phonetic> = Baby | Father | Mother | Sister | Brother | Grandmother | Grandfather ;'
var grammarword = '#JSGF V1.0; grammar phonetics; public<phonetic> = aligator | ant | apple | bear | butterfly | cake | cat | dog | elephant | fish | goat | horse | ice | lion | monkey | owl | pencil | rocket |tent |umbrella|dragon| juice |kangaroo |nurse |queen |sheep | volcano | watermelon |xylophone | yogurt | zebra | banana | chicken | chocolate| duck | earth|egg | frog | flag | grape | giraffe | hammer | hat | insect | iguana | jam | jet | key | lemon | lolipop | map | mouse | nest| nut | orange | octopus | panda | pizza | quarter | question | rose | rabbit | snake |spider | turtle | tiger | unicorn | uniform | van | violin | wolf | x-ray | yam | yarn | zipper | zucchini; '

var recognition = new SpeechRecognition();

var gramarlist = new SpeechGrammarList();
gramarlist.addFromString(grammarAlpha);
gramarlist.addFromString(grammarNumbers);
gramarlist.addFromString(grammarColor);
gramarlist.addFromString(grammarFamily);
gramarlist.addFromString(grammarword);

recognition.grammars = gramarlist;
recognition.lang = 'en-UK';
recognition.interimResults = false;
recognition.maxAlternatives = 1;

function _(id) {
    return document.getElementById(id);
}

function startRecognition() {
    recognition.start();
}

recognition.onresult = function (event) {
    var res = event.results[0][0].transcript;
    _('<%=speech_txt.ClientID%>').value = res.toString();
    __doPostBack("speech_txt", "TextChanged");
   

   
}



   </script>
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
                 <asp:ImageButton ID="speech" runat="server" style=" margin-left:150px; width:50px;height:40px;margin-top:5px; "  ImageUrl="~/images/icons/speecker.png" OnClick="speech_Click" />
                 <asp:TextBox ID="speech_txt" runat="server" BackColor="#FFFFCC" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" ForeColor="#6699FF" OnTextChanged="speech_txt_TextChanged" Width="77px"></asp:TextBox>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:ImageButton ID="hint" runat="server" style=" margin-left:150px; width:50px;height:40px;margin-top:5px; "  ImageUrl="~/images/background/question-mark.png" OnClick="hint_Click" />
               <asp:ImageButton ID="nextQ" runat="server" style=" margin-left:150px; width:50px;height:40px;margin-top:5px; "  ImageUrl="~/images/icons/rightarrow.png" OnClick="nextQ_Click" />

</div>
    
     <div class="mySlides" style="width:900px; height:150px; margin-left:250px; margin-top:10px;  background: rgba(0,0,0,0.2);  border-radius: 20px; padding-bottom:100px; padding-top:100px;" >

     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="ImageButton1" runat="server"  Width="236px"  CssClass="letters" ImageUrl="" OnClick="ImageButton1_Click" Height="163px"    />
      
       
          </div>	

</asp:Content>
