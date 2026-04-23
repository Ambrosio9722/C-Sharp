using System;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            int idade = 10;
            double valor = 123;
            string nome = "Maria";
            
           

            Console.WriteLine(idade);
            Console.WriteLine("{0} tem {1} anos, com o valor de {2} reais", nome, idade, valor);
            Console.WriteLine(nome + " tem " + idade + " anos, com o valor de " + valor.ToString("F2") + " reais");

            //--------  Exercicio 01 --------
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade1 = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine(produto1+", cujo preço é $ "+preco1);
            Console.WriteLine(produto2 + "cujo preco é $ " + preco2);
            Console.WriteLine("Registro "+idade1+" anos de idade");
        }
    }
}