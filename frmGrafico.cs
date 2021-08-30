using Simulacion_TP_3.Clases;
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
    public partial class frmGrafico : Form
    {
        private double[] intv, valuesFE, valuesFO;
        private List<Iteracion> _dataSource;
        private IDistribucion _distribucion;

        public frmGrafico(List<Iteracion> dataSource, IDistribucion dist)
        {
            InitializeComponent();
            this._dataSource = dataSource;
            this._distribucion = dist;
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            TestChi();
        }

        private void CargarGrillaChi(DataGridView grilla, IDistribucion lista)
        {
            grilla.Rows.Clear();
            string intervalo;
            for (int i = 0; i < lista.intervalos.Length; i++)
            {
                intervalo = Convert.ToDouble(lista.intervalos[i, 0].ToString("#.00")) + " - " + Convert.ToDouble(lista.intervalos[i, 1].ToString("#.00"));
                var intv = intervalo;
                var _fo = Convert.ToDouble(lista.fo[i].ToString("#.00"));
                var _fe = Convert.ToDouble(lista.fe[i].ToString("#.00"));
                var _c = Convert.ToDouble(lista.c[i].ToString("#.00"));
                var _cac = Convert.ToDouble(lista.cac[i].ToString("#.00"));
                grilla.Rows.Add(intv, _fo, _fe, _c, _cac);
            }
            dgvChi.Refresh();
        }

        private bool TestChi()
        {
            try
            {
                int k = Convert.ToInt32(txt_intervalos);
                dgvChi.DataSource = null;
                bool rechazada = _distribucion.CalcularChi(_dataSource, k);
                CargarGrillaChi(dgvChi, _distribucion);

                string msg = "Resultado: Con los grados de libertad " + (k - 1) + " se obtuvo un valor calculado de " + (_distribucion.cac[_distribucion.cac.Length - 1]) + ".\nSe obtuvo un valor crítico de " + _distribucion.valorCritico + ", por lo tanto, la hipótesis ";
                if (rechazada) msg += "fue rechazada";
                else msg += "no puede ser rechazada";
                /*lblResultado.Text = msg;
                lblResultado.Font = new Font("gothic century", lblResultado.Font.Size);
                lblResultado.ForeColor = Color.FromArgb(255, 255, 255);
                */
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
            string intervalo;
            chFE.Series.Add("Serie1");
            chFO.Series.Add("Serie2");
            chFE.Series["Serie1"].Points.Clear();
            chFO.Series["Serie2"].Points.Clear();

            chFE.Palette = ChartColorPalette.Berry;

            chFE.Series["Serie1"].LegendText = "Frecuencia esperada";
            chFO.Series["Serie2"].LegendText = "Frecuencia observada";

            for (int i = 0; i < intv.Length; i++)
            {
                if (i == 0) intervalo = "0 - " + Convert.ToDouble(intv[i].ToString("#.00"));
                else intervalo = Convert.ToDouble(intv[i - 1].ToString("#.00")) + " - " + Convert.ToDouble(intv[i].ToString("#.00"));
                chFE.Series["Serie1"].Points.AddXY(intervalo, valuesFE[i]);
            }

            for (int i = 0; i < intv.Length; i++)
            {
                if (i == 0) intervalo = "0 - " + Convert.ToDouble(intv[i].ToString("#.00"));
                else intervalo = Convert.ToDouble(intv[i - 1].ToString("#.00")) + " - " + Convert.ToDouble(intv[i].ToString("#.00"));
                chFO.Series["Serie2"].Points.AddXY(intervalo, valuesFO[i]);
            }
        }
    }
}
