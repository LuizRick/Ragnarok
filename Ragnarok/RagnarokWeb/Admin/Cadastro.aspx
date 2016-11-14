<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="RagnarokWeb.Cadastro" %>
<asp:Content ID="DefaultContentHead" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="DefaultConttentBody" ContentPlaceHolderID="PageBody" runat="server">
    <h1 class="ragnafont">Ragnarok - Cadastro</h1>
    <fieldset id="formee-cad">
        <legend>Preencher todos os Campos</legend>
            <div>
                <label for="username">Nome de usuário:</label>
                <asp:TextBox ID="username" runat="server" placeholder="Nome de usuário" autofocus="autofocus"></asp:TextBox>
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
