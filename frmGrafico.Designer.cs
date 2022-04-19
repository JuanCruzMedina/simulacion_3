namespace Simulacion_TP_3
{
    partial class FrmGrafico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgv_valores = new System.Windows.Forms.DataGridView();
            this.inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_confianza = new System.Windows.Forms.MaskedTextBox();
            this.btnProbar = new System.Windows.Forms.Button();
            this.chFO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txt_intervalos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_valores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChi
            // 
            this.dgv_valores.AllowUserToAddRows = false;
            this.dgv_valores.AllowUserToDeleteRows = false;
            this.dgv_valores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_valores.BackgroundColor = System.Drawing.Color.White;
            this.dgv_valores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_valores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_valores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_valores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inf,
            this.sup,
            this.medio,
            this.fo,
            this.p,
            this.fe,
            this.cac});
            this.dgv_valores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgv_valores.Location = new System.Drawing.Point(212, 98);
            this.dgv_valores.Name = "dgvChi";
            this.dgv_valores.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_valores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_valores.RowHeadersWidth = 5;
            this.dgv_valores.Size = new System.Drawing.Size(306, 310);
            this.dgv_valores.TabIndex = 9;
            // 
            // inf
            // 
            this.inf.HeaderText = "Inferior";
            this.inf.MinimumWidth = 6;
            this.inf.Name = "inf";
            this.inf.ReadOnly = true;
            // 
            // sup
            // 
            this.sup.HeaderText = "Superior";
            this.sup.MinimumWidth = 6;
            this.sup.Name = "sup";
            this.sup.ReadOnly = true;
            // 
            // medio
            // 
            this.medio.HeaderText = "Medio";
            this.medio.MinimumWidth = 6;
            this.medio.Name = "medio";
            this.medio.ReadOnly = true;
            // 
            // fo
            // 
            this.fo.HeaderText = "fo";
            this.fo.MinimumWidth = 6;
            this.fo.Name = "fo";
            this.fo.ReadOnly = true;
            // 
            // p
            // 
            this.p.HeaderText = "P()";
            this.p.MinimumWidth = 6;
            this.p.Name = "p";
            this.p.ReadOnly = true;
            this.p.Visible = false;
            // 
            // fe
            // 
            this.fe.HeaderText = "fe";
            this.fe.MinimumWidth = 6;
            this.fe.Name = "fe";
            this.fe.ReadOnly = true;
            this.fe.Visible = false;
            // 
            // cac
            // 
            this.cac.HeaderText = "c(ac)";
            this.cac.MinimumWidth = 6;
            this.cac.Name = "cac";
            this.cac.ReadOnly = true;
            this.cac.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(17, 141);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "SubIntervalos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(17, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Nivel de Confianza";
            this.label12.Visible = false;
            // 
            // txt_confianza
            // 
            this.txt_confianza.Enabled = false;
            this.txt_confianza.Location = new System.Drawing.Point(20, 215);
            this.txt_confianza.Margin = new System.Windows.Forms.Padding(4);
            this.txt_confianza.Mask = "99999";
            this.txt_confianza.Name = "txt_confianza";
            this.txt_confianza.Size = new System.Drawing.Size(99, 20);
            this.txt_confianza.TabIndex = 10;
            this.txt_confianza.Text = "95";
            this.txt_confianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_confianza.ValidatingType = typeof(int);
            this.txt_confianza.Visible = false;
            // 
            // btnProbar
            // 
            this.btnProbar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProbar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProbar.FlatAppearance.BorderSize = 2;
            this.btnProbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProbar.Location = new System.Drawing.Point(20, 379);
            this.btnProbar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(185, 28);
            this.btnProbar.TabIndex = 13;
            this.btnProbar.Text = "Calcular";
            this.btnProbar.UseVisualStyleBackColor = false;
            this.btnProbar.Click += new System.EventHandler(this.BtnProbar_Click);
            // 
            // chFO
            // 
            this.chFO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chFO.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chFO.BackSecondaryColor = System.Drawing.Color.White;
            this.chFO.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea1.Name = "ChartArea1";
            this.chFO.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chFO.Legends.Add(legend1);
            this.chFO.Location = new System.Drawing.Point(524, 98);
            this.chFO.Name = "chFO";
            this.chFO.Size = new System.Drawing.Size(461, 310);
            this.chFO.TabIndex = 17;
            this.chFO.Text = "chart2";
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDist.Location = new System.Drawing.Point(17, 98);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(104, 17);
            this.lblDist.TabIndex = 19;
            this.lblDist.Text = "Distribución: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 82);
            this.panel1.TabIndex = 22;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblResultado.Location = new System.Drawing.Point(0, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(566, 82);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(800, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 82);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Gráficos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_intervalos
            // 
            this.txt_intervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_intervalos.FormattingEnabled = true;
            this.txt_intervalos.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.txt_intervalos.Location = new System.Drawing.Point(20, 161);
            this.txt_intervalos.Name = "txt_intervalos";
            this.txt_intervalos.Size = new System.Drawing.Size(121, 21);
            this.txt_intervalos.TabIndex = 23;
            // 
            // FrmGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1003, 420);
            this.Controls.Add(this.txt_intervalos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.chFO);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_confianza);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.dgv_valores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmGrafico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_valores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_valores;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txt_confianza;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chFO;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn inf;
        private System.Windows.Forms.DataGridViewTextBoxColumn sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn medio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cac;
        private System.Windows.Forms.ComboBox txt_intervalos;
    }
}