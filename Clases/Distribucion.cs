using System;

namespace Simulacion_TP_3.Clases
{
    public abstract class Distribucion : Interfaces.IDistribucion
    {
        protected Random _Random;
        public abstract float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior);
        public abstract int ObtenerDatosEmpiricos();
        public abstract string ObtenerNombre();
        public abstract double ObtenerVariableAleatoria();
        public abstract Parametros ObtenerParametros();
    }
    public enum Parametros
    {
        DesviacionEstandar,
        Media,
        Lambda,
        VariableA,
        VariableB
    }
}
