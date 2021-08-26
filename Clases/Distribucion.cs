using Simulacion_TP_3.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Simulacion_TP_3.Clases
{
    public abstract class Distribucion : IDistribucion
    {
        protected Random _Random;
        public abstract float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior);
        public abstract int ObtenerDatosEmpiricos();
        public abstract string ObtenerNombre();
        public abstract double ObtenerVariableAleatoria();
        public abstract List<Parametros> ObtenerParametros();
    }
    [Flags]
    public enum Parametros
    {
        [Description("Desviación Estandar")]
        DesviacionEstandar,
        [Description("Media")]
        Media,
        [Description("Lambda")]
        Lambda,
        [Description("Variable A")]
        VariableA,
        [Description("Variable B")]
        VariableB
    }
}
