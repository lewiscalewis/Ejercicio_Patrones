// See https://aka.ms/new-console-template for more information
using Ejercicio_Patrones.Ejercitos;
using Ejercicio_Patrones.Ejercitos.Artilleria;

Tropa e1 = new Tropa("xd", 20, 10, 10, 1000);
Tropa e2 = new Tropa("xd", 20, 10, 10, 1200);
AntiAereo e3 = new AntiAereo();

Ejercito_Composite ejercito = new Ejercito_Composite();
Ejercito_Artilleria_Composite artilleria = new Ejercito_Artilleria_Composite();
ejercito.MeterTropa(artilleria);

ejercito.MeterTropa(e1);
ejercito.MeterTropa(e2);
artilleria.MeterTropa(e3);

Console.WriteLine($"Coste total: {ejercito.obtenerPrecio()}$");
Console.WriteLine($"Blindaje total: {ejercito.obtenerBlindaje()}");
Console.WriteLine($"Capacidad militar total: {ejercito.obtener_CM()}");
