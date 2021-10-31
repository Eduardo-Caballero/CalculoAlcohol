using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoAlcohol.Domain.Entities
{
    public class Bebidas
    {
        private int _cantidad;
        private int _LCantidad;
        private int _peso;
        private double TotalCon;
        private double SangreD;
        private double MasaE = 0.789;
        private double EtohSangre;
        private double volumenSangre;
        private double SangreA;
        private double GradoAlcohol;
        private string _bebida;
        public void AlcoholIngerido(string bebida, int cantidad)
        {
            _cantidad = cantidad;
            _bebida = bebida.ToLower();
            switch (_bebida)
            {
                case "cerveza":
                    _LCantidad = 330;
                    _cantidad = _cantidad * _LCantidad;
                    GradoAlcohol = 5;
                    TotalCon = GradoAlcohol / 100 * _cantidad;
                    break;
                case "vino":
                    _LCantidad = 100;
                    _cantidad = _cantidad * _LCantidad;
                    GradoAlcohol = 12;
                    TotalCon = GradoAlcohol / 100 * _cantidad;
                    break;
                case "cava":
                    _LCantidad = 100;
                    _cantidad = _cantidad * _LCantidad;
                    GradoAlcohol = 12;
                    TotalCon = GradoAlcohol / 100 * _cantidad;
                    break;
                case "vermu":
                    _LCantidad = 70;
                    _cantidad = _cantidad * _LCantidad;
                    GradoAlcohol = 17;
                    TotalCon = GradoAlcohol / 100 * _cantidad;
                    break;
                case "licor":
                    _LCantidad = 45;
                    _cantidad = _cantidad * _LCantidad;
                    GradoAlcohol = 23;
                    TotalCon = GradoAlcohol / 100 * _cantidad;
                    break;
                case "brandy":
                    _LCantidad = 45;
                    _cantidad = _cantidad * _LCantidad;
                    GradoAlcohol = 38;
                    TotalCon = GradoAlcohol / 100 * _cantidad;
                    break;
                case "combinado":
                    _LCantidad = 50;
                    _cantidad = _cantidad * _LCantidad;
                    GradoAlcohol = 38;
                    TotalCon = GradoAlcohol / 100 * _cantidad;
                    break;
            }
        }
        public void CantidadAlcoholSangre(int peso)
        {
            _peso = peso;
            SangreD = 0.15 * TotalCon;
            EtohSangre = MasaE * SangreD;
            volumenSangre = 0.8 * _peso;
            SangreA = EtohSangre / volumenSangre;

        }

        public string Validar()
        {
            if (SangreA > 0.8)
            {
                return $" El nivel de Alcohol en Sangre es: {SangreA} El Nivel de Alcohol es Mayor al Limite reglamentario, no es apto para manejar";
            }
            return $" Su nivel de alcohol en la sangre es  de: {SangreA}  El Nivel de Alcohol Comple con el Limite reglamentario,  es apto para manejar, que tenga un buen viaje";

        }
    }
}
