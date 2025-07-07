using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Academia
{
    public class Aluno : Pessoa
{
    public string Plano { get; set; }

    public Aluno(string nome, int idade, string plano) : base(nome, idade)
    {
        Plano = plano;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Aluno: {Nome}, Idade: {Idade}, Plano: {Plano}");
    }
}
}