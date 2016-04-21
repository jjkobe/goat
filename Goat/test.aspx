<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body> 
    <form id="form1" runat="server">
        <input runat="server" type="checkbox" name="chk" value="1"/>1
        <input runat="server" type="checkbox" name="chk" value="2"/>2
        <input runat="server" type="checkbox" name="chk" value="3"/>3
        <input runat="server" type="checkbox" name="chk1" value="4"/>4<br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:CheckBox ID="CheckBox1" Text="sss" runat="server" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                    <asp:Button ID="wc" runat="server" Text="Button" OnClick="wc_Click" />
        <br />
        <asp:Button ID="rt" runat="server" Text="Button" OnClick="rt_Click" />
        <br />
                </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="wc" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="rt" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
        <br />
        <input type="text" id="data" runat="server" />
    </form>
    <script type="text/javascript" language="javascript">
　　function Ceshi(a)
　　{
　　　　//var a = "你们好啊！"
　　　　alert(a);
　　}
</script>
</body>
</html>
