/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 29/4/2023
 * Time: 15:32
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
	/// Description of LibroArch.
	/// </summary>
	[Serializable]
	public class LibroArch
	{
		string nomArch;
		Libroo x;

		public LibroArch(string x)
		{
			nomArch = x;
		}
		
		public void crear(){
			string op;
			if(File.Exists(nomArch)){
				Console.WriteLine("el archio existe, desea eliminarlo s/n");
				op = Console.ReadLine();
				if(op == "s"){
					File.Delete(nomArch);
				}
			} else {
				Console.WriteLine("Archivo Creado");
			}
		}
		
		public void adicionar(){
			Stream arch  = File.Open(nomArch, FileMode.Append);
			BinaryWriter escribe =  new BinaryWriter(arch);
			x = new Libroo();
			string op;
			try {
				do {
					x.leer();
					x.escribir(escribe);
					Console.WriteLine("seguir adciionando s/n");
					op = Console.ReadLine();
				} while( op == "s");
			} catch (Exception e) {
				Console.WriteLine("Fallo en adicionar");
			} finally {
				arch.Close();
			}
		}
		
		public void listar() {
			Stream arch = File.Open(nomArch, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			x = new Libroo();
			try {
				while(true) {
					x.lectura(lee);
					
					x.mostrar();
				}
				
			} catch (Exception e) {
				Console.WriteLine("Fin del archivo");
			} finally {
				arch.Close();
			}
		}


		public void listar(string nombreX, int hojaX) {
			Stream arch = File.Open(nomArch, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			x = new Libroo();
			try {
				while(true) {
					x.lectura(lee);
					if(x.getNombre().Equals(nombreX)) {
						Console.WriteLine(x.getPaginasI(hojaX).getContenido());
					}
				}
				
			} catch (Exception e) {
				Console.WriteLine("Fin del archivo");
			} finally {
				arch.Close();
			}
		}
		
		public void masPaginas() {
			Stream arch = File.Open(nomArch, FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			x = new Libroo();
			int c = 0;
			string y = "";
			try {
				while(true) {
					x.lectura(lee);
					if(x.getNh() > c) {
						c = x.getNh();
						y = x.getNombre();
					}
				}
			} catch (Exception e) {
				Console.WriteLine("Fin del archivo");
			} finally {
				arch.Close();
				Console.WriteLine(y);	
			}
		}
	}
}
