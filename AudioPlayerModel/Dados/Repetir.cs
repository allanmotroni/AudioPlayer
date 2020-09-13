using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioPlayerModel
{
    public class Repetir
    {
        //Propriedades
        public string Descricao { get; set; }
        public double Inicio { get; set; }
        public double Fim { get; set; }

        public Repetir(string descricao, double inicio, double fim)
        {
            this.Descricao = descricao;
            this.Inicio = inicio;
            this.Fim = fim;
        }

        public override string ToString()
        {
            return string.Format("Descrição: {0} - Início: {1} - Fim: {2}", Descricao, Inicio, Fim);
        }

    }
}
