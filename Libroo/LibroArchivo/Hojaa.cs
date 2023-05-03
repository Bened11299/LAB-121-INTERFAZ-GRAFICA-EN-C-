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
	/// Description of Hojaa.
	/// </summary>
	[Serializable]
	public class Hojaa
	{
		private int nroHoja;
		private string contenido;
		
		public Hojaa() {
			
		}
		public Hojaa(int n, string c)
		{
			nroHoja = n;
			contenido = c;
		}
		
		public int getNroHoja() {
			return nroHoja;
		}
		
		public string getContenido() {
			return contenido;
		}
		
		public void setNroHoja(int i) {
			nroHoja = i;
		}
		
		public void setContenido(string c) {
			contenido = c;
		}
		
		public void mostrar() {
			Console.WriteLine("nro hoja :" +nroHoja);
			Console.WriteLine("contenido: " +contenido);
		}
		
		public void leer(){
			
			nroHoja = int.Parse(Console.ReadLine());
			contenido  = Console.ReadLine();
		}
		
		public void escribir(BinaryWriter escritor){
			escritor.Write(this.nroHoja);
			escritor.Write(this.contenido);
		}
		public void lectura( BinaryReader lector) {
			this.nroHoja = lector.ReadInt32();
			this.contenido = lector.ReadString();
		}

	}
}
