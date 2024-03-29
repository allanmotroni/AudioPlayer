﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using AudioPlayerModel;
using AudioPlayer.Menu;
using AudioPlayerUtils;

namespace AudioPlayer
{
    public partial class FormPlayer : Form
    {
        #region ATRIBUTOS

        private AudioPlayerDados audioPlayerDados;
        private int indiceAtual;

        #endregion ATRIBUTOS

        #region PROPRIEDADES

        private Arquivo ArquivoAtual
        {
            get
            {
                return audioPlayerDados.ListaReproducao.Count > 0 ? audioPlayerDados.ListaReproducao[IndiceAtual] : null;
            }
        }

        private int IndiceAtual
        {
            get
            {
                return indiceAtual;
            }
            set
            {
                indiceAtual = value;
                listBoxLista.ClearSelected();
                listBoxLista.SetSelected(value, true);
                if (value > -1)
                {
                    Arquivo arquivo = listBoxLista.SelectedItem as Arquivo;
                    if (arquivo != null)
                    {
                        IniciarMusica(arquivo);
                        PreencherComboLoopings();
                    }
                }
                else
                {
                    FimReproducao();
                }
            }
        }

        private double PosicaoAtual
        {
            get
            {
                return player.Ctlcontrols.currentPosition;
            }
            set
            {
                player.Ctlcontrols.currentPosition = value;
            }
        }

        private string PosicaoAtualString
        {
            get
            {
                return player.Ctlcontrols.currentPositionString;
            }
        }

        private double Duracao
        {
            get
            {
                return player.currentMedia.duration;
            }
        }

        private double VelocidadeReproducao
        {
            set
            {
                player.settings.rate = value;
            }
        }

        private bool Looping
        {
            get
            {
                return checkBoxLooping.Checked;
            }
        }

        public double TempoLoopInicial
        {
            get
            {
                double d = 0;
                Double.TryParse(labelTempoInicial.Text, out d);
                return d;
            }
        }

        public string TempoLoopInicialString
        {
            get
            {
                return labelTempoInicial.Text;
            }
            set
            {
                labelTempoInicial.Text = value;
            }
        }

        public double TempoLoopFinal
        {
            get
            {
                double d = 0;
                Double.TryParse(labelTempoFinal.Text, out d);
                return d;
            }
        }

        public string TempoLoopFinalString
        {
            get
            {
                return labelTempoFinal.Text;
            }
            set
            {
                labelTempoFinal.Text = value;
            }
        }

        public string NomeMaquina
        {
            get
            {
                return Environment.MachineName;
            }
        }

        #endregion PROPRIEDADES

