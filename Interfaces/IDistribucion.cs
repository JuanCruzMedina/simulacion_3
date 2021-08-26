using Simulacion_TP_3.Clases;
using System.Collections.Generic;

namespace Simulacion_TP_3.Interfaces
{
    public interface IDistribucion
    {
        double ObtenerVariableAleatoria();
        float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior);
        int ObtenerDatosEmpiricos();
        string ObtenerNombre();
        List<Parametros> ObtenerParametros();
    }
}
