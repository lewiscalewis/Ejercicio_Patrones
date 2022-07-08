using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Infanteria
{
    public class Basica: EntidadMilitar, IInfanteria
    {
        public double precio { get; set; } = 250;
        public string nombre { get; set; } = "Infantería básica";
        public double velocidad { get; set; } = 6;
        public double blindaje { get; set; } = 0;
        public double potencia_fuego { get; set; } = 7;

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
