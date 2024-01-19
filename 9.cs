using System;

class Program 
{
  public static void Main (string[] args) 
  {
    /* 9. Leer un número entero de cuatro dígitos y 
    determinar si el segundo dígito es igual al penúltimo. */

    Console.WriteLine("Ingrese un numero de cuatro digitos");
    int num;

    try
    {
      num = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
      Console.WriteLine("El número ingresado no es un número entero válido");
      return; // El programa detectara si es un string 
    }

    if ((num >= 1000) && (num <= 9999))
    {
      int d2 = (num / 100) % 10;
      int d3 = (num / 10) % 10;

      if (d2 == d3)
      {
        Console.WriteLine("El segundo digito es igual al penultimo");
      }
      else
      {
        Console.WriteLine("El segundo digito no es igual al penultimo");
      }
    }
    else 
    {
      Console.WriteLine("El numero ingresado no es de cuatro digitos");
    }
  }
}