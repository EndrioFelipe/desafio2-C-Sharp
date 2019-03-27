using Desafio2.Mascara;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio 2");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("O programa abaixo é um formatador de CPF, ele pede que você digite o CPF e logo após exibe o resultado formatado.");
            Console.WriteLine("Até o momento, ele só funciona caso digite os 11 numeros. Ex: 12345678901 => 123.456.789-01");
            Console.WriteLine("Ajuste o codigo existente para que o formatador de CPF também funcione nos seguintes casos:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1) Caso digite menos de 11 números, exibir a formatação nos números digitados. Ex: 1234567 => 123.456.7");
            Console.WriteLine("2) Não gerar erro caso digite letras, simbolos ou CPF parcialmente formatado. Ex: 123456789-01 => 123.456.789-01");
            Console.WriteLine("3) Caso não digite nada, exibir a mensagem 'É necessário digitar o CPF'");
            Console.WriteLine("4) Após formatar o CPF, solicitar para digitar novamente até que seja informado SAIR");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("ATENÇÂO: Deve-se implementar os casos acima utilizando como base o codigo já existente.");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("         Formatador de CPF v0.1 ");
            Console.WriteLine("--------------------------------------------------");
            string cpf = null;
            while (cpf!="SAIR") { 
                try
                {
                          

                    Console.WriteLine("Digite um CPF ou digite SAIR:");
                    cpf = Console.ReadLine();





                    char[] arrayDeChar = cpf.ToCharArray();

                    for(int i = 0; i<cpf.Length; i++)
                    {
                        if (!Char.IsDigit(arrayDeChar[i]))
                        {
                            arrayDeChar[i] = ' ';
                        }
                    }
                    string astr = new string(arrayDeChar);
                    string trim = Regex.Replace(astr, @" ", "");




                    MascaraCPF mascaraCPF = new MascaraCPF();
                    string cpfFormatado = mascaraCPF.Aplicar(trim);
                    Console.WriteLine($"CPF Formatado: {cpfFormatado}");


                

                }
                catch (Exception ex)
                {
                    Console.ReadKey();

                }

               

            }
        }
    }
}
