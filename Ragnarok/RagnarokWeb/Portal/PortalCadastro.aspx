<%@ Page Title="" Language="C#" MasterPageFile="~/PortalMasterPage.Master" AutoEventWireup="true" CodeBehind="PortalCadastro.aspx.cs" Inherits="RagnarokWeb.PortalCadastro" %>
<asp:Content ID="DefaultContentHead" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="DefaultConttentBody" ContentPlaceHolderID="PageBody" runat="server">
    <h1 class="ragnafont">Ragnarok - Cadastro</h1>
    <fieldset id="formee-cad">
        <legend>Preencher todos os Campos</legend>
            <div>
                <label for="usernamecp">Nome Completo</label>
                <asp:TextBox ID="usernamecp" runat="server" placeholder="seu nome completo" autofocus="autofocus"></asp:TextBox>
            </div>
            <div>
                <label for="username">Nome de usuário:</label>
                <asp:TextBox ID="username" runat="server" placeholder="Nome de usuário"></asp:TextBox>
            </div>
            <div>
                <label for="email">Endereço de e-mail atual:</label>
                <asp:TextBox ID="email" runat="server" placeholder="Endereço de e-mail atual" autofocus="autofocus"></asp:TextBox>
            </div>
            <div>
                <label for="userpwd">Escolha sua senha:</label>
                <asp:TextBox TextMode="Password" ID="senha" runat="server" placeholder="Digite sua senha" autofocus="autofocus"></asp:TextBox>
            </div>
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
    </fieldset>
</asp:Content>
