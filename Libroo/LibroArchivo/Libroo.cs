/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 29/4/2023
 * Time: 15:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic; 
using System.Text; 
using System.IO;


namespace LibroArchivo
{
	/// <summary>
	/// Description of Libroo.
	/// </summary>
	[Serializable]
	public class Libroo
	{
		private string nombre;
		private int nh;
		private Hojaa []paginas = new Hojaa[50];
		
		public Libroo() {
			for(int i = 0; i < 50 ; i++) {
				paginas[i] = new Hojaa();
			}
		}
		public Libroo(string n, int nro)
		{
			nombre = n;
			nh = nro;
			for(int i = 0; i < 50 ; i++) {
				paginas[i] = new Hojaa();
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
		
		public Hojaa getPaginasI(int i) {
			return paginas[i];
		}
		
		public void mostrar() {
			Console.WriteLine("nombre: " + nombre);
			Console.WriteLine("nro de hojas: "+ nh);
			Console.WriteLine("HOJAS DEL LIBRO");
			for(int i = 0; i < nh; i++) {
				paginas[i].mostrar();
			}
		}
		
		public void leer() {
			nombre  = Console.ReadLine();
			nh = int.Parse(Console.ReadLine());
			for(int i = 0; i < nh; i++){
				paginas[i].leer();
			}
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
