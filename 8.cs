using System;

class Program 
{
  
  public static void Main (string[] args) 
  {
    /* 8. Leer un número entero de cinco dígitos y 
    determinar si es un número Capicúa. */

    Console.WriteLine("Ingrese un número entero de cinco dígitos: ");
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

    if (num >= 10000 && num <= 99999)
    {
      
      int d1 = (num / 10000)  % 10;
      int d2 = (num / 1000) % 10;
      int d3 = (num / 100) % 10;
      int d4 = (num / 10) % 10;
      int d5 = (num % 10);

      if (d1 == d5 && d2 == d4)
      {
        Console.WriteLine("El número ingresado es un número capicúa");
      }
      else 
      {
        Console.WriteLine("El número ingresado no es un número capicúa");
      }
      
    }
    else 
    {
      Console.WriteLine("El número ingresado no tiene cinco dígitos");
    }

  }
  
}
