using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario ingresar el precio de la casa y sus ingresos
        Console.WriteLine("Ingrese el precio de la casa:");
        decimal precioCasa = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Ingrese los ingresos del comprador:");
        decimal ingresos = Convert.ToDecimal(Console.ReadLine());

        // Calcular el enganche y la cuota mensual según las condiciones
        decimal enganche;
        decimal cuotaMensual;
        decimal costoRestante;

        if (ingresos < 600000)
        {
            enganche = precioCasa * 0.15m;
            costoRestante = precioCasa - enganche;
            cuotaMensual = costoRestante / (10 * 12); // 10 años en meses
        }
        else
        {
            enganche = precioCasa * 0.30m;
            costoRestante = precioCasa - enganche;
            cuotaMensual = costoRestante / (7 * 12); // 7 años en meses
        }

        // Aplicar descuento adicional si el comprador es cabeza de familia
        Console.WriteLine("¿Es el comprador cabeza de familia? (S/N)");
        string respuesta = Console.ReadLine();

        if (respuesta.ToUpper() == "S")
        {
            cuotaMensual *= 0.97m; // Aplicar descuento del 3%
        }

        // Mostrar los resultados al usuario
        Console.WriteLine($"El enganche a pagar es: {enganche:C}");
        Console.WriteLine($"La cuota mensual a pagar es: {cuotaMensual:C}");
        Console.ReadKey();
    }
}
