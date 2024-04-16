using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
	//definindo a variavel da media dos alunos
        int mediaAlunos = 5;
	//declarando os valores das notas
        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;

        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;

        int zahirah1 = 84;
        int zahirah2 = 96;
        int zahirah3 = 73;
        int zahirah4 = 85;
        int zahirah5 = 79;

        int jeong1 = 90;
        int jeong2 = 92;
        int jeong3 = 98;
        int jeong4 = 100;
        int jeong5 = 97;

        // Calculando as somas das notas de cada aluno
        int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
        int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
        int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
        int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

        // Calculando as médias das notas de cada aluno
        decimal sophiaCalc = (decimal)sophiaSum / mediaAlunos;
        decimal nicolasCalc = (decimal)nicolasSum / mediaAlunos;
        decimal zahirahCalc = (decimal)zahirahSum / mediaAlunos;
        decimal jeongCalc = (decimal)jeongSum / mediaAlunos;

        // Definindo o dicionário para mapear os intervalos de notas para as letras correspondentes
        Dictionary<int, string> definicaoDasNotas = new Dictionary<int, string>()
        {
            { 97, "A+" },
            { 93, "A" },
            { 90, "A-" },
            { 87, "B+" },
            { 83, "B" }
        };

        // Função para atribuir a nota correspondente com base no intervalo
        string AtribuirNota(decimal nota)
        {
            foreach (var intervalo in definicaoDasNotas)
            {
                if (nota >= intervalo.Key)
                {
                    return intervalo.Value;
                }
            }
            return "Nota não definida";
        }

        // Imprimindo as notas finais dos alunos
        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" +AtribuirNota(sophiaCalc));
        Console.WriteLine("Nicolas:\t" +AtribuirNota(nicolasCalc));
        Console.WriteLine("Zahirah:\t" +AtribuirNota(zahirahCalc));
        Console.WriteLine("Jeong:\t\t" +AtribuirNota(jeongCalc));
    }
};

/*

//Resultado do curso
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");
*/
