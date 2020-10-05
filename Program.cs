using System;

namespace ABB
{
    class Program
    {
        static void Main(string[] args)
        {
			

			//Compruebo el metodo agregar()
			ArbolBinarioBusqueda arbolBinarioBusqueda = new ArbolBinarioBusqueda(null);
			arbolBinarioBusqueda.agregar(3);
			arbolBinarioBusqueda.agregar(1);
			arbolBinarioBusqueda.agregar(4);
			arbolBinarioBusqueda.agregar(6);
			arbolBinarioBusqueda.agregar(8);
			arbolBinarioBusqueda.agregar(2);
			arbolBinarioBusqueda.agregar(5);
			arbolBinarioBusqueda.agregar(7); 

			//Compruebo el funcionamiento de los recorridos.
			Console.Write("Preorden: ");
			arbolBinarioBusqueda.preorden();//Funciona
			Console.WriteLine();
			Console.Write("Inorden: ");
			arbolBinarioBusqueda.inorden();//Funciona
			Console.WriteLine();
			Console.Write("Postorden: ");
			arbolBinarioBusqueda.postorden();//Funciona
			Console.WriteLine();

			//Compruebo el funcionamiento de incluye().
			int dato = 0;
			Console.WriteLine("El dato {0} esta en el ab? {1}", dato, arbolBinarioBusqueda.incluye(dato));


			Console.WriteLine("Presione un tecla para salir");
			Console.ReadKey(true);
		}
    }
}
