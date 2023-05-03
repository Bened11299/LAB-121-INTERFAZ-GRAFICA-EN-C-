/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 25/4/2023
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Libro
{
	partial class MainForm
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
			this.textNombre = new System.Windows.Forms.TextBox();
			this.textNh = new System.Windows.Forms.TextBox();
			this.mostrar = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.mostrar2 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.archName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(432, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "LIBRO";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(91, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NOMBRE";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(91, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "NRO HOJAS";
			// 
			// textNombre
			// 
			this.textNombre.Location = new System.Drawing.Point(241, 112);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(164, 22);
			this.textNombre.TabIndex = 3;
			// 
			// textNh
			// 
			this.textNh.Location = new System.Drawing.Point(241, 159);
			this.textNh.Name = "textNh";
			this.textNh.Size = new System.Drawing.Size(164, 22);
			this.textNh.TabIndex = 4;
			// 
			// mostrar
			// 
			this.mostrar.Location = new System.Drawing.Point(603, 132);
			this.mostrar.Name = "mostrar";
			this.mostrar.Size = new System.Drawing.Size(318, 23);
			this.mostrar.TabIndex = 5;
			this.mostrar.Text = "-";
			this.mostrar.Click += new System.EventHandler(this.Label4Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(477, 219);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "crear";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 11;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(241, 219);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(130, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "llenarHojas";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// mostrar2
			// 
			this.mostrar2.Location = new System.Drawing.Point(603, 174);
			this.mostrar2.Name = "mostrar2";
			this.mostrar2.Size = new System.Drawing.Size(100, 23);
			this.mostrar2.TabIndex = 9;
			this.mostrar2.Text = "-";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(613, 219);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(106, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "MOSTRAR";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(135, 352);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(162, 23);
			this.button5.TabIndex = 12;
			this.button5.Text = "CREAR ARCHIVO";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(341, 352);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(126, 23);
			this.button6.TabIndex = 13;
			this.button6.Text = "ADICIONAR";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(499, 350);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 14;
			this.button7.Text = "LISTAR";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// archName
			// 
			this.archName.Location = new System.Drawing.Point(135, 391);
			this.archName.Name = "archName";
			this.archName.Size = new System.Drawing.Size(162, 22);
			this.archName.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1012, 509);
			this.Controls.Add(this.archName);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.mostrar2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.mostrar);
			this.Controls.Add(this.textNh);
			this.Controls.Add(this.textNombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Libro";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox archName;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		public System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label mostrar2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.Label mostrar;
		public System.Windows.Forms.TextBox textNh;
		public System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
