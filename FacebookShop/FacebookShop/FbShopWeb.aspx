<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FbShopWeb.aspx.cs" Inherits="FacebookShop.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Id<asp:TextBox ID="TextBox0" runat="server"></asp:TextBox>
            Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            Email<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            Telephone<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="width: 37px" Text="Add" />
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="№" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="Telephone" HeaderText="Telephone" SortExpression="Telephone" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [client] WHERE [Id] = @Id" InsertCommand="INSERT INTO [client] ([Id], [Name], [Email], [Telephone]) VALUES (@Id, @Name, @Email, @Telephone)" SelectCommand="SELECT * FROM [client]" UpdateCommand="UPDATE [client] SET [Name] = @Name, [Email] = @Email, [Telephone] = @Telephone WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:FormParameter Name="Id" Type="Int32" FormField="TextBox0"/>
                <asp:FormParameter Name="Name" Type="String" FormField="TextBox1"/>
                <asp:FormParameter Name="Email" Type="String" FormField="TextBox2"/>
                <asp:FormParameter Name="Telephone" Type="String" FormField="TextBox3"/>
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Telephone" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
