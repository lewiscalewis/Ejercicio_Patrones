namespace Ejercicio_Patrones.Ejercitos
{
    public class EntidadMilitar : IEntidadMilitar
    {
        //Esto debería haberse hecho con {get; set} pero la costumbre con Java...
        private string? _nombre;
        private double _velocidad;
        private double _blindaje;
        private double _potencia_fuego;
        private double _precio;
        private string? _tipo;

        public void establecerTipo(string tipo)
        {
            this._tipo = tipo;
        }

        public string obtenerTipo()
        {
            return this._tipo!;
        }
        public void establecerBlindaje(double blindaje)
        {
            this._blindaje = blindaje;
        }

        public void establecerNombre(string nombre)
        {
            this._nombre = nombre;
        }

        public void establecerPotenciaFuego(double potencia_fuego)
        {
            this._potencia_fuego = potencia_fuego;
        }

        public void establecerPrecio(double precio)
        {
            this._precio = precio;
        }

        public void establecerVelocidad(double velocidad)
        {
            this._velocidad = velocidad;
        }

        public double obtenerBlindaje()
        {
            return this._blindaje;
        }

        public string? obtenerNombre()
        {
            return this._nombre;
        }

        public double obtenerPotenciaFuego()
        {
            return this._potencia_fuego;
        }

        public double obtenerPrecio()
        {
            return this._precio;
        }

        public double obtenerVelocidad()
        {
            return this._velocidad;
        }
        public double obtener_CM()
        {
            var total = ((_potencia_fuego * _velocidad) / 2) / (100 - _blindaje);

            return total;
        }

        public virtual int ObtenerTropas()
        {
            return 1;
        }
    }
}
