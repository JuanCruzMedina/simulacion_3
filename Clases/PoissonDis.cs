using Simulacion_TP_3.Clases;
using System;

namespace TP3.Distribuciones
{
    public class PoissonDis : Distribucion
    {
        private readonly double _Lambda;
        public PoissonDis(double lambda)
        {
            _Lambda = lambda;
            _Random = new Random();
        }
        public override double ObtenerVariableAleatoria()
        {
            double p = 1, x = -1, a = Math.Exp(-_Lambda);
            do
            {
                double u = _Random.NextDouble();
                p *= u;
                x += 1;
            }
            while (p >= a);
            return (int)x;
        }
        public override float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior)
        {
            double factorial = 1;
            for (int i = 1; i <= mc; i++) factorial *= i;
            float probabilidad = (float)(((Math.Pow(_Lambda, mc) * Math.Exp(-_Lambda))) / factorial);
            return probabilidad;
        }
        public override int ObtenerDatosEmpiricos() => default;
        public override string ObtenerNombre() => " de Poisson";
        public override Parametros ObtenerParametros() => Parametros.Lambda | Parametros.Media;
    }
}
