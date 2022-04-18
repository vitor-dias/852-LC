using System;

namespace FirstCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "TODOS PASSARAM!";

            int primeiroNumero = 1;
            int segundoNumero = 2;

            int resultado = primeiroNumero + segundoNumero;

            decimal numeroDecimal = decimal.MaxValue;

            DateTime dtAgora = DateTime.Now;

            bool estaChovendo = true;

            //Comando para mostrar mensagem no console
            Console.WriteLine(msg);
            Console.WriteLine(primeiroNumero);
            Console.WriteLine(segundoNumero);
            Console.WriteLine(resultado);
            Console.WriteLine(numeroDecimal);
            Console.WriteLine(dtAgora);
            Console.WriteLine(estaChovendo);

            Console.WriteLine("Digite um caracter");

            //Comando para leitura de valor digitado no console
            string inputUsuario = "";
            inputUsuario = Console.ReadLine();

            Console.WriteLine("O caracter digitado foi: " +  inputUsuario);


        }
    }
}