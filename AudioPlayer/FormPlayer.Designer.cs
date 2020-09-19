namespace AudioPlayer
{
    partial class FormPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBoxReproducaoUnica = new System.Windows.Forms.CheckBox();
            this.pictureBoxTelaCheia = new System.Windows.Forms.PictureBox();
            this.comboBoxLoopings = new System.Windows.Forms.ComboBox();
            this.pictureBoxExcluirLooping = new System.Windows.Forms.PictureBox();
            this.pictureBoxSalvarLooping = new System.Windows.Forms.PictureBox();
            this.checkBoxLooping = new System.Windows.Forms.CheckBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.numericUpDownLoopFinal = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLoopInicial = new System.Windows.Forms.NumericUpDown();
            this.labelDescricaoTempoFinal = new System.Windows.Forms.Label();
            this.labelDescricaoTempoInicial = new System.Windows.Forms.Label();
            this.labelTempoFinal = new System.Windows.Forms.Label();
            this.labelTempoInicial = new System.Windows.Forms.Label();
            this.numericUpDownVelocidadeReproducao = new System.Windows.Forms.NumericUpDown();
            this.linkLabelRapida = new System.Windows.Forms.LinkLabel();
            this.linkLabelNormal = new System.Windows.Forms.LinkLabel();
            this.linkLabelLenta = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxReproducaoContinua = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeDaMáquinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxLimparLista = new System.Windows.Forms.PictureBox();
            this.comboBoxListaReproducao = new System.Windows.Forms.ComboBox();
            this.pictureBoxExcluirListaReproducao = new System.Windows.Forms.PictureBox();
            this.pictureBoxSalvarListaReproducao = new System.Windows.Forms.PictureBox();
            this.listBoxLista = new System.Windows.Forms.ListBox();
            this.timerLooping = new System.Windows.Forms.Timer(this.components);
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTempoReproducao = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelListaReproducaoQuantidade = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelaCheia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcluirLooping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalvarLooping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoopFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoopInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocidadeReproducao)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLimparLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcluirListaReproducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalvarListaReproducao)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxReproducaoUnica);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxTelaCheia);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxLoopings);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxExcluirLooping);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxSalvarLooping);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxLooping);
            this.splitContainer1.Panel1.Controls.Add(this.player);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownLoopFinal);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownLoopInicial);
            this.splitContainer1.Panel1.Controls.Add(this.labelDescricaoTempoFinal);
            this.splitContainer1.Panel1.Controls.Add(this.labelDescricaoTempoInicial);
            this.splitContainer1.Panel1.Controls.Add(this.labelTempoFinal);
            this.splitContainer1.Panel1.Controls.Add(this.labelTempoInicial);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownVelocidadeReproducao);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelRapida);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelNormal);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelLenta);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxReproducaoContinua);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelListaReproducaoQuantidade);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxLimparLista);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxListaReproducao);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxExcluirListaReproducao);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxSalvarListaReproducao);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxLista);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 645);
            this.splitContainer1.SplitterDistance = 770;
            this.splitContainer1.TabIndex = 2;
            // 
            // checkBoxReproducaoUnica
            // 
            this.checkBoxReproducaoUnica.AutoSize = true;
            this.checkBoxReproducaoUnica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxReproducaoUnica.Location = new System.Drawing.Point(476, 60);
            this.checkBoxReproducaoUnica.Name = "checkBoxReproducaoUnica";
            this.checkBoxReproducaoUnica.Size = new System.Drawing.Size(112, 17);
            this.checkBoxReproducaoUnica.TabIndex = 28;
            this.checkBoxReproducaoUnica.Text = "Reprodução única";
            this.checkBoxReproducaoUnica.UseVisualStyleBackColor = true;
            // 
            // pictureBoxTelaCheia
            // 
            this.pictureBoxTelaCheia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTelaCheia.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTelaCheia.Image")));
            this.pictureBoxTelaCheia.Location = new System.Drawing.Point(597, 59);
            this.pictureBoxTelaCheia.Name = "pictureBoxTelaCheia";
            this.pictureBoxTelaCheia.Size = new System.Drawing.Size(17, 18);
            this.pictureBoxTelaCheia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTelaCheia.TabIndex = 27;
            this.pictureBoxTelaCheia.TabStop = false;
            this.pictureBoxTelaCheia.Click += new System.EventHandler(this.PictureBoxTelaCheia_Click);
            // 
            // comboBoxLoopings
            // 
            this.comboBoxLoopings.FormattingEnabled = true;
            this.comboBoxLoopings.Location = new System.Drawing.Point(11, 55);
            this.comboBoxLoopings.Name = "comboBoxLoopings";
            this.comboBoxLoopings.Size = new System.Drawing.Size(202, 21);
            this.comboBoxLoopings.TabIndex = 25;
            this.comboBoxLoopings.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxLoopings_SelectionChangeCommitted);
            // 
            // pictureBoxExcluirLooping
            // 
            this.pictureBoxExcluirLooping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExcluirLooping.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExcluirLooping.Image")));
            this.pictureBoxExcluirLooping.Location = new System.Drawing.Point(245, 57);
            this.pictureBoxExcluirLooping.Name = "pictureBoxExcluirLooping";
            this.pictureBoxExcluirLooping.Size = new System.Drawing.Size(17, 18);
            this.pictureBoxExcluirLooping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxExcluirLooping.TabIndex = 24;
            this.pictureBoxExcluirLooping.TabStop = false;
            this.pictureBoxExcluirLooping.Click += new System.EventHandler(this.pictureBoxExcluirLooping_Click);
            // 
            // pictureBoxSalvarLooping
            // 
            this.pictureBoxSalvarLooping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSalvarLooping.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalvarLooping.Image")));
            this.pictureBoxSalvarLooping.Location = new System.Drawing.Point(219, 57);
            this.pictureBoxSalvarLooping.Name = "pictureBoxSalvarLooping";
            this.pictureBoxSalvarLooping.Size = new System.Drawing.Size(17, 18);
            this.pictureBoxSalvarLooping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSalvarLooping.TabIndex = 23;
            this.pictureBoxSalvarLooping.TabStop = false;
            this.pictureBoxSalvarLooping.Click += new System.EventHandler(this.pictureBoxSalvarLooping_Click);
            // 
            // checkBoxLooping
            // 
            this.checkBoxLooping.AutoSize = true;
            this.checkBoxLooping.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxLooping.Location = new System.Drawing.Point(273, 60);
            this.checkBoxLooping.Name = "checkBoxLooping";
            this.checkBoxLooping.Size = new System.Drawing.Size(62, 17);
            this.checkBoxLooping.TabIndex = 22;
            this.checkBoxLooping.Text = "Looping";
            this.checkBoxLooping.UseVisualStyleBackColor = true;
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(3, 107);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(765, 536);
            this.player.TabIndex = 17;
            this.player.StatusChange += new System.EventHandler(this.player_StatusChange);
            // 
            // numericUpDownLoopFinal
            // 
            this.numericUpDownLoopFinal.DecimalPlaces = 3;
            this.numericUpDownLoopFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLoopFinal.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownLoopFinal.Location = new System.Drawing.Point(607, 28);
            this.numericUpDownLoopFinal.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownLoopFinal.Name = "numericUpDownLoopFinal";
            this.numericUpDownLoopFinal.Size = new System.Drawing.Size(98, 26);
            this.numericUpDownLoopFinal.TabIndex = 16;
            this.numericUpDownLoopFinal.ValueChanged += new System.EventHandler(this.numericUpDownLoopFinal_ValueChanged);
            // 
            // numericUpDownLoopInicial
            // 
            this.numericUpDownLoopInicial.DecimalPlaces = 3;
            this.numericUpDownLoopInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLoopInicial.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownLoopInicial.Location = new System.Drawing.Point(253, 28);
            this.numericUpDownLoopInicial.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownLoopInicial.Name = "numericUpDownLoopInicial";
            this.numericUpDownLoopInicial.Size = new System.Drawing.Size(98, 26);
            this.numericUpDownLoopInicial.TabIndex = 15;
            this.numericUpDownLoopInicial.ValueChanged += new System.EventHandler(this.numericUpDownLoopInicial_ValueChanged);
            // 
            // labelDescricaoTempoFinal
            // 
            this.labelDescricaoTempoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescricaoTempoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricaoTempoFinal.Location = new System.Drawing.Point(365, 29);
            this.labelDescricaoTempoFinal.Name = "labelDescricaoTempoFinal";
            this.labelDescricaoTempoFinal.Size = new System.Drawing.Size(115, 22);
            this.labelDescricaoTempoFinal.TabIndex = 13;
            this.labelDescricaoTempoFinal.Text = "Tempo Final";
            this.labelDescricaoTempoFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDescricaoTempoFinal.DoubleClick += new System.EventHandler(this.labelDescricaoTempoFinal_DoubleClick);
            // 
            // labelDescricaoTempoInicial
            // 
            this.labelDescricaoTempoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescricaoTempoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricaoTempoInicial.Location = new System.Drawing.Point(11, 29);
            this.labelDescricaoTempoInicial.Name = "labelDescricaoTempoInicial";
            this.labelDescricaoTempoInicial.Size = new System.Drawing.Size(115, 23);
            this.labelDescricaoTempoInicial.TabIndex = 12;
            this.labelDescricaoTempoInicial.Text = "Tempo Inicial";
            this.labelDescricaoTempoInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDescricaoTempoInicial.DoubleClick += new System.EventHandler(this.LabelDescricaoTempoInicial_DoubleClick);
            // 
            // labelTempoFinal
            // 
            this.labelTempoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTempoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempoFinal.Location = new System.Drawing.Point(486, 29);
            this.labelTempoFinal.Name = "labelTempoFinal";
            this.labelTempoFinal.Size = new System.Drawing.Size(115, 22);
            this.labelTempoFinal.TabIndex = 11;
            this.labelTempoFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTempoFinal.Click += new System.EventHandler(this.LabelTempoFinal_Click);
            // 
            // labelTempoInicial
            // 
            this.labelTempoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTempoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempoInicial.Location = new System.Drawing.Point(132, 29);
            this.labelTempoInicial.Name = "labelTempoInicial";
            this.labelTempoInicial.Size = new System.Drawing.Size(115, 23);
            this.labelTempoInicial.TabIndex = 10;
            this.labelTempoInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTempoInicial.Click += new System.EventHandler(this.LabelTempoInicial_Click);
            // 
            // numericUpDownVelocidadeReproducao
            // 
            this.numericUpDownVelocidadeReproducao.DecimalPlaces = 2;
            this.numericUpDownVelocidadeReproducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownVelocidadeReproducao.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownVelocidadeReproducao.Location = new System.Drawing.Point(115, 80);
            this.numericUpDownVelocidadeReproducao.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownVelocidadeReproducao.Name = "numericUpDownVelocidadeReproducao";
            this.numericUpDownVelocidadeReproducao.Size = new System.Drawing.Size(63, 26);
            this.numericUpDownVelocidadeReproducao.TabIndex = 9;
            this.numericUpDownVelocidadeReproducao.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDownVelocidadeReproducao.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // linkLabelRapida
            // 
            this.linkLabelRapida.AutoSize = true;
            this.linkLabelRapida.Location = new System.Drawing.Point(275, 87);
            this.linkLabelRapida.Name = "linkLabelRapida";
            this.linkLabelRapida.Size = new System.Drawing.Size(41, 13);
            this.linkLabelRapida.TabIndex = 7;
            this.linkLabelRapida.TabStop = true;
            this.linkLabelRapida.Text = "Rápida";
            this.linkLabelRapida.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRapida_LinkClicked);
            // 
            // linkLabelNormal
            // 
            this.linkLabelNormal.AutoSize = true;
            this.linkLabelNormal.Location = new System.Drawing.Point(228, 87);
            this.linkLabelNormal.Name = "linkLabelNormal";
            this.linkLabelNormal.Size = new System.Drawing.Size(40, 13);
            this.linkLabelNormal.TabIndex = 6;
            this.linkLabelNormal.TabStop = true;
            this.linkLabelNormal.Text = "Normal";
            this.linkLabelNormal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNormal_LinkClicked);
            // 
            // linkLabelLenta
            // 
            this.linkLabelLenta.AutoSize = true;
            this.linkLabelLenta.Location = new System.Drawing.Point(188, 87);
            this.linkLabelLenta.Name = "linkLabelLenta";
            this.linkLabelLenta.Size = new System.Drawing.Size(34, 13);
            this.linkLabelLenta.TabIndex = 5;
            this.linkLabelLenta.TabStop = true;
            this.linkLabelLenta.Text = "Lenta";
            this.linkLabelLenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLenta_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Velocidade";
            // 
            // checkBoxReproducaoContinua
            // 
            this.checkBoxReproducaoContinua.AutoSize = true;
            this.checkBoxReproducaoContinua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxReproducaoContinua.Location = new System.Drawing.Point(341, 60);
            this.checkBoxReproducaoContinua.Name = "checkBoxReproducaoContinua";
            this.checkBoxReproducaoContinua.Size = new System.Drawing.Size(129, 17);
            this.checkBoxReproducaoContinua.TabIndex = 1;
            this.checkBoxReproducaoContinua.Text = "Reprodução contínua";
            this.checkBoxReproducaoContinua.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.nomeDaMáquinaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.salvarToolStripMenuItem.Text = "&Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.SalvarToolStripMenuItem_Click);
            // 
            // nomeDaMáquinaToolStripMenuItem
            // 
            this.nomeDaMáquinaToolStripMenuItem.Name = "nomeDaMáquinaToolStripMenuItem";
            this.nomeDaMáquinaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nomeDaMáquinaToolStripMenuItem.Text = "Nome da Máquina";
            this.nomeDaMáquinaToolStripMenuItem.Click += new System.EventHandler(this.nomeDaMáquinaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // pictureBoxLimparLista
            // 
            this.pictureBoxLimparLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLimparLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLimparLista.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLimparLista.Image")));
            this.pictureBoxLimparLista.Location = new System.Drawing.Point(234, 4);
            this.pictureBoxLimparLista.Name = "pictureBoxLimparLista";
            this.pictureBoxLimparLista.Size = new System.Drawing.Size(17, 18);
            this.pictureBoxLimparLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLimparLista.TabIndex = 9;
            this.pictureBoxLimparLista.TabStop = false;
            this.pictureBoxLimparLista.Click += new System.EventHandler(this.PictureBoxLimparLista_Click);
            // 
            // comboBoxListaReproducao
            // 
            this.comboBoxListaReproducao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxListaReproducao.FormattingEnabled = true;
            this.comboBoxListaReproducao.Location = new System.Drawing.Point(0, 2);
            this.comboBoxListaReproducao.Name = "comboBoxListaReproducao";
            this.comboBoxListaReproducao.Size = new System.Drawing.Size(171, 21);
            this.comboBoxListaReproducao.TabIndex = 8;
            this.comboBoxListaReproducao.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxListaReproducao_SelectionChangeCommitted);
            // 
            // pictureBoxExcluirListaReproducao
            // 
            this.pictureBoxExcluirListaReproducao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExcluirListaReproducao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExcluirListaReproducao.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExcluirListaReproducao.Image")));
            this.pictureBoxExcluirListaReproducao.Location = new System.Drawing.Point(206, 4);
            this.pictureBoxExcluirListaReproducao.Name = "pictureBoxExcluirListaReproducao";
            this.pictureBoxExcluirListaReproducao.Size = new System.Drawing.Size(17, 18);
            this.pictureBoxExcluirListaReproducao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxExcluirListaReproducao.TabIndex = 7;
            this.pictureBoxExcluirListaReproducao.TabStop = false;
            this.pictureBoxExcluirListaReproducao.Click += new System.EventHandler(this.pictureBoxExcluirListaReproducao_Click);
            // 
            // pictureBoxSalvarListaReproducao
            // 
            this.pictureBoxSalvarListaReproducao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSalvarListaReproducao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSalvarListaReproducao.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalvarListaReproducao.Image")));
            this.pictureBoxSalvarListaReproducao.Location = new System.Drawing.Point(179, 4);
            this.pictureBoxSalvarListaReproducao.Name = "pictureBoxSalvarListaReproducao";
            this.pictureBoxSalvarListaReproducao.Size = new System.Drawing.Size(17, 18);
            this.pictureBoxSalvarListaReproducao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSalvarListaReproducao.TabIndex = 6;
            this.pictureBoxSalvarListaReproducao.TabStop = false;
            this.pictureBoxSalvarListaReproducao.Click += new System.EventHandler(this.pictureBoxSalvarListaReproducao_Click);
            // 
            // listBoxLista
            // 
            this.listBoxLista.AllowDrop = true;
            this.listBoxLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLista.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBoxLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLista.FormattingEnabled = true;
            this.listBoxLista.Location = new System.Drawing.Point(0, 28);
            this.listBoxLista.Name = "listBoxLista";
            this.listBoxLista.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxLista.Size = new System.Drawing.Size(252, 585);
            this.listBoxLista.TabIndex = 4;
            this.listBoxLista.DoubleClick += new System.EventHandler(this.listBoxLista_DoubleClick);
            this.listBoxLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxLista_KeyDown);
            // 
            // timerLooping
            // 
            this.timerLooping.Interval = 25;
            this.timerLooping.Tick += new System.EventHandler(this.timerLooping_Tick);
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 50;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelTempoReproducao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1029, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelTempoReproducao
            // 
            this.toolStripStatusLabelTempoReproducao.Name = "toolStripStatusLabelTempoReproducao";
            this.toolStripStatusLabelTempoReproducao.Size = new System.Drawing.Size(0, 17);
            // 
            // labelListaReproducaoQuantidade
            // 
            this.labelListaReproducaoQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelListaReproducaoQuantidade.AutoSize = true;
            this.labelListaReproducaoQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaReproducaoQuantidade.Location = new System.Drawing.Point(3, 623);
            this.labelListaReproducaoQuantidade.Name = "labelListaReproducaoQuantidade";
            this.labelListaReproducaoQuantidade.Size = new System.Drawing.Size(0, 13);
            this.labelListaReproducaoQuantidade.TabIndex = 11;
            this.labelListaReproducaoQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPlayer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 670);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayer_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPlayer_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelaCheia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcluirLooping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalvarLooping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoopFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoopInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocidadeReproducao)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLimparLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcluirListaReproducao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalvarListaReproducao)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer timerLooping;
        private System.Windows.Forms.CheckBox checkBoxReproducaoContinua;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelRapida;
        private System.Windows.Forms.LinkLabel linkLabelNormal;
        private System.Windows.Forms.LinkLabel linkLabelLenta;
        private System.Windows.Forms.NumericUpDown numericUpDownVelocidadeReproducao;
        private System.Windows.Forms.Label labelTempoFinal;
        private System.Windows.Forms.Label labelTempoInicial;
        private System.Windows.Forms.Label labelDescricaoTempoFinal;
        private System.Windows.Forms.Label labelDescricaoTempoInicial;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTempoReproducao;
        private System.Windows.Forms.NumericUpDown numericUpDownLoopInicial;
        private System.Windows.Forms.NumericUpDown numericUpDownLoopFinal;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox listBoxLista;
        private System.Windows.Forms.PictureBox pictureBoxExcluirListaReproducao;
        private System.Windows.Forms.PictureBox pictureBoxSalvarListaReproducao;
        private System.Windows.Forms.ComboBox comboBoxListaReproducao;
        private System.Windows.Forms.ComboBox comboBoxLoopings;
        private System.Windows.Forms.PictureBox pictureBoxExcluirLooping;
        private System.Windows.Forms.PictureBox pictureBoxSalvarLooping;
        private System.Windows.Forms.CheckBox checkBoxLooping;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxTelaCheia;
        private System.Windows.Forms.PictureBox pictureBoxLimparLista;
        private System.Windows.Forms.CheckBox checkBoxReproducaoUnica;
        private System.Windows.Forms.ToolStripMenuItem nomeDaMáquinaToolStripMenuItem;
        private System.Windows.Forms.Label labelListaReproducaoQuantidade;
    }
}

