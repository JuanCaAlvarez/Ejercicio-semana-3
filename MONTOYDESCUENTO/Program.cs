// See https://aka.ms/new-console-template for more information

//PASO 1: COLOCACION DE DATOS
Console.WriteLine("Ingrese la cantidad de productos: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el costo de cada producto: ");
decimal n2 = int.Parse(Console.ReadLine());

//PASO 2: PROCESO
decimal producto = n1 * n2;

//PASO 3: EVALUAR EL DESCUENTO

decimal Descuento = 0.0m;


if (n1 > 20)
{
    Descuento = 0.10m;
}
else if (n1 >= 10)
{
    Descuento = 0.05m;
}

//PASO 4 : CALCULO DEL DESCUENTO
decimal Montocondescuento = producto * Descuento;

//PASO 5: CALCULO MONTO TOTAL
decimal Montototal = producto - Montocondescuento;

//PASO 6: RESULTADO
Console.WriteLine($"Monto total: {Montototal}");
