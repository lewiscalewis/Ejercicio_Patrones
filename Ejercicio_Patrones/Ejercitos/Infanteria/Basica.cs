namespace Ejercicio_Patrones.Ejercitos.Infanteria
{
    public class Basica: EntidadMilitar, IInfanteria
    {
        public double precio { get => 250; set => establecerPrecio(value); }
        public string nombre { get => "Unidad básica de combate terrestre"; set => establecerNombre(value); }
        public double velocidad { get => 6; set => establecerVelocidad(value); }
        public double blindaje { get => 0; set => establecerBlindaje(value); }
        public double potencia_fuego { get => 7; set => establecerPotenciaFuego(value); }

        public Basica()
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
