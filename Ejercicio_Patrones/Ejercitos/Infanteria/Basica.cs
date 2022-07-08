using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Infanteria
{
    public class Basica: Tropa, IInfanteria
    {
        private double precio = 250;
        private string nombre = "Infantería básica";
        private double velocidad = 6;
        private double blindaje = 0;
        private double potencia_fuego = 7;

        public Basica() : base()
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
