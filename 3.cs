using System;

class Program 
{
  public static void Main (string[] args) 
  {
    /*3. Leer un número entero de dos dígitos y 
    determinar si sus dos dígitos son primos. */

    Console.WriteLine("Ingrese un número entero de dos dígitos: ");
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

    if ((num >= -99 && num <= -10) || (num >= 10 && num <= 99))
    {
      int d1 = (num / 10);
      int d2 = (num % 10);

      if (EsPrimo(d1) && EsPrimo(d2))
      {
        Console.WriteLine("Los dos dígitos son primos");
      }
      else if (EsPrimo(d1) || EsPrimo(d2))
      {
        Console.WriteLine("Al menos uno de los dos dígitos es primos");
      }
      else 
      {
        Console.WriteLine("Ninguno de los dos dígitos es primo");
      }
    }
    else
    {
      Console.WriteLine("El número ingresado no tiene dos dígitos.");
    }
  }

  // Para determinar si el numero es primo
  static bool EsPrimo(int numprimo)
  {
    if (numprimo < 2)
    {
      return false;
    }
    for (int i = 2; i <= Math.Sqrt(numprimo); i++)
    {
      if (numprimo % i == 0)
      {
        return false;
      }
    }
    return true;
  }
}
