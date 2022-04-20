using Simulacion_TP_3.Interfaces;

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Simulacion_TP_3.Clases
{
    public abstract class Distribucion : IDistribucion
    {
        protected Random _Random;

        public double[] Fo { get; set; }
        public double[] Fe { get; set; }
        public double[,] Intervalos { get; set; }
        public double[] C { get; set; }
        public double[] Cac { get; set; }
        public double[] Prob { get; set; }
        public double ValorCritico { get; set; }

        public abstract string ObtenerNombre();

        public abstract float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior);
        public abstract int ObtenerDatosEmpiricos();
        public abstract double?[] ObtenerVariableAleatoria();
        public abstract List<Parametros> ObtenerParametros();
        public double[,] ObtenerIntervalos() => Intervalos;
        public abstract void Calcular(List<Iteracion> variables, int cantInt);
        protected double[,] CalcularIntervalos(List<double> numeros, int cantIntervalos)
        {
            double max = numeros[0];
            double min = numeros[0];
            int n = numeros.Count;

            for (int i = 1; i < n; i++)
            {
                if (numeros[i] > max) max = numeros[i];
                if (numeros[i] < min) min = numeros[i];
            }

            double diferencia = max - min;
            double ancho = diferencia / cantIntervalos;

            double[,] intervalos = new double[cantIntervalos, 2];

            for (int i = 0; i < cantIntervalos; i++)
            {
                intervalos[i, 0] = min + (i * ancho);
                intervalos[i, 1] = min + ((i + 1) * ancho);
                if (i == cantIntervalos - 1)
                    intervalos[i, 1] += 0.00001;
            }
            return intervalos;
        }
        protected void CalcularFO(List<Iteracion> variables)
        {
            foreach (Iteracion numero in variables)
            {
                bool alguno = false;
                for (int i = 0; i < Intervalos.GetLength(0); i++)
                {
                    if (Intervalos[i, 0] <= numero.Valor && numero.Valor < Intervalos[i, 1])
                    {
                        Fo[i]++;
                        alguno = true;
                        break;
                    }
                }
                if (!alguno)
                    Console.WriteLine($"NO INGRESO EN EL LIMITE {numero.Valor}");
            }
        }
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
