using System;

namespace SISTEMAALUNO
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public string Matricula { get; set; }

        public Aluno(string nome, double nota1, double nota2, string matricula)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Matricula = matricula;
        }

        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2;
        }

        public void ExibirResultado()
        {
            double media = CalcularMedia();
            Console.WriteLine($"Aluno: {Nome} || Matrícula: {Matricula}");
            Console.WriteLine($"Média: {media}");

            if (media >= 6.0)
                Console.WriteLine("Status: Aprovado");
            else
                Console.WriteLine("Status: Reprovado");
        }
    }
}
