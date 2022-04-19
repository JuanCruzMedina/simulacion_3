using Simulacion_TP_3.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Simulacion_TP_3.Clases
{
    public abstract class Distribucion : IDistribucion
    {
        protected Random _Random;

        public double[] fo { get; set; }
        public double[] fe { get; set; }
        public double[,] intervalos { get; set; }
        public double[] c { get; set; }
        public double[] cac { get; set; }
        public double[] prob { get; set; }
        public double valorCritico { get; set; }
        public abstract string ObtenerNombre();
        public abstract float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior);
        public abstract int ObtenerDatosEmpiricos();
        public abstract double?[] ObtenerVariableAleatoria();
        public abstract List<Parametros> ObtenerParametros();
        public double[,] ObtenerIntervalos() => intervalos;
        public abstract bool Calcular(List<Iteracion> variables, int cantInt);
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
