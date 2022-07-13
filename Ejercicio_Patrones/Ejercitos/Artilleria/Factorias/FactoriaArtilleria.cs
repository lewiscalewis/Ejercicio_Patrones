namespace Ejercicio_Patrones.Ejercitos.Artilleria.Factorias
{
    public class FactoriaArtilleria : IFactoriaArtilleria
    {
        public IArtilleria CrearAntiaereo()
        {
            return new AntiAereo();
        }

        public IArtilleria CrearCañon()
        {
            return new Cañon();
        }

        public IArtilleria CrearTorpederoMovil()
        {
            return new TorpederoMovil();
        }
    }
}
