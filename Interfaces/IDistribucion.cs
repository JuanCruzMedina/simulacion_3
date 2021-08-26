using Simulacion_TP_3.Clases;

namespace Simulacion_TP_3.Interfaces
{
    public interface IDistribucion
    {
        double ObtenerVariableAleatoria();
        float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior);
        int ObtenerDatosEmpiricos();
        string ObtenerNombre();
        Parametros ObtenerParametros();
    }
}
