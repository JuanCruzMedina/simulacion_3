using Simulacion_TP_3.Clases;
using Simulacion_TP_3.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TP3.Clases;

namespace Simulacion_TP_3
{
    public partial class FrmPrincipal : Form
    {
        private readonly int _cantidadDecimales = 4;
        private List<Iteracion> _dataSource = null;
        private IDistribucion _distribucion;
        private int _cantidadNumeros;

        public FrmPrincipal()
        {
            _distribucion = new ExponencialNegativa(default);
            _cantidadNumeros = default;
            _dataSource = new List<Iteracion>();
            InitializeComponent();
            LimpiarCampos();
            CargarComboDistribuciones();
            HabilitarParametros();
        }

        #region Métodos Privados
        private void CargarComboDistribuciones()
        {
            cboDistribuciones.DataSource = EnumExtension.ToList<Distribucion>();
            cboDistribuciones.ValueMember = "Key";
            cboDistribuciones.DisplayMember = "Value";
            cboDistribuciones.SelectedIndex = 0;
        }
        private void LimpiarGrilla()
        {
            _dataSource = new List<Iteracion>();
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
            try
            {
                if (_distribucion != null)
                {
                    pVariableA.Visible = _distribucion.ObtenerParametros().Contains(Parametros.VariableA);
                    pVariableB.Visible = _distribucion.ObtenerParametros().Contains(Parametros.VariableB);
                    pDesviacionEstandar.Visible = _distribucion.ObtenerParametros().Contains(Parametros.DesviacionEstandar);
                    pMedia.Visible = _distribucion.ObtenerParametros().Contains(Parametros.Media);
                    pLambda.Visible = _distribucion.ObtenerParametros().Contains(Parametros.Lambda);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio una inconsistencia al habilitar los parametros. \nError:" + ex.Message);
            }
        }
        private (bool, string) EstablecerDistribucion(bool usarDefault = true)
        {
            var resultado = (exito: true, mensaje: string.Empty);
            var distribucion = (Distribucion)cboDistribuciones.SelectedIndex;
            switch (distribucion)
            {
                case Distribucion.ExponencialNegativa:
                    if (usarDefault)
                        _distribucion = new ExponencialNegativa(default);
                    else if (double.TryParse(txtLambda.Text, out double lambda))
                        _distribucion = new ExponencialNegativa(lambda);
                    else resultado.exito = false;
                    break;

                case Distribucion.NormalConvolucion:
                    if (usarDefault)
                        _distribucion = new NormalConvolucion(default, default);
                    else if (double.TryParse(txtMedia.Text, out double media) && double.TryParse(txtDesviacionEstandar.Text, out double desviacionEstandar))
                        _distribucion = new NormalConvolucion(media, desviacionEstandar);
                    else resultado.exito = false;
                    break;

                case Distribucion.NormalMuller:
                    if (usarDefault)
                        _distribucion = new NormalMuller(default, default);
                    else if (double.TryParse(txtMedia.Text, out double media) && double.TryParse(txtDesviacionEstandar.Text, out double desviacionEstandar))
                        _distribucion = new NormalMuller(media, desviacionEstandar);
                    else resultado.exito = false;
                    break;

                case Distribucion.PoissonDis:
                    if (usarDefault)
                        _distribucion = new PoissonDis(default);
                    else if (double.TryParse(txtLambda.Text, out double lambda))
                        _distribucion = new PoissonDis(lambda);
                    else resultado.exito = false;
                    break;

                case Distribucion.Uniforme:
                    if (usarDefault)
                        _distribucion = new Uniforme(default, default);
                    else if (double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b))
                        _distribucion = new Uniforme(a, b);
                    else resultado.exito = false;
                    break;
            }
            if (!resultado.exito)
                resultado.mensaje = "Los parámetros ingresados no son válidos.";

            return resultado;
        }

       
        #endregion

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            _dataSource = new List<Iteracion>();
            LimpiarGrilla();
            EstablecerDistribucion(false);
            _cantidadNumeros = int.TryParse(txtN.Text, out int n) ? n : 0;
            for (int i = 1; i <= _cantidadNumeros; i++)
                _dataSource.Add(new Iteracion(i, Math.Round(_distribucion.ObtenerVariableAleatoria(), _cantidadDecimales)));
            dgv.DataSource = _dataSource;
            btnGenerarGraficos.Enabled = true;
            dgv.Refresh();
        }
        private void CboDistribuciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstablecerDistribucion();
            HabilitarParametros();
        }

        private void btnGenerarGraficos_Click(object sender, EventArgs e)
        {
            frmGrafico graf = new frmGrafico(_dataSource,_distribucion);
            graf.ShowDialog();
        }
    }
    enum Distribucion
    {
        [Description("Exponencial Negativa"),]
        ExponencialNegativa,
        [Description("Normal Convolución")]
        NormalConvolucion,
        [Description("Normal Muller")]
        NormalMuller,
        [Description("Poisson")]
        PoissonDis,
        [Description("Uniforme")]
        Uniforme
    }
    public static class EnumExtension
    {
        /// <summary>
        /// Gets the string of an DescriptionAttribute of an Enum.
        /// </summary>
        /// <param name="value">The Enum value for which the description is needed.</param>
        /// <returns>If a DescriptionAttribute is set it return the content of it.
        /// Otherwise just the raw name as string.</returns>
        public static string Description(this Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            string description = value.ToString();
            FieldInfo fieldInfo = value.GetType().GetField(description);
            DescriptionAttribute[] attributes =
               (DescriptionAttribute[])
             fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                description = attributes[0].Description;
            }

            return description;
        }

        /// <summary>
        /// Creates an List with all keys and values of a given Enum class
        /// </summary>
        /// <typeparam name="T">Must be derived from class Enum!</typeparam>
        /// <returns>A list of KeyValuePair&lt;Enum, string&gt; with all available
        /// names and values of the given Enum.</returns>
        public static IList<KeyValuePair<Enum, string>> ToList<T>() where T : struct
        {
            var type = typeof(T);

            if (!type.IsEnum)
            {
                throw new ArgumentException("T must be an enum");
            }

            return (IList<KeyValuePair<Enum, string>>)
                    Enum.GetValues(type)
                        .OfType<Enum>()
                        .Select(e => new KeyValuePair<Enum, string>(e, e.Description()))
                        .ToArray();
        }

        public static T GetValueFromDescription<T>(string description) where T : struct
        {
            var type = typeof(T);

            if (!type.IsEnum)
            {
                throw new ArgumentException("T must be an enum");
            }

            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (attribute != null)
                {
                    if (attribute.Description == description)
                    {
                        return (T)field.GetValue(null);
                    }
                }
                else
                {
                    if (field.Name == description)
                    {
                        return (T)field.GetValue(null);
                    }
                }
            }

            throw new ArgumentOutOfRangeException("description");
            // or return default(T);
        }
    }
}
