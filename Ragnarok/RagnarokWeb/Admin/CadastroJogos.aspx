<%@ Page Title="" MasterPageFile="~/AdminMasterPage.master" Language="C#" AutoEventWireup="true" CodeBehind="CadastroJogos.aspx.cs" Inherits="RagnarokWeb.Admin.CadastroJogos" %>
<asp:Content ID="DefaultContentHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="DefaultConttentBody" ContentPlaceHolderID="PageBody" runat="server">
    <article class="main-article">
        <header>
            Cadastro de Jogos
        </header>
    </article>
    <table style="width: 57%; margin-left: 217px;">
        <tr>
            <td style="font-family: 'Arial Black'; font-size: 13px; height: 50px;">Nome do jogo: </td>
            <td><asp:TextBox ID="txtNomeJogo" runat="server" Width="200px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="font-family: 'Arial Black'; font-size: 13px; height: 50px;">Site do jogo: </td>
            <td><asp:TextBox ID="txtSiteJogo" runat="server" Width="200px" ></asp:TextBox></td>
        </tr>
        <tr>
            <td style="font-family: 'Arial Black'; font-size: 13px;" >Descrição: </td>
            <td><asp:TextBox ID="txtDescricaoJogo" runat="server" Height="129px" style="margin-top: 10px" Width="358px" placeholder="Escreva uma descrição sobre o jogo..."></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp</td>
            <td><asp:Button ID="btnCadastrar" runat="server" BackColor="Green" BorderColor="Black" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" Height="38px" Text="Cadastrar" Width="98px" OnClick="btnCadastrar_Click"/></td>
        </tr>
    </table>
</asp:Content>