using System;
using System.Collections.Generic;
using AudioPlayerDatabase;
using AudioPlayerModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AudioPlayerUnitTest
{
    [TestClass]
    public class JsonDatabaseTest
    {
        [TestMethod]
        public void GravarArquivosTest()
        {
            List<Arquivo> arquivos = CarregarArquivos();
            bool retorno = arquivos.GravarListaJsonDatabase();
        }

        private static List<Arquivo> CarregarArquivos()
        {
            List<Arquivo> arquivos = new List<Arquivo>();
            List<Repetir> repeticoes = new List<Repetir>();
            repeticoes.Add(new Repetir("Repetir 01", 1.10,1.15));

            repeticoes.Add(new Repetir("Repetir 02",1.20,1.25));

            arquivos.Add(new Arquivo("nome", @"c:\", ".mp3", @"c:\")
            {
                Musica = new Musica()
                {
                    Duracao = "2:00",
                    Repeticoes = repeticoes
                }
            });

            arquivos.Add(new Arquivo("nome 2", @"d:\", ".mp3", @"d:\")
            {
                Musica = new Musica()
                {
                    Duracao = "3:00",
                    Repeticoes = repeticoes
                }
            });
            return arquivos;
        }

        [TestMethod]
        public void LerArquivosTest()
        {
            List<Arquivo> arquivos = new List<Arquivo>();
            arquivos = arquivos.LerListaJsonDatabase();
        }

        [TestMethod]
        public void LerAudioPlayerDadosTest()
        {
            List<AudioPlayerDados> audioPlayerDados = new List<AudioPlayerDados>();
            audioPlayerDados = audioPlayerDados.LerListaJsonDatabase();
        }

        [TestMethod]
        public void GravarAudioPlayerDadosTest()
        {
            List<AudioPlayerDados> audioPlayerDados = CarregarAudioPlayerDados();
            bool retorno = audioPlayerDados.GravarListaJsonDatabase();
        }

        private static List<AudioPlayerDados> CarregarAudioPlayerDados()
        {
            List<AudioPlayerDados> lista = new List<AudioPlayerDados>();
            List<Arquivo> listaReproducao = new List<Arquivo>();
            listaReproducao.AddRange(CarregarArquivos());

            List<ListaReproducao> listaListaReproducao = new List<ListaReproducao>();
            listaListaReproducao.Add(new ListaReproducao() {
                Nome = "Lista 1",
                Arquivos = CarregarArquivos()
            });

            lista.Add(new AudioPlayerDados()
            {
                Configuracao = new Configuracao(),
                ArquivosReproducao = listaReproducao,
                ListasReproducoes = listaListaReproducao
            });

            return lista;
        }
    }
}
