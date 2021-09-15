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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgvChi = new System.Windows.Forms.DataGridView();
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
            this.txt_intervalos = new System.Windows.Forms.MaskedTextBox();
            this.btnProbar = new System.Windows.Forms.Button();
            this.chFE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chFO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChi
            // 
            this.dgvChi.AllowUserToAddRows = false;
            this.dgvChi.AllowUserToDeleteRows = false;
            this.dgvChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChi.BackgroundColor = System.Drawing.Color.White;
            this.dgvChi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inf,
            this.sup,
            this.medio,
            this.fo,
            this.p,
            this.fe,
            this.cac});
            this.dgvChi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvChi.Location = new System.Drawing.Point(235, 85);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChi.RowHeadersWidth = 5;
            this.dgvChi.Size = new System.Drawing.Size(705, 187);
            this.dgvChi.TabIndex = 9;
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
            // 
            // fe
            // 
            this.fe.HeaderText = "fe";
            this.fe.MinimumWidth = 6;
            this.fe.Name = "fe";
            this.fe.ReadOnly = true;
            // 
            // cac
            // 
            this.cac.HeaderText = "c(ac)";
            this.cac.MinimumWidth = 6;
            this.cac.Name = "cac";
            this.cac.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(30, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "SubIntervalos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(30, 181);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Nivel de Confianza";
            // 
            // txt_confianza
            // 
            this.txt_confianza.Enabled = false;
            this.txt_confianza.Location = new System.Drawing.Point(33, 202);
            this.txt_confianza.Margin = new System.Windows.Forms.Padding(4);
            this.txt_confianza.Mask = "99999";
            this.txt_confianza.Name = "txt_confianza";
            this.txt_confianza.Size = new System.Drawing.Size(99, 20);
            this.txt_confianza.TabIndex = 10;
            this.txt_confianza.Text = "95";
            this.txt_confianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_confianza.ValidatingType = typeof(int);
            // 
            // txt_intervalos
            // 
            this.txt_intervalos.Location = new System.Drawing.Point(33, 149);
            this.txt_intervalos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_intervalos.Mask = "99999";
            this.txt_intervalos.Name = "txt_intervalos";
            this.txt_intervalos.Size = new System.Drawing.Size(99, 20);
            this.txt_intervalos.TabIndex = 11;
            this.txt_intervalos.Text = "3";
            this.txt_intervalos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_intervalos.ValidatingType = typeof(int);
            // 
            // btnProbar
            // 
            this.btnProbar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProbar.FlatAppearance.BorderSize = 2;
            this.btnProbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProbar.Location = new System.Drawing.Point(33, 244);
            this.btnProbar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(113, 28);
            this.btnProbar.TabIndex = 13;
            this.btnProbar.Text = "Calcular chi";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.BtnProbar_Click);
            // 
            // chFE
            // 
            this.chFE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.chFE.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chFE.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.chFE.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea1.Name = "ChartArea1";
            this.chFE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chFE.Legends.Add(legend1);
            this.chFE.Location = new System.Drawing.Point(10, 279);
            this.chFE.Name = "chFE";
            this.chFE.Size = new System.Drawing.Size(461, 310);
            this.chFE.TabIndex = 16;
            this.chFE.Text = "chart1";
            // 
            // chFO
            // 
            this.chFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.chFO.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chFO.BackSecondaryColor = System.Drawing.Color.White;
            this.chFO.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea2.Name = "ChartArea1";
            this.chFO.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chFO.Legends.Add(legend2);
            this.chFO.Location = new System.Drawing.Point(479, 279);
            this.chFO.Name = "chFO";
            this.chFO.Size = new System.Drawing.Size(461, 310);
            this.chFO.TabIndex = 17;
            this.chFO.Text = "chart2";
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lblDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDist.Location = new System.Drawing.Point(30, 85);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(104, 17);
            this.lblDist.TabIndex = 19;
            this.lblDist.Text = "Distribución: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 82);
            this.panel1.TabIndex = 22;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 82);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Gráficos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lblResultado.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblResultado.ForeColor = System.Drawing.Color.Gold;
            this.lblResultado.Location = new System.Drawing.Point(386, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(566, 82);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(952, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.chFO);
            this.Controls.Add(this.chFE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_confianza);
            this.Controls.Add(this.txt_intervalos);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.dgvChi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmGrafico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txt_confianza;
        private System.Windows.Forms.MaskedTextBox txt_intervalos;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chFE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chFO;
        private System.Windows.Forms.DataGridViewTextBoxColumn inf;
        private System.Windows.Forms.DataGridViewTextBoxColumn sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn medio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cac;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTitulo;
    }
}