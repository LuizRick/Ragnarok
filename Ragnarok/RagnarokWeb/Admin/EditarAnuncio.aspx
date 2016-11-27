<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="EditarAnuncio.aspx.cs" Inherits="RagnarokWeb.Admin.EditarAnuncio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container{
            position:relative;
        }
        .divValue {
            float: left;
            border: 1px solid #333;
            position:absolute;
            right:0;
            width:42%;
            overflow:scroll;
            background:#fff;
        }
        .form{
            position:absolute;
            left:0;
        }
        .divValue div {
            border-bottom:1px solid #333;
        }
        .divValue span
        {
            color: blue;
        }
        .divValue span::after {
            content: '/';
            color: #ffd800;
            font: 20px arial;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageBody" runat="server">
    <div class="container">
        <div style="float: right" class="divValue">
            <h3>Valores Resgistrado</h3>
            <div>Nome do Anuncios:
                <asp:Label runat="server" ID="lblNomeAnuncio"></asp:Label></div>
            <div>Tempo:<asp:Label runat="server" ID="lblTempoAnuncio"></asp:Label></div>
            <div>Nome do jogo:<asp:Label runat="server" ID="lblNomeJogo"></asp:Label></div>
            <div>Site do jogo:<asp:Label runat="server" ID="lbllinkSite"></asp:Label></div>
            <div>Link para imagem:<asp:Label runat="server" ID="lblLInkImagem"></asp:Label></div>
            <div>Descrição do anuncio:<asp:Label runat="server" ID="lblDescricaoAnuncio"></asp:Label></div>
        </div>
        <table style="width: 57%; margin-left: 217px;" id="form">
            <!-- tabela para organizar o formulario -->
            <tr>
                <td class="TableFormAnuncio" style="font-family: 'Arial Black'; font-size: 13px;">
                    <asp:Label ID="LabelNomeAn" runat="server" Text="Nome Do Anuncio: "></asp:Label>
                </td>
                <td class="TableFormAnuncio">
                    <asp:TextBox ID="TextBoxNomeAn" runat="server" Width="166px"></asp:TextBox>
                    <!-- textbox do nome do anuncio -->
                </td>
            </tr>
            <tr>
                <td class="TableFormAnuncio" style="font-family: 'Arial Black'; font-size: 13px;">Tempo de anuncio:</td>
                <td class="TableFormAnuncio">
                    <!-- list box com a opção do tempo de anuncio -->
                    <asp:DropDownList ID="DropDownListTempo" runat="server">
                        <asp:ListItem Selected="True">3 Dias</asp:ListItem>
                        <asp:ListItem>7 Dias</asp:ListItem>
                        <asp:ListItem>15 Dias</asp:ListItem>
                        <asp:ListItem>30 Dias</asp:ListItem>
                        <asp:ListItem>6 Meses</asp:ListItem>
                        <asp:ListItem>1 Ano</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="TableFormAnuncio" style="font-family: 'Arial Black'; font-size: 13px;">Jogo:</td>
                <td class="TableFormAnuncio">
                    <asp:TextBox ID="txtNomeJogo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="TableFormAnuncio" style="font-family: 'Arial Black'; font-size: 13px;">Link Do Seu Site: &nbsp;&nbsp;</td>
                <td class="TableFormAnuncio">
                    <asp:TextBox ID="TextBoxLinkServer" runat="server" Width="159px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="TableFormAnuncio" style="font-family: 'Arial Black'; font-size: 13px;">
                    <asp:Label ID="Label1" runat="server" Text="Link Da Imagem:"></asp:Label>
                </td>
                <td class="TableFormAnuncio">
                    <asp:TextBox ID="TextBoxLinkAn" runat="server" Width="162px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="TableFormAnuncioDesc" style="font-family: 'Arial Black'; font-size: 13px;">Descrição Do Anuncio: </td>
                <td class="TableFormAnuncioDesc">
                    <asp:TextBox ID="TextBoxDescricao" runat="server" Height="63px" Style="margin-top: 22px" Width="358px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="TableFormAnuncio" style="font-family: 'Arial Black'; font-size: 13px;">&nbsp;</td>
                <td class="TableFormAnuncio">
                    <asp:Button ID="ButtonEditar" OnClick="ButtonEditar_Click" runat="server" BackColor="Red" BorderColor="Black" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" Height="38px" Text="Editar" Width="98px" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
