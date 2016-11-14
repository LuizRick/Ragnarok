<%@ Page Title="" Language="C#" MasterPageFile="~/PortalMasterPage.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RagnarokWeb.Portal.Default" %>

<asp:Content ID="DefaultContentHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="DefaultConttentBody" ContentPlaceHolderID="PageBody" runat="server">
    <article class="main-article">
        <header>
            PORTAL MMO
            <em>Servers</em>
        </header>
    </article>
    <article class="content" style="margin-top:13px;margin-left:12px;">
        <section>
            <asp:Repeater ID="ResultAnuncios" runat="server">
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="clianuncio" style="<%# DataBinder.Eval(Container.DataItem, "tamanho") %>">
                        <div class="clianuncio header">
                            <%# DataBinder.Eval(Container.DataItem,"Nome") %>
                        </div>
                        <div class="clianuncio img">
                            <img src="<%# DataBinder.Eval(Container.DataItem, "link") %>"  style="<%# DataBinder.Eval(Container.DataItem, "tamanho") %>"/>
                        </div>
                        <div class="clianuncio descricao">
                            <%# DataBinder.Eval(Container.DataItem,"Descricao") %>
                        </div>
                    </div>
                    <div style="margin:10px 0 11px 0"></div>
                </ItemTemplate>
            </asp:Repeater>
        </section>
    </article>
</asp:Content>
