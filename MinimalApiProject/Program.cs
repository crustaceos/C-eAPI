using MinimalApiProject.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "TESTEEE");

app.Run();

Produto produto = new Produto();
produto.Preco = 5;
Console.WriteLine("Preço: " + produto.Preco);

produto.Nome = "nomenome";
Console.WriteLine("O nome é: " + produto.Nome);