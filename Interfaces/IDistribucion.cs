using Simulacion_TP_3.Clases;
using System.Collections.Generic;

namespace Simulacion_TP_3.Interfaces
{
    public interface IDistribucion
    {
        double[] fo { get; set; }
        double[] fe { get; set; }
        double[,] intervalos { get; set; }
        double[] c { get; set; }
        double[] cac { get; set; }
        double[] prob { get; set; }
        double valorCritico { get; set; }

        double ObtenerVariableAleatoria();
        float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior);
        int ObtenerDatosEmpiricos();
        string ObtenerNombre();
        List<Parametros> ObtenerParametros();
        bool CalcularChi(List<Iteracion> variables, int cantInt);
    }
}
