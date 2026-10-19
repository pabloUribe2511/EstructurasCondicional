﻿Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine(CheckNumber(5));   
Console.WriteLine(CheckNumber(-3));  
Console.WriteLine(CheckNumber(0));   

static string CheckNumber(int number)
{
    if (number > 0)
    {
        return "El número es positivo";
    }
    else if (number < 0)
    {
        return "El número es negativo";
    }
    else
    {
        return "El número es cero";
    }
}
