using System;
using System.Collections.Generic;
using System.Text;

// Atencao: Os comentarios em ingles neste arquivo nao farao parte da aula e sao apenas recortes da documentacao.
namespace NovidadesCSharp73_80
{
    class MelhoriaSobrecargaMetodoDeClasseOuEstatico
    {
        public void Testar()
        {
            //MelhoriaSobrecargaMetodoDeClasseOuEstatico.EscreverMensagem((string)null);
            MelhoriaSobrecargaMetodoDeClasseOuEstatico.EscreverMensagem(null);
        }

        public static void EscreverMensagem(string a)
        {
            Console.WriteLine("EscreverMensagem(string)");
        }
        public void EscreverMensagem(StringBuilder b)
        {
            Console.WriteLine("EscreverMensagem(StringBuilder)");
        }
    }


    // When a method group contains some generic methods whose type parameters do not satisfy their constraints, these members are removed from the candidate set.
    class MelhoriaMetodoComArgumentoGenerico
    {
        public void Testar()
        {
            //short meuShort = 0;
            //MelhoriaMetocoComArgumentoGenerico.EscreverMensagem("Pedro", meuShort);
            MelhoriaMetodoComArgumentoGenerico.EscreverMensagem("Pedro", 0);
        }

        public static void EscreverMensagem<T>(T t1, int i) where T : IDisposable
        {
            Console.WriteLine(1);
        }
        public static void EscreverMensagem<T>(T t1, short s)
        {
            Console.WriteLine(2);
        }
    }

    //For a method group conversion, candidate methods whose return type doesn't match up with the delegate's return type are removed from the set.
    class MelhoriaComTipoDeRetornoDoDelegate
    {
        public void Testar()
        {
            //Action<StringBuilder> action = Escrever;
            //ChamaDelegate(action);
            ChamaDelegate(Escrever);
        }

        static void ChamaDelegate(Func<string, int> func) { System.Console.WriteLine("ChamaDelegate(Func<string, int>)"); }
        static void ChamaDelegate(Action<StringBuilder> action) { System.Console.WriteLine("ChamaDelegate(Action<StringBuilder>)"); }

        static void Escrever(string a) { }
        static void Escrever(StringBuilder b) { }
    }
}
