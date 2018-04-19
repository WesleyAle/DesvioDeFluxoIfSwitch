
using System;
namespace OperacoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
                //Comentário in-line (em linha)
        /*
                 Comentário in-block (em bloco)
         */
         // Declaração da variavel Operação. Ela será do tipo Int (Inteira)
         int operacao;

         // Declaração das variaveis n1 e n2. Elas serão do tipo Double
         double n1, n2;

         /* Para limpar a tela de comando a cada exxecução, ultilizaremos o comando Console.Clear();
          obs.: Clear ->Limpar
          */
          Console.Clear();
          Console.WriteLine(" Escolha uma das operações abaixo:");
          /*
           Para a exibição das opcões de operações, vamos user o comando Console.WriteLine e,
            nele usaremos um comando de quebra de linha \n(contra-barra n (new line)),
            Assim, as opcões ficarão um abaixo da outra  */

            Console.WriteLine("1-soma\n2-Subtrair\n3-Multiplicar\n4-Dividir");
            operacao = int.Parse(Console.ReadLine());
            
            Console.WriteLine(" Digite um número:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Digite outro número");
        }
    }
}
