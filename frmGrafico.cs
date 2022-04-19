﻿using Simulacion_TP_3.Clases;
using Simulacion_TP_3.Interfaces;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simulacion_TP_3
{
    public partial class FrmGrafico : Form
    {
        private double[] valuesFE, valuesFO;
        private double[,] intv;
        private readonly List<Iteracion> _dataSource;
        private readonly IDistribucion _distribucion;

        public FrmGrafico(List<Iteracion> dataSource, IDistribucion dist)
        {
            InitializeComponent();
            this._dataSource = dataSource;
            this._distribucion = dist;
            chFO.Titles.Add("Histograma de frecuencias observadas");
            chFO.Series.Add("Serie2");
            chFO.Series["Serie2"].LegendText = "Frecuencia observada";
            lblDist.Text += Environment.NewLine + dist.ObtenerNombre();
        }

        private void BtnProbar_Click(object sender, EventArgs e)
        {
            TestChi();
        }

        private void CargarGrillaChi(DataGridView grilla)
        {
            grilla.Rows.Clear();
            Clases.Distribucion distribucion = _distribucion as Clases.Distribucion;
            this.intv = distribucion.intervalos;
            this.valuesFE = distribucion.fe;
            this.valuesFO = distribucion.fo;
            for (int i = 0; i < distribucion.intervalos.GetLength(0); i++)
            {
                var _inf = Convert.ToDouble(distribucion.intervalos[i, 0].ToString("#.00"));
                var _sup = Convert.ToDouble(distribucion.intervalos[i, 1].ToString("#.00"));
                var _fo = Convert.ToDouble(distribucion.fo[i].ToString("#.00"));
                var _p = Convert.ToDouble(distribucion.prob[i].ToString("#.00"));
                var _medio = Convert.ToDouble(((distribucion.intervalos[i, 0] + distribucion.intervalos[i, 1]) / 2).ToString("#.00"));
                var _fe = Convert.ToDouble(distribucion.fe[i].ToString("#.00"));
                var _cac = Convert.ToDouble(distribucion.cac[i].ToString("#.00"));
                grilla.Rows.Add(_inf, _sup, _medio, _fo, _p, _fe, _cac);
            }
            dgvChi.Refresh();
        }

        private bool TestChi()
        {
            try
            {
                int k = Convert.ToInt32(txt_intervalos.SelectedItem.ToString());
                dgvChi.DataSource = null;
                bool rechazada = _distribucion.CalcularChi(_dataSource, k);
                CargarGrillaChi(dgvChi);
                Clases.Distribucion distribucion = _distribucion as Clases.Distribucion;
                string msg = "Resultado: Con los grados de libertad " +
                              (k - 1) +
                              " se obtuvo un valor calculado de " +
                              Common.TruncateDouble(distribucion.cac[k - 1],4) +
                              ". Se obtuvo un valor crítico de " +
                              distribucion.valorCritico +
                              ", por lo tanto, la hipótesis " +
                              (rechazada ? "fue rechazada." : "no puede ser rechazada.");
                MessageBox.Show(msg);
                lblResultado.Text = msg;
                this.CargarGrafico();
                return rechazada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CargarGrafico()
        {
            bool infinito = false;
            chFO.Series["Serie2"].Points.Clear();
            foreach (var item in valuesFE)
            {
                try
                {
                    var entero = Convert.ToInt32(item);
                }
                catch
                {
                    infinito = true;
                }
            }
            for (int i = 0; i < intv.GetLength(0); i++)
            {
                var inter = Convert.ToDouble(intv[i, 0].ToString("#.00")) + " - " + Convert.ToDouble(intv[i, 1].ToString("#.00"));
                chFO.Series["Serie2"].Points.AddXY(inter, valuesFO[i]);
            }
        }
    }
}
