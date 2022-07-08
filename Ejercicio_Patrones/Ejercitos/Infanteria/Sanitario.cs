using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Infanteria
{
    public class Sanitario: Tropa, ITropa, IInfanteria
    {
        private double precio = 500;
        private string nombre = "Sanitario";
        private double velocidad = 7;
        private double blindaje = 5;
        private double potencia_fuego = 0;

        public Sanitario() : base()
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
