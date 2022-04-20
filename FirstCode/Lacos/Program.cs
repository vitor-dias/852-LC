using System;

namespace Lacos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = "a";
            string senha = "a";
            int qtdTentativasMaxima = 3;
            bool usuarioValido = false;

            #region "FOR"
            //#region "codigo"
            ////for(valor inicial do elemento; condicional de encerrar o laço, incremento)
            ////mesmo resultado, com formas diferentes
            ////i++
            ////i = i + 1;
            ////i += 1;
            //for (int tentativas = 1; tentativas <= qtdTentativasMaxima; tentativas++)
            //{
            //    Console.WriteLine("Digite um usuário:");
            //    string inputUsuario = Console.ReadLine();
            //    Console.WriteLine("Digite uma senha:");
            //    string inputSenha = Console.ReadLine();

            //    if (usuario == inputUsuario && senha == inputSenha)
            //    {
            //        usuarioValido = true;
            //        break;
            //    }
            //    else
            //    {
            //        if (tentativas < qtdTentativasMaxima)
            //        {
            //            Console.WriteLine("Usuário ou senha inválido. Tente novamente.");
            //        }
            //    }
            //}
            //#endregion
            #endregion

            #region "WHILE com número de tentativas"
            //#region "codigo"
            ////while (condicao)
            //int tentativas = 1;
            //while (tentativas <= qtdTentativasMaxima)
            //{
            //    Console.WriteLine("Digite um usuário:");
            //    string inputUsuario = Console.ReadLine();
            //    Console.WriteLine("Digite uma senha:");
            //    string inputSenha = Console.ReadLine();

            //    if (usuario == inputUsuario && senha == inputSenha)
            //    {
            //        usuarioValido = true;
            //        break;
            //    }
            //    else
            //    {
            //        if (tentativas < qtdTentativasMaxima)
            //        {
            //            Console.WriteLine("Usuário ou senha inválido. Tente novamente.");
            //        }
            //    }
            //    tentativas++;
            //}
            ////#endregion
            #endregion

            #region "WHILE até bloquear usuário"
            //#region "codigo"
            //bool usuarioBloqueado = false;
            //int tentativas = 1;
            ////while (condicao)
            ////while (usuarioBloqueado==false)
            //while (!usuarioBloqueado)
            //{
            //    Console.WriteLine("Digite um usuário:");
            //    string inputUsuario = Console.ReadLine();
            //    Console.WriteLine("Digite uma senha:");
            //    string inputSenha = Console.ReadLine();

            //    if (usuario == inputUsuario && senha == inputSenha)
            //    {
            //        usuarioValido = true;
            //        break;
            //    }
            //    else
            //    {
            //        if (tentativas < qtdTentativasMaxima)
            //        {
            //            Console.WriteLine($"Usuário ou senha inválido. Tente novamente.({qtdTentativasMaxima - tentativas} tentativas restantes)");
            //        }

            //        if (tentativas == qtdTentativasMaxima)
            //        {
            //            usuarioBloqueado = true;
            //            Console.WriteLine($"Usuário bloqueado, senta e chora.");
            //            return;
            //        }
            //    }
            //    tentativas++;
            //}
            //#endregion
            #endregion

            //if (usuarioValido)
            //{
            //    Console.WriteLine("Usuário logado com sucesso");
            //}



            
            
            int numeroCalculado = 0;
            int atualTabuada = 0;
            int maximoTabuada = 10;
            bool numeroValido = false;
            string xpto = null;
       
            while (!numeroValido)
            {
                Console.WriteLine("Entra um número para calcular a tabuada até 10.");
                numeroValido = (int.TryParse(Console.ReadLine(),out numeroCalculado) 
                               && numeroCalculado > 0);
                if (numeroValido)
                {
                    break;
                }
                Console.WriteLine("Número inválido");
            }
            do
            {
                Console.WriteLine($"{numeroCalculado}*{atualTabuada} = {numeroCalculado * atualTabuada}");
                atualTabuada++;
            }
            while (atualTabuada <= maximoTabuada);



   
        }
    }
}
