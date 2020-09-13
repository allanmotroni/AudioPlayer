using AudioPlayerDatabase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [JsonIgnore]
        public List<Arquivo> ListaReproducao { get; set; }

        [JsonIgnore]
        private JsonDatabase jsonDatabase;

        public bool Gravar()
        {
            if(jsonDatabase == null) jsonDatabase = new JsonDatabase();

            return jsonDatabase.GravarListaJsonDatabase(this);
        }

        public static AudioPlayerDados Ler()
        {
            return new JsonDatabase().LerListaJsonDatabase(new AudioPlayerDados());
        }
    }
}
