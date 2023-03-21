using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine("1 - Abrir arquivo");
            Thread.Sleep(1000);
            Console.WriteLine("2 - Criar novo arquivo");
            Thread.Sleep(1000);
            Console.WriteLine("0 - Sair");
            Thread.Sleep(1000);


            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
            }
        }

        static void Abrir()
        {

        }
        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("---------------------------------------");
            string text = "";

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {

            }
        }
    }
}

