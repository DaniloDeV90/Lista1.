using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista_Um
{
    public class exercicio1
    {
        public void Soma()
        {
            int A;

            int B;
            int C;
            int Somaa;

            Console.WriteLine("Digite o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            C = Convert.ToInt32(Console.ReadLine());

            Somaa = A + B;


            if (Somaa > C)
            {
                Console.WriteLine("A E B SOMADOS É MAIOR DO QUE C, O VALOR DE C É " + C);
            }
            else if (Somaa == C)
            {
                Console.WriteLine("A e B SOMADOS SÃO IGUAIS, O VALOR DE C É " + C);
            }
            else
            {
                Console.WriteLine("A e B SOMADOS É MENOR DO QUE C, O VALOR DE C É " + C);

            }
            Console.ReadLine();
        }
    }

    public class exercicio2
    {
        public void casamento()

        {
            string? nome;
            string? sexo;
            string? EstadoCivil;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu Sexo F ou M (EM MAIUSCULO): ");

            do
            {
                sexo = Console.ReadLine();
                if (!(sexo == "F" || sexo == "M"))
                {
                    Console.WriteLine("Apenas F ou M (EM MAIUSCULO)");
                }


            } while (!(sexo == "F" || sexo == "M"));

            Console.WriteLine("Digite o seu estado Civil");
            EstadoCivil = Console.ReadLine()!;
            string estadoMaiusculo = EstadoCivil.ToUpper()!;



            var anos = 0;
            if (sexo == "F" && estadoMaiusculo == "CASADA")
            {

                Console.WriteLine("Digite o tempo de casada");
                anos = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("Sexo: " + sexo);



        }
    }

    public class exercicio3
    {
        public void parimpa()
        {
            int numero;
            Console.WriteLine("Digite um numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " É par");
            }
            else
            {
                Console.WriteLine(numero + " É impar");
            }
        }
    }


    public class exercicio4
    {
        public void inteiros()
        {
            int A;
            int B;
            int C;

            Console.WriteLine("Digite o valor de A");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            B = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                C = A + B;
                Console.WriteLine("O resultado da soma de A e B é: " + C);
            }
            else
            {
                C = A * B;
                Console.WriteLine("O resultado da Multiplicação de A e B é: " + (A * B));
            }
        }
    }

    public class exercicio5
    {
        public void dobro()
        {
            int numeroP;

            Console.WriteLine("Digite o valor do número");
            numeroP = Convert.ToInt32(Console.ReadLine());

            if (numeroP < 0)
            {
                Console.WriteLine("Numeri digitado é negativo, triplicando o numero: " + (numeroP * 3));
            }
            else
            {
                Console.WriteLine("Numero digitado é positivo, dobrando o numero:" + (numeroP * 2));

            };
        }
    }

    public class exercicio6
    {
        public void boleanos()
        {
            bool boleano;

            bool boleano1;

            Console.WriteLine("Digite o valor booleano 1");
            boleano = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("Digite o valor booleano 2");
            boleano1 = Convert.ToBoolean(Console.ReadLine());

            if (boleano && boleano1)
            {
                Console.WriteLine("Ambos são verdadeiros");
            }
            else if (boleano || boleano1)
            {
                Console.WriteLine("Ao menos um é verdadeiro");
            }
            else
            {
                Console.WriteLine("Ambos são falsos");
            }
        }
    }

    public class exercicio7
    {
        public void some5()
        {
            int variavel;
            Console.WriteLine("Digite o valor");
            variavel = Convert.ToInt32(Console.ReadLine());

            if (variavel % 2 == 0)
            {
                Console.WriteLine("Número par, somando 5:  " + (variavel + 5));
            }
            else
            {
                Console.WriteLine("Numero impar, somando 8: " + (variavel + 8));
            }
        }
    }

    public class exercicio8
    {
              public void decrescente()
        {
            


            int[] arr = new int[3];

            var valor = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("Digite um número");
                valor = int.Parse(Console.ReadLine());


                if (!arr.Contains (valor)) {
                   
                    arr[i] = valor;
                } else
                {
                    int number;
                    do
                    {

                        Console.WriteLine("Número repetido, corrija: ");
                        number = int.Parse(Console.ReadLine());
                    } while (arr.Contains(number));
                    arr[i] = number;
                }



            }

            Array.Sort(arr);
            Array.Reverse(arr);

            var valorTOT = "";
            foreach (int i in arr)
            {
                valorTOT += (i + " ");
            }
            Console.WriteLine("Os numeros em ordem descrescente são: " + valorTOT);
        }

    }
    public class exercicio9
    {
        public void psoIdeal()
        {
            double Alturap;

            Console.WriteLine("Digite o sua altura");
            Alturap = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o seu sexo (F ou M)");
            string? sexop = Console.ReadLine();
            var sexoMaiusculo = sexop.ToUpper();

            if (sexoMaiusculo == "M")
            {
                double Psoideal = (72.27 * Alturap) - 58;

                Console.WriteLine("O seu peso ideal é: " + (Psoideal.ToString().Split(',')[0]) + " KG");
            }
            else if (sexoMaiusculo == "F")
            {
                double Psoideal = (62.1 * Alturap) - 44.7;

                Console.WriteLine("O seu peso ideal é: " + (Psoideal.ToString().Split(',')[0]) + " KG");
            }


        }
    }

    public class exercicio10
    {
        public void IMC()
        {
            var PesoM = 0.0;
            var alturaM = 0.0;
            Console.WriteLine("Digite o seu peso");
            PesoM = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o sua altura");
            alturaM = Convert.ToDouble(Console.ReadLine());

            double IMC = PesoM / (alturaM * alturaM);

            string ResultadoF = "Seu IMC é: " + IMC.ToString("F");

            if (IMC > 30)
            {
                Console.WriteLine(ResultadoF + " E você está obeso");
            }
            else if (IMC > 25 && IMC < 30)
            {
                Console.WriteLine(ResultadoF + " E você está acima do peso");
            }
            else if (IMC >= 18.5 && IMC <= 25)
            {
                Console.WriteLine(ResultadoF + " E você está no peso ideal");
            }
            else
            {
                Console.WriteLine(ResultadoF + " E você está abaixo do peso");
            }


        }


    }

    public class exercicio11
    {
        public void TABELAPRECOS()
        {
            int qual;
            Console.WriteLine("----TABELA DE PREÇOS----\n 1 para NOTEBOOK: 5087 R$ \n 2 PARA CELULAR: 800 RS$");
            qual = Convert.ToInt32(Console.ReadLine());

            var valorProduto = 0;
            if (qual == 1)
            {
                valorProduto = 5087;
            }
            else if (qual == 2)
            {
                valorProduto = 800;

            }
            else
            {
                Console.WriteLine("Valor inexistente");

            }
            int QUERPAGAREMQUAL;
            Console.WriteLine("-----Escolha a forma de pagamento---- \n 1 PARA A VISTA EM DINHEIRO OU CHEQUE COM 10% DE DESCONTO\n 2 PARA A VISTA NO CARTÃO DE CRÉDITO COM 15% DE DESCONTO \n 3 PARA 2X SEM JUROS \n 4 PARA 2X COM JUROS DE 10%");
            QUERPAGAREMQUAL = Convert.ToInt32(Console.ReadLine());

            if (QUERPAGAREMQUAL == 1)
            {
                Console.WriteLine("Você irá pagar: " + (valorProduto - (valorProduto * 10 / 100)) + " R$ COM DESCONTO DE 10%");
            }
            else if (QUERPAGAREMQUAL == 2)
            {
                Console.WriteLine("Você irá pagar: " + (valorProduto - (valorProduto * 15 / 100)) + " R$ COM DESCONTO DE 15%");
            }
            else if (QUERPAGAREMQUAL == 3)
            {
                Console.WriteLine("Você irá pagar em 2x de " + valorProduto / 2 + " SEM JUROS");
            }
            else if (QUERPAGAREMQUAL == 4)
            {
                double Dsconto = (valorProduto + (valorProduto * 0.1));

                Console.WriteLine("Você irá pagar 2x de " + Dsconto / 2 + " R$ com juros de 10%");
            }
        }

    }

    public class exercicio12
    {
        public void nota()
        {
            string? NomeAluno;


            Console.WriteLine("Digite o nome do ALUNO: ");
            NomeAluno = Console.ReadLine();

            Console.WriteLine("-------");

            Console.WriteLine("Digite a nota 1: ");
            decimal NOTA1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a Média do Exercício 1: ");
            int MediaEx1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------");
            Console.WriteLine("Digite a nota 2: ");
            decimal NOTA2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a Média do exercício 2: ");
            int MediaEx2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------");



            Console.WriteLine("Digite a nota 3: ");
            decimal NOTA3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a Média do Exercício 3: ");
            int MediaEx3 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            decimal MediaEx = (MediaEx1 + MediaEx2 + MediaEx3) / 3;

            decimal Media = (NOTA1 + NOTA2 * 2 + NOTA3 * 3 + MediaEx) / 7;



            decimal Aproveitamento = (Media / 100) * 100;

            if (Media > 100 || Media < 0)
            {
                Console.WriteLine("NOTA ACIMA DE 100/ABAIXO DE 0, VALOR INVÁLIDO");

            }

            if (Media >= 60 && Media <= 100)
            {
                Console.WriteLine("Média de aproveitamento: " + Aproveitamento.ToString("F") + "%");
                Console.WriteLine("Parabéns " + NomeAluno + " Aprovado!!");
            }
            if (Media >= 40 && Media < 60 || Media < 40)
            {
                Console.WriteLine("Média de aproveitamento: " + Aproveitamento.ToString("F") + "%");
                Console.WriteLine("Parabéns  " + NomeAluno + "!!! Tá reprovado kk");
            }
        }
    }
}
