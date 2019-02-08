using System;
using System.Collections.Generic;
using ListaEHJ;

namespace ListaEHJ
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = 10;



            List<ContaBancaria> listaDeContasBancarias = new List<ContaBancaria>();


            while (opcao != 0)
            {


                Console.WriteLine("\n1-Criar conta");
                Console.WriteLine("2-Acessar conta");
                int operacao = Convert.ToInt32(Console.ReadLine());


                //CRIA CONTA
                if (operacao == 1)
                {
                    Console.WriteLine("Tipo de conta:\n 1-Conta Poupança\n 2-Conta Master Especial\n 3-Conta Master Sem Limite\n 0-Voltar");
                    int tipoDeConta = Convert.ToInt32(Console.ReadLine());

                    switch (tipoDeConta)
                    {
                        case -1:
                            {
                                break;
                            }
                        case 1:
                            {
                                ContaPoupanca contaPoupanca = new ContaPoupanca();
                                Console.WriteLine("Preencha os dados:\n");
                                Console.WriteLine("Nome:");
                                contaPoupanca.NomeCliente = Console.ReadLine();
                                Console.WriteLine("CPF:");
                                contaPoupanca.CPF = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Data de nascimento:");
                                contaPoupanca.Aniversario = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("O numero da conta é {0}", contaPoupanca.NumeroDaConta);
                                Console.WriteLine("Conta criada com sucesso");
                                listaDeContasBancarias.Add(contaPoupanca);


                                break;
                            }
                        case 2:
                            {
                                ContaMasterEspecial contaMasterEspecial = new ContaMasterEspecial();
                                Console.WriteLine("Preencha os dados:\n");
                                Console.WriteLine("Nome:");
                                contaMasterEspecial.NomeCliente = Console.ReadLine();
                                Console.WriteLine("CPF:");
                                contaMasterEspecial.CPF = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Data de nascimento:");
                                contaMasterEspecial.Aniversario = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("O numero da conta é {0}", contaMasterEspecial.NumeroDaConta);
                                Console.WriteLine("Conta criada com sucesso");
                                listaDeContasBancarias.Add(contaMasterEspecial);

                                break;
                            }
                        case 3:
                            {
                                ContaMasterSemLimite contaMasterSemLimite = new ContaMasterSemLimite();
                                Console.WriteLine("Preencha os dados:\n");
                                Console.WriteLine("Nome:");
                                contaMasterSemLimite.NomeCliente = Console.ReadLine();
                                Console.WriteLine("CPF:");
                                contaMasterSemLimite.CPF = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Data de nascimento:");
                                contaMasterSemLimite.Aniversario = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("O numero da conta é {0}", contaMasterSemLimite.NumeroDaConta);
                                Console.WriteLine("Conta criada com sucesso");
                                listaDeContasBancarias.Add(contaMasterSemLimite);

                                break;
                            }
                        default:
                            break;
                    }
                }
                //ACESSA CONTA
                if (operacao == 2)
                {
                    ContaPoupanca contaPoupanca = default(ContaPoupanca);
                    ContaMasterEspecial contaMasterEspecial = default(ContaMasterEspecial);
                    ContaMasterSemLimite contaMasterSemLimite = default(ContaMasterSemLimite);

                    Console.WriteLine("Insira o número da conta");
                    var numeroDaConta = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Insira o tipo da conta:\n 1-Conta Poupança\n 2-Conta Master Especial\n 3-Conta Master Sem Limite");
                    var tipoDaConta = Convert.ToInt32(Console.ReadLine());

                    foreach (var conta in listaDeContasBancarias)
                    {
                        if (numeroDaConta == conta.NumeroDaConta)
                        {
                            switch (tipoDaConta)
                            {
                                case 1:

                                    contaPoupanca = conta as ContaPoupanca;
                                    break;

                                case 2:

                                    contaMasterEspecial = conta as ContaMasterEspecial;
                                    break;

                                case 3:

                                    contaMasterSemLimite = conta as ContaMasterSemLimite;
                                    break;

                                default:
                                    break;
                            }
                        } 
                    }
                    int test = 10;
                    while (test != 0)
                    { 
                        //POUPANÇA
                        if (contaPoupanca != default(ContaPoupanca))
                        {
                            Console.WriteLine("Titular: {0}\n", contaPoupanca.NomeCliente);
                            Console.WriteLine("1-Verificar saldo\n2-Cheques disponíveis\n3-Saque\n4-Depósito\n0-SAIR");
                            int opcoesDaConta = Convert.ToInt32(Console.ReadLine());
                            switch (opcoesDaConta)
                            {
                                case -1:
                                    {
                                        break;
                                    }
                                case 1:
                                    {
                                        Console.WriteLine("Seu saldo é R${0}", contaPoupanca.Saldo);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("O número de cheques disponíveis no momento {0} ", contaPoupanca.QuantidadeDeChequesDisponiveis);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Valor de saque:");
                                        decimal valorDeSaque = Convert.ToDecimal(Console.ReadLine());
                                        try
                                        {
                                            if (contaPoupanca.Sacar(valorDeSaque) == true)
                                            {
                                                Console.WriteLine("Saque realizado com sucesso!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Saldo insuficiente!");
                                            }
                                            
                                        }
                                        catch (ArgumentException ex)
                                        {
                                            Console.WriteLine("erro");
                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Valor de depósito:");
                                        decimal valorDeDeposito = Convert.ToDecimal(Console.ReadLine());
                                        try
                                        {
                                            contaPoupanca.Depositar(valorDeDeposito);
                                            Console.WriteLine("Depósito realizado com sucesso!");
                                        }
                                        catch (ArgumentException ex)
                                        {
                                            Console.WriteLine("erro");
                                        }
                                        break;
                                    }
                            }
                        }
                        //MASTER ESPECIAL
                        if (contaMasterEspecial != default(ContaMasterEspecial))
                        {                            
                            Console.WriteLine("Titular: {0}\n", contaMasterEspecial.NomeCliente);
                            Console.WriteLine("1-Verificar saldo\n2-Cheques disponíveis\n3-Saque\n4-Depósito\n5-Verificar limite\n0-SAIR");

                            int opcoesDaContaMasterEspecial = Convert.ToInt32(Console.ReadLine());
                            switch (opcoesDaContaMasterEspecial)
                            {
                                case -1:
                                    {
                                        break;
                                    }
                                case 1:
                                    {
                                        Console.WriteLine("Seu saldo é R${0}\n", contaMasterEspecial.Saldo);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("O número de cheques disponíveis no momento {0}\n", contaMasterEspecial.QuantidadeDeChequesDisponiveis);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Valor de saque:");
                                        decimal valorDeSaque = Convert.ToDecimal(Console.ReadLine());
                                        try
                                        {
                                            if (contaMasterEspecial.Sacar(valorDeSaque) == true)
                                            {
                                                Console.WriteLine("Saque realizado com sucesso!\n");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Saldo insuficiente!\n");
                                            }

                                        }
                                        catch (ArgumentException ex)
                                        {
                                            Console.WriteLine("erro");
                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Valor de depósito:");
                                        decimal valorDeDeposito = Convert.ToDecimal(Console.ReadLine());
                                        try
                                        {
                                            contaMasterEspecial.Depositar(valorDeDeposito);
                                            Console.WriteLine("Depósito realizado com sucesso!\n");
                                        }
                                        catch (ArgumentException ex)
                                        {
                                            Console.WriteLine("erro");
                                        }
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.WriteLine("Valor de limite {0}\n", contaMasterEspecial.valorLimiteDeSaldo);
                                        break;
                                    }
                            }
                        }
                        //MASTER SEM LIMITE
                        if (contaMasterSemLimite != default(ContaMasterSemLimite))
                        {
                            Console.WriteLine("Titular: {0}\n", contaMasterSemLimite.NomeCliente);
                            Console.WriteLine("1-Verificar saldo\n2-Cheques disponíveis\n3-Saque\n4-Depósito\n0-SAIR");

                            int opcoesDaContaMasterSemLimite = Convert.ToInt32(Console.ReadLine());
                            switch (opcoesDaContaMasterSemLimite)
                            {
                                case -1:
                                    {
                                        break;
                                    }
                                case 1:
                                    {
                                        Console.WriteLine("Seu saldo é R${0}\n", contaMasterSemLimite.Saldo);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("O número de cheques disponíveis no momento {0}\n", contaMasterSemLimite.QuantidadeDeChequesDisponiveis);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Valor de saque:");
                                        decimal valorDeSaque = Convert.ToDecimal(Console.ReadLine());
                                        try
                                        {
                                            if(contaMasterSemLimite.Sacar(valorDeSaque) == true)
                                            {
                                                Console.WriteLine("Saque realizado com sucesso!\n");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Saldo insuficiente!\n");
                                            }

                                        }
                                        catch (ArgumentException ex)
                                        {
                                            Console.WriteLine("erro");
                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Valor de depósito:");
                                        decimal valorDeDeposito = Convert.ToDecimal(Console.ReadLine());
                                        try
                                        {
                                            contaMasterSemLimite.Depositar(valorDeDeposito);
                                            Console.WriteLine("Depósito realizado com sucesso!\n");
                                        }
                                        catch (ArgumentException ex)
                                        {
                                            Console.WriteLine("erro");
                                        }
                                        break;
                                    }
                            }
                        }
                    }
                }

                Console.WriteLine("\nDeseja realizar nova operação?\n1-SIM\n0-NÃO");
                opcao = Convert.ToInt32(Console.ReadLine());


            }


        }
    }
}
