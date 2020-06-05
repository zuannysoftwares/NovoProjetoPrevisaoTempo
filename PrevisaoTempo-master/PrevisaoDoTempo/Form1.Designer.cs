namespace PrevisaoDoTempo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_diaSemana = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_tempAtual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_diaSemana1 = new System.Windows.Forms.Label();
            this.lbl_max1 = new System.Windows.Forms.Label();
            this.lbl_min1 = new System.Windows.Forms.Label();
            this.pb_dia1 = new System.Windows.Forms.PictureBox();
            this.pb_dia2 = new System.Windows.Forms.PictureBox();
            this.lbl_min2 = new System.Windows.Forms.Label();
            this.lbl_max2 = new System.Windows.Forms.Label();
            this.lbl_diaSemana2 = new System.Windows.Forms.Label();
            this.pb_dia3 = new System.Windows.Forms.PictureBox();
            this.lbl_min3 = new System.Windows.Forms.Label();
            this.lbl_max3 = new System.Windows.Forms.Label();
            this.lbl_diaSemana3 = new System.Windows.Forms.Label();
            this.pb_dia4 = new System.Windows.Forms.PictureBox();
            this.lbl_min4 = new System.Windows.Forms.Label();
            this.lbl_max4 = new System.Windows.Forms.Label();
            this.lbl_diaSemana4 = new System.Windows.Forms.Label();
            this.pb_dia5 = new System.Windows.Forms.PictureBox();
            this.lbl_min5 = new System.Windows.Forms.Label();
            this.lbl_max5 = new System.Windows.Forms.Label();
            this.lbl_diaSemana5 = new System.Windows.Forms.Label();
            this.lbl_umidadeAux = new System.Windows.Forms.Label();
            this.lbl_umidade = new System.Windows.Forms.Label();
            this.lbl_velocidadeVentoAux = new System.Windows.Forms.Label();
            this.lbl_velocidadeVento = new System.Windows.Forms.Label();
            this.lbl_porDoSol = new System.Windows.Forms.Label();
            this.pb_diaAtual = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dia3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dia4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dia5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_diaAtual)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_cidade.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_cidade.Location = new System.Drawing.Point(43, 35);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(300, 85);
            this.lbl_cidade.TabIndex = 0;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_diaSemana
            // 
            this.lbl_diaSemana.AutoSize = true;
            this.lbl_diaSemana.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_diaSemana.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diaSemana.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_diaSemana.Location = new System.Drawing.Point(49, 91);
            this.lbl_diaSemana.Name = "lbl_diaSemana";
            this.lbl_diaSemana.Size = new System.Drawing.Size(370, 39);
            this.lbl_diaSemana.TabIndex = 1;
            this.lbl_diaSemana.Text = "Dia da semana + hora";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_descricao.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_descricao.Location = new System.Drawing.Point(49, 129);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(176, 39);
            this.lbl_descricao.TabIndex = 2;
            this.lbl_descricao.Text = "Descrição";
            // 
            // lbl_tempAtual
            // 
            this.lbl_tempAtual.AutoSize = true;
            this.lbl_tempAtual.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_tempAtual.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempAtual.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_tempAtual.Location = new System.Drawing.Point(167, 180);
            this.lbl_tempAtual.Name = "lbl_tempAtual";
            this.lbl_tempAtual.Size = new System.Drawing.Size(102, 115);
            this.lbl_tempAtual.TabIndex = 3;
            this.lbl_tempAtual.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(238, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "°C";
            // 
            // lbl_diaSemana1
            // 
            this.lbl_diaSemana1.AutoSize = true;
            this.lbl_diaSemana1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_diaSemana1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diaSemana1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_diaSemana1.Location = new System.Drawing.Point(93, 317);
            this.lbl_diaSemana1.Name = "lbl_diaSemana1";
            this.lbl_diaSemana1.Size = new System.Drawing.Size(75, 38);
            this.lbl_diaSemana1.TabIndex = 5;
            this.lbl_diaSemana1.Text = "Seg";
            // 
            // lbl_max1
            // 
            this.lbl_max1.AutoSize = true;
            this.lbl_max1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_max1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max1.ForeColor = System.Drawing.Color.Gold;
            this.lbl_max1.Location = new System.Drawing.Point(86, 434);
            this.lbl_max1.Name = "lbl_max1";
            this.lbl_max1.Size = new System.Drawing.Size(85, 38);
            this.lbl_max1.TabIndex = 6;
            this.lbl_max1.Text = "Máx";
            // 
            // lbl_min1
            // 
            this.lbl_min1.AutoSize = true;
            this.lbl_min1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_min1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_min1.Location = new System.Drawing.Point(87, 459);
            this.lbl_min1.Name = "lbl_min1";
            this.lbl_min1.Size = new System.Drawing.Size(73, 38);
            this.lbl_min1.TabIndex = 7;
            this.lbl_min1.Text = "Mín";
            // 
            // pb_dia1
            // 
            this.pb_dia1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pb_dia1.Location = new System.Drawing.Point(62, 345);
            this.pb_dia1.Name = "pb_dia1";
            this.pb_dia1.Size = new System.Drawing.Size(100, 86);
            this.pb_dia1.TabIndex = 8;
            this.pb_dia1.TabStop = false;
            // 
            // pb_dia2
            // 
            this.pb_dia2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pb_dia2.Location = new System.Drawing.Point(196, 345);
            this.pb_dia2.Name = "pb_dia2";
            this.pb_dia2.Size = new System.Drawing.Size(100, 86);
            this.pb_dia2.TabIndex = 12;
            this.pb_dia2.TabStop = false;
            // 
            // lbl_min2
            // 
            this.lbl_min2.AutoSize = true;
            this.lbl_min2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_min2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_min2.Location = new System.Drawing.Point(221, 459);
            this.lbl_min2.Name = "lbl_min2";
            this.lbl_min2.Size = new System.Drawing.Size(73, 38);
            this.lbl_min2.TabIndex = 11;
            this.lbl_min2.Text = "Mín";
            // 
            // lbl_max2
            // 
            this.lbl_max2.AutoSize = true;
            this.lbl_max2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_max2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max2.ForeColor = System.Drawing.Color.Gold;
            this.lbl_max2.Location = new System.Drawing.Point(220, 434);
            this.lbl_max2.Name = "lbl_max2";
            this.lbl_max2.Size = new System.Drawing.Size(85, 38);
            this.lbl_max2.TabIndex = 10;
            this.lbl_max2.Text = "Máx";
            // 
            // lbl_diaSemana2
            // 
            this.lbl_diaSemana2.AutoSize = true;
            this.lbl_diaSemana2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_diaSemana2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diaSemana2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_diaSemana2.Location = new System.Drawing.Point(227, 317);
            this.lbl_diaSemana2.Name = "lbl_diaSemana2";
            this.lbl_diaSemana2.Size = new System.Drawing.Size(75, 38);
            this.lbl_diaSemana2.TabIndex = 9;
            this.lbl_diaSemana2.Text = "Seg";
            // 
            // pb_dia3
            // 
            this.pb_dia3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pb_dia3.Location = new System.Drawing.Point(329, 345);
            this.pb_dia3.Name = "pb_dia3";
            this.pb_dia3.Size = new System.Drawing.Size(100, 86);
            this.pb_dia3.TabIndex = 16;
            this.pb_dia3.TabStop = false;
            // 
            // lbl_min3
            // 
            this.lbl_min3.AutoSize = true;
            this.lbl_min3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_min3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_min3.Location = new System.Drawing.Point(354, 459);
            this.lbl_min3.Name = "lbl_min3";
            this.lbl_min3.Size = new System.Drawing.Size(73, 38);
            this.lbl_min3.TabIndex = 15;
            this.lbl_min3.Text = "Mín";
            // 
            // lbl_max3
            // 
            this.lbl_max3.AutoSize = true;
            this.lbl_max3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_max3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max3.ForeColor = System.Drawing.Color.Gold;
            this.lbl_max3.Location = new System.Drawing.Point(353, 434);
            this.lbl_max3.Name = "lbl_max3";
            this.lbl_max3.Size = new System.Drawing.Size(85, 38);
            this.lbl_max3.TabIndex = 14;
            this.lbl_max3.Text = "Máx";
            // 
            // lbl_diaSemana3
            // 
            this.lbl_diaSemana3.AutoSize = true;
            this.lbl_diaSemana3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_diaSemana3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diaSemana3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_diaSemana3.Location = new System.Drawing.Point(360, 317);
            this.lbl_diaSemana3.Name = "lbl_diaSemana3";
            this.lbl_diaSemana3.Size = new System.Drawing.Size(75, 38);
            this.lbl_diaSemana3.TabIndex = 13;
            this.lbl_diaSemana3.Text = "Seg";
            // 
            // pb_dia4
            // 
            this.pb_dia4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pb_dia4.Location = new System.Drawing.Point(465, 345);
            this.pb_dia4.Name = "pb_dia4";
            this.pb_dia4.Size = new System.Drawing.Size(100, 86);
            this.pb_dia4.TabIndex = 20;
            this.pb_dia4.TabStop = false;
            // 
            // lbl_min4
            // 
            this.lbl_min4.AutoSize = true;
            this.lbl_min4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_min4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_min4.Location = new System.Drawing.Point(490, 459);
            this.lbl_min4.Name = "lbl_min4";
            this.lbl_min4.Size = new System.Drawing.Size(73, 38);
            this.lbl_min4.TabIndex = 19;
            this.lbl_min4.Text = "Mín";
            // 
            // lbl_max4
            // 
            this.lbl_max4.AutoSize = true;
            this.lbl_max4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_max4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max4.ForeColor = System.Drawing.Color.Gold;
            this.lbl_max4.Location = new System.Drawing.Point(489, 434);
            this.lbl_max4.Name = "lbl_max4";
            this.lbl_max4.Size = new System.Drawing.Size(85, 38);
            this.lbl_max4.TabIndex = 18;
            this.lbl_max4.Text = "Máx";
            // 
            // lbl_diaSemana4
            // 
            this.lbl_diaSemana4.AutoSize = true;
            this.lbl_diaSemana4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_diaSemana4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diaSemana4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_diaSemana4.Location = new System.Drawing.Point(496, 317);
            this.lbl_diaSemana4.Name = "lbl_diaSemana4";
            this.lbl_diaSemana4.Size = new System.Drawing.Size(75, 38);
            this.lbl_diaSemana4.TabIndex = 17;
            this.lbl_diaSemana4.Text = "Seg";
            // 
            // pb_dia5
            // 
            this.pb_dia5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pb_dia5.Location = new System.Drawing.Point(592, 345);
            this.pb_dia5.Name = "pb_dia5";
            this.pb_dia5.Size = new System.Drawing.Size(100, 86);
            this.pb_dia5.TabIndex = 24;
            this.pb_dia5.TabStop = false;
            // 
            // lbl_min5
            // 
            this.lbl_min5.AutoSize = true;
            this.lbl_min5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_min5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_min5.Location = new System.Drawing.Point(617, 459);
            this.lbl_min5.Name = "lbl_min5";
            this.lbl_min5.Size = new System.Drawing.Size(73, 38);
            this.lbl_min5.TabIndex = 23;
            this.lbl_min5.Text = "Mín";
            // 
            // lbl_max5
            // 
            this.lbl_max5.AutoSize = true;
            this.lbl_max5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_max5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max5.ForeColor = System.Drawing.Color.Gold;
            this.lbl_max5.Location = new System.Drawing.Point(616, 434);
            this.lbl_max5.Name = "lbl_max5";
            this.lbl_max5.Size = new System.Drawing.Size(85, 38);
            this.lbl_max5.TabIndex = 22;
            this.lbl_max5.Text = "Máx";
            // 
            // lbl_diaSemana5
            // 
            this.lbl_diaSemana5.AutoSize = true;
            this.lbl_diaSemana5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_diaSemana5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diaSemana5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_diaSemana5.Location = new System.Drawing.Point(623, 317);
            this.lbl_diaSemana5.Name = "lbl_diaSemana5";
            this.lbl_diaSemana5.Size = new System.Drawing.Size(75, 38);
            this.lbl_diaSemana5.TabIndex = 21;
            this.lbl_diaSemana5.Text = "Seg";
            // 
            // lbl_umidadeAux
            // 
            this.lbl_umidadeAux.AutoSize = true;
            this.lbl_umidadeAux.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_umidadeAux.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_umidadeAux.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_umidadeAux.Location = new System.Drawing.Point(461, 100);
            this.lbl_umidadeAux.Name = "lbl_umidadeAux";
            this.lbl_umidadeAux.Size = new System.Drawing.Size(171, 39);
            this.lbl_umidadeAux.TabIndex = 25;
            this.lbl_umidadeAux.Text = "Umidade:";
            // 
            // lbl_umidade
            // 
            this.lbl_umidade.AutoSize = true;
            this.lbl_umidade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_umidade.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_umidade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_umidade.Location = new System.Drawing.Point(570, 100);
            this.lbl_umidade.Name = "lbl_umidade";
            this.lbl_umidade.Size = new System.Drawing.Size(35, 39);
            this.lbl_umidade.TabIndex = 26;
            this.lbl_umidade.Text = "0";
            // 
            // lbl_velocidadeVentoAux
            // 
            this.lbl_velocidadeVentoAux.AutoSize = true;
            this.lbl_velocidadeVentoAux.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_velocidadeVentoAux.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_velocidadeVentoAux.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_velocidadeVentoAux.Location = new System.Drawing.Point(491, 138);
            this.lbl_velocidadeVentoAux.Name = "lbl_velocidadeVentoAux";
            this.lbl_velocidadeVentoAux.Size = new System.Drawing.Size(121, 39);
            this.lbl_velocidadeVentoAux.TabIndex = 27;
            this.lbl_velocidadeVentoAux.Text = "Vento:";
            // 
            // lbl_velocidadeVento
            // 
            this.lbl_velocidadeVento.AutoSize = true;
            this.lbl_velocidadeVento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_velocidadeVento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_velocidadeVento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_velocidadeVento.Location = new System.Drawing.Point(570, 138);
            this.lbl_velocidadeVento.Name = "lbl_velocidadeVento";
            this.lbl_velocidadeVento.Size = new System.Drawing.Size(35, 39);
            this.lbl_velocidadeVento.TabIndex = 28;
            this.lbl_velocidadeVento.Text = "0";
            // 
            // lbl_porDoSol
            // 
            this.lbl_porDoSol.AutoSize = true;
            this.lbl_porDoSol.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_porDoSol.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_porDoSol.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_porDoSol.Location = new System.Drawing.Point(570, 219);
            this.lbl_porDoSol.Name = "lbl_porDoSol";
            this.lbl_porDoSol.Size = new System.Drawing.Size(0, 39);
            this.lbl_porDoSol.TabIndex = 29;
            // 
            // pb_diaAtual
            // 
            this.pb_diaAtual.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pb_diaAtual.Location = new System.Drawing.Point(53, 172);
            this.pb_diaAtual.Name = "pb_diaAtual";
            this.pb_diaAtual.Size = new System.Drawing.Size(100, 86);
            this.pb_diaAtual.TabIndex = 31;
            this.pb_diaAtual.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(59, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Aperte F1 para escolher a cidade";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(381, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 37);
            this.textBox1.TabIndex = 33;
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(458, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 39);
            this.label3.TabIndex = 34;
            this.label3.Text = "Pôr do Sol:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 564);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_diaAtual);
            this.Controls.Add(this.lbl_porDoSol);
            this.Controls.Add(this.lbl_velocidadeVento);
            this.Controls.Add(this.lbl_velocidadeVentoAux);
            this.Controls.Add(this.lbl_umidade);
            this.Controls.Add(this.lbl_umidadeAux);
            this.Controls.Add(this.pb_dia5);
            this.Controls.Add(this.lbl_min5);
            this.Controls.Add(this.lbl_max5);
            this.Controls.Add(this.lbl_diaSemana5);
            this.Controls.Add(this.pb_dia4);
            this.Controls.Add(this.lbl_min4);
            this.Controls.Add(this.lbl_max4);
            this.Controls.Add(this.lbl_diaSemana4);
            this.Controls.Add(this.pb_dia3);
            this.Controls.Add(this.lbl_min3);
            this.Controls.Add(this.lbl_max3);
            this.Controls.Add(this.lbl_diaSemana3);
            this.Controls.Add(this.pb_dia2);
            this.Controls.Add(this.lbl_min2);
            this.Controls.Add(this.lbl_max2);
            this.Controls.Add(this.lbl_diaSemana2);
            this.Controls.Add(this.pb_dia1);
            this.Controls.Add(this.lbl_min1);
            this.Controls.Add(this.lbl_max1);
            this.Controls.Add(this.lbl_diaSemana1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tempAtual);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_diaSemana);
            this.Controls.Add(this.lbl_cidade);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_dia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dia3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dia4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dia5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_diaAtual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_diaSemana;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_tempAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_diaSemana1;
        private System.Windows.Forms.Label lbl_max1;
        private System.Windows.Forms.Label lbl_min1;
        private System.Windows.Forms.PictureBox pb_dia1;
        private System.Windows.Forms.PictureBox pb_dia2;
        private System.Windows.Forms.Label lbl_min2;
        private System.Windows.Forms.Label lbl_max2;
        private System.Windows.Forms.Label lbl_diaSemana2;
        private System.Windows.Forms.PictureBox pb_dia3;
        private System.Windows.Forms.Label lbl_min3;
        private System.Windows.Forms.Label lbl_max3;
        private System.Windows.Forms.Label lbl_diaSemana3;
        private System.Windows.Forms.PictureBox pb_dia4;
        private System.Windows.Forms.Label lbl_min4;
        private System.Windows.Forms.Label lbl_max4;
        private System.Windows.Forms.Label lbl_diaSemana4;
        private System.Windows.Forms.PictureBox pb_dia5;
        private System.Windows.Forms.Label lbl_min5;
        private System.Windows.Forms.Label lbl_max5;
        private System.Windows.Forms.Label lbl_diaSemana5;
        private System.Windows.Forms.Label lbl_umidadeAux;
        private System.Windows.Forms.Label lbl_umidade;
        private System.Windows.Forms.Label lbl_velocidadeVentoAux;
        private System.Windows.Forms.Label lbl_velocidadeVento;
        private System.Windows.Forms.Label lbl_porDoSol;
        private System.Windows.Forms.PictureBox pb_diaAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
    }
}

