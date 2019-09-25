using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace NovidadesCSharp73_80
{
    class ExpressionVariables : ITesteRecursoDaLinguagem
    {
        public string NomeRecurso => "Expression Variables";

        public readonly bool AplicacalPossuiPortaAlta =
            int.TryParse(ConfiguracoesAplicacaoWeb.porta, out var numeroPorta) && numeroPorta > 3000;

        public void Executar()
        {
            throw new NotImplementedException();
        }

        public void ComQueries()
        {
            var registroAlunos = new string[] { "1110651", "1110600", "1110800", "111060A", "111060C" };

            //int num;
            //var registroAlunosNumericos =
            //    from registro in registroAlunos
            //    where int.TryParse(registro, out num) && num > 11106
            //    select registro;

            var registroAlunosNumericos =
                from registro in registroAlunos
                where int.TryParse(registro, out var num) && num > 11106
                select registro;

            // select new { registro, num }; continua não funcionando
        }
    }

    class ConfiguracoesAplicacao
    {
        public ConfiguracoesAplicacao(out int idProcesso)
        {
            idProcesso = 124;
        }
    }

    class ConfiguracoesAplicacaoWeb : ConfiguracoesAplicacao
    {
        public static string porta = "8080";

        //public ConfiguracoesAplicacaoWeb(out int idProcesso) : base(out idProcesso)
        //{
        //}

        public ConfiguracoesAplicacaoWeb() : base(out int idProcesso)
        {

        }
    }
}
