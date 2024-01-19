using System;

class Program
{
  public static void Main (string[] args)
  {
    /*2. Leer un número entero de dos dígitos y
    determinar si es primo y además si es negativo. */

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
      if (EsPrimo(num))
      {
        Console.WriteLine("El número ingresado es primo.");
      }
      else
      {
        Console.WriteLine("El número ingresado no es primo.");
      }

    }
    else
    {
      Console.WriteLine("El número ingresado no tiene dos dígitos.");
    }

    if (num < 0)
    {
      Console.WriteLine("El número ingresado es negativo.");
    }
    else
    {
      Console.WriteLine("El número ingresado no es negativo.");
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

