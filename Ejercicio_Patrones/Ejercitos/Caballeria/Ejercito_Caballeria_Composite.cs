namespace Ejercicio_Patrones.Ejercitos.Caballeria
{
    public class Ejercito_Caballeria_Composite : EntidadMilitar, IEjercito_Composite
    {
        private List<IEntidadMilitar>? _tropas = new ();
        private double precio;
        private double velocidad;
        private double blindaje;
        private double potencia_fuego;
        private string tipo = "caballeria";


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
                Console.WriteLine("No se ha introducido una tropa del tipo caballeria");
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
