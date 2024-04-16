//Minha versão 
using System;

class testeMatematico
{
    static void Main()
    {
        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);

        Console.WriteLine(largerValue);
    }
}


/* Versão do curso
using System;

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);

*/
