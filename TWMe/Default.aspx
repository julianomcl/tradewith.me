<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TWMe._Default" %>

<%@ Register assembly="DevExpress.Web.v15.1, Version=15.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>TradeWith.Me</h1>
        <p class="lead">TradeWith.Me permite que você troque os produtos que não te interessam mais por outros de seu desejo. 
            Cadastre seus produtos que deseja trocar, adicione seus produtos desejos 
            e aguarde com um sistema inovador o match entre você e outra pessoa que deseja um produto que não serve mais para você.</p>
        <p><a href="~/Cadastro" class="btn btn-primary btn-lg">Comece por aqui</a></p>
    </div>


</asp:Content>
