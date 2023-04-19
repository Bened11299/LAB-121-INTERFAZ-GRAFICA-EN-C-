/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 18/4/2023
 * Time: 20:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VehiculoHerencia
{
	/// <summary>
	/// Description of Vehiculo.
	/// </summary>
	public class Vehiculo
	{
		public int nroRuedas { get; set; }
		public string tipoCombustible { get; set; }
		public string color { get; set; }
		
		
		public Vehiculo()
		{
			
			nroRuedas= 4;
			tipoCombustible="GLP";
			color= "azul";
		}
		
		public Vehiculo(int nr, string tc, string c) 
		{
			nroRuedas= nr;
			tipoCombustible=tc;
			color= c;
		}
		public void mostrar() {
			Console.WriteLine(nroRuedas + " " + tipoCombustible + " " + color);
		}
		
		public int getNroRuedas() {
			return nroRuedas;
		}
		
		public string getTipoCombustible() {
			return tipoCombustible;
		}
		
		public string getColor() {
			return color;
		}
		
		public void leer() {
			Console.WriteLine("ingrese el nro de ruedas:");
			nroRuedas = int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el tipo de combustible:");
			tipoCombustible = Console.ReadLine();
			Console.WriteLine("ingrese el color:");
			color = Console.ReadLine();
		}
	}
}
