using System;
using System.Collections.Generic;

namespace CStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World Pilha!");
            Console.WriteLine("----------------");
            Console.WriteLine("Pilha de livros!");
            Console.WriteLine("----------------\n");

            Stack<Livro> pilhaLivros = new Stack<Livro>();

            pilhaLivros.Push(new Livro("In Search of Lost Time", "Marcel Proust", 4215));
            pilhaLivros.Push(new Livro("Ulysses", "James Joyce", 730));
            pilhaLivros.Push(new Livro("Don Quixote", "Miguel de Cervantes", 1072));

            Console.WriteLine($"Primeiro livro do topo da stack: {pilhaLivros.Peek()}");
            pilhaLivros.Pop(); // retira o livro no topo da stack (último a ser adicionado)
            Console.WriteLine("--Removido o livro no topo da stack--");
            Console.WriteLine($"Quandidade atual de livros: {pilhaLivros.Count}");





            foreach (var item in pilhaLivros)
            {
                Console.WriteLine($"{item.ToString()}");
            }
            Console.ReadKey();
        }

        public class Livro
        {
            public string NameLivro { get; set; }
            public string Autor { get; set; }
            public int NumeroPaginas { get; set; }

            public Livro(string nomelivro, string autor, int paginas)
            {
                NameLivro = nomelivro;
                Autor = autor;
                NumeroPaginas = paginas;
            }
            public override string ToString()
            {
                return $"Nome do livro: {NameLivro} | Autor(a): {Autor} | Número de páginas: {NumeroPaginas}";
            }
        }
    }
}