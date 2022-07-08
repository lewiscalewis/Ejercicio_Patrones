using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Infanteria
{
    public class Ametrallador: EntidadMilitar, IInfanteria
    {
        public double precio { get; set; } = 400;
        public string nombre { get; set; } = "Ametrallador";
        public double velocidad { get; set; } = 4;
        public double blindaje { get; set; } = 0;
        public double potencia_fuego { get; set; } = 10;

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
