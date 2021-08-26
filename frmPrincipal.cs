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

namespace Simulacion_TP_3
{
    public partial class FrmPrincipal : Form
    {
        private readonly int _cantidadDecimales = 4;
        private List<Clases.Iteracion> _dataSource;
        private readonly IDistribucion _distribucion;
        private readonly int _cantidadNumeros;

        public FrmPrincipal()
        {
            InitializeComponent();
            LimpiarGrilla();
            LimpiarCampos();
            cboDistribuciones.DataSource = new List<Clases.Parametros>()
            {
                Clases.Parametros.DesviacionEstandar,
                Clases.Parametros.Lambda,
                Clases.Parametros.Media,
                Clases.Parametros.VariableA,
                Clases.Parametros.VariableB
            };
        }

        #region Métodos Privados

        private void LimpiarGrilla()
        {
            _dataSource = new List<Clases.Iteracion>();
            dgv.DataSource = _dataSource;
            dgv.Refresh();
        }

        private void LimpiarCampos()
        {
            txtA.Clear();
            txtB.Clear();
            txtN.Clear();
            txtMedia.Clear();
            txtDesviacionEstandar.Clear();
            txtLambda.Clear();
        }

        private void HabilitarParametros()
        {

        }

        private bool ObtenerParametros()
        {
            throw new Exception();
        }

        private bool EstablecerDistribucion()
        {
            throw new Exception();
        }

        #endregion

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            LimpiarGrilla();
            for (int i = 0; i < _cantidadNumeros; i++)
                _dataSource.Add(new Clases.Iteracion(i, Math.Round(_distribucion.ObtenerVariableAleatoria(), _cantidadDecimales)));
            dgv.Refresh();
        }
        private void CboDistribuciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarParametros();
        }
    }
}
