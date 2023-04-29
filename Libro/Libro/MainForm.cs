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
using System.Drawing;
using System.Windows.Forms;

namespace Libro
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Libro obje;
		HojasForm hf ;
		MostrarLibro m;
		public MainForm()
		{
			InitializeComponent();
			hf = new HojasForm(this);
			m = new MostrarLibro(this);
		}
		public bool addi(string x, string y) {
			bool ans = obje.setHojaI(int.Parse(x), y);
			if(!ans) {
				MessageBox.Show("No existe la hoja nro " + x);
				return false;
			}
			return true;
		}
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			obje = new Libro(textNombre.Text, int.Parse(textNh.Text));
		}
		
	
		void Button3Click(object sender, EventArgs e)
		{
			obje = new Libro(textNombre.Text, int.Parse(textNh.Text));
			hf.Visible = true;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			m.Visible = true;
			string mos = obje.getNombre() + " "+ obje.getNh().ToString() +"\n";
			for(int i = 0; i < obje.getNh(); i++) {
				mos += obje.getPaginasI(i).getContenido() + " " + obje.getPaginasI(i).getNroHoja().ToString() + "\n";
			}
			
			m.mostrarObjeto.Text = mos;
		}
	}
}
