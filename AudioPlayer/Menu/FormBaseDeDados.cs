using AudioPlayerUtils;
using System;
using System.Windows.Forms;

namespace AudioPlayer.Menu
{
    public partial class FormBaseDeDados : Form
    {        
        public string Caminho { get; set; }
        
        public FormBaseDeDados(string caminho)
        {
            this.Caminho = caminho;

            InitializeComponent();
        }

        private void FormBaseDeDados_Load(object sender, EventArgs e)
        {
            textBoxCaminho.Text = this.Caminho;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string caminho = textBoxCaminho.Text;

                GravarCaminho(caminho);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GravarCaminho(string informacao)
        {
            try
            {
                GerenciadorArquivo.Gravar(ConstantesSistema.PATH, informacao);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
