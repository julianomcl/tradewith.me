<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="TWMe.Produtos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    
    <h4>Meus Produtos</h4>

    <asp:GridView
          id="GridView1"
          runat="server"
          DataSourceID="SqlDataSource1">
      </asp:GridView>

    <div class="form-horizontal">
        <h4>Cadastrar Novo Produto</h4>
        <hr />
        
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" CssClass="col-md-2 control-label">Rótulo</asp:Label>
            <div class="col-md-10">
                <select ID="RotuloDDList">
                    <asp:Repeater ID="Repeater1" DataSourceID="SqlDataSource2" runat="server">
                         
                            <ItemTemplate>
                                <option value='<%Eval("Id"); %>'><% Eval("Nome"); %></option>
                            </ItemTemplate>
                       
                    </asp:Repeater>
                </select>  
                <asp:TextBox runat="server" ID="RotuloTxt" CssClass="hidden" />
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
    <asp:SqlDataSource
          id="SqlDataSource1"
          runat="server"
          DataSourceMode="DataReader"
          ConnectionString="<%$ ConnectionStrings:OracleConnectionString %>"
          SelectCommand="SELECT r.nome as Nome, p.descricao as Descricao 
                FROM produto p, rotulo r WHERE p.id_rotulo = r.id_rotulo">
      </asp:SqlDataSource>
    <asp:SqlDataSource
          id="SqlDataSource2"
          runat="server"
          DataSourceMode="DataReader"
          ConnectionString="<%$ ConnectionStrings:OracleConnectionString %>"
          SelectCommand="SELECT r.id_rotulo as Id, r.nome as Nome 
                FROM rotulo r">
      </asp:SqlDataSource>
</asp:Content>
