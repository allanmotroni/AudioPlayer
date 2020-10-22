using AudioPlayerDatabase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace AudioPlayerModel
{
    public class AudioPlayerDados
    {
        public AudioPlayerDados()
        {
            ListaReproducao = new List<Arquivo>();
            ListaListaReproducao = new List<ListaReproducao>();
            Loopings = new List<Arquivo>();
        }

        public Configuracao Configuracao { get; set; }
        public List<ListaReproducao> ListaListaReproducao { get; set; }
        public List<Arquivo> Loopings { get; set; }

        public DateTime AtualizadoEm { get; private set; }

        [JsonIgnore]
        public List<Arquivo> ListaReproducao { get; set; }

        [JsonIgnore]
        private JsonDatabase jsonDatabase;

        public bool Gravar()
        {
            if (jsonDatabase == null) jsonDatabase = new JsonDatabase();

            this.AtualizadoEm = DateTime.Now;
            return jsonDatabase.GravarListaJsonDatabase(this);
        }

        public bool Merge(string caminhoArquivoJson)
        {
            if (jsonDatabase == null) jsonDatabase = new JsonDatabase();

            AudioPlayerDados audioPlayerDadosMerge = jsonDatabase.LerArquivoJson<AudioPlayerDados>(caminhoArquivoJson);
            if (audioPlayerDadosMerge != null)
            {
                //MergeLoopings(audioPlayerDadosMerge);
                //MergeListaListaReproducao(audioPlayerDadosMerge);

                return true;
            }

            return false;
        }

        public static AudioPlayerDados Ler()
        {
            return new JsonDatabase().LerListaJsonDatabase(new AudioPlayerDados());
        }

        private void MergeLoopings(AudioPlayerDados audioPlayerDadosMerge)
        {
            List<Arquivo> excecoesLoopings = this.Loopings.Where(p => !audioPlayerDadosMerge.Loopings.Any(pp => p.Nome.ToLower() == p.Nome.ToLower())).ToList();
            if (excecoesLoopings.Count > 0)
                this.Loopings.AddRange(excecoesLoopings);

            Arquivo arquivo = null;
            List<Repetir> excecoesRepetir = null;
            foreach (Arquivo looping in this.Loopings)
            {
                arquivo = audioPlayerDadosMerge.Loopings.FirstOrDefault(p => p.Nome.ToLower() == looping.Nome.ToLower());
                if (arquivo != null)
                {
                    excecoesRepetir = looping.Musica.Repeticoes.Where(p => !arquivo.Musica.Repeticoes.Any(pp => p.Descricao.ToLower() == pp.Descricao.ToLower())).ToList();
                    if (excecoesRepetir.Count > 0)
                        looping.Musica.Repeticoes.AddRange(excecoesRepetir);
                }
            }
        }

        private void MergeListaListaReproducao(AudioPlayerDados audioPlayerDadosMerge)
        {

        }
    }
}
