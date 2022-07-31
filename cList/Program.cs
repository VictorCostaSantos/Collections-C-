using System;
using System.Collections.Generic;

namespace CList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World List!");
            Console.WriteLine("-----------------");
            Console.WriteLine("Lista de animais!");
            Console.WriteLine("-----------------\n");
            //Escrito igual abaixo em apenas uma linha
            //List<string> listaNomes;
            //listaNomes = new List<string>();

            //igual o de cima, mas escrito em apenas uma linha
            List<Animal> listaAnimal = new List<Animal>();

            listaAnimal.Add(new Animal("Cachooro"));
            //Raposa vai ser adicionada (posição 2, começa do 1) e vai ser removida (índice 1, começa do zero)
            listaAnimal.Add(new Animal("gato"));
            listaAnimal.Add(new Animal("Cobra"));
            listaAnimal.Add(new Animal("Camelo")); // último animal será removido

            foreach (var nomeanimal in listaAnimal) // Imprime a lista inicial
            {
                Console.WriteLine($"Aqui está o animal: {nomeanimal}");
            }
            Console.WriteLine("\n");

            listaAnimal.Insert(1, new Animal("Raposa")); // insere raposa na posição 2
            Console.WriteLine("Adicionado raposa na posição 2");
            Console.WriteLine("\n");

            foreach (var nomeanimal in listaAnimal) // Imprime a lista após adicionar a raposa
            {
                Console.WriteLine($"Aqui está o animal: {nomeanimal}");
            }
            Console.WriteLine("\n");

            //listaNomes.Remove("Zebra");
            listaAnimal.RemoveAt(listaAnimal.Count - 1); // remove o último animal da lista
            Console.WriteLine("Removido o último animal da lista");
            listaAnimal.RemoveAt(1); // remove posição 1 do índice
            Console.WriteLine("Removida a posição 1 do índice");
            Console.WriteLine("\n");
            Console.WriteLine("Lista final abaixo: ");
            foreach (var nomeanimal in listaAnimal) // Imprime a lista final
            {
                Console.WriteLine($"Aqui está o animal: {nomeanimal}");
            }
            Console.ReadKey();
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