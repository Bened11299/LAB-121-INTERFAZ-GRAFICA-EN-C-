/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 25/4/2023
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic; 
using System.Text; 
using System.IO;

namespace Libro
{
	/// <summary>
	/// Description of Libro.
	/// </summary>
	[Serializable]
	public class Libro
	{
		private string nombre;
		private int nh;
		private Hoja []paginas = new Hoja[50];
		
		public Libro() {
			for(int i = 0; i < 50 ; i++) {
				paginas[i] = new Hoja();
			}
		}
		
		public Libro(string n, int nro)
		{
			nombre = n;
			nh = nro;
			for(int i = 0; i < nh ; i++) {
				paginas[i] = new Hoja();
			}
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public int getNh() {
			return nh;
		}
		
		public bool setHojaI(int i, string contenido) {
			if(i < nh ) {
				paginas[i].setNroHoja(i);
				paginas[i].setContenido(contenido);
				return true;
			} else {
				return false;
			}
		}
		
		public Hoja getPaginasI(int i) {
			return paginas[i];
		}
		
		public void escribir(BinaryWriter escritor){
			escritor.Write(this.nombre);
			escritor.Write(this.nh);
			for(int i = 0; i < nh ; i++) {
				paginas[i].escribir(escritor);
			}
		}
		
		public void lectura( BinaryReader lector) {
			this.nombre = lector.ReadString();
			this.nh = lector.ReadInt32();
			for(int i = 0; i < nh ; i++) {
				paginas[i].lectura(lector);
			}
		}
	
	}
}
