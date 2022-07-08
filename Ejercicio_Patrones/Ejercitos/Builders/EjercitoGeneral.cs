using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Patrones.Ejercitos.Artilleria;
using Ejercicio_Patrones.Ejercitos.Caballeria;
using Ejercicio_Patrones.Ejercitos.Infanteria;
using Ejercicio_Patrones.Ejercitos.Artilleria.Factorias;
using Ejercicio_Patrones.Ejercitos.Caballeria.Factorias;
using Ejercicio_Patrones.Ejercitos.Infanteria.Factorias;

namespace Ejercicio_Patrones.Ejercitos.Builders
{
    public class EjercitoGeneral
    {
        IBuilder builder;

        public EjercitoGeneral()
        {
            this.builder = new BuilderEjercito();
        }

        public ITropa CrearEjercitoCompleto()
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
    }
}
