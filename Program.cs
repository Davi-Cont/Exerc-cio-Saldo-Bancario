using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_SaldoBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe o saldo atual da sua conta: ");
                double saldo = double.Parse(Console.ReadLine());

                int cont;
                cont = 1;

                while (cont == 1)
                {

                    Console.WriteLine("Informe a operação desejada:" +
                                        "\n(1) Saque" +
                                        "\n(2) Deposito");
                    int operacao = int.Parse(Console.ReadLine());


                    switch (operacao)
                    {
                        case 1:
                            Console.WriteLine("Informe o valor do saque: ");
                            double valor = double.Parse(Console.ReadLine());

                            if (valor < saldo)
                            {
                                saldo -= valor;

                                Console.WriteLine("Seu saldo atual é de: " + saldo.ToString("C"));
                                Console.WriteLine("Deseja realizar outra operação ?" +
                                                  "\n(1) Sim " +
                                                  "\n(2) Não");
                                cont = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Valor indispnivel");
                                Console.WriteLine("Seu saldo atual é de: " + saldo.ToString("C"));
                                Console.WriteLine("Deseja realizar outra operação ?" +
                                                  "\n(1) Sim " +
                                                  "\n(2) Não");
                                cont = int.Parse(Console.ReadLine());
                            }

                            break;


                        case 2:
                            Console.WriteLine("Informe o valor do deposito: ");
                            valor = double.Parse(Console.ReadLine());

                            saldo += valor;

                            Console.WriteLine("Seu saldo atual é de: " + saldo.ToString("C"));
                            Console.WriteLine("Deseja realizar outra operação ?" +
                                              "\n(1) Sim " +
                                              "\n(2) Não");
                            cont = int.Parse(Console.ReadLine());
                            break;
                    }

                }
            }

            catch(Exception erro)
            {
                Console.WriteLine(erro.Message);
            }

            finally
            {
                Console.WriteLine("Fim da execução");
            }


            Console.ReadKey();
        }
    }
}
