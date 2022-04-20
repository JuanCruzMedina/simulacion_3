
namespace Simulacion_TP_3
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pInferior = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGenerarGraficos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.pVariableN = new System.Windows.Forms.Panel();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pVariableB = new System.Windows.Forms.Panel();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pVariableA = new System.Windows.Forms.Panel();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pLambda = new System.Windows.Forms.Panel();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pDesviacionEstandar = new System.Windows.Forms.Panel();
            this.txtDesviacionEstandar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pMedia = new System.Windows.Forms.Panel();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pDistribuciones = new System.Windows.Forms.Panel();
            this.cboDistribuciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.indiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iteracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSuperior.SuspendLayout();
            this.pInferior.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbParametros.SuspendLayout();
            this.pVariableN.SuspendLayout();
            this.pVariableB.SuspendLayout();
            this.pVariableA.SuspendLayout();
            this.pLambda.SuspendLayout();
            this.pDesviacionEstandar.SuspendLayout();
            this.pMedia.SuspendLayout();
            this.pDistribuciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteracionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pSuperior
            // 
            this.pSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pSuperior.Controls.Add(this.lblTitulo);
            this.pSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSuperior.Location = new System.Drawing.Point(0, 0);
            this.pSuperior.Margin = new System.Windows.Forms.Padding(5);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(921, 82);
            this.pSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(921, 82);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Generador de Variables Aleatorias";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pInferior
            // 
            this.pInferior.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pInferior.Controls.Add(this.label8);
            this.pInferior.Controls.Add(this.panel4);
            this.pInferior.Controls.Add(this.panel3);
            this.pInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pInferior.Location = new System.Drawing.Point(0, 392);
            this.pInferior.Margin = new System.Windows.Forms.Padding(5);
            this.pInferior.Name = "pInferior";
            this.pInferior.Size = new System.Drawing.Size(921, 64);
            this.pInferior.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(546, 64);
            this.label8.TabIndex = 4;
            this.label8.Text = "- Juan Cruz Medina             - Lautaro Goyeneceha\r\n- Gabriel Bracamonte        " +
    "  - Alejandro Guanuco\r\n\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGenerarGraficos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(546, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 64);
            this.panel4.TabIndex = 2;
            // 
            // btnGenerarGraficos
            // 
            this.btnGenerarGraficos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerarGraficos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerarGraficos.Enabled = false;
            this.btnGenerarGraficos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerarGraficos.FlatAppearance.BorderSize = 2;
            this.btnGenerarGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarGraficos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerarGraficos.Location = new System.Drawing.Point(0, 0);
            this.btnGenerarGraficos.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGenerarGraficos.Name = "btnGenerarGraficos";
            this.btnGenerarGraficos.Size = new System.Drawing.Size(195, 64);
            this.btnGenerarGraficos.TabIndex = 0;
            this.btnGenerarGraficos.Text = "Generar Gráficos";
            this.btnGenerarGraficos.UseVisualStyleBackColor = false;
            this.btnGenerarGraficos.Click += new System.EventHandler(this.BtnGenerarGraficos_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGenerar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(741, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 64);
            this.panel3.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerar.FlatAppearance.BorderSize = 2;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerar.Location = new System.Drawing.Point(0, 0);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(180, 64);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 82);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbParametros);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.splitContainer1.Panel2.Controls.Add(this.dgv);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(921, 310);
            this.splitContainer1.SplitterDistance = 434;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // gbParametros
            // 
            this.gbParametros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbParametros.Controls.Add(this.pVariableN);
            this.gbParametros.Controls.Add(this.pVariableB);
            this.gbParametros.Controls.Add(this.pVariableA);
            this.gbParametros.Controls.Add(this.pLambda);
            this.gbParametros.Controls.Add(this.pDesviacionEstandar);
            this.gbParametros.Controls.Add(this.pMedia);
            this.gbParametros.Controls.Add(this.pDistribuciones);
            this.gbParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbParametros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbParametros.Location = new System.Drawing.Point(0, 0);
            this.gbParametros.Margin = new System.Windows.Forms.Padding(5);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Padding = new System.Windows.Forms.Padding(5);
            this.gbParametros.Size = new System.Drawing.Size(434, 310);
            this.gbParametros.TabIndex = 0;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // pVariableN
            // 
            this.pVariableN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pVariableN.Controls.Add(this.txtN);
            this.pVariableN.Controls.Add(this.label7);
            this.pVariableN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pVariableN.Location = new System.Drawing.Point(5, 262);
            this.pVariableN.Margin = new System.Windows.Forms.Padding(5);
            this.pVariableN.Name = "pVariableN";
            this.pVariableN.Size = new System.Drawing.Size(424, 38);
            this.pVariableN.TabIndex = 10;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(157, 5);
            this.txtN.Margin = new System.Windows.Forms.Padding(5);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(210, 23);
            this.txtN.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(131, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "n";
            // 
            // pVariableB
            // 
            this.pVariableB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pVariableB.Controls.Add(this.txtB);
            this.pVariableB.Controls.Add(this.label6);
            this.pVariableB.Dock = System.Windows.Forms.DockStyle.Top;
            this.pVariableB.Location = new System.Drawing.Point(5, 224);
            this.pVariableB.Margin = new System.Windows.Forms.Padding(5);
            this.pVariableB.Name = "pVariableB";
            this.pVariableB.Size = new System.Drawing.Size(424, 38);
            this.pVariableB.TabIndex = 9;
            this.pVariableB.Visible = false;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(157, 5);
            this.txtB.Margin = new System.Windows.Forms.Padding(5);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(210, 23);
            this.txtB.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(131, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "b";
            // 
            // pVariableA
            // 
            this.pVariableA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pVariableA.Controls.Add(this.txtA);
            this.pVariableA.Controls.Add(this.label5);
            this.pVariableA.Dock = System.Windows.Forms.DockStyle.Top;
            this.pVariableA.Location = new System.Drawing.Point(5, 186);
            this.pVariableA.Margin = new System.Windows.Forms.Padding(5);
            this.pVariableA.Name = "pVariableA";
            this.pVariableA.Size = new System.Drawing.Size(424, 38);
            this.pVariableA.TabIndex = 8;
            this.pVariableA.Visible = false;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(157, 5);
            this.txtA.Margin = new System.Windows.Forms.Padding(5);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(210, 23);
            this.txtA.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(131, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "a";
            // 
            // pLambda
            // 
            this.pLambda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pLambda.Controls.Add(this.txtLambda);
            this.pLambda.Controls.Add(this.label4);
            this.pLambda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLambda.Location = new System.Drawing.Point(5, 148);
            this.pLambda.Margin = new System.Windows.Forms.Padding(5);
            this.pLambda.Name = "pLambda";
            this.pLambda.Size = new System.Drawing.Size(424, 38);
            this.pLambda.TabIndex = 0;
            this.pLambda.Visible = false;
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(157, 5);
            this.txtLambda.Margin = new System.Windows.Forms.Padding(5);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(210, 23);
            this.txtLambda.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(88, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lambda";
            // 
            // pDesviacionEstandar
            // 
            this.pDesviacionEstandar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pDesviacionEstandar.Controls.Add(this.txtDesviacionEstandar);
            this.pDesviacionEstandar.Controls.Add(this.label3);
            this.pDesviacionEstandar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDesviacionEstandar.Location = new System.Drawing.Point(5, 110);
            this.pDesviacionEstandar.Margin = new System.Windows.Forms.Padding(5);
            this.pDesviacionEstandar.Name = "pDesviacionEstandar";
            this.pDesviacionEstandar.Size = new System.Drawing.Size(424, 38);
            this.pDesviacionEstandar.TabIndex = 6;
            this.pDesviacionEstandar.Visible = false;
            // 
            // txtDesviacionEstandar
            // 
            this.txtDesviacionEstandar.Location = new System.Drawing.Point(157, 5);
            this.txtDesviacionEstandar.Margin = new System.Windows.Forms.Padding(5);
            this.txtDesviacionEstandar.Name = "txtDesviacionEstandar";
            this.txtDesviacionEstandar.Size = new System.Drawing.Size(210, 23);
            this.txtDesviacionEstandar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desviación Estandar";
            // 
            // pMedia
            // 
            this.pMedia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pMedia.Controls.Add(this.txtMedia);
            this.pMedia.Controls.Add(this.label2);
            this.pMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMedia.Location = new System.Drawing.Point(5, 72);
            this.pMedia.Margin = new System.Windows.Forms.Padding(5);
            this.pMedia.Name = "pMedia";
            this.pMedia.Size = new System.Drawing.Size(424, 38);
            this.pMedia.TabIndex = 5;
            this.pMedia.Visible = false;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(157, 5);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(5);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(210, 23);
            this.txtMedia.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(101, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Media";
            // 
            // pDistribuciones
            // 
            this.pDistribuciones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pDistribuciones.Controls.Add(this.cboDistribuciones);
            this.pDistribuciones.Controls.Add(this.label1);
            this.pDistribuciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDistribuciones.Location = new System.Drawing.Point(5, 21);
            this.pDistribuciones.Margin = new System.Windows.Forms.Padding(5);
            this.pDistribuciones.Name = "pDistribuciones";
            this.pDistribuciones.Size = new System.Drawing.Size(424, 51);
            this.pDistribuciones.TabIndex = 4;
            // 
            // cboDistribuciones
            // 
            this.cboDistribuciones.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboDistribuciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistribuciones.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cboDistribuciones.FormattingEnabled = true;
            this.cboDistribuciones.Location = new System.Drawing.Point(157, 14);
            this.cboDistribuciones.Margin = new System.Windows.Forms.Padding(5);
            this.cboDistribuciones.Name = "cboDistribuciones";
            this.cboDistribuciones.Size = new System.Drawing.Size(210, 25);
            this.cboDistribuciones.TabIndex = 0;
            this.cboDistribuciones.SelectedIndexChanged += new System.EventHandler(this.CboDistribuciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distribuciones";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indiceDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.iteracionBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(5);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 10;
            this.dgv.Size = new System.Drawing.Size(486, 310);
            this.dgv.TabIndex = 0;
            // 
            // indiceDataGridViewTextBoxColumn
            // 
            this.indiceDataGridViewTextBoxColumn.DataPropertyName = "Indice";
            this.indiceDataGridViewTextBoxColumn.HeaderText = "Indice";
            this.indiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.indiceDataGridViewTextBoxColumn.Name = "indiceDataGridViewTextBoxColumn";
            this.indiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iteracionBindingSource
            // 
            this.iteracionBindingSource.DataSource = typeof(Simulacion_TP_3.Clases.Iteracion);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(921, 456);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pInferior);
            this.Controls.Add(this.pSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variables Aleatorias";
            this.pSuperior.ResumeLayout(false);
            this.pInferior.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbParametros.ResumeLayout(false);
            this.pVariableN.ResumeLayout(false);
            this.pVariableN.PerformLayout();
            this.pVariableB.ResumeLayout(false);
            this.pVariableB.PerformLayout();
            this.pVariableA.ResumeLayout(false);
            this.pVariableA.PerformLayout();
            this.pLambda.ResumeLayout(false);
            this.pLambda.PerformLayout();
            this.pDesviacionEstandar.ResumeLayout(false);
            this.pDesviacionEstandar.PerformLayout();
            this.pMedia.ResumeLayout(false);
            this.pMedia.PerformLayout();
            this.pDistribuciones.ResumeLayout(false);
            this.pDistribuciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteracionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pInferior;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGenerarGraficos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDistribuciones;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.TextBox txtDesviacionEstandar;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Panel pVariableN;
        private System.Windows.Forms.Panel pVariableB;
        private System.Windows.Forms.Panel pVariableA;
        private System.Windows.Forms.Panel pLambda;
        private System.Windows.Forms.Panel pDesviacionEstandar;
        private System.Windows.Forms.Panel pMedia;
        private System.Windows.Forms.Panel pDistribuciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn indiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iteracionBindingSource;
        private System.Windows.Forms.Label label8;
    }
}

