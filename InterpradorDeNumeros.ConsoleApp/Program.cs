using System;

namespace InterpradorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto =
                            "     __  __      __  __  __  __  __  __ "+ Environment.NewLine +
                            "   | __| __||__||__ |__    ||__||__||  |"+ Environment.NewLine +
                            "   ||__  __|   | __||__|   ||__| __||__|";

            Console.WriteLine(texto);

            System.IO.StringReader stringReader = new System.IO.StringReader(texto);

            string primeiraLinha = stringReader.ReadLine();
            string segundaLinha = stringReader.ReadLine();
            string terceiraLinha = stringReader.ReadLine();
            int tamanhoLinha = primeiraLinha.Length;

            for (int i = 0; i < tamanhoLinha; i+=4)
            {

                if(primeiraLinha[i+1] == ' ' && primeiraLinha[i+2] == ' ' && primeiraLinha[i+3] == ' '
                    && segundaLinha[i+1] == ' ' && segundaLinha[i+2] == ' ') {

                    Console.Write("1");

                }
                
                else if(primeiraLinha[i+1] == '_' && primeiraLinha[i+2] == '_' && terceiraLinha[i] == '|' 
                    && terceiraLinha[i+1] == '_' && terceiraLinha[i+2] == '_' && terceiraLinha[i+3] == ' ')
                {

                    Console.Write("2");

                }
                else if(primeiraLinha[i] == ' ' && segundaLinha[i] == ' ' && terceiraLinha[i] == ' '
                    && segundaLinha[i+1] == '_' && segundaLinha[i+2] == '_' && segundaLinha[i+3] == '|')
                {

                    Console.Write("3");
                    
                }
                else if (primeiraLinha[i] == ' ' && primeiraLinha[i+1] == ' ' && primeiraLinha[i+2] == ' '
                    && segundaLinha[i] == '|' && terceiraLinha[i+1] == ' ' && terceiraLinha[i+2] == ' ')
                {

                    Console.Write("4");

                }
                else if (segundaLinha[i] == '|' && segundaLinha[i+3] == ' ' && terceiraLinha[i] == ' ')
                {

                    Console.Write("5");

                }
                else if (segundaLinha[i] == '|' && segundaLinha[i + 3] == ' ' && terceiraLinha[i] == '|')
                {

                    Console.Write("6");

                }
                else if (primeiraLinha[i] == ' ' && segundaLinha[i] == ' ' && segundaLinha[i+1] == ' ' 
                    && segundaLinha[i+2] == ' ' && terceiraLinha[i] == ' ' && terceiraLinha[i + 1] == ' '
                    && terceiraLinha[i + 2] == ' ')
                {

                    Console.Write("7");

                }
                else if (segundaLinha[i] == '|' && segundaLinha[i+1] == '_' && segundaLinha[i+2] == '_' 
                    && segundaLinha[i+3] == '|' && terceiraLinha[i] == '|' && terceiraLinha[i + 1] == '_' 
                    && terceiraLinha[i + 2] == '_' && terceiraLinha[i + 3] == '|')
                {

                    Console.Write("8");

                }
                else if (segundaLinha[i] == '|' && segundaLinha[i + 1] == '_' && segundaLinha[i + 2] == '_'
                    && segundaLinha[i + 3] == '|' && terceiraLinha[i] == ' ' && terceiraLinha[i + 1] == '_'
                    && terceiraLinha[i + 2] == '_' && terceiraLinha[i + 3] == '|')
                {

                    Console.Write("9");

                }
                else
                {

                    Console.Write("0");

                }

            }

            Console.ReadKey();
        }
    }
}
