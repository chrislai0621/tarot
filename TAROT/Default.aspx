<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TAROT._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width:70%;
            text-align:left;
           
        }
        .style2
        {
            width:130px;
            color:White;
            background-color:Gray;
            text-align:justify;
        }
     
        .style5
        {
            width:30%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     流年年份：
        <asp:DropDownList ID="ddlYear" runat="server">
        </asp:DropDownList>
        <br />
        西元出生年月日：<asp:TextBox ID="txtDate"  runat="server" ></asp:TextBox>(yyyy/MM/dd)
            
        <asp:Button ID="BtnOk" runat="server" Text="確定" onclick="BtnOk_Click"   />
        <br />
        <br />
    <div id="a" align="center">
    
    
        <b>本性</b><br />
        <table class="style1" border="1" cellpadding="0" cellspacing="0" >
            <tr>
                <td class="style2">
                    編號</td>
                <td class="style5">
                    
                    <asp:Label ID="lblRno" runat="server" ></asp:Label>&nbsp;</td>
                <td class="style2">
                    角色名稱</td>
                <td>
                    <asp:Label ID="lblRName" runat="server" ></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    優點</td>
                <td class="style5">
                    <asp:Label ID="lblRMerit" runat="server" ></asp:Label>&nbsp;</td>
                <td class="style2">
                    缺點</td>
                <td>
                    <asp:Label ID="lblRDefect" runat="server" ></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    圖案及動作內涵</td>
                <td colspan="3">
                   <asp:Label ID="lblRPicAndAction" runat="server" ></asp:Label> &nbsp;</td>
            </tr>
        </table>
    <br /> <b>內在</b><br />
        <table class="style1"  border="1" cellpadding="0" cellspacing="0" >
            <tr>
                <td class="style2">
                    編號</td>
                <td class="style5">
                    <asp:Label ID="lblINo" runat="server" ></asp:Label>&nbsp;</td>
                <td  class="style2">
                    角色名稱</td>
                <td>
                    <asp:Label ID="lblIName" runat="server" ></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    優點</td>
                <td class="style5">
                    <asp:Label ID="lblImerit" runat="server" ></asp:Label>&nbsp;</td>
                <td class="style2">
                    缺點</td>
                <td>
                    <asp:Label ID="lblIDefect" runat="server" ></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    圖案及動作內涵</td>
                <td colspan="3">
                   <asp:Label ID="lblIPicAndAction" runat="server" ></asp:Label> &nbsp;</td>
            </tr>
        </table>
         <br /><b>外在</b><br />
        <table class="style1"  border="1" cellpadding="0" cellspacing="0" >
            <tr>
                <td class="style2">
                    編號</td>
                <td class="style5">
                    <asp:Label ID="lblENo" runat="server" ></asp:Label>&nbsp;</td>
                <td  class="style2">
                    角色名稱</td>
                <td>
                    <asp:Label ID="lblEName" runat="server" ></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    優點</td>
                <td class="style5">
                    <asp:Label ID="lblEMerit" runat="server" ></asp:Label>&nbsp;</td>
                <td class="style2">
                    缺點</td>
                <td>
                    <asp:Label ID="lblEDefect" runat="server" ></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    圖案及動作內涵</td>
                <td colspan="3">
                   <asp:Label ID="lblEPicAndAction" runat="server" ></asp:Label> &nbsp;</td>
            </tr>
        </table>
        <br /> <b>其他性格<br />
        </b>
        <table class="style1"  border="1" cellpadding="0" cellspacing="0" >
            <tr>
                <td class="style2">
                    編號</td>
                <td class="style5">
                    <asp:Label ID="lblONo" runat="server" ></asp:Label>&nbsp;</td>
                <td  class="style2">
                    角色名稱</td>
                <td>
                    <asp:Label ID="lblOName" runat="server" ></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    優點</td>
                <td class="style5">
                    <asp:Label ID="lblOMerit" runat="server" ></asp:Label>&nbsp;</td>
                <td class="style2">
                    缺點</td>
                <td>
                    <asp:Label ID="lblODefect" runat="server" ></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    圖案及動作內涵</td>
                <td colspan="3">
                   <asp:Label ID="lblOPicAndAction" runat="server" ></asp:Label> &nbsp;</td>
            </tr>
        </table>
        
        <br /> <b>流年運勢_年份：<asp:Label ID="lblYYear" runat="server" ></asp:Label><br />
        </b>
        <table class="style1"  border="1" cellpadding="0" cellspacing="0" >
            <tr>
                <td class="style2">
                    號碼</td>
                <td class="style5">
                   <asp:Label ID="lblYNo" runat="server" ></asp:Label> &nbsp;</td>
                <td  class="style2">
                    角色名稱</td>
                <td>
                    <asp:Label ID="lblYName" runat="server" ></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    流年吉凶</td>
                <td ="style5">
                    <asp:Label ID="lblYStatus" runat="server" ></asp:Label>&nbsp;</td>
                <td class="style2">
                    關鍵語</td>
                <td>
                    <asp:Label ID="lblYkeyWord" runat="server" ></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    深度指引</td>
                <td colspan="3">
                   <asp:Label ID="lblYPoint" runat="server" ></asp:Label> &nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
