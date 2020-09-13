using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioPlayerModel
{
    public class Arquivo
    {
        /// <summary>
        /// Caminho do arquivo sem barra
        /// </summary>
        public string Caminho { get; set; }

        public string Nome { get; set; }

        public string Extensao { get; set; }

        public Musica Musica { get; set; }

        public string CaminhoCompleto { get; set; }

        //Construtor
        public Arquivo(string nome, string caminho, string extensao, string caminhoCompleto, Musica musica = null)
        {
            this.Nome = nome;
            this.Caminho = TratarCaminho(caminho);
            this.Extensao = extensao;
            this.CaminhoCompleto = caminhoCompleto;
            this.Musica = musica == null ? new Musica() : musica;
        }

        private string TratarCaminho(string caminho)
        {
            return !string.IsNullOrEmpty(caminho) && caminho.EndsWith(@"\") ?
                caminho.Substring(0, caminho.Length - 1) :
                caminho;
        }

        public override string ToString()
        {
            return string.Format("Nome: {0}", Nome);
        }

    }

}
