using System;


namespace ConsoleApp
{

    class Pessoa
    {
        public string nome;
        public int idade;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa aluno;
            aluno = new Pessoa();
            aluno.nome = "Andre";
            aluno.idade = 20;

            Console.WriteLine(aluno.nome);

            Console.ReadKey();
            
        }
    }
}
