﻿using Simulacion_TP_3.Clases;
using System.Collections.Generic;

namespace Simulacion_TP_3.Interfaces
{
    public interface IDistribucion
    {
        string ObtenerNombre();
        double?[] ObtenerVariableAleatoria();
        float CalcularProbabilidad(double mc, double limiteInferior, double limiteSuperior);
        int ObtenerDatosEmpiricos();
        double[,] ObtenerIntervalos();
        List<Parametros> ObtenerParametros();
        void Calcular(List<Iteracion> variables, int cantInt);
    }
}
