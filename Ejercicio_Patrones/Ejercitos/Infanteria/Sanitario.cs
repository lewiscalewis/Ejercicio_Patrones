namespace Ejercicio_Patrones.Ejercitos.Infanteria
{
    public class Sanitario: EntidadMilitar, IInfanteria
    {
        public double precio { get => 500; set => establecerPrecio(value); }
        public string nombre { get => "Unidad sanitaria de combate terrestre"; set => establecerNombre(value); }
        public double velocidad { get => 7; set => establecerVelocidad(value); }
        public double blindaje { get => 5; set => establecerBlindaje(value); }
        public double potencia_fuego { get => 0; set => establecerPotenciaFuego(value); }

        public Sanitario()
        {
            establecerBlindaje(this.blindaje);
            establecerNombre(this.nombre);
            establecerVelocidad(this.velocidad);
            establecerPotenciaFuego(this.potencia_fuego);
            establecerPrecio(this.precio);
            establecerTipo("infanteria");
        }
    }
}
