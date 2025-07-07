using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Academia
{
    public class Instrutor : Pessoa
{
    public string Especialidade { get; set; }

    public Instrutor(string nome, int idade, string especialidade) : base(nome, idade)
    {
        Especialidade = especialidade;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Instrutor: {Nome}, Idade: {Idade}, Especialidade: {Especialidade}");
    }
}
}