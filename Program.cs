using System;

namespace Guerrero
{
    class Program
    {
        static void Main(string[] args)
        {
        	{
            Console.WriteLine("¿Quieres practicar?");
            String SiNo = Console.ReadLine();

            switch (SiNo)
            {
            	case "Si":
            	    Console.WriteLine("Tomas tu lira...");
            	    break;
            	case "No":
            	    Console.WriteLine("Buscas madera para la fogata");
            	    break;
            }

            Console.WriteLine("¿Cuantas horas quieres practicar?");
            String horas = Console.ReadLine();

            switch (horas)
            {
                case "1 hora":
                    Console.WriteLine("Cantas por una hora");
                    break;
                case "una hora":
                    Console.WriteLine("Cantas por una hora");
                    break;
                case "2 horas":
                    Console.WriteLine("Cantas por dos horas");
                    break;
                case "3 horas":
                    Console.WriteLine("Cantas por tres horas");
                    break;
                case "4 horas":
                    Console.WriteLine("Cantas por cuatro horas");
                    break;
                case "5 horas":
                    Console.WriteLine("Cantas por cinco horas");
                    break;
                case "6 horas":
                    Console.WriteLine("Cantas por 6 horas");
                    break;
                default:
                    Console.WriteLine(horas + " Excedes el maximo de horas");
                    break;
            }
            
            Console.ReadKey();
           }
        }
    }
}
