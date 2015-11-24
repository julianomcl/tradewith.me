<%@ Page Title="Produtos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="TWMe.Produtos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    
    <h4>Meus Produtos</h4>

    <div class="form-horizontal">
        <h4>Cadastrar Novo Produto</h4>
        <hr />
        
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" CssClass="col-md-2 control-label">Rótulo</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="RotuloDD" runat="server">
                    <asp:ListItem Value="1">Battlefield</asp:ListItem>
                    <asp:ListItem Value="2">GTA IV</asp:ListItem>
                    <asp:ListItem Value="3">Viol&#227;o</asp:ListItem>
                    <asp:ListItem Value="4">Notebook DELL</asp:ListItem>
                    <asp:ListItem Value="5">Tablet Samsung</asp:ListItem>
                    <asp:ListItem Value="6">iPod 4&#170; Gera&#231;&#227;o</asp:ListItem>
                    <asp:ListItem Value="7">Rel&#243;gio</asp:ListItem>
                    <asp:ListItem Value="8">Samsung Galaxy S3</asp:ListItem>
                    <asp:ListItem Value="9">PlayStation 3</asp:ListItem>
                    <asp:ListItem Value="10">Nintendo Wii</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" CssClass="col-md-2 control-label">Descrição</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Descricao" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" CssClass="col-md-2 control-label">Imagem</asp:Label>
            <div class="col-md-10">
                <asp:FileUpload ID="Imagem" runat="server" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="Button1" runat="server" OnClick="AddProduto" Text="Enviar" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
   
</asp:Content>
