using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nome = new string [10];
            string [] telefone = new string [10];
            string[] email = new string [10];
            int i, editar = 0, pos = 0, cont = 0, menu = 0;
            int  resposta, resposta1;
            string edit, excluir;
            

            while (true)
            {
                Console.WriteLine("Agenda de contatos \n");
                Console.WriteLine("[1] - Cadastrar");
                Console.WriteLine("[2] - Listar");
                Console.WriteLine("[3] - Editar");
                Console.WriteLine("[4] - Excluir");
                Console.WriteLine("[5] - Sair \n");
                Console.WriteLine("Digite a opção escolhida");
                menu = Int32.Parse(Console.ReadLine());
                Console.Clear();

                if (menu == 1)
                {
                    for (i = cont; i < 10; i++)
                    {
                        Console.WriteLine("Menu Cadastrar \n");
                        Console.WriteLine(" Digite o nome do contato a ser salvo \n");
                        nome[i] = Console.ReadLine();
                        Console.WriteLine("\n Digite o email do contato a ser salvo \n");
                        email[i] = Console.ReadLine();
                        Console.WriteLine("\n Digite o telefone do contato a ser salvo \n");
                        telefone[i] = Console.ReadLine();
                        cont++;
                        Console.WriteLine("\n Contato cadastrado com sucesso");
                        Console.WriteLine("\n Deseja fazer outro cadastro? \n");
                        Console.WriteLine("[1] - Sim / [2] - Não");
                        resposta = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        if (resposta == 2)
                        {                                                   
                            break;
                        }                                                            
                    }
                    
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Menu Listar \n");
                    if (cont == 0)
                    {
                        Console.WriteLine("Não existem contatos cadastrados!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    for (i = 0; i < cont; i++)
                    {
                        Console.WriteLine("\n [" + i + "] + Nome:" + nome[i] );
                        Console.WriteLine(" [" + i + "] + Email: " + email[i]); 
                        Console.WriteLine(" [" + i + "] + Telefone: " + telefone[i]);
                        Console.WriteLine("\n");                       
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Menu Editar \n");
                    Console.WriteLine("Digite o nome do contato que deseja editar");
                    edit = Console.ReadLine();
                    Console.Clear();
                    for (i = 0; i <cont; i++)
                    {
                        if (edit == nome[i])
                        {
                            Console.WriteLine("O que você deseja editar? \n");
                            Console.WriteLine("[1] - Nome");
                            Console.WriteLine("[2] - Email");
                            Console.WriteLine("[3] - Telefone");
                            Console.WriteLine("[4] - Tudo");
                            Console.WriteLine("[5] - Sair");
                            editar = Int32.Parse(Console.ReadLine());

                            if (editar == 1)
                            {
                                Console.WriteLine("Digite o novo nome");
                                nome[i] = Console.ReadLine();
                            }
                            else if (editar == 2)
                            {
                                Console.WriteLine("Digite o novo email");
                                email[i] = Console.ReadLine();
                            }
                            else if (editar == 3)
                            {
                                Console.WriteLine("Digite o novo telefone");
                                telefone[i] = Console.ReadLine();
                            }
                            else if (editar == 4)
                            {
                                Console.WriteLine("Digite o novo nome");
                                nome[i] = Console.ReadLine();
                                Console.WriteLine("Digite o novo email");
                                email[i] = Console.ReadLine();
                                Console.WriteLine("Digite o novo telefone");
                                telefone[i] = Console.ReadLine();                                
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                        }
                    }                                   
                }
                else if (menu == 4)
                {
                    Console.WriteLine("Menu Excluir \n");
                    Console.WriteLine("Digite o nome do contato que deseja excluir \n");
                    excluir = Console.ReadLine();

                    for (i = 0; i < cont; i++)
                    {
                        if (excluir == nome[i])
                        {
                            pos = i;
                            Array.Clear(nome, i, 1);
                            Array.Clear(telefone, i, 1);
                            Array.Clear(email, i, 1);
                            Console.WriteLine("Contato excluído com sucesso");
                            cont--;

                            for (i = 0; i < cont; i++)
                            {
                                if (pos == 1)
                                {
                                    nome[i] = nome[(i + 1)];
                                    telefone[i] = telefone[(i + 1)];
                                    email[i] = email[(i + 1)];
                                    pos++;
                                }                              
                            }

                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado na agenda!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Deseja mesmo sair? \n");
                    Console.WriteLine("[1] - sim / [2] - não");
                    resposta1 = Int32.Parse(Console.ReadLine());

                    if (resposta1 == 1)
                    {
                        break;
                    }
                    Console.Clear();
                }              
            }
            Console.ReadLine();
        }
    }
}
