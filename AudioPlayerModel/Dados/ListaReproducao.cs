using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioPlayerModel
{
    public class ListaReproducao
    {
        public string NomeMaquina { get; set; }
        public string Nome { get; set; }
        public List<Arquivo> Arquivos { get; set; }

        public override string ToString()
        {
            return string.Format("Nome Máquina: {0} - Nome: {1}", NomeMaquina, Nome);
        }
    }
}
