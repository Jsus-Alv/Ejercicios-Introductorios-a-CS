using System;

class Program 
{
  
  public static void Main (string[] args) 
  {
    /* 7. Leer tres números enteros y 
    determinar cuál es el mayor. Usar solamente dos variables. */

    Console.WriteLine("Ingrese tres números enteros: ");
    int n1; 
    int n3;
    int n2;

    try
    {
      n1 = Convert.ToInt32(Console.ReadLine());
      n2 = Convert.ToInt32(Console.ReadLine());
      n3 = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
      Console.WriteLine("Uno de los numeros ingresados no es un número entero válido");
      return; // El programa detectara si alguno es un string 
    }

    int numMayor = n1;
    int numTemp;
    
    numTemp = (n2 > numMayor) ? n2 : numMayor;
    numMayor = (n3 > numTemp) ? n3 : numTemp;

    Console.WriteLine("El número mayor es: " + numMayor);
    
  }
}