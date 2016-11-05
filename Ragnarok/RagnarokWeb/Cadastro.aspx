<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="Cadastro" MasterPageFile="~/MasterPage.master" %>
<asp:Content ID="DefaultContentHead" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="DefaultConttentBody" ContentPlaceHolderID="PageBody" runat="server">
    <h1 class="ragnafont">Ragnarok - Cadastro</h1>
    <fieldset>
        <legend>Preencher todos os Campos</legend>
        <form action="javascript:void(0)" id="cadastro-usuario" class="formee">
            <div>
                <label for="username">Nome de usuário:</label>
                <asp:TextBox ID="username" runat="server" placeholder="Nome de usuário" autofocus="autofocus"></asp:TextBox>
            </div>
            <div>
                <label for="email">Endereço de e-mail atual:</label>
                <asp:TextBox ID="email" runat="server" placeholder="Endereço de e-mail atual" autofocus="autofocus"></asp:TextBox>
            </div>
            <div>
                <label for="userpwd">Escolhe sua senha:</label>
                <asp:TextBox ID="senha" runat="server" placeholder="Digite sua senha" autofocus="autofocus"></asp:TextBox>
            </div>
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
        </form>
    </fieldset>
</asp:Content>
