using System;
using System.Collections.Generic;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region arrays
            //#region "codigo"
            //int[] numeros = new int[10];
            //Console.WriteLine("Digite 10 números");
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine($"Número {i + 1}:");
            //    string numaux = Console.ReadLine();
            //    int numero;
            //    int.TryParse(numaux, out numero);
            //    numeros[i] = numero;
            //}
            //int maiorNumero = numeros[0];
            //int menorNumero = 0;
            //foreach (int i in numeros)
            //{
            //    if (maiorNumero < i)
            //    {
            //        maiorNumero = i;
            //    }

            //    if (menorNumero > i)
            //    {
            //        menorNumero = i;
            //    }
            //}
            //devido a array ter tamanho fixo, para remover elementos 
            //precisamos criar um novo array com menos elementos
            //int[] novoArray = new int[numeros.Length - 1];
            //int indice = 0;
            //bool removido = false;
            //foreach (int numero in numeros)
            //{
            //verifica se ainda não removeu o número,
            //    se não removeu ele remove e continua a iteração
            //    if (menorNumero == numero && !removido)
            //    {
            //        removido = true;
            //        continue;
            //    }
            //    novoArray[indice] = numero;
            //    indice++;
            //}
            //Console.WriteLine($"O maior número é: {maiorNumero}");
            //Console.WriteLine($"O array resultante foi:");
            //foreach (int numero in novoArray)
            //{
            //    Console.WriteLine(numero);
            //}

            //#endregion
            #endregion

            #region Listas
            //#region codigo
            //List<int> numeros = new List<int>();
            //Console.WriteLine($"Digite 10 números");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"Número {i}:");
            //    string numaux = Console.ReadLine();
            //    int numero;
            //    int.TryParse(numaux, out numero);
            //    numeros.Add(numero);

            //}
            //int maiorNumero = numeros[0];
            //int menorNumero = numeros[0];
            //foreach (int i in numeros)
            //{
            //    if (maiorNumero < i)
            //    {
            //        maiorNumero = i;
            //    }

            //    if (menorNumero > i)
            //    {
            //        menorNumero = i;
            //    }
            //}
            //Console.WriteLine($"O maior número é: {maiorNumero}");

            //remove o menor numero da lista
            //numeros.Remove(menorNumero);

            //Console.WriteLine($"A lista resultante foi:");
            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}
            //#endregion
            #endregion

            #region "Dicionario"
            #region "codigo"
            //usuario,senha
            Dictionary<string, string> usuarios = new Dictionary<string, string>();
            usuarios.Add("123", "a");
            usuarios.Add("456", "b");
            usuarios.Add("789", "c");

            List<string> usuariosBloqueados = new List<string>();
            usuariosBloqueados.Add("123");
            bool usuarioLogado = false;

            //usuario,tentativa
            Dictionary<string, int> usuariosTentativas = new Dictionary<string, int>();

            while (!usuarioLogado)
            {
                Console.WriteLine("Digite um usuário:");
                string inputUsuario = Console.ReadLine();
                Console.WriteLine("Digite uma senha:");
                string inputSenha = Console.ReadLine();

                //Verifica se o usuário está bloqueado e
                //vai para a proxima iteracao caso esteja
                if (usuariosBloqueados.Contains(inputUsuario))
                {
                    Console.WriteLine("Usuário Bloqueado");
                    continue;
                }
                //percorre os usuarios cadastrados (através da chave)
                foreach (string id in usuarios.Keys)
                {
                    //se o usuario digitado for igual ao usuario da chave
                    if (inputUsuario == id)
                    {
                        //valida se a senha está certa, se estiver
                        //interrompe o laço
                        if (inputSenha == usuarios[id])
                        {
                            usuarioLogado = true;
                            Console.WriteLine("Logado com sucesso");
                            break;
                        }
                        //caso a usuario esteja errada
                        else
                        {
                            //verifica se já houve alguma tentativa para aquele
                            //usuario
                            if (usuariosTentativas.ContainsKey(inputUsuario))
                            {
                                //se ja houve tentativa, acrescenta + 1 ao contador
                                usuariosTentativas[inputUsuario] += 1;
                            }
                            else
                            {
                                //se ainda n'ao houve tentativa, adiciona
                                //no dicionario com valor 1 (1ª tentativa)
                                usuariosTentativas.Add(inputUsuario, 1);
                            }
                            //valida se excedeu o numero de tentativas
                            if (usuariosTentativas[inputUsuario] > 3)
                            {

                                Console.WriteLine($"Número de tentativas máximas excedidas para o usuário {inputUsuario}");
                                //se excedeu bloqueia o usuario (adicionando na lista de usu[arios bloqueados)
                                usuariosBloqueados.Add(inputUsuario);
                                continue;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Falha de autenticação. Usuário ou senha inválidos");
            #endregion
            #endregion
        }
    }
}
