// usa o System, que tem as principais classes usadas
using System;
//cria a classe Programa
class Programa
{
    //cria um principal para começar o programa
    static void Main()
    {
        //cria duas variáveis inteiras com valor 1
        int num, i = 1;

        //fala com o user
        Console.WriteLine("Digite um número inteiro positivo: ");
        //guarda a resposta do user como valor da variável 'num'
        num = int.Parse(Console.ReadLine());


        //enquanto a variável i for menor ou igual à variável num
        while (i <= num)
        {

            //o programa vai falar para o user o valor de i seguido de um espaço
            Console.WriteLine( i + " ");
            //depois vai aumentar 1 em i
            i++;
            //desse modo o while vai fazer a contagem desde o 1 e repetir até chegar no valor da variável num

        }
    }

}
