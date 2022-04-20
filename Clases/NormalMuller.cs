using Simulacion_TP_3.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

namespace TP3.Clases
{
    public class NormalMuller : Distribucion
    {
        private readonly double _Media;
        private readonly double _DesviacionEstandar;
        private readonly Dictionary<int, double> _valoresCriticos;
        public double salto;
        public bool rechazada;

        public NormalMuller(double media, double desviacionEstandar)
        {
            _Media = media;
            _DesviacionEstandar = desviacionEstandar;
            _Random = new Random();
            _valoresCriticos = new Dictionary<int, double>();
        }
        public override string ObtenerNombre() => "Normal";
        public override double?[] ObtenerVariableAleatoria()
        {
            double?[] vector = new double?[2];
            double RND1 = _Random.NextDouble(),
            RND2 = _Random.NextDouble(),
            x = Sqrt(-2 * Log(RND1)) * Cos(2 * PI * RND2),
            y = Sqrt(-2 * Log(RND1)) * Sin(2 * PI * RND2);
            vector[0] = x * _DesviacionEstandar + _Media;
            vector[1] = y * _DesviacionEstandar + _Media;
            return vector;
        }
        public override float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior) => (float)(((Math.Exp((-0.5) * Math.Pow(((mc - _Media) / _DesviacionEstandar), 2))) / (_DesviacionEstandar * Sqrt(2 * PI))) * (limiteSuperior - limiteInferior));
        public override int ObtenerDatosEmpiricos() => 2;
        public override List<Parametros> ObtenerParametros() => new List<Parametros>() { Parametros.DesviacionEstandar, Parametros.Media };
        public override void Calcular(List<Iteracion> variables, int cantIntervalos)
        {
            if (_valoresCriticos.Count == 0)
                CargarDiccionario();
            Fo = new double[cantIntervalos];
            Fe = new double[cantIntervalos];
            C = new double[cantIntervalos];
            Cac = new double[cantIntervalos];
            Prob = new double[cantIntervalos];

            List<double> nums = new List<double>();
            foreach (var item in variables)
            {
                nums.Add(item.Valor);
            }
            Intervalos = CalcularIntervalos(nums, cantIntervalos);

            salto = nums.Max() / cantIntervalos;
            for (int i = 0; i < Intervalos.GetLength(0); i++)
            {
                var valorMedio = (Intervalos[i, 0] + Intervalos[i, 1]) / 2;
                Prob[i] = this.CalcularProbabilidad(valorMedio, Intervalos[i, 0], Intervalos[i, 1]);
            }
            CalcularFO(variables);
        }
        private void CargarDiccionario()
        {
            _valoresCriticos.Add(1, 3.84);
            _valoresCriticos.Add(2, 5.99);
            _valoresCriticos.Add(3, 7.81);
            _valoresCriticos.Add(4, 9.49);
            _valoresCriticos.Add(5, 11.1);
            _valoresCriticos.Add(6, 12.6);
            _valoresCriticos.Add(7, 14.1);
            _valoresCriticos.Add(8, 15.5);
            _valoresCriticos.Add(9, 16.9);
            _valoresCriticos.Add(10, 18.3);
            _valoresCriticos.Add(11, 19.7);
            _valoresCriticos.Add(12, 21.0);
            _valoresCriticos.Add(13, 22.4);
            _valoresCriticos.Add(14, 23.7);
            _valoresCriticos.Add(15, 25.0);
            _valoresCriticos.Add(16, 26.3);
            _valoresCriticos.Add(17, 27.6);
            _valoresCriticos.Add(18, 28.9);
            _valoresCriticos.Add(19, 30.1);
            _valoresCriticos.Add(20, 31.4);
            _valoresCriticos.Add(21, 32.7);
            _valoresCriticos.Add(22, 33.9);
            _valoresCriticos.Add(23, 35.2);
            _valoresCriticos.Add(24, 36.4);
            _valoresCriticos.Add(25, 37.7);
            _valoresCriticos.Add(26, 38.9);
            _valoresCriticos.Add(27, 40.1);
            _valoresCriticos.Add(28, 41.3);
            _valoresCriticos.Add(29, 42.6);
            _valoresCriticos.Add(30, 43.8);
            _valoresCriticos.Add(40, 55.8);
            _valoresCriticos.Add(50, 67.5);
            _valoresCriticos.Add(60, 79.1);
            _valoresCriticos.Add(70, 90.5);
            _valoresCriticos.Add(80, 101.9);
            _valoresCriticos.Add(90, 113.1);
            _valoresCriticos.Add(100, 124.3);
        }
    }
}
