<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Default" MasterPageFile="~/AdminMasterPage.master" %>
<asp:Content ID="DefaultContentHead" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="DefaultConttentBody" ContentPlaceHolderID="PageBody" runat="server">
    <article class="main-article">
        <header>
            PORTAL MMO
            <em>Servers</em>
        </header>
    </article>
    <asp:GridView ID="GridAnuncios" runat="server"></asp:GridView>
</asp:Content>

