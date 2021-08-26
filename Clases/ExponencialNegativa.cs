using Simulacion_TP_3.Clases;
using System;
using static System.Math;

namespace TP3.Distribuciones
{
    public class ExponencialNegativa : Distribucion
    {
        private readonly double _Lambda;

        public ExponencialNegativa(double lambda)
        {
            _Lambda = lambda;
            _Random = new Random();
        }

        public override double ObtenerVariableAleatoria() => -(1 / _Lambda) * Log(1.0 - _Random.NextDouble());
        public override float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior) => (float)((_Lambda * Math.Exp(-_Lambda * mc)) * (limiteSuperior - limiteInferior));
        public override int ObtenerDatosEmpiricos() => default;
        public override string ObtenerNombre() => "Exponencial Negativa";
        public override Parametros ObtenerParametros() => Parametros.Lambda | Parametros.Media;
    }
}
