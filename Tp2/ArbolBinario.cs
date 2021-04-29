using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp2
{
	public class ArbolBinario<T>
	{
		
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		public void inorden() {
		}
		
		public void preOrden() {
			Console.Write(this.getDatoRaiz()+"|");
			
			if(this.getHijoIzquierdo()!=null){
				this.getHijoIzquierdo().preOrden();
			}
			
			if(this.getHijoDerecho()!=null){
				this.getHijoDerecho().preOrden();
			}
		}
		
		public void postorden() {
		}
		
		public void recorridoPorNiveles() {
		}
	
		public int contarHojas(int hojas) {
			
			
			if(this.getHijoIzquierdo()==null && this.getHijoDerecho()==null){
				hojas++;
			}
			
			if(this.getHijoIzquierdo()!=null){
				hojas=this.getHijoIzquierdo().contarHojas(hojas);
			}
			
			if(this.getHijoDerecho()!=null){
				hojas=this.getHijoDerecho().contarHojas(hojas);
			}
			
			return hojas;
			
		}
		
		public void recorridoEntreNiveles(int n,int m) {
		}
	}
}
