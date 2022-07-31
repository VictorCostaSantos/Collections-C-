using System;
using System.Collections;
using System.Collections.Generic;

namespace CQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World Fila!");
            Console.WriteLine("----------------");
            Console.WriteLine("Fila de pessoas!");
            Console.WriteLine("----------------\n");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();

            pessoas.Enqueue(new Pessoa("Jesus", "Las Vegas", 33));
            pessoas.Enqueue(new Pessoa("Israel", "Jerusalem", 45));
            pessoas.Enqueue(new Pessoa("Nick", "Amsterdam", 25));
            pessoas.Enqueue(new Pessoa("Mauricio", "Lisboa", 27));
            pessoas.Enqueue(new Pessoa("Vinicius", "Barcelona", 22));

            Console.WriteLine($"O primeiro da lista é: {pessoas.Peek()}"); // Valida o primeiro da fila

            pessoas.Dequeue(); // Retira o primeiro da fila
            //pessoas.(1);
            Console.WriteLine("--Retirado o primeiro da fila--"); // Avisa que retirou

            Console.WriteLine($"O número de pessoas restantes na fila é: {pessoas.Count}"); // Conta o número de pessoas restantes na fila

            // pessoas.Dequeue();


            foreach (Pessoa pessoa in pessoas) // Imprime cada pessoa restante na fila
            {
                Console.WriteLine(pessoa.ToString());
            }
            Console.ReadKey();

        }
        public class Pessoa
        {
            public string Nome { get; set; }
            public string Cidade { get; set; }
            public int Idade { get; set; }

            public Pessoa(string nome, string cidade, int idade)
            {
                Nome = nome;
                Cidade = cidade;
                Idade = idade;
            }
            public override string ToString()
            {
                return $"Nome: {Nome} | Cidade: {Cidade} | Idade: {Idade}";
            }
        }
        public class Animal
        {
            public string NomeAnimal { get; set; }

            public Animal(string nomeanimal)
            {
                NomeAnimal = nomeanimal;

            }
            public override string ToString()
            {
                return $"Nome: {NomeAnimal}";
            }
        }
        
    }
}