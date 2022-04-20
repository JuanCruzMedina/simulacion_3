using Simulacion_TP_3.Clases;
using Simulacion_TP_3.Interfaces;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            txt_intervalos.SelectedIndex = 2;
            _dataSource = dataSource;
            _distribucion = dist;
            chFO.Titles.Add("Histograma de frecuencias observadas");
            chFO.Series.Add("Serie2");
            chFO.Series["Serie2"].LegendText = "Frecuencia observada";
            lblDist.Text += " " + dist.ObtenerNombre();
        }

        private void BtnProbar_Click(object sender, EventArgs e) => Calcular();

        private void CargarGrilla(DataGridView grilla)
        {
            grilla.Rows.Clear();
            Clases.Distribucion distribucion = _distribucion as Clases.Distribucion;
            intv = distribucion.Intervalos;
            valuesFE = distribucion.Fe;
            valuesFO = distribucion.Fo;
            double cuentaFO = 0;
            for (int i = 0; i < distribucion.Intervalos.GetLength(0); i++)
            {
                var _inf = Convert.ToDouble(distribucion.Intervalos[i, 0].ToString("#.00"));
                var _sup = Convert.ToDouble(distribucion.Intervalos[i, 1].ToString("#.00"));
                var _fo = Convert.ToDouble(distribucion.Fo[i].ToString("#.00"));
                var _medio = Convert.ToDouble(((distribucion.Intervalos[i, 0] + distribucion.Intervalos[i, 1]) / 2).ToString("#.00"));
                grilla.Rows.Add(_inf, _sup, _medio, _fo);
                cuentaFO += _fo;
            }
            lblTotal.Text = cuentaFO.ToString();
            dgv_valores.Refresh();
        }

        private void Calcular()
        {
            try
            {
                int cantidadIntervalos = Convert.ToInt32(txt_intervalos.SelectedItem.ToString());
                dgv_valores.DataSource = null;
                _distribucion.Calcular(_dataSource, cantidadIntervalos);
                CargarGrilla(dgv_valores);
                CargarGrafico();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGrafico_Load(object sender, EventArgs e)
        {
            Calcular();
        }

        private void CargarGrafico()
        {
            chFO.Series["Serie2"].Points.Clear();
            foreach (var item in valuesFE)
            {
                try
                {
                    var entero = Convert.ToInt32(item);
                }
                catch
                {
                    Console.WriteLine($"VALOR INVALIDO {item}");
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
