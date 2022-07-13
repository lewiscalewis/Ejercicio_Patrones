using Ejercicio_Patrones.Ejercitos.Artilleria;
using Ejercicio_Patrones.Ejercitos.Caballeria;
using Ejercicio_Patrones.Ejercitos.Infanteria;

namespace Ejercicio_Patrones.Ejercitos.Builders
{
    public class BuilderEjercitosCompuestos
    {
        readonly IBuilder builder;

        public BuilderEjercitosCompuestos()
        {
            this.builder = new BuilderEjercito();
        }

        public IEntidadMilitar CrearEjercitoCompleto()
        {
            Ejercito_Artilleria_Composite artilleria = (Ejercito_Artilleria_Composite)builder.CrearEjercitoArtilleria();
            Ejercito_Caballeria_Composite caballeria = (Ejercito_Caballeria_Composite)builder.CrearEjercitoCaballeria();
            Ejercito_Infanteria_Composite infanteria = (Ejercito_Infanteria_Composite)builder.CrearEjercitoInfanteria();

            Ejercito_Composite ejercito =  new Ejercito_Composite();
            ejercito.MeterTropa(artilleria);
            ejercito.MeterTropa(caballeria);
            ejercito.MeterTropa(infanteria);

            return ejercito;
        }

        public IEntidadMilitar CrearCaballeriaInfanteria()
        {
            Ejercito_Caballeria_Composite caballeria = (Ejercito_Caballeria_Composite)builder.CrearEjercitoCaballeria();
            Ejercito_Infanteria_Composite infanteria = (Ejercito_Infanteria_Composite)builder.CrearEjercitoInfanteria();

            Ejercito_Composite ejercito = new Ejercito_Composite();
            ejercito.MeterTropa(caballeria);
            ejercito.MeterTropa(infanteria);

            return ejercito;
        }

        public IEntidadMilitar CrearCaballeriaArtilleria()
        {
            Ejercito_Artilleria_Composite artilleria = (Ejercito_Artilleria_Composite)builder.CrearEjercitoArtilleria();
            Ejercito_Caballeria_Composite caballeria = (Ejercito_Caballeria_Composite)builder.CrearEjercitoCaballeria();

            Ejercito_Composite ejercito = new Ejercito_Composite();
            ejercito.MeterTropa(artilleria);
            ejercito.MeterTropa(caballeria);

            return ejercito;
        }

        public IEntidadMilitar CrearArtilleriaInfanteria()
        {
            Ejercito_Artilleria_Composite artilleria = (Ejercito_Artilleria_Composite)builder.CrearEjercitoArtilleria();
            Ejercito_Infanteria_Composite infanteria = (Ejercito_Infanteria_Composite)builder.CrearEjercitoInfanteria();

            Ejercito_Composite ejercito = new Ejercito_Composite();
            ejercito.MeterTropa(artilleria);
            ejercito.MeterTropa(infanteria);

            return ejercito;
        }
    }
}
