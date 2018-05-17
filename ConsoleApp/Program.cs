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

            bool Trocou;

            do
            {
                Trocou = false;
                for (int i = 0; i < alunos.Length-1; i++)
                {
                    if (alunos[i].nome.CompareTo(alunos[i + 1].nome) > 0)
                    {
                        Pessoa Aux = alunos[i + 1];
                        alunos[i + 1] = alunos[i];
                        alunos[i] = Aux;
                        Trocou = true;
                    }
                }
            } while (Trocou);




            for (int p = 0; p < quantidade; p++)
                Console.WriteLine("Nome: " + alunos[p].nome + " - Idade: " + alunos[p].idade);

            Console.ReadKey();

        }
    }
}
