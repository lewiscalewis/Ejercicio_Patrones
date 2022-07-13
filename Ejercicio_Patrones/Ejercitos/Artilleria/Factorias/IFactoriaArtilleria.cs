namespace Ejercicio_Patrones.Ejercitos.Artilleria.Factorias
{
    public interface IFactoriaArtilleria
    {
        IArtilleria CrearAntiaereo();
        IArtilleria CrearCañon();
        IArtilleria CrearTorpederoMovil();
    }
}
