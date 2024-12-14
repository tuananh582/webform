<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hienthi.aspx.cs" enableEventValidation="false" Inherits="luyenlan1.WebForms.hienthi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Ma"></asp:Label>
                <asp:TextBox ID="txtMa" runat="server"></asp:TextBox>
                <asp:Label ID="lbMaSach" runat="server" ForeColor
="red"></asp:Label>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Ten Sach"></asp:Label>
                <asp:TextBox ID="txttensach" runat="server"></asp:TextBox>

            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Nha Xuat Ban"></asp:Label>
                <asp:TextBox ID="txtnxb" runat="server"></asp:TextBox>

            </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Nam Xuat Ban"></asp:Label>
                <asp:TextBox ID="txtnamxuatban" runat="server"></asp:TextBox>

            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Tac Gia"></asp:Label>
                <asp:TextBox ID="txttacgia" runat="server"></asp:TextBox>

            </div>
            <div>
                <asp:Label ID="Label6" runat="server" Text="Don Gia"></asp:Label>
                <asp:TextBox ID="txtdongia" runat="server"></asp:TextBox>

            </div>
            <div>
                <asp:Label ID="Label7" runat="server" Text="Hinh Anh"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" />

            </div>
            <asp:Button ID="btnthem" runat="server" Text="Them" OnClick="btnthem_Click" />
            <asp:Button ID="btnxoa" runat="server" Text="Xoa" />
            <asp:Button ID="Button2" runat="server" Text="Lam Moi" />

        </div>

        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="MaSach" HeaderText="Ma Sach " />
                    <asp:BoundField DataField="TenSach" HeaderText="Ten Sach" />
                    <asp:BoundField DataField="NhaXB" HeaderText="Nha Xuat Ban" />
                    <asp:BoundField DataField="NamXB" HeaderText="Nam Xuat Ban" />
                    <asp:BoundField DataField="TacGia" HeaderText="Tac Gia" />
                    <asp:BoundField DataField="DonGia" HeaderText="Don Gia" />
                    <asp:TemplateField HeaderText="Hinh Anh">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Images/"+Eval("Hinhanh") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Chuc Nang ">
                        <ItemTemplate>
                            <asp:Button ID="btnsua" runat="server" OnClick="btnsua_Click" Text="Sua " />
                            <asp:Button ID="btnxoacn" runat="server" Text="Xoa" OnClick="btnxoacn_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
