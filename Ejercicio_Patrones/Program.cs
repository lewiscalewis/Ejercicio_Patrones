// See https://aka.ms/new-console-template for more information
using Ejercicio_Patrones.Ejercitos;
using Ejercicio_Patrones.Ejercitos.Artilleria;
using Ejercicio_Patrones.Ejercitos.Caballeria;
using Ejercicio_Patrones.Ejercitos.Infanteria;
using Ejercicio_Patrones.Ejercitos.Artilleria.Factorias;
using Ejercicio_Patrones.Ejercitos.Caballeria.Factorias;
using Ejercicio_Patrones.Ejercitos.Infanteria.Factorias;

//Artilleria
Ejercito_Artilleria_Composite artilleria = new Ejercito_Artilleria_Composite();
FactoriaArtilleria factoriaArtilleria = new FactoriaArtilleria();

ITropa e1 = (ITropa)factoriaArtilleria.CrearTorpederoMovil();
ITropa e2 = (ITropa)factoriaArtilleria.CrearAntiaereo();
ITropa e3 = (ITropa)factoriaArtilleria.CrearCañon();

artilleria.MeterTropa(e1);
artilleria.MeterTropa(e2);
artilleria.MeterTropa(e3);

//Caballeria
Ejercito_Caballeria_Composite caballeria = new Ejercito_Caballeria_Composite();
FactoriaCaballeria factoriaCaballeria = new FactoriaCaballeria();

ITropa e4 = (ITropa)factoriaCaballeria.CrearTanqueSombras();
ITropa e5 = (ITropa)factoriaCaballeria.CrearMX_7899();

caballeria.MeterTropa(e4);
caballeria.MeterTropa(e5);

//Infanteria
Ejercito_Infanteria_Composite infanteria = new Ejercito_Infanteria_Composite();
FactoriaInfanteria factoriaInfanteria = new FactoriaInfanteria();

ITropa e6 = (ITropa)factoriaInfanteria.CrearAmetrallador();
ITropa e7 = (ITropa)factoriaInfanteria.CrearSanitario();

infanteria.MeterTropa(e6);
infanteria.MeterTropa(e7);

//Ejercito general
Ejercito_Composite ejercito = new Ejercito_Composite();
ejercito.MeterTropa(artilleria);
ejercito.MeterTropa(caballeria);
ejercito.MeterTropa(infanteria);



//Logs
Console.WriteLine($"Coste total: {ejercito.obtenerPrecio()}$");
Console.WriteLine($"Velocidad total: {ejercito.obtenerVelocidad()}");
Console.WriteLine($"Potencia de Fuego total: {ejercito.obtenerPotenciaFuego()}");
Console.WriteLine($"Blindaje total: {ejercito.obtenerBlindaje()}");
Console.WriteLine($"Capacidad militar total: {ejercito.obtener_CM()}");
Console.WriteLine($"Tropas totales: {ejercito.ObtenerTropas()}");
