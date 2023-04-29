/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 25/4/2023
 * Time: 20:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Libro
{
	/// <summary>
	/// Description of HojasForm.
	/// </summary>
	public partial class HojasForm : Form
	{
		MainForm form;
		int ch = 0;
		public HojasForm(MainForm x)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			form = x;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Cerrar(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Visible = false;			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string x = textNroHoja.Text;
			bool res = form.obje.setHojaI(int.Parse(x), textContenido.Text);
			if(res) {
				MessageBox.Show("Se añadio la hoja");
				textContenido.Text = "";
				textNroHoja.Text = "";
			} else {
				MessageBox.Show("No se pudo añadir la hoja");
			}
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			
		}
	}
}
