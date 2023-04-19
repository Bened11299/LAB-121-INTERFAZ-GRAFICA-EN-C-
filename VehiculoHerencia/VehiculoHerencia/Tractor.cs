/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 18/4/2023
 * Time: 21:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VehiculoHerencia
{
	/// <summary>
	/// Description of Tractor.
	/// </summary>
	/// La clase Padre es VehiculoTerrestre
	public class Tractor:VehiculoTerrestre
	{
		private string fuerzaPala { get; set; }
		
		//al acceder al constructor de nuestra clase padre le enviamos loas parametros que necesita
		public Tractor(int nr, string tc, string c, string p, string m, string fp):base(nr,tc,c,p,m)
		{
			fuerzaPala = fp;
		}
		
		public string getFuerzaPala() {
			return fuerzaPala;
		}
	}
}
