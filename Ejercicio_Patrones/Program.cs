// See https://aka.ms/new-console-template for more information
using Ejercicio_Patrones.Ejercitos;
using Ejercicio_Patrones.Ejercitos.Artilleria;
using Ejercicio_Patrones.Ejercitos.Caballeria;
using Ejercicio_Patrones.Ejercitos.Infanteria;

//Artilleria
Ejercito_Artilleria_Composite artilleria = new Ejercito_Artilleria_Composite();

Cañon e1 = new Cañon();
TorpederoMovil e2 = new TorpederoMovil();
AntiAereo e3 = new AntiAereo();

artilleria.MeterTropa(e1);
artilleria.MeterTropa(e2);
artilleria.MeterTropa(e3);

//Caballeria
Ejercito_Caballeria_Composite caballeria = new Ejercito_Caballeria_Composite();

TanqueAtaqueSombras e4 = new TanqueAtaqueSombras();
MX_7899 e5 = new MX_7899();

caballeria.MeterTropa(e4);
caballeria.MeterTropa(e5);

//Infanteria
Ejercito_Infanteria_Composite infanteria = new Ejercito_Infanteria_Composite();

Ametrallador e6 = new Ametrallador();
Basica e7 = new Basica();

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
Console.WriteLine($"Tropas totales: {ejercito.ObtenerTropas()}");
Console.WriteLine($"Capacidad militar total: {ejercito.obtener_CM()}");
