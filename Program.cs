﻿using System;
using System.IO;

namespace ProjetoHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ControleFluxo controleFluxo = new ControleFluxo();
            controleFluxo.FilaCovid.LerArq();
            controleFluxo.Internacao.LerArq();
            controleFluxo.FilaInternacao.LerArq();
            controleFluxo.ListaArquivados.LerArq();
            string opc = "a";
            int quant;

            if (!LerArq())
            {
                ConfigIniciais();
            }
            else
            {
                controleFluxo.Internacao.LerArqLeitos();
            }


            do
            {
                Console.Clear();
                opc = Menu();
                switch (opc)
                {
                    case "1":
                        controleFluxo.InserirPaciente();
                        break;
                    case "2":
                        controleFluxo.Recepcao();
                        break;
                    case "3":
                        controleFluxo.Triagem();
                        break;
                    case "4":
                        ListaArquivados();
                        break;
                    case "5":
                        CasosCovid();
                        break;
                    case "6":
                        ListaEmergencia();
                        break;
                    case "7":
                        Internacao();
                        break;
                    default:
                        break;
                }
            } while (opc != "0");

            string Menu()
            {
                Console.WriteLine("***** MENU *****");
                Console.WriteLine("[1]Entrada de Paciente");
                Console.WriteLine("[2]Recepcao");
                Console.WriteLine("[3]Triagem");
                Console.WriteLine("[4]Lista de Arquivados");
                Console.WriteLine("[5]Acompanhar Casos");
                Console.WriteLine("[6]Fila Internacao");
                Console.WriteLine("[7]Internacao");
                Console.WriteLine("[0]Sair");
                return Console.ReadLine();

            }
            void ListaEmergencia()
            {
                string opcao = "a";
                do
                {
                    Console.Clear();
                    Console.WriteLine("Fila Internacao");
                    Console.WriteLine("[1]Buscar Paciente");
                    Console.WriteLine("[2]Imprimir Lista Internacao");
                    Console.WriteLine("[0]Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            controleFluxo.FilaInternacao.BuscarFilaInternacao();
                            break;
                        case "2":
                            controleFluxo.FilaInternacao.ImprimirFilaInternacao();
                            break;
                        case "3":

                            break;
                    }

                } while (opcao != "0");
            }
            void Internacao()
            {
                string opcao = "a";


                do
                {
                    Console.Clear();
                    Console.WriteLine("Internacao");
                    Console.WriteLine("[1]Adicionar Paciente na Internacao");
                    Console.WriteLine("[2]Buscar Paciente");
                    Console.WriteLine("[3]Buscar Paciente Para dar Alta(Arquivar)");
                    Console.WriteLine("[4]Imprimir Lista Internacao");
                    Console.WriteLine("[5]Quantidade de Leitos Disponiveis");
                    Console.WriteLine("[6]Alterar quantidade de Leitos");
                    Console.WriteLine("[0]Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            controleFluxo.InserirInternacao();
                            break;
                        case "2":
                            controleFluxo.Internacao.BuscarInternacao();
                            break;
                        case "3":
                            controleFluxo.BuscarInternacaoAlta();
                            break;
                        case "4":
                            controleFluxo.Internacao.ImprimirInternacao();
                            break;
                        case "5":
                            controleFluxo.Internacao.VerificarLeitos();
                            break;
                        case "6":
                            controleFluxo.Internacao.Leitos();

                            break;
                    }

                } while (opcao != "0");

            }
            void ListaArquivados()
            {
                string opcao = "a";
                do
                {
                    Console.Clear();
                    Console.WriteLine("Lista Arquivados");
                    Console.WriteLine("[1]Buscar Paciente");
                    Console.WriteLine("[2]Imprimir Lista Arquivados");
                    Console.WriteLine("[0]Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            controleFluxo.ListaArquivados.BuscarArquivado();
                            break;
                        case "2":
                            controleFluxo.ListaArquivados.ImprimirListaArquivados();
                            break;
                    }

                } while (opcao != "0");
            }

            void CasosCovid()
            {
                string opcao = "a";
                do
                {
                    Console.Clear();
                    Console.WriteLine("Acompanhar Casos");
                    Console.WriteLine("[1]Buscar Paciente");
                    Console.WriteLine("[2]Imprimir Pacientes que estao sendo acompanhados");
                    Console.WriteLine("[0]Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            controleFluxo.FilaCovid.BuscarFilaCovid();
                            break;
                        case "2":
                            controleFluxo.FilaCovid.ImprimirFilaCovid();
                            break;
                    }

                } while (opcao != "0");
            }

            void ConfigIniciais()
            {
                Console.Clear();
                Console.WriteLine("Bem vindo ao Sistema de controle");
                Console.WriteLine("Necessario a seguinte configuracao para iniciar:");
                Console.WriteLine("Quantos leitos possui a unidade?");
                quant = Convert.ToInt32(Console.ReadLine());
                controleFluxo.Internacao.Leitos(quant);
                Console.WriteLine("Configuracao concluida");
                Console.WriteLine("Pressione uma tecla para ir ao Menu principal");
                Console.ReadKey();
                GravarArq();
            }
            void GravarArq()
            {
                try
                {
                    StreamWriter sw = new StreamWriter("C:\\Users\\matheus\\Config.txt", append: true);
                    sw.WriteLine(quant);
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }

            }
            bool LerArq()
            {
                int quant = 0;
                string line;
                try
                {
                    StreamReader sr = new StreamReader("C:\\Users\\matheus\\Config.txt");
                    line = sr.ReadLine();


                    while (line != null)
                    {
                        quant = Convert.ToInt32(line);
                        line = sr.ReadLine();

                    }

                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                if (quant > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
