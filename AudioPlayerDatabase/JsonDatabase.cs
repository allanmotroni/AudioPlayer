using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AudioPlayerDatabase
{
    public class JsonDatabase
    {
        private const string EXTENSAO_DO_ARQUIVO = ".dat";
        
        public T LerListaJsonDatabase<T>(T objeto)
        {
            try
            {
                string nomeDaClasse = ObterNomeArquivo<T>();
                string nomeDoArquivo = string.Concat(nomeDaClasse, EXTENSAO_DO_ARQUIVO);

                if (ArquivoExiste(nomeDoArquivo))
                {
                    string conteudoJson = LerArquivo(nomeDoArquivo);
                    objeto = Deserializar<T>(conteudoJson);
                }

                return objeto;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static bool ArquivoExiste(string nomeDoArquivo)
        {
            FileInfo fileInfo = new FileInfo(nomeDoArquivo);
            return fileInfo.Exists;
        }

        public bool GravarListaJsonDatabase<T>(T objeto)
        {
            try
            {
                string nomeDaClasse = ObterNomeArquivo<T>();
                string nomeDoArquivo = string.Concat(nomeDaClasse, EXTENSAO_DO_ARQUIVO);

                string json = Serializar(objeto);

                GravarArquivo(nomeDoArquivo, json);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static string ObterNomeArquivo<T>()
        {
            return typeof(T).Name;
        }

        private static string LerArquivo(string caminho)
        {
            try
            {
                string retorno = string.Empty;
                using (StreamReader sr = new StreamReader(caminho))
                {
                    retorno = sr.ReadToEnd();
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static void GravarArquivo(string caminho, string informacao)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(caminho))
                {
                    sw.WriteLine(informacao);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static T Deserializar<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        private static string Serializar<T>(T lista)
        {
            return JsonConvert.SerializeObject(lista);
        }
    }
}
