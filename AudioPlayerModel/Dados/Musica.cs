using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioPlayerModel
{
    public class Musica
    {
        //Propriedades
        public string Duracao { get; set; }

        public List<Repetir> Repeticoes { get; set; }

        //Construtor
        public Musica()
        {
            this.Repeticoes = new List<Repetir>();
        }

        public Musica(string duracao) : this()
        {
            this.Duracao = duracao;
        }

    }
}
