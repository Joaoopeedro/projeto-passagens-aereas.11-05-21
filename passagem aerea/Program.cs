using System;

namespace passagem_aerea
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes;
            nomes = new string[5];
            string[] origem;
            origem = new string[5];
            string[] destino;
            destino = new string[5];
            string[] data = null;
            data = new string[5];
            string[] nome;
            nome = new string[5];
            string novoCadastro;
            int menu;
            int i2 = 0;

            Console.WriteLine("Bem Vindo a Compania Aérea - Buon Parmeggio! ");

            bool senhaErrada = false;

            do
            {



                Console.WriteLine($"Digite sua senha:");
                int senha = int.Parse(Console.ReadLine());


                if (senha == 123456)
                {
                    do
                    {

                        Console.WriteLine("");
                        Console.WriteLine(
                        $@"
 =======================
 |    MENU PRINCIPAL   |
 |=====================|
 |1- Cadastrar passagem|
 |2- Lista passagem    |
 |0- sair              |
 =======================");
                        menu = int.Parse(Console.ReadLine());




                        if (menu == 1)
                        {

                            do
                            {



                                Console.WriteLine("");
                                Console.WriteLine($"Escreva seu nome:");
                                nomes[i2] = Console.ReadLine();
                                Console.WriteLine("Qual sua origem?");
                                origem[i2] = Console.ReadLine();
                                Console.WriteLine("Qual seu destino?");
                                destino[i2] = Console.ReadLine();
                                Console.WriteLine("Qual sua data de Voo?");

                                data[i2] = Console.ReadLine();
                                i2++;





                                Console.WriteLine("Deseja Cadastrar mais alguma passagem?(s/n)");
                                novoCadastro = Console.ReadLine().ToLower();
                                if (i2 == nome.Length)
                                {
                                   Console.WriteLine("Sua lista de passagens esta cheia!!") ;
                                   break;
                                }

                            } while (novoCadastro == "s");



                        }
                        if (menu == 2)
                        {
                            Console.WriteLine($"Passagens cadastradas:");
                            for (var i = 0; i < i2; i++)
                            {
                                Console.WriteLine($@"-{i + 1}° { nomes[i]} | {origem[i]} - {destino[i]} | {data[i]}");
                            }
                        }

                        if (menu == 0)
                        {
                            Console.WriteLine("Operação finalizada! OBRIGADO!");

                        }

                    } while (menu != 0);
                    senhaErrada = true;

                }
                else
                {
                    Console.WriteLine($@"Senha invalida!|| Tente novamente!");
                }

            } while (senhaErrada == false);











        }
    }
}
