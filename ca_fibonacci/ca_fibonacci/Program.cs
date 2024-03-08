using System;

class Fibonacci
{
    //verificar o numero pertence a seq.
    static bool checkFibonacci(int numero)
    {
        if (numero <= 0)
        {
            return false;
        }

        //gerar seq. de Fibonacci
        int a = 0, b = 1;
        while(b < numero)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b == numero;
    }

    static void Main()
    {
        //entrada do número
        Console.WriteLine("Verificar número na Sequência de Fibonacci");
        Console.WriteLine("\nDigite um número: ");
        int numero = int.Parse(Console.ReadLine());


        //fazer verificação
        if(checkFibonacci(numero))
        {
            Console.WriteLine($"\n{numero} pertece à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"\n{numero} não pertece à sequência de Fibonacci.");
        }
    }
}
