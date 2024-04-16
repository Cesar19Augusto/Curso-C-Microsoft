//Sorteio com nomes e utilizando uma estrutura de repetição para que caso o usuario não informe "done" ele poder continuar inserindo nomes
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        Console.WriteLine("Digite os nomes dos participantes (digite 'done' para encerrar):");

        // Loop para ler os nomes até que o usuário digite "done"
        string nome;
        while (true)
        {
            nome = Console.ReadLine();

            if (nome.ToLower() == "done")
                break; // Sai do loop se o usuário digitar "done"

            nomes.Add(nome);
        }

        if (nomes.Count == 0)
        {
            Console.WriteLine("Nenhum nome foi fornecido. Encerrando o programa.");
            return;
        }

        Random sorteio = new Random();
        int indiceSorteado = sorteio.Next(nomes.Count); // Sorteia um índice válido na lista de nomes

        string nomeSorteado = nomes[indiceSorteado]; // Obtém o nome sorteado

        Console.WriteLine("O sorteado e: " + nomeSorteado);
    }
}
