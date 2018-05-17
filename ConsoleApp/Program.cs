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
            Pessoa[] alunos;

            Console.WriteLine("Quantos alunos ?");
            int quantidade = int.Parse(Console.ReadLine());

            alunos = new Pessoa[quantidade];

           for (int posicao = 0; posicao < quantidade; posicao++)
            {
                alunos[posicao] = new Pessoa();
                Console.WriteLine("Qual o nome do aluno?");
                alunos[posicao].nome = Console.ReadLine();
                Console.WriteLine("qual a idade do aluno ?");
                alunos[posicao].idade = int.Parse(Console.ReadLine());
            }

            for (int p = 0; p < quantidade; p++)
            {
                Console.WriteLine("Nome do aluno: " + alunos[p].nome);
                Console.WriteLine("Idade do aluno: " + alunos[p].idade);
            }

            Console.ReadKey();
            
        }
    }
}
