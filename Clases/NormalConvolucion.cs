using Simulacion_TP_3.Clases;
using System;
using System.Collections.Generic;
using static System.Math;

namespace TP3.Clases
{
    public class NormalConvolucion : Distribucion
    {
        private readonly double _media;
        private readonly double _desviacionEstandar;
        public NormalConvolucion(double media, double desviacionEstandar)
        {
            this._media = media;
            this._desviacionEstandar = desviacionEstandar;
            _Random = new Random();
        }
        public override double ObtenerVariableAleatoria()
        {
            double ac = 0.0;
            for (int i = 0; i < 12; i++) ac += _Random.NextDouble();
            ac -= 6.0;
            double x = ac * _desviacionEstandar + _media;
            return x;
        }
        public override float CalcularProbabilidad(double mc, double desde, double hasta) => (float)(((Math.Exp((-0.5) * Math.Pow(((mc - _media) / _desviacionEstandar), 2))) / (_desviacionEstandar * Sqrt(2 * PI))) * (hasta - desde));
        public override int ObtenerDatosEmpiricos() => 2;
        public override string ObtenerNombre() => "Normal";
        public override List<Parametros> ObtenerParametros() => new List<Parametros>() { Parametros.DesviacionEstandar, Parametros.Media };
    }
}
