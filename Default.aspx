<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Stylesheet.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style1 {
            width: 27%;
        }
        .auto-style2 {
            height: 52px;
            width: 46px;
        }
        .auto-style8 {
            margin-left: 2px;
        }
        .auto-style11 {
            height: 52px;
            width: 329px;
        }
        .auto-style13 {
            width: 329px;
            height: 66px;
        }
        .auto-style14 {
            width: 46px;
            height: 66px;
        }
        .auto-style15 {
            height: 72px;
            width: 329px;
        }
        .auto-style16 {
            height: 72px;
            width: 46px;
        }
        .auto-style17 {
            height: 44px;
        }
    </style> 
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <br />
         <h2 id ="h2">Unit Converter </h2><br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style11">Conversion Type :</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style8" Height="29px" Width="165px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ViewStateMode="Enabled">
                            
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Select Units From/To :</td>
                    <td class="auto-style14">
                        <asp:DropDownList ID="DropDownList2" runat="server" Height="29px" Width="165px" AutoPostBack="True" >
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">Enter the value :</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="165px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style17">
                        <asp:Button ID="Button1" runat="server" Height="40px" OnClick="Button1_Click" Text="Convert" Width="112px" />
                     
                    
                     <br /> <br/> <asp:Button ID="Button2" runat="server" Text="Clear" Hight="40px" Width="112px" OnClick="btnclear" Height="40px"/></td>
               
                   </tr>
                
            </table>
            <br />
            <br />
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" ReadOnly="True"  AutoPostBack="True" Rows="5" ></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
