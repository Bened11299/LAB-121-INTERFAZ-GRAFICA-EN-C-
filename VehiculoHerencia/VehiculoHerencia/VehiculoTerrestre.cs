/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 18/4/2023
 * Time: 21:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VehiculoHerencia
{
	/// <summary>
	/// Description of VehiculoTerrestre.
	/// </summary>
	
	/// Para realizar herencia de alguna clase, debemos hacerlo 
	/// agregando dos puntos (:) y el nombre de la clase base o clase padre, 
	/// de la cual realizaremos la herencia, en este caso hacemos la herencia 
	/// de la clase Vehiculo
	public class VehiculoTerrestre:Vehiculo
	{
		public string marca { get; set; }
		public string placa { get; set; }
		
		//Es necesario utilizar la palabra clave "base" en la definición del 
		//constructor de la clase derivada
		public VehiculoTerrestre():base()
		{
			placa = "XYZ123";
			marca="Toyota";
		}
		
		//Si nuestro contrsuctor recibe parametros, se deben enviar los que 
		//determina el constructor de la clase base
		public VehiculoTerrestre(int nr, string tc, string c, string p, string m):base(nr,tc,c)
		{
			placa = p;
			marca = m;
		}
		
		//Para acceder a los metodos de nuestra clase base tambien lo 
		//hacemoscon la palabra "base" seguido de punto (.) y el nombre del 
		//metodo heredado a utilizar
		public void mostrar(){
			base.mostrar();
			Console.WriteLine(marca + " " + placa);
		}
		
		public void leer() {
			base.leer();
			Console.WriteLine("ingrese la placa:");
			placa = Console.ReadLine();
			Console.WriteLine("ingrese la marca:");
			marca = Console.ReadLine();
		}
		
		//Para poder acceder a los getters de la clase base, no es necesario usar "base"
		//podremos acceder a estos sin ningun problema solo referenciando el objetos
		public string getMarca() {
			return marca;
		}
		
		public string getPlaca() {
			return placa;
		}
		
	}
}
