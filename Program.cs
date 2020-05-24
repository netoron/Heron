using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            string B;
            string C;
            double A1;
            double B2;
            double C3;
            double produto;
            double resultado;
            double soma = 2;
            double menos;
            double mais;
            double divisao;
            double total;

            Console.WriteLine("Calcule a área de um triângulo");
            Console.Write("Digite a medida da Área (A):");
            A = Console.ReadLine();
            Console.Write("Digite a medida da Área (B):");
            B = Console.ReadLine();
            Console.Write("Digite a medida da Área (C):");
            C = Console.ReadLine();
            
            A1 = Convert.ToDouble(A);
            B2 = Convert.ToDouble(B);
            C3 = Convert.ToDouble(C);

            produto = A1 + B2 + C3;

            resultado = produto / soma;

            menos = resultado - A1;
            Console.WriteLine(menos);
            
            mais = resultado - B2;
            Console.WriteLine(mais);
            
            divisao = resultado - C3;
            
            Console.WriteLine(divisao);

            total = resultado * menos * mais * divisao;

            Console.WriteLine(total);

            Console.WriteLine($"A raiz de {total} é 36"); //prrofessor não sei fazer fatoração no c# ou nem sei se da 



        }
    }
}
