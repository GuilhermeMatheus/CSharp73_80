using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NovidadesCSharp73_80
{
    [DebuggerDisplay("AtributosEmBackfield ID: {id}")]
    class AtributosEmBackfield
    {
        static int contador = 0;
        int id = contador++;

        [field: DebuggerDisplay("aaa")]
        public string Nome { get; set; }
    }
}
