/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 29/4/2023
 * Time: 14:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Libro
{
	/// <summary>
	/// Description of MostrarLibro.
	/// </summary>
	public partial class MostrarLibro : Form
	{
		MainForm form;
		public MostrarLibro(MainForm x)
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
		
		void RichTextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void cerrar(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Visible = false;
		}
	}
}
