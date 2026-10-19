﻿using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
var cultura = new CultureInfo("es-CO"); // para mostrar 280.000 con punto


Console.WriteLine("¿Cómo te llamas?");
string nombre = Console.ReadLine() ?? ""; // Guarda lo que el usuario escriba
Console.WriteLine("Hola, " + nombre);
Console.WriteLine();


string especieMascota = "perro";   // "perro", "gato", "conejo", "reptil"
int edadMascota = 7;               // edad en años
double peso = 28.5;                // peso en kilogramos
bool tieneVacunasAlDia = false;
bool esSocio = true;
string motivoConsulta = "cirugia"; // "vacuna", "revision", "cirugia", "urgencia"

Console.WriteLine("=== Reporte de Atención Veterinaria ===");


string etapaVida = edadMascota switch
{
    < 1 => "Cachorro",
    >= 1 and <= 3 => "Joven",
    >= 4 and <= 8 => "Adulto",
    _ => "Senior"
};

Console.WriteLine($"Mascota: {especieMascota} | Edad: {edadMascota} años | Etapa: {etapaVida}");


string alertaVacuna;

if ((especieMascota == "perro" || especieMascota == "gato") && !tieneVacunasAlDia)
{
    alertaVacuna = "ALERTA: vacunación urgente requerida";
}
else if ((especieMascota == "perro" || especieMascota == "gato") && tieneVacunasAlDia)
{
    alertaVacuna = "Vacunación al día";
}
else
{
    alertaVacuna = "Esquema de vacunación no aplica";
}

Console.WriteLine($"Estado de vacunación: {alertaVacuna}");


decimal costoBase;

switch (motivoConsulta)
{
    case "vacuna":
        costoBase = 35000;
        break;
    case "revision":
        costoBase = 50000;
        break;
    case "cirugia":
        costoBase = 280000;
        break;
    case "urgencia":
        costoBase = 150000;
        break;
    default:
        costoBase = 0;
        break;
}

Console.WriteLine($"Motivo: {motivoConsulta} | Costo base: ${costoBase.ToString("N0", cultura)}");


double porcentajeDescuento = esSocio ? (peso > 25 ? 15.0 : 10.0) : 0.0;

decimal descuento = costoBase * (decimal)(porcentajeDescuento / 100);
decimal costoFinal = costoBase - descuento;

Console.WriteLine($"Descuento: {porcentajeDescuento}% | Costo final: ${costoFinal.ToString("N0", cultura)}");


string recomendacion;

if (motivoConsulta == "cirugia")
{
    if (etapaVida == "Senior")
    {
        recomendacion = "Reposo absoluto por 10 días, control post-operatorio obligatorio";
    }
    else
    {
        recomendacion = "Reposo por 5 días, evitar ejercicio intenso";
    }
}
else if (motivoConsulta == "urgencia")
{
    if (!tieneVacunasAlDia)
    {
        recomendacion = "Atender urgencia y programar vacunación inmediata";
    }
    else
    {
        recomendacion = "Seguimiento en 48 horas";
    }
}
else
{
    recomendacion = "Seguimiento en próxima consulta de rutina";
}

Console.WriteLine($"Recomendación: {recomendacion}");