using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AudioPlayerUtils
{
    public static class GerenciadorArquivo
    {
        public static string Ler(string caminho)
        {
            try
            {
                string retorno = string.Empty;

                if (File.Exists(caminho))
                {
                    using (StreamReader sr = new StreamReader(caminho))
                    {
                        retorno = sr.ReadToEnd();
                    }
                }

                return retorno;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void Gravar(string caminho, string informacao)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(caminho))
                {
                    sw.Write(informacao);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
