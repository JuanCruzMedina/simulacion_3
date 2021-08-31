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
        private double[] valuesFE, valuesFO;
        private double[,] intv;
        private List<Iteracion> _dataSource;
        private IDistribucion _distribucion;

        public frmGrafico(List<Iteracion> dataSource, IDistribucion dist)
        {
            InitializeComponent();
            this._dataSource = dataSource;
            this._distribucion = dist;
            lblDist.Text += dist.ObtenerNombre();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            TestChi();
        }

        private void CargarGrillaChi(DataGridView grilla)
        {
            grilla.Rows.Clear();
            Clases.Distribucion distribucion = _distribucion as Clases.Distribucion;
            this.intv = distribucion.intervalos;
            this.valuesFE= distribucion.fe;
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
                //var _cac = Convert.ToDouble(distribucion.cac[i].ToString("#.00"));
                grilla.Rows.Add(_inf, _sup, _medio, _fo, _p, _fe, _cac);
            }
            dgvChi.Refresh();
        }

        private bool TestChi()
        {
            try
            {
                lblResultado.Visible = false;
                int k = Convert.ToInt32(txt_intervalos.Text);
                dgvChi.DataSource = null;
                bool rechazada = _distribucion.CalcularChi(_dataSource, k);
                CargarGrillaChi(dgvChi);
                Clases.Distribucion distribucion = _distribucion as Clases.Distribucion;
                string msg = "Resultado: Con los grados de libertad " + (k - 1) + " se obtuvo un valor calculado de " + (distribucion.cac[k - 1]) + ".\nSe obtuvo un valor crítico de " + distribucion.valorCritico + ", por lo tanto, la hipótesis ";
                if (rechazada) msg += "fue rechazada";
                else msg += "no puede ser rechazada";
                lblResultado.Text = msg;
                lblResultado.Font = new Font("gothic century", lblResultado.Font.Size);
                lblResultado.ForeColor = Color.FromArgb(0, 0, 0);
                lblResultado.Visible = true;

                this.CargarGrafico();
                return rechazada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void frmGrafico_Load(object sender, EventArgs e)
        {
            chFE.Titles.Add("Histograma de frecuencias esperadas");
            chFO.Titles.Add("Histograma de frecuencias observadas");
        }

        private void CargarGrafico()
        {
            chFE.Series.Add("Serie1");
            chFO.Series.Add("Serie2");
            chFE.Series["Serie1"].Points.Clear();
            chFO.Series["Serie2"].Points.Clear();

            chFE.Palette = ChartColorPalette.Berry;

            chFE.Series["Serie1"].LegendText = "Frecuencia esperada";
            chFO.Series["Serie2"].LegendText = "Frecuencia observada";

            for (int i = 0; i < intv.GetLength(0); i++)
            {
                var inter = Convert.ToDouble(intv[i,0].ToString("#.00")) + " - " + Convert.ToDouble(intv[i,1].ToString("#.00"));
                chFE.Series["Serie1"].Points.AddXY(inter, valuesFE[i]);
                chFO.Series["Serie2"].Points.AddXY(inter, valuesFO[i]);
            }
        }
    }
}
