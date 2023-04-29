/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 25/4/2023
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Libro
{
	/// <summary>
	/// Description of Hoja.
	/// </summary>
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
	}
}
