using System;

class Program 
{
    public static void Main (string[] args) 
    {
      /*1. Leer un número entero de dos dígitos y 
      determinar a cuánto es igual la suma de sus dígitos. */

      Console.WriteLine("Ingrese un número entero de dos dígitos: ");
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

      if (num >= 10 && num <= 99)
      {
        int sum = (num / 10) + (num % 10);

        Console.WriteLine("La suma de los dígitos es " + sum);
      }
      else
      {
        Console.WriteLine("El número ingresado no es de dos dígitos");
      }
    }
}
