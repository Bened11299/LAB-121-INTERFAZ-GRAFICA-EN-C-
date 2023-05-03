/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 25/4/2023
 * Time: 20:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Libro
{
	partial class HojasForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textNroHoja = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textContenido = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(387, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "HOJA";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(102, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NRO HOJA";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(102, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "CONTENIDO";
			// 
			// textNroHoja
			// 
			this.textNroHoja.Location = new System.Drawing.Point(251, 122);
			this.textNroHoja.Name = "textNroHoja";
			this.textNroHoja.Size = new System.Drawing.Size(100, 22);
			this.textNroHoja.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(403, 276);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "AÑADIR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textContenido
			// 
			this.textContenido.Location = new System.Drawing.Point(251, 173);
			this.textContenido.Name = "textContenido";
			this.textContenido.Size = new System.Drawing.Size(569, 22);
			this.textContenido.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(609, 275);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "MOSTRAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// HojasForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 422);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textContenido);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textNroHoja);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "HojasForm";
			this.Text = "HojasForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		public System.Windows.Forms.TextBox textContenido;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textNroHoja;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
