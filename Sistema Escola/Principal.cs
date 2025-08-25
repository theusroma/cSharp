using System;
using System.Globalization;

namespace SISTEMAALUNO{
    class Principal{

        static void Main(string[] args){
            
            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a matrícula do aluno:");
            string matricula = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno aluno = new Aluno(nome, nota1, nota2, matricula);

            aluno.ExibirResultado();
        }
    }
}
