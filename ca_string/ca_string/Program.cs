using System;

class InverterStrings
{
    static void Main()
    {
        //solicitar string
        Console.WriteLine("Digite uma string: ");
        string strg = Console.ReadLine();

        //chamar função
        string strgInvertida = InverterString(strg);

        //exibir string invertida
        Console.WriteLine("String invertida: " + strgInvertida);
    }

    //converter string
    static string InverterString(string str)
    {
        char[] caracteres = str.ToCharArray();
        int inicio = 0;
        int fim = caracteres.Length - 1;

        while (inicio < fim)
        {
            //trocar as posições
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            inicio++;
            fim--;
        }
        string invertida = new string(caracteres);
        return invertida;
    }

}