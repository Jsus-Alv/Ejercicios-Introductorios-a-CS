using System;

class Program 
{
  public static void Main (string[] args) 
  {
    /* 6. Leer un número entero de tres dígitos y 
    determinar si algún dígito es múltiplo de los otros.*/
      
    Console.WriteLine("Ingrese un número entero de tres dígitos: ");
    int n1;

    try
    {
      n1 = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
      Console.WriteLine("El número ingresado no es un número entero válido");
      return; // El programa detectara si es un string 
    }

    if (((n1 >= -999) && (n1 <= -100)) || ((n1 >= 100) && (n1 <= 999)))
    {
      int d1 = (n1 / 100) % 10;
      int d2 = (n1 / 10) % 10;
      int d3 = (n1 % 10);

      if (d1 % d2 == 0)
      {
        Console.WriteLine("El primer dígito es múltiplo del segundo");
      }
      if (d1 % d3 == 0)
      {
        Console.WriteLine("El primer dígito es múltiplo del tercero");
      }
      if (d2 % d1 == 0 && d2 % d3 == 0)
      {
        Console.WriteLine("El segundo dígito es múltiplo de los otros dos");
      }
      if (d2 % d1 == 0)
      {
        Console.WriteLine("El segundo dígito es múltiplo del primero");
      }
      if (d2 % d3 == 0)
      {
        Console.WriteLine("El segundo dígito es múltiplo del tercero");
      }
      if (d3 % d1 == 0)
      {
        Console.WriteLine("El tercer dígito es múltiplo del primero");
      }
      if (d3 % d2 == 0)
      {
        Console.WriteLine("El tercer dígito es múltiplo del segundo");
      }

      if ((d1 % d2 != 0) && (d1 % d3 != 0) && (d2 % d1 != 0) && (d2 % d3 != 0) && (d3 % d1 != 0) && (d3 % d2 != 0))
      {
        Console.WriteLine("Ningún dígito es múltiplo de los otros");
      }
    }
    else
    {
      Console.WriteLine("El número ingresado no es de tres dígitos");
    } 
  }
}
