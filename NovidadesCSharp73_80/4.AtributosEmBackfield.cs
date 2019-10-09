using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NovidadesCSharp73_80
{
    [Serializable]
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {
            DataCriacao = DateTime.Now;
        }

        [field: NonSerialized]
        public DateTime DataCriacao { get; set; }

        //[NonSerialized]
        //private DateTime _dataCriacao;
        //public DateTime DataCriacao
        //{
        //    get { return _dataCriacao; }
        //    private set { _dataCriacao = value; }
        //}
    }

    class AtributosEmBackfield
    {
        public void Testar()
        {
            var stream = new MemoryStream();
            var streamWriter = new StreamWriter(stream);
            var serializador = new XmlSerializer(typeof(Pessoa));

            var pessoa = new Pessoa
            {
                DataNascimento = new DateTime(1990, 5, 1),
                Nome = "Nathalia",
                Id = 20
            };

            serializador.Serialize(streamWriter, pessoa);
            stream.Position = 0;

            var leitor = new StreamReader(stream);
            var texto = leitor.ReadToEnd();

            Console.WriteLine(texto);
        }
    }
}
