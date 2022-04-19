using Simulacion_TP_3.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

namespace TP3.Clases
{
    public class ExponencialNegativa : Distribucion
    {
        private readonly double _Lambda;
        private readonly Dictionary<int, double> _valoresCriticos;
        public double salto;
        public bool rechazada;

        public ExponencialNegativa(double lambda)
        {
            _Lambda = lambda;
            _Random = new Random();
            _valoresCriticos = new Dictionary<int, double>();
        }
        public override string ObtenerNombre()
        {
            return "Exponencial negativa";
        }
        public override double?[] ObtenerVariableAleatoria() {
            double?[] vector = new double?[1];
            var x = -(1 / _Lambda) * Log(1.0 - _Random.NextDouble());
            vector[0] = x;
            return vector;
        }

        public override float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior) => 
            (float)((_Lambda * Math.Exp(-_Lambda * mc)) * (limiteSuperior - limiteInferior));

        public override int ObtenerDatosEmpiricos() => default;
        public override List<Parametros> ObtenerParametros() => new List<Parametros>() { Parametros.Lambda };
        public override bool Calcular(List<Iteracion> variables, int cantIntervalos)
        {
            if (_valoresCriticos.Count == 0)
                CargarDiccionario();
            fo = new double[cantIntervalos];
            fe = new double[cantIntervalos];
            c = new double[cantIntervalos];
            cac = new double[cantIntervalos];
            prob = new double[cantIntervalos];

            List<double> nums = new List<double>();
            foreach (var item in variables)
            {
                nums.Add(item.Valor);
            }
            intervalos = CalcularIntervalos(nums, cantIntervalos);

            salto = nums.Max() / cantIntervalos;
            for (int i = 0; i < intervalos.GetLength(0); i++)
            {
                var valorMedio = (intervalos[i, 0] + intervalos[i, 1]) / 2;
                prob[i] = this.CalcularProbabilidad(valorMedio, intervalos[i, 0], intervalos[i, 1]);
            }

            // Primero calculamos las frecuencias observadas
            CalcularFO(variables);
            return false;
        }
        private double[,] CalcularIntervalos(List<double> numeros, int cantIntervalos)
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
            }

            return intervalos;
        }

        // Calcular Frecuencias Observadas
        private void CalcularFO(List<Iteracion> variables)
        {
            // Vamos metiendo cada numero en el intervalo que corresponde
            fo[0]++;
            foreach (Iteracion numero in variables)
            //double numero :variables
            {
                for (int i = 0; i < intervalos.GetLength(0); i++)
                {
                    if (this.intervalos[i, 0] < numero.Valor && numero.Valor <= this.intervalos[i, 1])
                    {
                        fo[i]++;
                        continue;
                    }
                }
            }
        }

        // Calcular Frecuencias Esperadas
        private void CalcularFE(List<Iteracion> variables)
        {
            for (int i = 0; i < this.fe.Length; i++)
            {
                this.fe[i] = this.prob[i] * variables.Count;
            }
        }

        private void CalcularEstadisticoPrueba()
        {
            double valorAnt = 0;
            for (int i = 0; i < this.fe.Length; i++)
            {
                this.c[i] = Math.Pow((this.fe[i] - this.fo[i]), 2) / this.fe[i];
                valorAnt += this.c[i];
                this.cac[i] = valorAnt;
            }
        }

        // Este metodo verifica si se puede rechazar o no la hipotesis nula

        public void TestHipotesis(List<Iteracion> variables)
        {
            int gradosLibertad;
            if (intervalos.GetLength(0) == 1) gradosLibertad = 1;
            else gradosLibertad = intervalos.GetLength(0) - 1;

            this.valorCritico = _valoresCriticos[gradosLibertad];
            this.rechazada = !(_valoresCriticos[gradosLibertad] > cac[cac.Length - 1]);
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
