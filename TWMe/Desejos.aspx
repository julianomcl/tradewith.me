<%@ Page Title="Desejos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Desejos.aspx.cs" Inherits="TWMe.Desejos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    
    <h4>Meus Desejos</h4>

    <asp:GridView
          id="GridView1"
          runat="server"
          DataSourceID="SqlDataSource1">
      </asp:GridView>

    <div class="form-horizontal">
        <h4>Cadastrar Novo Desejo</h4>
        <hr />
        
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" CssClass="col-md-2 control-label">Rótulo</asp:Label>
            <div class="col-md-10">
                <select ID="RotuloDDList">
                    <asp:Repeater ID="Repeater2" DataSourceID="SqlDataSource2" runat="server">
                         
                            <ItemTemplate>
                                <option value='<%Eval("Id"); %>'><% Eval("Nome"); %></option>
                            </ItemTemplate>
                       
                    </asp:Repeater>
                </select>  
                <asp:TextBox runat="server" ID="RotuloTxt" CssClass="hidden" />
            </div>
        </div>
        
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="Button1" runat="server" OnClick="AddDesejo" Text="Enviar" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
    <asp:SqlDataSource
          id="SqlDataSource1"
          runat="server"
          DataSourceMode="DataReader"
          ConnectionString="<%$ ConnectionStrings:OracleConnectionString %>"
          SelectCommand="SELECT r.nome as Nome,
                FROM desejo d, rotulo r WHERE d.id_rotulo = r.id_rotulo">
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
