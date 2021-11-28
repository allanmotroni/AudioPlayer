using AudioPlayerUtils;
using AudioPlayerUtils.Interfaces;
using System;
using System.IO;

namespace AudioPlayerDatabase
{
    public class JsonDatabase
    {
        private const string EXTENSAO_DO_ARQUIVO = ".dat";
        private readonly string caminho;
        private readonly ICustomJsonConvert _jsonConvert;

        public JsonDatabase(string caminho) 
            : base()
        {
            this._jsonConvert = new CustomJsonConvert();

            this.caminho = caminho;
        }

        public T LerListaJsonDatabase<T>()
        {
            try
            {
                string caminhoCompleto = ObterCaminho<T>();

                T objeto = LerArquivoJson<T>(caminhoCompleto);

                return objeto;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public T LerArquivoJson<T>(string caminho)
        {
            string conteudoJson = string.Empty;
            if (ArquivoExiste(caminho))
                conteudoJson = LerArquivo(caminho);
            
            return Deserializar<T>(conteudoJson);
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
                string caminhoCompleto = ObterCaminho<T>();

                string json = Serializar(objeto);

                GravarArquivo(caminhoCompleto, json);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private string ObterCaminho<T>()
        {
            string nomeDaClasse = ObterNomeArquivo<T>();
            string nomeDoArquivo = string.Concat(nomeDaClasse, EXTENSAO_DO_ARQUIVO);
            string caminhoCompleto = this.caminho != null ? Path.Combine(this.caminho, nomeDoArquivo) : nomeDoArquivo;

            return caminhoCompleto;
        }

        private static string ObterNomeArquivo<T>()
        {
            return typeof(T).Name;
        }

        private static string LerArquivo(string caminho)
        {
            try
            {
                string retorno = GerenciadorArquivo.Ler(caminho);
                
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
                GerenciadorArquivo.Gravar(caminho, informacao);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private T Deserializar<T>(string json)
        {
            return _jsonConvert.Deserializar<T>(json);
        }

        private string Serializar<T>(T lista)
        {
            return _jsonConvert.Serializar(lista);
        }
    }
}
