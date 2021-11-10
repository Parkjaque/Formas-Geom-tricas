using System;
using System.Collections.Generic;
using System.Globalization;

namespace Formas_Geométricas_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> list = new List<Forma>();
            Console.WriteLine("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());

            //For utilizado para reconhecer a quantidade de formas, se é um Retangulo ou um Circulo e a cor
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Forma #{i}:");
                Console.Write("Retângulo ou Circulo(R / C) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor: (Preto / Azul / Vermelho): ");
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'R' || ch == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    Console.WriteLine("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }

                Console.WriteLine();
                Console.WriteLine("Área de cada forma: ");

                foreach (Forma forma in list)
                {
                    Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}










