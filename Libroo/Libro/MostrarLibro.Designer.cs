/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 29/4/2023
 * Time: 14:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Libro
{
	partial class MostrarLibro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.mostrarObjeto = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// mostrarObjeto
			// 
			this.mostrarObjeto.Location = new System.Drawing.Point(122, 52);
			this.mostrarObjeto.Name = "mostrarObjeto";
			this.mostrarObjeto.Size = new System.Drawing.Size(770, 338);
			this.mostrarObjeto.TabIndex = 0;
			this.mostrarObjeto.Text = "";
			this.mostrarObjeto.TextChanged += new System.EventHandler(this.RichTextBox1TextChanged);
			// 
			// MostrarLibro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(985, 450);
			this.Controls.Add(this.mostrarObjeto);
			this.Name = "MostrarLibro";
			this.Text = "MostrarLibro";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cerrar);
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.RichTextBox mostrarObjeto;
	}
}
