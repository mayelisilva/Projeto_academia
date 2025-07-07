using System;
using System.Collections.Generic;

namespace Projeto_Academia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa aluno1 = new Aluno("Carlos", 25, "Musculação");
            Pessoa aluno2 = new Aluno("Juliana", 32, "Crossfit");
            Pessoa instrutor1 = new Instrutor("André", 40, "Treinamento Funcional");

            pessoas.Add(aluno1);
            pessoas.Add(aluno2);
            pessoas.Add(instrutor1);

            Console.WriteLine("Lista de Pessoas da Academia:");
            foreach (var pessoa in pessoas)
            {
                pessoa.ExibirInformacoes();
            }
        }
    }
}