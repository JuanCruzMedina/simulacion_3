using Simulacion_TP_3.Clases;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TP3.Clases
{
    public class Uniforme : Distribucion
    {
        private readonly double _A;
        private readonly double _B;
        private readonly Dictionary<int, double> valoresCriticos;
        public double[] fo { get; set; }
        public double[] fe { get; set; }
        public double[,] intervalos { get; set; }
        public double[] c { get; set; }
        public double[] cac { get; set; }
        public double[] prob { get; set; }
        public double valorCritico { get; set; }
        public double salto;
        public bool rechazada;

        public Uniforme(double a, double b)
        {
            _A = a;
            _B = b;
            _Random = new Random();
        }

        public override double ObtenerVariableAleatoria() => _A + _Random.NextDouble() * (_B - _A);
        public override int ObtenerDatosEmpiricos() => default;
        public override string ObtenerNombre() => "Uniforme";
        public override List<Parametros> ObtenerParametros() => new List<Parametros>() { Parametros.VariableA, Parametros.VariableB };
        public override float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior) => (float)Math.Round(((float)((limiteSuperior - limiteInferior) / (_B - _A))), 4);

        public bool CalcularChi(List<Iteracion> variables, int cantIntervalos)
        {
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
            intervalos = calcularIntervalos(nums, cantIntervalos);

            salto = nums.Max() / cantIntervalos;
            for (int i = 0; i < intervalos.Length; i++)
            {
                var valorMedio = (intervalos[i, 0] + intervalos[i, 1]) / 2;
                prob[i] = this.CalcularProbabilidad(valorMedio, intervalos[i, 0], intervalos[i, 1]);
            }
            
            // Primero calculamos las frecuencias observadas
            calcularFO(variables);
            // Calculamos las frecuencias esperadas
            calcularFE(variables);
            // Obtenemos el estadistico acumulado
            calcularEstadisticoPrueba();
            // Verificamos si se rechaza la hipotesis nula
            testHipotesis(variables);

            return rechazada;
        }
        private double[,] calcularIntervalos(List<double> numeros, int cantIntervalos)
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
        private void calcularFO(List<Iteracion> variables)
        {
            // Vamos metiendo cada numero en el intervalo que corresponde
            foreach (Iteracion numero in variables)
            //double numero :variables
            {
                for (int i = 0; i < this.intervalos.Length; i++)
                {
                    if (this.intervalos[i, 0] > numero.Valor && numero.Valor >= (this.intervalos[i, 1] - this.salto))
                    {
                        fo[i]++;
                        continue;
                    }
                }
            }
        }

        // Calcular Frecuencias Esperadas
        private void calcularFE(List<Iteracion> variables)
        {
            for (int i = 0; i < this.fe.Length; i++)
            {
                this.fe[i] = this.prob[i]*variables.Count;
            }
        }

        private void calcularEstadisticoPrueba()
        {
            double valorAnt = 0;
            for (int i = 0; i < this.fe.Length; i++)
            {
                this.c[i] = ((this.fe[i] - this.fo[i]) * (this.fe[i] - this.fo[i])) / this.fe[i];
                valorAnt += this.c[i];
                this.cac[i] = valorAnt;
            }
        }

        // Este metodo verifica si se puede rechazar o no la hipotesis nula

        public void testHipotesis(List<Iteracion> variables)
        {
            int gradosLibertad;
            if (intervalos.Length == 1) gradosLibertad = 1;
            else gradosLibertad = intervalos.Length - 1;
            Dictionary<int, double> valoresCriticos = new Dictionary<int, double>();

            this.valorCritico = valoresCriticos[gradosLibertad];
            this.rechazada = !(valoresCriticos[gradosLibertad] > cac[cac.Length - 1]);
        }

        private void CargarDiccionario()
        {
            valoresCriticos.Add(1, 3.84);
            valoresCriticos.Add(2, 5.99);
            valoresCriticos.Add(3, 7.81);
            valoresCriticos.Add(4, 9.49);
            valoresCriticos.Add(5, 11.1);
            valoresCriticos.Add(6, 12.6);
            valoresCriticos.Add(7, 14.1);
            valoresCriticos.Add(8, 15.5);
            valoresCriticos.Add(9, 16.9);
            valoresCriticos.Add(10, 18.3);
            valoresCriticos.Add(11, 19.7);
            valoresCriticos.Add(12, 21.0);
            valoresCriticos.Add(13, 22.4);
            valoresCriticos.Add(14, 23.7);
            valoresCriticos.Add(15, 25.0);
            valoresCriticos.Add(16, 26.3);
            valoresCriticos.Add(17, 27.6);
            valoresCriticos.Add(18, 28.9);
            valoresCriticos.Add(19, 30.1);
            valoresCriticos.Add(20, 31.4);
            valoresCriticos.Add(21, 32.7);
            valoresCriticos.Add(22, 33.9);
            valoresCriticos.Add(23, 35.2);
            valoresCriticos.Add(24, 36.4);
            valoresCriticos.Add(25, 37.7);
            valoresCriticos.Add(26, 38.9);
            valoresCriticos.Add(27, 40.1);
            valoresCriticos.Add(28, 41.3);
            valoresCriticos.Add(29, 42.6);
            valoresCriticos.Add(30, 43.8);
            valoresCriticos.Add(40, 55.8);
            valoresCriticos.Add(50, 67.5);
            valoresCriticos.Add(60, 79.1);
            valoresCriticos.Add(70, 90.5);
            valoresCriticos.Add(80, 101.9);
            valoresCriticos.Add(90, 113.1);
            valoresCriticos.Add(100, 124.3);
        }

    }
}