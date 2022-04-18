using System;

namespace Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //podemos chamar variaveis de qualquer nome, inclusive batata
            string batata = Console.ReadLine();

            #region "Exemplo condicional com AND e OR"
            //Criação da primeira condicional se libera ou não empréstimos
            int salario;
            int emprestimo;
            bool nomeSujo = false;
            Console.WriteLine("Digite o seu salário:");
            Console.WriteLine("Digite o valor do empréstimo:");
            int.TryParse(Console.ReadLine(), out salario);
            int.TryParse(Console.ReadLine(), out emprestimo);

            //Condicional utilizando o || (OR)
            if (nomeSujo || (emprestimo > (salario * 0.2)))
            {
                Console.WriteLine("Empréstimo não concedido");
            }
            else
            {
                Console.WriteLine("Empréstimo concedido");
            }

            //Condicional utilizando o && (AND)
            if (!(emprestimo > (salario * 0.2)) & !nomeSujo)
            {
                Console.WriteLine("Empréstimo concedido");
            }
            else
            {
                Console.WriteLine("Empréstimo não concedido");
            }
            #endregion

            #region "Condicional mais complexo, usando else if ou switch"

            #region "Else IF"

            Console.WriteLine("Digite um dia da semana de 1 a 7");
            int diaSemana;
            if (!int.TryParse(Console.ReadLine(), out diaSemana))
            {
                Console.WriteLine("Número inválido");
                return;
            }

            if (diaSemana == 7)
            {
                Console.WriteLine();
            }
            else if (diaSemana == 1)
            {
                Console.WriteLine("O dia digitado foi Domingo");
            }
            else if (diaSemana == 2)
            {
                Console.WriteLine("O dia digitado foi Segunda");
            }
            else if (diaSemana == 3)
            {
                Console.WriteLine("O dia digitado foi Terça");
            }
            else if (diaSemana == 4)
            {
                Console.WriteLine("O dia digitado foi Quarta");
            }
            else if (diaSemana == 5)
            {
                Console.WriteLine("O dia digitado foi Quinta");
            }
            else if (diaSemana == 6)
            {
                Console.WriteLine("O dia digitado foi Sexta");
            }
            else
            {
                Console.WriteLine("Dia inválido");
            }
            #endregion

            #region "Switch 2.0 Enhanced Version plus ultra interpolação "

            string diaPorExtenso = "";
            switch (diaSemana)
            {
                case 1:
                    diaPorExtenso = "Domingo";
                    break;
                case 2:
                    diaPorExtenso = "Segunda";
                    break;
                case 3:
                    diaPorExtenso = "Terça";
                    break;
                case 4:
                    diaPorExtenso = "Quarta";
                    break;
                case 5:
                    diaPorExtenso = "Quinta";
                    break;
                case 6:
                    diaPorExtenso = "Sexta";
                    break;
                case 7:
                    diaPorExtenso = "Sábado";
                    break;
                default:
                    Console.WriteLine("Dia inválido");
                    return;
            }
            Console.WriteLine($"O número digitado foi {diaSemana} que equivale a {diaPorExtenso}");
            #endregion

            #endregion
        }
    }
}
