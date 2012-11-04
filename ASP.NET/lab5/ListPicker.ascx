<%@ Control Language="C#" AutoEventWireup="true"
 CodeFile="ListPicker.ascx.cs" Inherits="ListPicker" %>


<style type="text/css">
    .style1
    {
        width: 39%;
    }
    .style2
    {
        width: 200px;
    }
    .style3
    {
        width: 31px;
    }
</style>



<table class="style1">
    <tr>
        <td class="style2">
            Доступно<br />
            <asp:ListBox ID="sourceList" runat="server" Height="200px" Width="200px">
            </asp:ListBox>
        </td>
        <td class="style3">
            <asp:Button ID="addAll" runat="server" Text="&gt;&gt;" onclick="addAll_Click" 
                Width="29px" />
            <br />
            <asp:Button ID="addOne" runat="server" onclick="addOne_Click" Text=" &gt; " 
                Width="29px" />
            <br />
            <asp:Button ID="remove" runat="server" onclick="remove_Click" Text=" X " />
        </td>
        <td>
            Выбрано<br />
            <asp:ListBox ID="targetList" runat="server" Height="200px" Width="200px">
            </asp:ListBox>
        </td>
    </tr>
</table>



