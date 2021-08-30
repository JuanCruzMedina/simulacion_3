using Simulacion_TP_3.Clases;
using System;
using System.Collections.Generic;
using static System.Math;

namespace TP3.Clases
{
    public class NormalMuller : Distribucion
    {
        private readonly double _Media;
        private readonly double _DesviacionEstandar;
        public NormalMuller(double media, double desviacionEstandar)
        {
            _Media = media;
            _DesviacionEstandar = desviacionEstandar;
            _Random = new Random();
        }

        public override double ObtenerVariableAleatoria()
        {
            double[] vector = new double[2];
            double RND1 = _Random.NextDouble(),
            RND2 = _Random.NextDouble(),
            x = Sqrt(-2 * Log(RND1)) * Cos(2 * PI * RND2),
            y = Sqrt(-2 * Log(RND1)) * Sin(2 * PI * RND2);
            vector[0] = x * _DesviacionEstandar + _Media;
            vector[1] = y * _DesviacionEstandar + _Media;
            return vector[0];
        }
        public override float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior) => (float)(((Math.Exp((-0.5) * Math.Pow(((mc - _Media) / _DesviacionEstandar), 2))) / (_DesviacionEstandar * Sqrt(2 * PI))) * (limiteSuperior - limiteInferior));
        public override int ObtenerDatosEmpiricos() => 2;
        public override List<Parametros> ObtenerParametros() => new List<Parametros>() { Parametros.DesviacionEstandar, Parametros.Media };

        public override bool CalcularChi(List<Iteracion> variables, int cantInt)
        {
            throw new NotImplementedException();
        }
    }
}
