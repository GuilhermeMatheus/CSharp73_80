using System;
using System.Collections.Generic;
using System.Text;

namespace NovidadesCSharp73_80
{
    class IgualdadeTuples : ITesteRecursoDaLinguagem
    {
        public string NomeRecurso => "Operador == e != com tuples";

        public void Executar()
        {
            OperadorIgualdade();
            OperadorIgualdadeComTuplesNomeadas();
            OperadorIgualdadeComTupleExpressions();
            OperadorComNullables();
        }

        private static void OperadorIgualdade()
        {
            var origem = ("Avenida Paulista", "900", "São Paulo");
            var destino = ("Avenida Paulista", "310", "São Paulo");

            // forma antiga
            // var mesmoLugar = enderecoOrigem.Item1 == enderecoDestino.Item1 && enderecoOrigem.Item2 == enderecoDestino.Item2;
            // var mesmoLugar = ComparaTuples(enderecoOrigem, enderecoDestino);

            // syntax sugar para a forma a.item1 == b.item1 && a.item2 == b.item2 && ... && a.itemN == b.itemN
            var mesmoLugar = origem == destino; // false
            Console.WriteLine($"mesmoLugar == {mesmoLugar}");
        }

        public bool ComparaTuples((string nome, string sobrenome) item1, (string nome, string sobrenome) item2)
        {
            return item1.nome == item2.nome && item1.sobrenome == item2.sobrenome;
        }

        private static void OperadorIgualdadeComTuplesNomeadas()
        {
            var origem = (nome: "Avenida Paulista", numero: "2073", cidade: "São Paulo");
            var enderecoConjuntoNacional = (numero: "2073", nome: "Avenida Paulista", cidade: "São Paulo");

            // syntax sugar para a forma:
            //   origem.nome == enderecoConjuntoNacional.numero && <~~
            //   origem.numero == enderecoConjuntoNacional.nome &&
            //   origem.cidade == enderecoConjuntoNacional.cidade
            var origemEhConjuntoNacional = origem == enderecoConjuntoNacional; // false
            Console.WriteLine($"origemEhConjuntoNacional == {origemEhConjuntoNacional}");

            var destino = (nomeRuaOuAvenida: "Avenida Paulista", numeroComComplemento: "2073", nomeCidade: "São Paulo");
            var mesmoLugar = origem == destino; // true
            Console.WriteLine($"mesmoLugar == {mesmoLugar}");

            var lugaresDiferentes = origem != destino; // false
            Console.WriteLine($"lugaresDiferentes == {lugaresDiferentes}");
        }

        private static void OperadorIgualdadeComTupleExpressions()
        {
            Console.WriteLine(("Guilherme", "Costa") == ("Guilherme", "Silveira")); // false
            // Syntax sugar para:
            //    var tuple1 = ("Guilherme", "Costa");
            //    var tuple2 = ("Guilherme", "Silveira");
            //    var ehIgual = tuple1.Item1 == tuple2.Item1 && tuple1.Item2 == tuple2.Item2;
            //    Console.WriteLine(ehIgual);

            //Console.WriteLine(("Guilherme", "Matheus", "Costa") == ("Guilherme", "Silveira")); // erro de compilação
            //Console.WriteLine(("Guilherme", 46546) == ("Guilherme", "Silveira")); // erro de compilação
        }

        private static void OperadorComNullables()
        {
            (string nome, int? idade) pedro = ("Pedro", 15);
            (string nome, int idade) bianca = ("Bianca", 15);

            Console.WriteLine(pedro == bianca); // false
            Console.WriteLine(pedro == ("Pedro", null)); // false

            Console.WriteLine(pedro == ("Pedro", 15)); // true
            Console.WriteLine(pedro.Equals(("Pedro", 15))); // true

            int? a = null;
            int b = 10;
            Console.WriteLine(a == b); // podemos aplicar o operador == entre int? e int
        }
    }
}
