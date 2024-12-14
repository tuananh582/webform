<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hienthi.aspx.cs" EnableEventValidation="false" Inherits="luyenlan2.WebForms.hienthi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="MaSach" HeaderText="Ma Sach" />
                    <asp:BoundField DataField="TenSach" HeaderText="TenSach" />
                    <asp:BoundField DataField="NhaXB" HeaderText="Nha Xuat Ban" />
                    <asp:BoundField DataField="NamXB" HeaderText="Nam Xuat Ban" />
                    <asp:BoundField DataField="TacGia" HeaderText="Tac Gia" />
                    <asp:BoundField DataField="DonGia" HeaderText="Don Gia" />
                    <asp:BoundField HeaderText="Hinh Anh" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
