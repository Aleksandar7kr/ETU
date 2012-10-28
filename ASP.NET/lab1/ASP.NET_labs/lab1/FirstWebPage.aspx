<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstWebPage.aspx.cs" Inherits="lab1.FirstWebPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Добро пожаловать в Visual Web Developer
        <br />
        <br />
        Введите свое имя:<br />
        <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="204px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Height="20px" Text="Ввести" 
            onclick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Maroon"></asp:Label>
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
            BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
            Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" 
            onselectionchanged="Calendar1_SelectionChanged" Width="200px">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
        <br />
        <br />
    </div>
    </form>
</body>
</html>
