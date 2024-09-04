using System.Reflection.Metadata.Ecma335;
using MinimalApiProject.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "API de Produtos");

List<Produto> produtos = new List<Produto>();

//Adicionando diretamente na lista
produtos.Add(new Produto(){
    Nome = "Notebook",
    Preco = 5000,
    Quantidade = 54
});

produtos.Add(new Produto(){
    Nome = "Alienware",
    Preco = 13000,
    Quantidade = 14
});

produtos.Add(new Produto(){
    Nome = "Pc Hot Wilson",
    Preco = 150000,
    Quantidade = 1
});

app.MapGet("/produtos/listar", () => {
    return Results.Ok(produtos);
    });

    app.MapPost("/produtos/cadastrar/{nome}", (string nome) => {
        //Criar Objeto
        Produto produto = new Produto();
        produto.Nome = nome;
        //Adicionando dentro da lista
        produtos.Add(produto);
        return Results.Ok(produtos);
    });

app.Run();

