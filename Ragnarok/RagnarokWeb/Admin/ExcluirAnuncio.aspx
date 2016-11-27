<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="ExcluirAnuncio.aspx.cs" Inherits="RagnarokWeb.Admin.ExcluirAnuncio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btnConfirm{
            background: red;
            color:white;
        }
        .btnCancel{
            background:blue;
            color:#fff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageBody" runat="server">
    <div class="divValue">
        <h3>Valores Resgistrado</h3>
        <div>
            Nome do Anuncios:
                <asp:Label runat="server" ID="lblNomeAnuncio"></asp:Label>
        </div>
        <div>Tempo:<asp:Label runat="server" ID="lblTempoAnuncio"></asp:Label></div>
        <div>Nome do jogo:<asp:Label runat="server" ID="lblNomeJogo"></asp:Label></div>
        <div>Site do jogo:<asp:Label runat="server" ID="lbllinkSite"></asp:Label></div>
        <div>Link para imagem:<asp:Label runat="server" ID="lblLInkImagem"></asp:Label></div>
        <div>Descrição do anuncio:<asp:Label runat="server" ID="lblDescricaoAnuncio"></asp:Label></div>
        <span style="background:#039;color:#fff;">Desejá Realmente Excluir esse Anuncios? Isso nâo podera mais ser desfeito</span>
        <asp:Button runat="server" Text="Sim" CssClass="btnConfirm" OnClick="btnExcluirAnuncio_Click" ID="btnExcluirAnuncio"/>
        <asp:Button runat="server" Text="Cancelar" CssClass="btnCancel" OnClick="btnCancelarExcluir_Click" ID="btnCancelarExcluir"/>
    </div>
    <asp:Label runat="server" ID="status" Visible="false"></asp:Label>
</asp:Content>
