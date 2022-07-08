using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Infanteria
{
    public class Ametrallador: Tropa, ITropa, IInfanteria
    {
        private double precio = 400;
        private string nombre = "Ametrallador";
        private double velocidad = 4;
        private double blindaje = 0;
        private double potencia_fuego = 10;

        public Ametrallador() : base()
        {
            base.establecerBlindaje(this.blindaje);
            base.establecerNombre(this.nombre);
            base.establecerVelocidad(this.velocidad);
            base.establecerPotenciaFuego(this.potencia_fuego);
            base.establecerPrecio(this.precio);
            base.establecerTipo("infanteria");
        }
    }
}
