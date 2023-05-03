/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 29/4/2023
 * Time: 15:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LibroArchivo
{
	class Program
	{
		public static void Main(string[] args)
		{
			LibroArch x = new LibroArch("arcivoLibro.dat");

			string op;
			do {
				Console.WriteLine("=========== MENU =======");
				Console.WriteLine("1. Crear");
				Console.WriteLine("2. Adicionar");
				Console.WriteLine("3.Listar");
				Console.WriteLine("4.Mostrar pagina x del libro y");
				Console.WriteLine("5. Mostrar el nombre del libro con mas paginas");
				Console.WriteLine("6.Salir");
				op = Console.ReadLine();
				switch(int.Parse(op)) {
					case 1 :
						x.crear();
						break;
					case 2:
						x.adicionar();
						break;
					case 3:
						x.listar();
						break;
					case 4:
						Console.WriteLine("Ingrese el nombre del libro: ");
						string y = Console.ReadLine();
						Console.WriteLine("Ingrese el numero de pagina: ");
						int xx = int.Parse(Console.ReadLine());
						x.listar(y, xx);
						break;
					case 5:
						x.masPaginas();
						break;
					default:
						break;
				}
			} while(op!="6");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}