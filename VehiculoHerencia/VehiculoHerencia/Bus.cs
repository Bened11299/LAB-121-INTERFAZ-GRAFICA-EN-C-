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
	/// Description of Bus.
	/// </summary>
	/// La clase Padre es VehiculoTerrestre
	public class Bus:VehiculoTerrestre
	{
		private int nroPasajeros { get; set; }
		
		//al acceder al constructor de nuestra clase padre le enviamos loas parametros que necesita
		public Bus(int c, string tc, string col, string p, string m, int np):base(c,tc,col, p, m)
		{
			nroPasajeros = np;
		}
		public int getNroPasajeros() {
			return nroPasajeros;
		}
	}
}
