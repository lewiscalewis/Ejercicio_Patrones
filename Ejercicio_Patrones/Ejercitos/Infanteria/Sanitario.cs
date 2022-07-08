using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos.Infanteria
{
    public class Sanitario: EntidadMilitar, IInfanteria
    {
        public double precio { get => 500; set => base.establecerPrecio(value); }
        public string nombre { get => "Unidad sanitaria de combate terrestre"; set => base.establecerNombre(value); }
        public double velocidad { get => 7; set => base.establecerVelocidad(value); }
        public double blindaje { get => 5; set => base.establecerBlindaje(value); }
        public double potencia_fuego { get => 0; set => base.establecerPotenciaFuego(value); }

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
