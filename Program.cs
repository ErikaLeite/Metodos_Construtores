using System;
using Metodos_Construtores.classes;

namespace Metodos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();//Método Construtor Vazio
            Console.WriteLine($"Código = {p1.Codigo} Nome = {p1.Nome ?? "vazio"} Descrição = {p1.Descricao ?? "vazio"} Estoque = {p1.Estoque}");

            Produto p2 = new Produto(2506);//Método Construtor que solicita um número inteiro para ser acessado
            Console.WriteLine($"Código = {p2.Codigo} Nome = {p2.Nome ?? "vazio"} Descrição = {p2.Descricao ?? "vazio"} Estoque = {p2.Estoque}");

            Produto p3 = new Produto(9985, "Fanta Laranja", "Refrigerante sabor Laranja", 60); //Método Construtor que solicita 4 informações diferentes para ser acessado
            Console.WriteLine($"Código = {p3.Codigo} Nome = {p3.Nome ?? "vazio"} Descrição = {p3.Descricao ?? "vazio"} Estoque = {p3.Estoque}");

        }
    }
}
