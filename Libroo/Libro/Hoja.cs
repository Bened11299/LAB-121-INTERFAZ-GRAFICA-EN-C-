/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 25/4/2023
 * Time: 20:30
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
	/// Description of Hoja.
	/// </summary>
	[Serializable]
	public class Hoja
	{
		private int nroHoja;
		private string contenido;
		
		public Hoja() {
			
		}
		public Hoja(int n, string c)
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
