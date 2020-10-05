using System;

namespace ABB
{
    class Program
    {
        static void Main(string[] args)
        {
			ArbolBinarioBusqueda arbolBinarioBusqueda = new ArbolBinarioBusqueda(3);

			ArbolBinarioBusqueda hijoIzquierdo = new ArbolBinarioBusqueda(1);
			ArbolBinarioBusqueda hijoDerecho = new ArbolBinarioBusqueda(8);

			arbolBinarioBusqueda.agregarHijoIzquierdo(hijoIzquierdo);
			arbolBinarioBusqueda.agregarHijoDerecho(hijoDerecho);

			hijoIzquierdo.agregarHijoIzquierdo(new ArbolBinarioBusqueda(4));
			hijoIzquierdo.agregarHijoDerecho(new ArbolBinarioBusqueda(6));

			hijoDerecho.agregarHijoIzquierdo(new ArbolBinarioBusqueda(2));
			hijoDerecho.agregarHijoDerecho(new ArbolBinarioBusqueda(5));

			//Aun no cumple la propiedad de orden para ser un ABB
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
			int dato = 5;
			Console.WriteLine("El dato {0} esta en el ab? {1}", dato, arbolBinarioBusqueda.incluye(dato));

			Console.WriteLine("Presione un tecla para salir");
			Console.ReadKey(true);
		}
    }
}
