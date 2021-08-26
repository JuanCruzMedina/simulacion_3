using Simulacion_TP_3.Clases;
using System;

namespace TP3.Distribuciones
{
    public class Uniforme : Distribucion
    {
        private readonly double _A;
        private readonly double _B;

        public Uniforme(double a, double b)
        {
            _A = a;
            _B = b;
            _Random = new Random();
        }

        public override double ObtenerVariableAleatoria() => _A + _Random.NextDouble() * (_B - _A);
        public override float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior) => (float)Math.Round(((float)((limiteSuperior - limiteInferior) / (_B - _A))), 4);
        public override int ObtenerDatosEmpiricos() => default;
        public override string ObtenerNombre() => "Uniforme";
        public override Parametros ObtenerParametros() => Parametros.VariableA | Parametros.VariableB;
    }
}