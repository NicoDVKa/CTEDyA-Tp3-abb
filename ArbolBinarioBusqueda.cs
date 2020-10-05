using System;
using System.Globalization;

namespace ABB
{

	public class ArbolBinarioBusqueda{
		
		private IComparable dato;
		private ArbolBinarioBusqueda hijoIzquierdo;
		private ArbolBinarioBusqueda hijoDerecho;
		
		
		public ArbolBinarioBusqueda(IComparable dato){
			this.dato = dato;
		}
		
		
		public IComparable getDatoRaiz(){
			return this.dato;
		}
		
		public ArbolBinarioBusqueda getHijoIzquierdo(){
			return this.hijoIzquierdo;
		}
		
		public ArbolBinarioBusqueda getHijoDerecho(){
			return this.hijoDerecho;
		}
		
		public void agregarHijoIzquierdo(ArbolBinarioBusqueda hijo){
			this.hijoIzquierdo=hijo;
		}

		public void agregarHijoDerecho(ArbolBinarioBusqueda hijo){
			this.hijoDerecho=hijo;
		}
		
		public void eliminarHijoIzquierdo(){
			this.hijoIzquierdo=null;
		}
		
		public void eliminarHijoDerecho(){
			this.hijoDerecho=null;
		}
		

		//Metodo agregar
		public void agregar(IComparable elem) {
		}
		
		//Metodo incluye. Es el mismo que el de arbol binario.
		public bool incluye(IComparable elemento) {
			bool verificar = true;

			if (this.getDatoRaiz().ToString()==elemento.ToString())
			{
				return true;
			}

			if (this.getHijoIzquierdo() != null)
			{
				if (verificar == this.getHijoIzquierdo().incluye(elemento))
				{
					return verificar;
				}
			}

			if (this.getHijoDerecho() != null)
			{
				if (verificar == this.getHijoDerecho().incluye(elemento))
				{
					return verificar;
				}
			}

			return false;
		}

		//Recorridos. son los mismos que en los Arboles Binarios
		public void preorden() { 
			//Primero la raiz y luego los hijos izquierdos y derechos

			Console.Write(this.getDatoRaiz() + " ");
			
			if (this.getHijoIzquierdo() != null)
			{
				this.getHijoIzquierdo().preorden();
			}
			
			if (this.getHijoDerecho() != null)
			{
				this.getHijoDerecho().preorden();
			}
		}
		
		public void inorden() {
			//Primero el hijo izquierdo luego la raiz y por ultimo el hijo derecho
			if (this.getHijoIzquierdo() != null)
			{
				this.getHijoIzquierdo().inorden();
			}
			
			Console.Write(this.getDatoRaiz() + " ");
			
			if (this.getHijoDerecho() != null)
			{
				this.getHijoDerecho().inorden();
			}
		}
	
		
		public void postorden() {
			//Primero los hijos, izquierdo y derecho, y luego la raiz
			if (getHijoIzquierdo() != null)
			{
				this.getHijoIzquierdo().postorden();
			}
			
			if (this.getHijoDerecho() != null)
			{
				this.getHijoDerecho().postorden();
			}
			
			Console.Write(this.getDatoRaiz() + " ");
		}
		
		
	}
}