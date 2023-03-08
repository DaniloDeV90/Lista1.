using Exercicios_Lista_Um;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericiosLista2
{
    public class Ex1
    {
        static void Main(string[] args)
        {

            string? Result;
            do
            {
                Console.WriteLine("Digite qual exercicio você quer executar ou (s) para finalizar");
                Result = Console.ReadLine();


                switch (Result)
                {
                    case "1":

                        exercicio1 exercicio1 = new exercicio1();
                        exercicio1.Soma();

                        break;
                    case "2":
                        exercicio2 exercicio2 = new exercicio2();
                        exercicio2.casamento();

                        break;
                    case "3":
                        exercicio3 exercicio3 = new exercicio3();
                        exercicio3.parimpa();
                        break;

                    case "4":
                        exercicio4 exercicio4 = new exercicio4();
                        exercicio4.inteiros();


                        break;
                    case "5":
                        exercicio5 exercicio5 = new exercicio5();
                        exercicio5.dobro();
                        break;
                    case "6":
                        exercicio6 exercicio6 = new exercicio6();
                        exercicio6.boleanos();

                        break;

                    case "7":
                        exercicio7 exercicio7 = new exercicio7();
                        exercicio7.some5();
                        break;


                    case "8":

                        exercicio8 exercicio8 = new exercicio8();
                        exercicio8.decrescente();
                        break;

                    case "9":

                        exercicio9 exercicio9 = new exercicio9();
                        exercicio9.psoIdeal();

                        break;

                    case "10":
                        exercicio10 exercicio10 = new exercicio10();
                        exercicio10.IMC();

                        break;

                    case "11":

                        exercicio11 exercicio11 = new exercicio11();
                        exercicio11.TABELAPRECOS();
                        break;

                    case "12":

                        exercicio12 exercicio12 = new exercicio12();
                        exercicio12.nota();



                        break;


                    case "s":

                        Console.Clear();
                        continue;

                }
                if (Result != "s")
                {
                    Console.WriteLine("Pressione Enter para escolher o proximo exercicio ou um exercicio válido");

                }

                Console.ReadLine();
                Console.Clear();

            } while (Result != "s");

        }
    }
}