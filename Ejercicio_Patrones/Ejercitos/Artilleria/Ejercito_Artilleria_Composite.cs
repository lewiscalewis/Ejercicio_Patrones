namespace Ejercicio_Patrones.Ejercitos.Artilleria
{
    public class Ejercito_Artilleria_Composite : EntidadMilitar, IEjercito_Composite
    {
        private List<IEntidadMilitar> _tropas = new();
        private double precio;
        private double velocidad;
        private double blindaje;
        private double potencia_fuego;
        private string tipo = "artilleria";

       
        public void MeterTropa(IEntidadMilitar tropa)
        {
            if (this.tipo.Equals(tropa.obtenerTipo()))
            {
                _tropas.Add(tropa);

                precio += tropa.obtenerPrecio();
                establecerPrecio(precio);

                velocidad += tropa.obtenerVelocidad();
                establecerVelocidad(velocidad);

                blindaje += tropa.obtenerBlindaje();
                establecerBlindaje(blindaje);

                potencia_fuego += tropa.obtenerPotenciaFuego();
                establecerPotenciaFuego(potencia_fuego);
            }
            else
            {
                Console.WriteLine("No se ha introducido una tropa del tipo artilleria");
            }
            
        }

        public override int ObtenerTropas()
        {
            return _tropas.Count;
        }
        public void QuitarTropa(IEntidadMilitar tropa)
        {
            _tropas.Remove(tropa);
            precio -= tropa.obtenerPrecio();
            establecerPrecio(precio);

            velocidad -= tropa.obtenerVelocidad();
            establecerVelocidad(velocidad);

            blindaje -= tropa.obtenerBlindaje();
            establecerBlindaje(blindaje);

            potencia_fuego -= tropa.obtenerPotenciaFuego();
            establecerPotenciaFuego(potencia_fuego);
        }

    }
}
