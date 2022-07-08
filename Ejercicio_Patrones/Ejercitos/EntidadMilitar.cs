using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Patrones.Ejercitos
{
    public class EntidadMilitar : IEntidadMilitar
    {
        //Esto debería haberse hecho con {get; set} pero la costumbre con Java...
        private string nombre;
        private double velocidad;
        private double blindaje;
        private double potencia_fuego;
        private double precio;
        private string tipo;
  
        public EntidadMilitar()
        {
          
        }

        public void establecerTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string obtenerTipo()
        {
            return this.tipo;
        }
        public void establecerBlindaje(double blindaje)
        {
            this.blindaje = blindaje;
        }

        public void establecerNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void establecerPotenciaFuego(double potencia_fuego)
        {
            this.potencia_fuego = potencia_fuego;
        }

        public void establecerPrecio(double precio)
        {
            this.precio = precio;
        }

        public void establecerVelocidad(double velocidad)
        {
            this.velocidad = velocidad;
        }

        public double obtenerBlindaje()
        {
            return this.blindaje;
        }

        public string obtenerNombre()
        {
            return this.nombre;
        }

        public double obtenerPotenciaFuego()
        {
            return this.potencia_fuego;
        }

        public double obtenerPrecio()
        {
            return this.precio;
        }

        public double obtenerVelocidad()
        {
            return this.velocidad;
        }
        public double obtener_CM()
        {
            double total = 0;

            total = (potencia_fuego * (velocidad / 2)) / (100 - blindaje);

            return total;
        }

        public virtual int ObtenerTropas()
        {
            return 1;
        }
    }
}
