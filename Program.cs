using System;
using System.Collections.Generic;
using System.Xml;

namespace ProjetoCalculadoraV1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Operacoes O = new Operacoes();
            List<double> Result = new List<double>();
            string X;


            do
            {
                Console.Write("Informe o primeiro valor: ");
                O.X = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Informe o segundo valor: ");
                O.Y = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Informe a Operacao (Adicao, Subtracao, Multiplicacao, Divisao): ");
                string Op = Console.ReadLine();


                double Adicao = O.Adicao();
                double Subtracao = O.Subtracao();
                double Multiplicacao = O.Multiplicacao();
                double Divisao = O.Divisao();


                if (Op == "Adicao")
                {
                    Console.WriteLine();
                    Console.WriteLine(O.X + " + " + O.Y + " = " + Adicao.ToString());
                    Result.Add(Adicao);
                }
                else if (Op == "Subtracao")
                {
                    Console.WriteLine();
                    Console.WriteLine(O.X + " - " + O.Y + " = " + Subtracao.ToString());
                    Result.Add(Subtracao);
                }
                else if (Op == "Multiplicacao")
                {
                    Console.WriteLine();
                    Console.WriteLine(O.X + " * " + O.Y + " = " + Multiplicacao.ToString());
                    Result.Add(Multiplicacao);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(O.X + " / " + O.Y + " = " + Divisao.ToString());
                    Result.Add(Divisao);
                }

                Console.WriteLine();
                Console.Write("Deseja continuar (Sim ou Nao)?: ");
                X = (Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("____________________________");
                Console.WriteLine();
            }
            while (X == "Sim"); 

            Console.WriteLine("Resultados Salvos:");
            Console.WriteLine();

            foreach (double item in Result)
            {
                    Console.WriteLine(item);                  
            }          
        }  
    }
}