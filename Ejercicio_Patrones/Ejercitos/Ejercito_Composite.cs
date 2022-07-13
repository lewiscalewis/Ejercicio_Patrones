namespace Ejercicio_Patrones.Ejercitos
{
    public class Ejercito_Composite : EntidadMilitar, IEjercito_Composite
    {
        private List<IEntidadMilitar> _tropas = new();
        private double precio;
        private double velocidad;
        private double blindaje;
        private double potencia_fuego;

        public void MeterTropa(IEntidadMilitar tropa)
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

        public override int ObtenerTropas()
        {
            int total = 0;

            foreach(IEntidadMilitar item in _tropas)
            {
                try
                {
                    total += item.ObtenerTropas();
                }
                catch (Exception)
                {
                    total++;
                }
                
            }
            return total;
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
