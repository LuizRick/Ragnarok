<%@ Page Title="" Language="C#" MasterPageFile="~/PortalMasterPage.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RagnarokWeb.Portal.Default" %>

<asp:Content ID="DefaultContentHead" ContentPlaceHolderID="head" runat="server">
    <style>
        .clianuncio{
          
        }
    </style>
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
                    <h1>Server de Jogos</h1>
                </HeaderTemplate>
                <ItemTemplate>
                    <div style="height:90px;"></div>
                    <div class="clianuncio" style="<%# DataBinder.Eval(Container.DataItem, "tamanho") %>">
                        <div class="clianuncio header">
                            <%# DataBinder.Eval(Container.DataItem,"Nome") %>
                        </div>
                        <div class="clianuncio img">
                            <a href="<%# DataBinder.Eval(Container.DataItem,"site") %>" target="_blank">
                                <img src="<%# DataBinder.Eval(Container.DataItem, "link") %>"  style="<%# DataBinder.Eval(Container.DataItem, "tamanho") %>"/>
                            </a>
                        </div>
                        <div class="clianuncio descricao">
                            <%# DataBinder.Eval(Container.DataItem,"Descricao") %>                            
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </section>
    </article>
    
</asp:Content>
