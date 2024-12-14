<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hienthi.aspx.cs" EnableEventValidation="false" Inherits="luyenlan3.WebForms.hienthi" %>

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
                <asp:TextBox ID="txtma" runat="server"></asp:TextBox>
                <asp:Label ID="lbMaSach" runat="server" ForeColor="Red"></asp:Label>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Ten SAch"></asp:Label>
                <asp:TextBox ID="txttensach" runat="server"></asp:TextBox>
            </div>


            <div>
                <asp:Label ID="Label7" runat="server" Text="Nha Xuat Ban"></asp:Label>
                <asp:TextBox ID="txtnhaxuatban" runat="server"></asp:TextBox>
            </div>
            <div>


                <asp:Label ID="Label3" runat="server" Text="Nam Xuat Ban"></asp:Label>
                <asp:TextBox ID="txtnxb" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Tac Gia"></asp:Label>
                <asp:TextBox ID="txttacgia" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Don Gia"></asp:Label>
                <asp:TextBox ID="txtdongia" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label6" runat="server" Text="Hinh Anh"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </div>
            <asp:Button ID="btnthem" runat="server" Text="Them" OnClick="btnthem_Click" />
            <asp:Button ID="btnlammoi" runat="server" Text="Lam Moi" OnClick="btnlammoi_Click" />
            <asp:Button ID="btnxoa" runat="server" Text="Xoa" />

        </div>



        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Masach" HeaderText="Ma Sach" />
                    <asp:BoundField DataField="Tensach" HeaderText="Ten Sach" />
                    <asp:BoundField DataField="Nhaxb" HeaderText="Nha Xuat Ban" />
                    <asp:BoundField DataField="Namxb" HeaderText="Nam Xuat Ban" />
                    <asp:BoundField DataField="Tacgia" HeaderText="Tac Gia" />
                    <asp:BoundField DataField="Dongia" HeaderText="Don Gia" />
                    <asp:TemplateField HeaderText="Hinh Anh">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>

                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Images/"+Eval("Hinhanh") %>' />w
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Chuc Nang">
                        <ItemTemplate>
                            <asp:Button ID="btnsua1" runat="server" Text="Sua" />
                            <asp:Button ID="btnxoa2" runat="server" Text="Xoa" OnClick="btnxoa2_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
