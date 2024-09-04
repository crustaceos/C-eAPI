using Microsoft.AspNetCore.SignalR;

namespace MinimalApiProject.Models;

public class Produto
{
    //C# GETTERS E SETTERS
    public double Preco{get; set;}

    public string? Nome {get; set;}

    public string? Id{get; set;}

    public int Quantidade{get; set;}

    public DateTime CriadoEm { get; set; }


    //JAVA GETTERS E SETTERS
    //private double preco;

    //public double getPreco(){
        //return preco;
    //}

    //public void setPreco(double preco){
        //this.preco = preco * 3;
    //}
}
