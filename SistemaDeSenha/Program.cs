/*using System;
namespace praticando
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 20;
            if (a > b)
            {
                Console.WriteLine("a é maior que b");
            }
            else if (a < b)
            {
                Console.WriteLine("a é menor que b");
            }
            else
            {
                Console.WriteLine("os numeros são iguais");
            }

        }
      
    }
}
*/
using System;

class senhas
{
    static int senhaPreferencial = 1;
    static int senhaComum = 1;

    static void Main()
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Emitir Senha Preferencial");
            Console.WriteLine("2. Emitir Senha Comum");
            Console.WriteLine("3. Chamar Próxima Senha");
            Console.WriteLine("4. Sair");

            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    EmitirSenhaPreferencial();
                    break;
                case 2:
                    EmitirSenhaComum();
                    break;
                case 3:
                    ChamarProximaSenha();
                    break;
                case 4:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }

            Console.WriteLine();
        }
        static void EmitirSenhaPreferencial()
        {
            string senha = "P" + senhaPreferencial.ToString("D3");
            Console.WriteLine("Senha emitida: " + senha);
            senhaPreferencial++;
        }

        static void EmitirSenhaComum()
        {
            string senha = "C" + senhaComum.ToString("D3");
            Console.WriteLine("Senha emitida: " + senha);
            senhaComum++;
        }

        static void ChamarProximaSenha()
        {
            if (senhaPreferencial <= senhaComum)
            {
                string senha = "P" + (senhaPreferencial - 1).ToString("D3");
                Console.WriteLine("Chamando próxima senha: " + senha);
            }
            else
            {
                string senha = "C" + (senhaComum - 1).ToString("D3");
                Console.WriteLine("Chamando próxima senha: " + senha);
            }
        }
    }

  
}