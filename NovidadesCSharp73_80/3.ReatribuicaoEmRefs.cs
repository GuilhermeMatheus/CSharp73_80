using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace NovidadesCSharp73_80
{
    public class ReatribuicaoEmRefs
    {
        public void ExecutarTeste()
        {
            var numeros = new [] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            ref int valor = ref ObterReferenciaDeMaiorValor(5, numeros);
        }

        ref int ObterReferenciaDeMaiorValor(int valorDeInteresse, int[] numeros)
        {
            // Antes:
            //var indiceMaior = 0;
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    var atual = numeros[i];
            //    if (atual > numeros[indiceMaior])
            //    {
            //        indiceMaior = i;
            //    }
            //}
            //return ref numeros[indiceMaior];

            ref var maior = ref numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                // fazer comentario sobre REF de locais
                // ref var atual = ref i; 
                ref var atual = ref numeros[i];
                if (atual > maior)
                {
                    maior = ref atual;
                }
            }
            return ref maior;
        }

        ref int ObterReferenciaDeValorPorForeach(int valorDeInteresse, int[] numeros)
        {
            // Comentar sobre o funcionamento do foreach com IEnumerator e a estrutura interna das coleções
            // foreach (var item in new MeuTesteEnumerable())
            // {
            // }

            // explicar por que esse codigo nao poderia funcionar mesmo o numeros sendo array
            // foreach(ref var item in numeros)
            
            // explicar como o foreach esta funcionando para o ref var funcionar
            //foreach (ref var item in new MeuEnumerator())
            //{
            //}

            ref var maior = ref numeros[0];
            Span<int> span = numeros;
            foreach(ref var item in span.Slice(1))
            {
                if (item > maior)
                {
                    maior = ref item;
                }
            }

            return ref maior;
        }
    }

    //class MeuEnumerator
    //{
    //    public Enumerator GetEnumerator() => throw new Exception();
    //    public struct Enumerator
    //    {
    //        public bool MoveNext() => true;
    //        public ref int Current => throw new NotImplementedException();
    //    }
    //}
}
