using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoAlcohol.Services
{
    public class AlcoholService
    {
        public double CalcularTotalAlcoholConsumido(string bebida, int Cantidad)
        {
            int totalBebidaTomada;
            double totalAlcoholPorBebidaTomada;
            switch (bebida)
            {
                case "cerveza":
                    totalBebidaTomada = Cantidad * 330;
                    totalAlcoholPorBebidaTomada = totalBebidaTomada * 0.05;
                    break;

                case "vino" or "cava":
                    totalBebidaTomada = Cantidad * 100;
                    totalAlcoholPorBebidaTomada = totalBebidaTomada * 0.12;
                    break;

                case "vermu":
                    totalBebidaTomada = Cantidad * 70;
                    totalAlcoholPorBebidaTomada = totalBebidaTomada * 0.24;
                    break;

                case "licor":
                    totalBebidaTomada = Cantidad * 45;
                    totalAlcoholPorBebidaTomada = totalBebidaTomada * 0.51;
                    break;

                case "brandy":
                    totalBebidaTomada = Cantidad * 45;
                    totalAlcoholPorBebidaTomada = totalBebidaTomada * 0.84;
                    break;

                case "combinado":
                    totalBebidaTomada = Cantidad * 50;
                    totalAlcoholPorBebidaTomada = totalBebidaTomada * 0.76;
                    break;
                default:
                    return totalAlcoholPorBebidaTomada = 0;
            }
            return totalAlcoholPorBebidaTomada;

        }

        internal object CalcularTotalAlcoholConsumido(string bebida, object cantidad)
        {
            throw new NotImplementedException();
        }

        //calcular la cantidad de alcohol que pasa directo a la sangre
        public double CalcularCantidadAlcoholSangre(double totalAlcoholPorBebidaTomado)
        {
            double AlcoholSangre = (totalAlcoholPorBebidaTomado * 15) / 100;
            return AlcoholSangre;
        }
        //calcular la masa del etanol en sangre
        public double CalcularMasa(double AlcoholSangre)
        {
            double masa = 0.789 * AlcoholSangre;
            return masa;
        }

        //calcular el volumen de la sangre de la persona considerando su peso
        public double CalcularVolumenSangre(double peso)
        {
            double volumenSangre = (8 * peso / 100);
            return volumenSangre;
        }

        //calcular el volumen de alcochol en la sangre (alcoholemia)
        public double CalcularVolumenAlcohol(double masa, double volSangre)
        {
            double volAlcohol = masa / volSangre;
            return volAlcohol;
        }

        //validar si es apto para manejar
        public string Validar(double volAlcohol)
        {
            string resultado;

            if (volAlcohol > 0.8)
            {
                resultado = $"La cantidad de alcohol que tiene es: {volAlcohol}. es superior a 0.8 y no es apta para manejar.";
                return resultado;
            }
            resultado = $"La cantidad de alcohol que tiene es: {volAlcohol}. es inferios a 0.8 y es apta para manejar. ";
            return resultado;
        }
    }
}
