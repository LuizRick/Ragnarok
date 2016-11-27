/// <reference path="jquery.js" />
/*
    Script responsavel por gerenciar e validar os campos
    26/11/2016   - Luiz Henrique Monteiro - Versão 0.0
*/
$(function () {
    $("#btn_login").on('click', function () {
        var email = $("#email_login").val();    //pega o valor do textbox do email
        var senha = $("#senha_login").val();    //pega o valor do textbod da senha
        if (email.indexOf("@") < 0 && email.length == 0) {
            alert("Email Invalido!!!");
            $("#email_login").focus();
            return false;
        }

        if (senha.length < 3) {
            alert("Senha Invalida - Sua senha deve ter Pelomenos 3 caracteres");
            $("#senha_login").focus();
            return false;
        }
        Validar_Login(email);
    });


    /*
        Server Functions
    */

    //função que faz um requisição asyncrona e verifica o email digitado antes de entrar
    function Validar_Login(useremail) {
        $.ajax({
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            async: true,
            cache: false,
            url: "/Admin/Default.aspx/Validar_Login",       //url para WebMethod C#
            data: JSON.stringify({ email: useremail }),
            success: function (response) {
                if(!response.d) //email invalido
                {
                    alert("Email não cadastrado");
                    location.reload();
                }
            },
            error: function () {
                console.dir("Erro na Requisição de validação de email");
            }
        });
    }


    
    function Listar_Anuncios() {
        var sessionId = $("#idsession").val();
        //faz a requisição POST  para o WebMethod / Listar_Anuncios da pagina de anuncios
        $.ajax({
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            async: true,
            cache: false,
            url: "/Admin/Anunciar.aspx/Lista_Anuncios",//url para WebMethod C#
            data: JSON.stringify({ id: sessionId }),
            success: function (response) {
                var html = "";      ///variavel de trabalho para colocar no corpo da pagina dinamicamente
                var anuncios = response.d;
                for(var x in anuncios)
                {
                    var anuncio = anuncios[x];
                    html += "<tr>";
                    html += `<td>${anuncio["codigo"]}</td>`;
                    html += `<td>${anuncio["nome"]}</td>`;
                    html += `<td>${anuncio["jogo"]}</td>`;
                    html += `<td>${anuncio["tempo"]}</td>`;
                    html += `<td>${anuncio["descricao"]}</td>`;
                    html += `<td>${anuncio["site"]}</td>`;
                    html += `<td>${anuncio["link"]}</td>`;
                    html += `<td><a href="/Admin/EditarAnuncio.aspx?id=${anuncio["codigo"]}">Editar</a></td>`;
                    html += `<td><a href="/Admin/ExcluirAnuncio.aspx?id=${anuncio["codigo"]}">Excluir</a></td>`;
                    html += "</tr>";
                }

                $("#corpo").append(html);   //coloca no final da div#corpo da Pagina Anunciar.aspx
            },
            error: function () {
                console.dir("Erro na Requisição de validação de email");
            }
        });
    }
    //ac~ções a serem executadas dependendo da pagina e url
    switch(location.pathname)
    {
        case "/Admin/Anunciar.aspx":
            Listar_Anuncios();
            break;
    }

});