using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoAlcohol.Domain.Interface
{
    public interface Data
    {
        void AlcoholIngerido(string bebida, int cantidad);
        void CantidadAlcoholSangre(int peso);
        string Validar();
    }
}