        public FormPlayer()
        {
            InitializeComponent();            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarPath();
                CarregarAudioPlayerDados();
                CarregarListaListaReproducao();

                PopularMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarPath()
        {
            try
            {
                string path = GerenciadorArquivo.Ler(ConstantesSistema.PATH);
                
                if (Directory.Exists(path))
                {
                    AlterarCaminhoBaseDados(path);

                    string titulo = string.Concat("Audio Player (", path, ")");
                    AlterarTituloFormPlayer(titulo);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void AlterarCaminhoBaseDados(string caminhoBaseDeDados)
        {
            AudioPlayerDados.CaminhoBaseDeDados = caminhoBaseDeDados;            
        }

        private void AlterarTituloFormPlayer(string titulo)
        {
            this.Text = titulo;
        }

        private void CarregarAudioPlayerDados()
        {
            try
            {
                this.audioPlayerDados = AudioPlayerDados.Ler();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void CarregarListaListaReproducao()
        {
            LimparComboGenerico(comboBoxListaReproducao);
            PreencherComboListaListaReproducao();
        }

        private void PopularMenu()
        {
            ToolStripMenuItem toolStripMenuItemArquivo = new ToolStripMenuItem("Arquivo");
            ObterMenuArquivo(toolStripMenuItemArquivo);

            menuStrip1.Items.Add(toolStripMenuItemArquivo);
        }

        private void ObterMenuArquivo(ToolStripMenuItem toolStripMenuItemArquivo)
        {
            ToolStripMenuItem toolStripItemArquivo_Abrir = new ToolStripMenuItem("Abrir...");
            toolStripItemArquivo_Abrir.Click += AbrirToolStripMenuItem_Click;

            ToolStripMenuItem toolStripItemArquivo_Salvar = new ToolStripMenuItem("Salvar");
            toolStripItemArquivo_Salvar.Click += SalvarToolStripMenuItem_Click;

            ToolStripMenuItem toolStripItemArquivo_NomeMaquina = new ToolStripMenuItem("Nome da Máquina");
            toolStripItemArquivo_NomeMaquina.Click += nomeDaMáquinaToolStripMenuItem_Click;

            ToolStripMenuItem toolStripMenuItemArquivo_Dados = new ToolStripMenuItem("Dados");
            ObterMenuDados(toolStripMenuItemArquivo_Dados);

            ToolStripMenuItem toolStripItemArquivo_ArquivosRecentes = new ToolStripMenuItem("Arquivos Recentes");

            ToolStripMenuItem toolStripItemArquivo_Sair = new ToolStripMenuItem("Sair");
            toolStripItemArquivo_Sair.Click += SairToolStripMenuItem_Click;

            ToolStripItem[] arquivos = {
                toolStripItemArquivo_Abrir,
                toolStripItemArquivo_Salvar,
                toolStripMenuItemArquivo_Dados,
                toolStripItemArquivo_NomeMaquina,
                toolStripItemArquivo_ArquivosRecentes,
                toolStripItemArquivo_Sair
            };

            toolStripMenuItemArquivo.DropDownItems.AddRange(arquivos);
        }

        private void ObterMenuDados(ToolStripMenuItem toolStripMenuDados)
        {
            ToolStripMenuItem toolStripMenuItem_Merge = new ToolStripMenuItem("Merge...");
            toolStripMenuItem_Merge.Click += mergeToolStripMenuItem_Click;

            ToolStripMenuItem toolStripMenuItem_Listar = new ToolStripMenuItem("Listar...");
            toolStripMenuItem_Listar.Click += listarToolStripMenuItem_Click;

            ToolStripMenuItem toolStripMenuItem_BaseDados = new ToolStripMenuItem("Base de Dados...");
            toolStripMenuItem_BaseDados.Click += baseDadosToolStripMenuItem_Click;

            ToolStripItem[] dados = {
                toolStripMenuItem_Merge,
                toolStripMenuItem_Listar,
                toolStripMenuItem_BaseDados
            };

            toolStripMenuDados.DropDownItems.AddRange(dados);
        }

        private void FormPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    SalvarDados();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void timerLooping_Tick(object sender, EventArgs e)
        {
            if (LoopValido() && ValidarIrParaInicioLoop() && (PosicaoAtual > TempoLoopFinal || PosicaoAtual < TempoLoopInicial))
                IrParaInicioLoop(TempoLoopInicial);
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTempoReproducao.Text = string.Format("{0} - {1}", PosicaoAtualString, PosicaoAtual);
        }

        private void PreencherComboListaListaReproducao()
        {
            List<ListaReproducao> listaListaReproducao = ObterListaReproducaoPorMaquina();
            PreencherComboGenerico(comboBoxListaReproducao, listaListaReproducao, "Nome");
            comboBoxListaReproducao.SelectedIndex = -1;
        }

        private List<ListaReproducao> ObterListaReproducaoPorMaquina()
        {
            List<ListaReproducao> listaReproducaoPorMaquina = new List<ListaReproducao>();
            if (this.audioPlayerDados != null && this.audioPlayerDados.ListaListaReproducao != null && this.audioPlayerDados.ListaListaReproducao.Count > 0 && this.audioPlayerDados.ListaListaReproducao.Any(p => !string.IsNullOrEmpty(p.NomeMaquina) && p.NomeMaquina.ToUpper() == this.NomeMaquina.ToUpper()))
            {
                listaReproducaoPorMaquina = this.audioPlayerDados.ListaListaReproducao.Where(p => !string.IsNullOrEmpty(p.NomeMaquina) && p.NomeMaquina.ToUpper() == this.NomeMaquina.ToUpper()).ToList();
            }
            return listaReproducaoPorMaquina;
        }

        private void PreencherComboLoopings()
        {
            if (ArquivoAtual != null)
            {
                List<Repetir> listaLoopings = ObterListaLoopings(ArquivoAtual);
                PreencherComboGenerico(comboBoxLoopings, listaLoopings, "Descricao");
                LimparDadosLooping();
            }
        }

        private void LimparDadosLooping()
        {
            comboBoxLoopings.SelectedIndex = -1;

            numericUpDownLoopInicial.Value = 0;
            numericUpDownLoopInicial.DecimalPlaces = 0;

            numericUpDownLoopFinal.Value = 0;
            numericUpDownLoopFinal.DecimalPlaces = 0;

            labelTempoInicial.Text = string.Empty;
            labelTempoFinal.Text = string.Empty;
        }

        private List<Repetir> ObterListaLoopings(Arquivo arquivo)
        {
            Arquivo arquivoLoopings = this.audioPlayerDados.Loopings.Where(p => p.Nome == arquivo.Nome).FirstOrDefault();
            if (arquivoLoopings == null)
                return new List<Repetir>();

            return new List<Repetir>(arquivoLoopings.Musica.Repeticoes);
        }

        private void PreencherComboGenerico<T>(ComboBox comboBox, List<T> lista, string displayMember)
        {
            LimparComboGenerico(comboBox);
            comboBox.DataSource = new List<T>(lista);
            if (!string.IsNullOrEmpty(displayMember))
                comboBox.DisplayMember = displayMember;
        }

        private void LimparComboGenerico(ComboBox comboBox)
        {
            comboBox.DataSource = null;
        }

        private bool GravarAudioPlayerDados()
        {
            return this.audioPlayerDados.Gravar();
        }

        // Evento de duplo click da lista para escolher os itens a serem reproduzidos.
        private void listBoxLista_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.IndiceAtual = listBoxLista.SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IniciarMusica(Arquivo arquivo)
        {
            try
            {
                string fullPath = string.Concat(arquivo.Caminho, @"\\", arquivo.Nome, arquivo.Extensao);
                player.URL = fullPath;
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void FimReproducao()
        {
            try
            {
                player.currentPlaylist.clear();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void PreencherListaReproducao(List<Arquivo> arquivos = null)
        {
            List<Arquivo> arquivosNovo = new List<Arquivo>(arquivos == null ? this.audioPlayerDados.ListaReproducao : arquivos);

            listBoxLista.DataSource = null;
            listBoxLista.DataSource = arquivosNovo;
            listBoxLista.DisplayMember = "Nome";

            AtualizarListaReproducaoTotal(arquivosNovo.Count);
            if (arquivosNovo.Count == 0 && (IsPlaying() || IsPaused()))
                FimReproducao();
        }

        private void AtualizarListaReproducaoTotal(int total)
        {
            labelListaReproducaoQuantidade.Text = string.Format("Total: {0}", total);
        }

        /// <summary>
        /// Obter valor do AppSetting
        /// </summary>
        /// <param name="chave_">chave do valor a ser recuperado</param>
        /// <returns></returns>
        private string ObterChaveAppSettings(string chave_)
        {
            try
            {
                return System.Configuration.ConfigurationManager.AppSettings[chave_].ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private OpenFileDialog AbrirArquivos()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = ObterChaveAppSettings("filtro");
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Escolha dos arquivos de áudio";
            return openFileDialog;
        }

        private void Abrir()
        {
            try
            {
                OpenFileDialog openFileDialog = AbrirArquivos();
                if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileNames.Length > 0)
                {
                    if (this.audioPlayerDados.ListaReproducao == null)
                        this.audioPlayerDados.ListaReproducao = new List<Arquivo>();

                    List<string> nomes = openFileDialog.FileNames.ToList<string>();
                    foreach (string nome in nomes)
                    {
                        AdicionarArquivo(nome);
                    }

                    PreencherListaReproducao();

                    if (string.IsNullOrEmpty(player.status))
                    {
                        IndiceAtual = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarArquivo(string caminho)
        {
            FileInfo file = new FileInfo(caminho);
            if (file.Exists)
            {
                Arquivo arquivo = new Arquivo(file.Name.Replace(file.Extension, ""), file.DirectoryName, file.Extension, file.FullName);
                if (ArquivoNaoIncluido(arquivo))
                {
                    this.audioPlayerDados.ListaReproducao.Add(arquivo);
                }
            }
        }

        private bool ArquivoNaoIncluido(Arquivo arquivo)
        {
            return !this.audioPlayerDados.ListaReproducao.Exists(o => o.CaminhoCompleto.Equals(arquivo.CaminhoCompleto));
        }

        private bool LoopValido()
        {
            return TempoLoopInicial < TempoLoopFinal;
        }

        private bool IsPlaying()
        {
            return player.playState == WMPLib.WMPPlayState.wmppsPlaying;
        }

        private bool IsPaused()
        {
            return player.playState == WMPLib.WMPPlayState.wmppsPaused;
        }

        private void player_StatusChange(object sender, EventArgs e)
        {
            string statusAtual = player.status;
            toolStripStatusLabel1.Text = statusAtual;

            timerLooping.Enabled = !string.IsNullOrEmpty(statusAtual);

            if (!string.IsNullOrEmpty(statusAtual))
            {
                if (statusAtual.ToLower().Equals(Constantes.ALTERANDO_MIDIA) ||
                    statusAtual.ToLower().Equals(Constantes.EM_PAUSA) ||
                    statusAtual.ToLower().Equals(Constantes.PARADO))
                {
                    timerStatus.Enabled = false;
                }
                else if (statusAtual.ToLower().StartsWith(Constantes.REPRODUZINDO) ||
                    statusAtual.ToLower().Equals(Constantes.CONECTANDO_SE))
                {
                    timerStatus.Enabled = true;
                }
                else if (statusAtual.ToLower().Equals(Constantes.MIDIA_ABERTA))
                {
                    if (checkBoxReproducaoUnica.Checked)
                    {
                        this.IndiceAtual = this.IndiceAtual;
                    }
                    else
                    {
                        bool fimDaLista = IndiceAtual + 1 > listBoxLista.Items.Count - 1;
                        if (!fimDaLista || (fimDaLista && checkBoxReproducaoContinua.Checked))
                        {
                            this.IndiceAtual = fimDaLista ? 0 : this.IndiceAtual + 1;
                        }
                        else
                        {
                            this.IndiceAtual = -1;
                        }
                    }
                }
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            VelocidadeReproducao = Convert.ToDouble(numericUpDownVelocidadeReproducao.Value);
        }

        private void linkLabelLenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numericUpDownVelocidadeReproducao.Value = Convert.ToDecimal(Constantes.VELOCIDADE_LENTA);
            VelocidadeReproducao = Constantes.VELOCIDADE_LENTA;
        }

        private void linkLabelNormal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numericUpDownVelocidadeReproducao.Value = Convert.ToDecimal(Constantes.VELOCIDADE_NORMAL);
            VelocidadeReproducao = Constantes.VELOCIDADE_NORMAL;
        }

        private void linkLabelRapida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numericUpDownVelocidadeReproducao.Value = Convert.ToDecimal(Constantes.VELOCIDADE_RAPIDA);
            VelocidadeReproducao = Constantes.VELOCIDADE_RAPIDA;
        }

        private void LabelTempoInicial_Click(object sender, EventArgs e)
        {
            PreencherTempoLoop(Constantes.TEMPO.INICIAL);
        }

        private void LabelTempoFinal_Click(object sender, EventArgs e)
        {
            PreencherTempoLoop(Constantes.TEMPO.FINAL);
        }

        private void PreencherTempoLoop(Constantes.TEMPO enumTempo)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                string posicao = PosicaoAtual.ToString();
                if (enumTempo == Constantes.TEMPO.INICIAL)
                {
                    PreencherTempoLoopInicial(posicao);
                }
                else if (enumTempo == Constantes.TEMPO.FINAL)
                {
                    PreencherTempoLoopFinal(posicao);
                }
            }
        }

        private void PreencherTempoLoopFinal(string posicao)
        {
            TempoLoopFinalString = posicao;
            MontarTempoLoop(numericUpDownLoopFinal, Convert.ToDecimal(posicao));
        }

        private void PreencherTempoLoopInicial(string posicao)
        {
            TempoLoopInicialString = posicao;
            MontarTempoLoop(numericUpDownLoopInicial, Convert.ToDecimal(posicao));
        }

        private void MontarTempoLoop(NumericUpDown numericUpDown, decimal valor)
        {
            numericUpDown.Minimum = 0;
            numericUpDown.Maximum = Convert.ToDecimal(Duracao);
            numericUpDown.DecimalPlaces = 3;
            numericUpDown.Increment = 0.050M;
            numericUpDown.Value = valor;
        }

        private void numericUpDownLoopInicial_ValueChanged(object sender, EventArgs e)
        {
            TempoLoopInicialString = numericUpDownLoopInicial.Value.ToString();
        }

        private void numericUpDownLoopFinal_ValueChanged(object sender, EventArgs e)
        {
            TempoLoopFinalString = numericUpDownLoopFinal.Value.ToString();

        }

        private void PictureBoxTelaCheia_Click(object sender, EventArgs e)
        {
            if (IsPlaying() || IsPaused())
                player.fullScreen = true;
        }

        private void LabelDescricaoTempoInicial_DoubleClick(object sender, EventArgs e)
        {
            if (ValidarIrParaInicioLoop())
                IrParaInicioLoop(Convert.ToDouble(TempoLoopInicialString));
        }

        private void labelDescricaoTempoFinal_DoubleClick(object sender, EventArgs e)
        {
            if (ValidarIrParaFinalLoop())
                IrParaInicioLoop(Convert.ToDouble(TempoLoopFinalString) - 1);
        }

        private bool ValidarIrParaInicioLoop()
        {
            return IsPlaying() && Looping && !string.IsNullOrEmpty(TempoLoopInicialString);
        }

        private bool ValidarIrParaFinalLoop()
        {
            return IsPlaying() && Looping && !string.IsNullOrEmpty(TempoLoopFinalString);
        }

        private void IrParaInicioLoop(double posicaoInicial)
        {
            PosicaoAtual = posicaoInicial;
        }

        private void ListBoxLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listBoxLista.Items.Count > 0 && listBoxLista.SelectedIndices.Count > 0)
            {
                foreach (object selectedItem in listBoxLista.SelectedItems)
                {
                    this.audioPlayerDados.ListaReproducao.Remove(selectedItem as Arquivo);
                }

                PreencherListaReproducao();
            }
        }

        private void pictureBoxSalvarListaReproducao_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarListaReproducao();
                PreencherComboListaListaReproducao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalvarListaReproducao()
        {
            List<Arquivo> listaArquivos = ObterListaReproducao();
            string nome = comboBoxListaReproducao.Text;
            if (listaArquivos != null && listaArquivos.Count > 0 && !string.IsNullOrEmpty(nome))
            {
                int indice = this.audioPlayerDados.ListaListaReproducao.FindIndex(p => p.Nome.ToUpper() == nome.ToUpper() && p.NomeMaquina == this.NomeMaquina);
                if (indice == -1)
                {
                    this.audioPlayerDados.ListaListaReproducao.Add(new ListaReproducao()
                    {
                        NomeMaquina = this.NomeMaquina,
                        Nome = nome,
                        Arquivos = new List<Arquivo>(listaArquivos)
                    }); ;
                }
                else
                {
                    this.audioPlayerDados.ListaListaReproducao[indice].Arquivos = listaArquivos;
                }
            }
        }

        private List<Arquivo> ObterListaReproducao()
        {
            return audioPlayerDados.ListaReproducao;
        }

        private void pictureBoxExcluirListaReproducao_Click(object sender, EventArgs e)
        {
            try
            {
                ListaReproducao listaReproducao = comboBoxListaReproducao.SelectedItem as ListaReproducao;
                if (listaReproducao != null)
                {
                    int indice = this.audioPlayerDados.ListaListaReproducao.FindIndex(p => p.Nome == listaReproducao.Nome);
                    if (indice > -1)
                    {
                        this.audioPlayerDados.ListaListaReproducao.RemoveAt(indice);
                        PreencherComboListaListaReproducao();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxSalvarLooping_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarLooping();
                PreencherComboLoopings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalvarLooping()
        {
            string descricao = comboBoxLoopings.Text;
            string nomeArquivo = ArquivoAtual == null ? string.Empty : ArquivoAtual.Nome;
            string extensaoArquivo = ArquivoAtual == null ? string.Empty : ArquivoAtual.Extensao;

            if (!string.IsNullOrEmpty(descricao) && TempoLoopInicial >= 0 && TempoLoopFinal > 0)
            {
                Arquivo arquivoLoopings = this.audioPlayerDados.Loopings.Where(p => p.Nome.ToUpper() == nomeArquivo.ToUpper() && p.Extensao.ToUpper() == extensaoArquivo.ToUpper()).FirstOrDefault();
                int indiceRepeticoes = arquivoLoopings == null ? -1 : arquivoLoopings.Musica.Repeticoes.FindIndex(p => p.Descricao.ToUpper() == descricao.ToUpper());
                bool inclusao = indiceRepeticoes < 0;
                if (inclusao)
                {
                    if (arquivoLoopings == null)
                    {
                        this.audioPlayerDados.Loopings.Add(ArquivoAtual);
                        arquivoLoopings = ArquivoAtual;
                    }

                    Repetir repetirNovo = new Repetir(descricao, TempoLoopInicial, TempoLoopFinal);
                    arquivoLoopings.Musica.Repeticoes.Add(repetirNovo);
                }
                else
                {
                    int indice = arquivoLoopings.Musica.Repeticoes.FindIndex(p => p.Descricao.ToUpper() == descricao.ToUpper());
                    arquivoLoopings.Musica.Repeticoes[indice].Inicio = TempoLoopInicial;
                    arquivoLoopings.Musica.Repeticoes[indice].Fim = TempoLoopFinal;
                }
            }
        }

        private void pictureBoxExcluirLooping_Click(object sender, EventArgs e)
        {
            try
            {
                Repetir repetir = comboBoxLoopings.SelectedItem as Repetir;
                if (repetir != null)
                {
                    int indiceArquivo = this.audioPlayerDados.Loopings.FindIndex(p => p.Nome.ToUpper() == ArquivoAtual.Nome.ToUpper() && p.Musica.Repeticoes.Count > 0);
                    if (indiceArquivo > -1)
                    {
                        int indiceLooping = this.audioPlayerDados.Loopings[indiceArquivo].Musica.Repeticoes.FindIndex(p => p.Descricao.ToUpper() == repetir.Descricao.ToUpper());
                        if (indiceLooping > -1)
                        {
                            this.audioPlayerDados.Loopings[indiceArquivo].Musica.Repeticoes.RemoveAt(indiceLooping);
                            PreencherComboLoopings();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxListaReproducao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxListaReproducao.SelectedIndex > -1)
            {
                ListaReproducao listaReproducao = comboBoxListaReproducao.SelectedItem as ListaReproducao;
                if (listaReproducao != null)
                {
                    this.audioPlayerDados.ListaReproducao = new List<Arquivo>(listaReproducao.Arquivos);
                    PreencherListaReproducao(listaReproducao.Arquivos);

                    IndiceAtual = 0;
                }
            }
        }

        private void ComboBoxLoopings_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxLoopings.SelectedIndex > -1)
            {
                Repetir repetir = comboBoxLoopings.SelectedItem as Repetir;
                if (repetir != null)
                {
                    PreencherTempoLoopInicial(repetir.Inicio.ToString());
                    PreencherTempoLoopFinal(repetir.Fim.ToString());
                }
            }
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }

        private void SalvarDados()
        {
            if (!GravarAudioPlayerDados())
            {
                MessageBox.Show("Não foi possível gravar os dados!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                {
                    PreencherTempoLoop(Constantes.TEMPO.INICIAL);
                }
                else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                {
                    PreencherTempoLoop(Constantes.TEMPO.FINAL);
                }
                else if (e.KeyCode == Keys.O)
                {
                    Abrir();
                }
                else if (e.KeyCode == Keys.S)
                {
                    SalvarDados();
                }
            }
        }

        private void PictureBoxLimparLista_Click(object sender, EventArgs e)
        {
            LimparListaReproducao();
        }

        private void LimparListaReproducao()
        {
            this.audioPlayerDados.ListaReproducao = new List<Arquivo>();
            comboBoxListaReproducao.SelectedIndex = -1;
            PreencherListaReproducao();
        }

        private void nomeDaMáquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Environment.MachineName, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Arquivo DAT ou JSON|*.dat;*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivoJson = openFileDialog.FileName;

                    bool retorno = audioPlayerDados.Merge(caminhoArquivoJson);

                    string mensagem = "Merge realizado com sucesso!";
                    if (!retorno)
                        mensagem = "Erro ao realizar merge";

                    MessageBox.Show(mensagem, this.Text, MessageBoxButtons.OK, retorno ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Abrir tela");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void baseDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormBaseDeDados frm = new FormBaseDeDados(AudioPlayerDados.CaminhoBaseDeDados);
                
                frm.ShowDialog();
                                
                CarregarPath();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
