using System;

class Program 
{
  public static void Main (string[] args) 
  {
    /*5. Leer un número entero de tres dígitos y 
    determinar en qué posición está el mayor dígito. */

    Console.WriteLine("Ingrese un número entero de tres dígitos: ");
    int num;

    try
    {
      num = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
      Console.WriteLine("El valor ingresado no es un número entero válido");
      return; // El programa detectara si es un string
    }

    if ((num >= -999 && num <= -100) || (num >= 100 && num <= 999))
    {
      int d1 = (num / 100) % 10;
      int d2 = (num / 10) % 10;
      int d3 = (num % 10);

      if (d1 > d2 && d1 > d3)
      {
        Console.WriteLine("El mayor dígito se encuentra en la primera posición");
      }
      else if (d2 > d1 && d2 > d3)
      {
        Console.WriteLine("El mayor dígito se encuentra en la segunda posición");
      }
      else if (d3 > d1 && d3 > d2)
      {
        Console.WriteLine("El mayor dígito se encuentra en la tercera posición");
      }
      else if (d1 == d2 && d1 == d3)
      {
        Console.WriteLine("Todos los dígitos son iguales");
      }
      else 
      {
        Console.WriteLine("Hay dos dígitos iguales");
      }
    }
    else
    {
      Console.WriteLine("El número ingresado no tiene tres dígitos"); 
    }
  }
}
