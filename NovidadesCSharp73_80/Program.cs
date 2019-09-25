using System;

namespace NovidadesCSharp73_80
{
    class Program
    {
        static void Main(string[] args)
        {
            new ReadtribuicaoEmRefs();
            ExecutarTeste(new IgualdadeTuples());

            Console.ReadLine();
        }

        static void ExecutarTeste(ITesteRecursoDaLinguagem testeRecursoDaLinguagem)
        {
            Console.WriteLine($"Executando: {testeRecursoDaLinguagem.NomeRecurso}");
            testeRecursoDaLinguagem.Executar();
        }
    }
}
