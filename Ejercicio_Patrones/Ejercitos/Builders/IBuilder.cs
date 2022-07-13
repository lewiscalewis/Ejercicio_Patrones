namespace Ejercicio_Patrones.Ejercitos.Builders
{
    public interface IBuilder
    {
        IEntidadMilitar CrearEjercitoArtilleria();
        IEntidadMilitar CrearEjercitoInfanteria();
        IEntidadMilitar CrearEjercitoCaballeria();
    }
}
