
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
            this.pSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pSuperior.Controls.Add(this.lblTitulo);
            this.pSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSuperior.Location = new System.Drawing.Point(0, 0);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(669, 56);
            this.pSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(575, 56);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Generador de Variables Aleatorias";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pInferior
            // 
            this.pInferior.Controls.Add(this.panel4);
            this.pInferior.Controls.Add(this.panel3);
            this.pInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pInferior.Location = new System.Drawing.Point(0, 272);
            this.pInferior.Name = "pInferior";
            this.pInferior.Size = new System.Drawing.Size(669, 44);
            this.pInferior.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGenerarGraficos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(444, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(117, 44);
            this.panel4.TabIndex = 2;
            // 
            // btnGenerarGraficos
            // 
            this.btnGenerarGraficos.Enabled = false;
            this.btnGenerarGraficos.Location = new System.Drawing.Point(3, 10);
            this.btnGenerarGraficos.Name = "btnGenerarGraficos";
            this.btnGenerarGraficos.Size = new System.Drawing.Size(107, 23);
            this.btnGenerarGraficos.TabIndex = 0;
            this.btnGenerarGraficos.Text = "Generar Gráficos";
            this.btnGenerarGraficos.UseVisualStyleBackColor = true;
            this.btnGenerarGraficos.Click += new System.EventHandler(this.btnGenerarGraficos_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGenerar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(561, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 44);
            this.panel3.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(3, 10);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(98, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbParametros);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv);
            this.splitContainer1.Size = new System.Drawing.Size(669, 216);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 2;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.pVariableN);
            this.gbParametros.Controls.Add(this.pVariableB);
            this.gbParametros.Controls.Add(this.pVariableA);
            this.gbParametros.Controls.Add(this.pLambda);
            this.gbParametros.Controls.Add(this.pDesviacionEstandar);
            this.gbParametros.Controls.Add(this.pMedia);
            this.gbParametros.Controls.Add(this.pDistribuciones);
            this.gbParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbParametros.Location = new System.Drawing.Point(0, 0);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(315, 216);
            this.gbParametros.TabIndex = 0;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // pVariableN
            // 
            this.pVariableN.Controls.Add(this.txtN);
            this.pVariableN.Controls.Add(this.label7);
            this.pVariableN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pVariableN.Location = new System.Drawing.Point(3, 181);
            this.pVariableN.Name = "pVariableN";
            this.pVariableN.Size = new System.Drawing.Size(309, 26);
            this.pVariableN.TabIndex = 10;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(129, 3);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "n";
            // 
            // pVariableB
            // 
            this.pVariableB.Controls.Add(this.txtB);
            this.pVariableB.Controls.Add(this.label6);
            this.pVariableB.Dock = System.Windows.Forms.DockStyle.Top;
            this.pVariableB.Location = new System.Drawing.Point(3, 155);
            this.pVariableB.Name = "pVariableB";
            this.pVariableB.Size = new System.Drawing.Size(309, 26);
            this.pVariableB.TabIndex = 9;
            this.pVariableB.Visible = false;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(129, 3);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "b";
            // 
            // pVariableA
            // 
            this.pVariableA.Controls.Add(this.txtA);
            this.pVariableA.Controls.Add(this.label5);
            this.pVariableA.Dock = System.Windows.Forms.DockStyle.Top;
            this.pVariableA.Location = new System.Drawing.Point(3, 129);
            this.pVariableA.Name = "pVariableA";
            this.pVariableA.Size = new System.Drawing.Size(309, 26);
            this.pVariableA.TabIndex = 8;
            this.pVariableA.Visible = false;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(129, 3);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "a";
            // 
            // pLambda
            // 
            this.pLambda.Controls.Add(this.txtLambda);
            this.pLambda.Controls.Add(this.label4);
            this.pLambda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLambda.Location = new System.Drawing.Point(3, 103);
            this.pLambda.Name = "pLambda";
            this.pLambda.Size = new System.Drawing.Size(309, 26);
            this.pLambda.TabIndex = 7;
            this.pLambda.Visible = false;
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(129, 3);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(100, 20);
            this.txtLambda.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lambda";
            // 
            // pDesviacionEstandar
            // 
            this.pDesviacionEstandar.Controls.Add(this.txtDesviacionEstandar);
            this.pDesviacionEstandar.Controls.Add(this.label3);
            this.pDesviacionEstandar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDesviacionEstandar.Location = new System.Drawing.Point(3, 77);
            this.pDesviacionEstandar.Name = "pDesviacionEstandar";
            this.pDesviacionEstandar.Size = new System.Drawing.Size(309, 26);
            this.pDesviacionEstandar.TabIndex = 6;
            this.pDesviacionEstandar.Visible = false;
            // 
            // txtDesviacionEstandar
            // 
            this.txtDesviacionEstandar.Location = new System.Drawing.Point(129, 3);
            this.txtDesviacionEstandar.Name = "txtDesviacionEstandar";
            this.txtDesviacionEstandar.Size = new System.Drawing.Size(100, 20);
            this.txtDesviacionEstandar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desviación Estandar";
            // 
            // pMedia
            // 
            this.pMedia.Controls.Add(this.txtMedia);
            this.pMedia.Controls.Add(this.label2);
            this.pMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMedia.Location = new System.Drawing.Point(3, 51);
            this.pMedia.Name = "pMedia";
            this.pMedia.Size = new System.Drawing.Size(309, 26);
            this.pMedia.TabIndex = 5;
            this.pMedia.Visible = false;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(129, 3);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Media";
            // 
            // pDistribuciones
            // 
            this.pDistribuciones.Controls.Add(this.cboDistribuciones);
            this.pDistribuciones.Controls.Add(this.label1);
            this.pDistribuciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDistribuciones.Location = new System.Drawing.Point(3, 16);
            this.pDistribuciones.Name = "pDistribuciones";
            this.pDistribuciones.Size = new System.Drawing.Size(309, 35);
            this.pDistribuciones.TabIndex = 4;
            // 
            // cboDistribuciones
            // 
            this.cboDistribuciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistribuciones.FormattingEnabled = true;
            this.cboDistribuciones.Location = new System.Drawing.Point(129, 10);
            this.cboDistribuciones.Name = "cboDistribuciones";
            this.cboDistribuciones.Size = new System.Drawing.Size(172, 21);
            this.cboDistribuciones.TabIndex = 0;
            this.cboDistribuciones.SelectedIndexChanged += new System.EventHandler(this.CboDistribuciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distribuciones";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indiceDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.iteracionBindingSource;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(350, 216);
            this.dgv.TabIndex = 0;
            // 
            // indiceDataGridViewTextBoxColumn
            // 
            this.indiceDataGridViewTextBoxColumn.DataPropertyName = "Indice";
            this.indiceDataGridViewTextBoxColumn.HeaderText = "Indice";
            this.indiceDataGridViewTextBoxColumn.Name = "indiceDataGridViewTextBoxColumn";
            this.indiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iteracionBindingSource
            // 
            this.iteracionBindingSource.DataSource = typeof(Simulacion_TP_3.Clases.Iteracion);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(669, 316);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pInferior);
            this.Controls.Add(this.pSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPrincipal";
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
    }
}

