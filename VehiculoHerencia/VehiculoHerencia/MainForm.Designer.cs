/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 18/4/2023
 * Time: 20:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VehiculoHerencia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.nroRuedas = new System.Windows.Forms.Label();
			this.nroRuedasInput = new System.Windows.Forms.TextBox();
			this.tipo = new System.Windows.Forms.Label();
			this.tipoCombustibleInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.colorInput = new System.Windows.Forms.TextBox();
			this.mostrarVehiculo = new System.Windows.Forms.Label();
			this.crearButton = new System.Windows.Forms.Button();
			this.mostrarButton = new System.Windows.Forms.Button();
			this.crearDefectoButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.placaInput = new System.Windows.Forms.TextBox();
			this.marcaInput = new System.Windows.Forms.TextBox();
			this.mostrarVT = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.fuerzaPalaInput = new System.Windows.Forms.TextBox();
			this.nroPasajerosInput = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.mostrarTractor = new System.Windows.Forms.Label();
			this.mostrarBus = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// nroRuedas
			// 
			this.nroRuedas.Location = new System.Drawing.Point(74, 92);
			this.nroRuedas.Name = "nroRuedas";
			this.nroRuedas.Size = new System.Drawing.Size(100, 23);
			this.nroRuedas.TabIndex = 0;
			this.nroRuedas.Text = "nro ruedas";
			this.nroRuedas.Click += new System.EventHandler(this.Label1Click);
			// 
			// nroRuedasInput
			// 
			this.nroRuedasInput.Location = new System.Drawing.Point(180, 92);
			this.nroRuedasInput.Name = "nroRuedasInput";
			this.nroRuedasInput.Size = new System.Drawing.Size(100, 22);
			this.nroRuedasInput.TabIndex = 1;
			this.nroRuedasInput.TextChanged += new System.EventHandler(this.NroRuedasEntradaTextChanged);
			// 
			// tipo
			// 
			this.tipo.Location = new System.Drawing.Point(74, 133);
			this.tipo.Name = "tipo";
			this.tipo.Size = new System.Drawing.Size(100, 23);
			this.tipo.TabIndex = 2;
			this.tipo.Text = "tipoCombustible";
			this.tipo.Click += new System.EventHandler(this.TipoClick);
			// 
			// tipoCombustibleInput
			// 
			this.tipoCombustibleInput.Location = new System.Drawing.Point(180, 134);
			this.tipoCombustibleInput.Name = "tipoCombustibleInput";
			this.tipoCombustibleInput.Size = new System.Drawing.Size(100, 22);
			this.tipoCombustibleInput.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(74, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "color";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// colorInput
			// 
			this.colorInput.Location = new System.Drawing.Point(180, 175);
			this.colorInput.Name = "colorInput";
			this.colorInput.Size = new System.Drawing.Size(100, 22);
			this.colorInput.TabIndex = 5;
			// 
			// mostrarVehiculo
			// 
			this.mostrarVehiculo.Location = new System.Drawing.Point(568, 133);
			this.mostrarVehiculo.Name = "mostrarVehiculo";
			this.mostrarVehiculo.Size = new System.Drawing.Size(100, 23);
			this.mostrarVehiculo.TabIndex = 6;
			this.mostrarVehiculo.Text = "-";
			// 
			// crearButton
			// 
			this.crearButton.Location = new System.Drawing.Point(374, 91);
			this.crearButton.Name = "crearButton";
			this.crearButton.Size = new System.Drawing.Size(75, 23);
			this.crearButton.TabIndex = 7;
			this.crearButton.Text = "crear";
			this.crearButton.UseVisualStyleBackColor = true;
			this.crearButton.Click += new System.EventHandler(this.CrearButtonClick);
			// 
			// mostrarButton
			// 
			this.mostrarButton.Location = new System.Drawing.Point(374, 134);
			this.mostrarButton.Name = "mostrarButton";
			this.mostrarButton.Size = new System.Drawing.Size(75, 23);
			this.mostrarButton.TabIndex = 8;
			this.mostrarButton.Text = "Mostrar";
			this.mostrarButton.UseVisualStyleBackColor = true;
			this.mostrarButton.Click += new System.EventHandler(this.MostrarButClick);
			// 
			// crearDefectoButton
			// 
			this.crearDefectoButton.Location = new System.Drawing.Point(374, 175);
			this.crearDefectoButton.Name = "crearDefectoButton";
			this.crearDefectoButton.Size = new System.Drawing.Size(126, 23);
			this.crearDefectoButton.TabIndex = 12;
			this.crearDefectoButton.Text = "crear por defecto";
			this.crearDefectoButton.UseVisualStyleBackColor = true;
			this.crearDefectoButton.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(374, 258);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(97, 23);
			this.button3.TabIndex = 13;
			this.button3.Text = "crear VT";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(83, 275);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "placa";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(83, 319);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "marca";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(374, 316);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(97, 23);
			this.button4.TabIndex = 17;
			this.button4.Text = "mostrarVT";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// placaInput
			// 
			this.placaInput.Location = new System.Drawing.Point(180, 276);
			this.placaInput.Name = "placaInput";
			this.placaInput.Size = new System.Drawing.Size(100, 22);
			this.placaInput.TabIndex = 18;
			// 
			// marcaInput
			// 
			this.marcaInput.Location = new System.Drawing.Point(180, 317);
			this.marcaInput.Name = "marcaInput";
			this.marcaInput.Size = new System.Drawing.Size(100, 22);
			this.marcaInput.TabIndex = 19;
			// 
			// mostrarVT
			// 
			this.mostrarVT.Location = new System.Drawing.Point(529, 279);
			this.mostrarVT.Name = "mostrarVT";
			this.mostrarVT.Size = new System.Drawing.Size(339, 23);
			this.mostrarVT.TabIndex = 20;
			this.mostrarVT.Text = "-";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(83, 388);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 21;
			this.label4.Text = "fuerza pala";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(83, 441);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "nro pasajeros";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// fuerzaPalaInput
			// 
			this.fuerzaPalaInput.Location = new System.Drawing.Point(180, 385);
			this.fuerzaPalaInput.Name = "fuerzaPalaInput";
			this.fuerzaPalaInput.Size = new System.Drawing.Size(100, 22);
			this.fuerzaPalaInput.TabIndex = 23;
			// 
			// nroPasajerosInput
			// 
			this.nroPasajerosInput.Location = new System.Drawing.Point(180, 441);
			this.nroPasajerosInput.Name = "nroPasajerosInput";
			this.nroPasajerosInput.Size = new System.Drawing.Size(100, 22);
			this.nroPasajerosInput.TabIndex = 24;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(345, 384);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(126, 23);
			this.button5.TabIndex = 26;
			this.button5.Text = "crear Tractor";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(345, 441);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(126, 23);
			this.button6.TabIndex = 27;
			this.button6.Text = "crear bus";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(511, 440);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 29;
			this.button7.Text = "mostrarB";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(511, 384);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 30;
			this.button8.Text = "mostrarT";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// mostrarTractor
			// 
			this.mostrarTractor.Location = new System.Drawing.Point(629, 387);
			this.mostrarTractor.Name = "mostrarTractor";
			this.mostrarTractor.Size = new System.Drawing.Size(430, 23);
			this.mostrarTractor.TabIndex = 31;
			this.mostrarTractor.Text = "-";
			// 
			// mostrarBus
			// 
			this.mostrarBus.Location = new System.Drawing.Point(629, 444);
			this.mostrarBus.Name = "mostrarBus";
			this.mostrarBus.Size = new System.Drawing.Size(413, 23);
			this.mostrarBus.TabIndex = 32;
			this.mostrarBus.Text = "-";
			this.mostrarBus.Click += new System.EventHandler(this.MostrarBusClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(230, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(176, 36);
			this.label6.TabIndex = 38;
			this.label6.Text = "VEHICULO";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(844, 91);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(381, 425);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 39;
			this.pictureBox1.TabStop = false;
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(43, 536);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(543, 203);
			this.dataGrid1.TabIndex = 40;
			this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.DataGrid1Navigate);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(609, 536);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 23);
			this.button1.TabIndex = 41;
			this.button1.Text = "MOSTRAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1324, 785);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.mostrarBus);
			this.Controls.Add(this.mostrarTractor);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.nroPasajerosInput);
			this.Controls.Add(this.fuerzaPalaInput);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.mostrarVT);
			this.Controls.Add(this.marcaInput);
			this.Controls.Add(this.placaInput);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.crearDefectoButton);
			this.Controls.Add(this.mostrarButton);
			this.Controls.Add(this.crearButton);
			this.Controls.Add(this.mostrarVehiculo);
			this.Controls.Add(this.colorInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tipoCombustibleInput);
			this.Controls.Add(this.tipo);
			this.Controls.Add(this.nroRuedasInput);
			this.Controls.Add(this.nroRuedas);
			this.Name = "MainForm";
			this.Text = "VehiculoHerencia";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label mostrarBus;
		private System.Windows.Forms.Label mostrarTractor;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox nroPasajerosInput;
		private System.Windows.Forms.TextBox fuerzaPalaInput;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label mostrarVT;
		private System.Windows.Forms.TextBox marcaInput;
		private System.Windows.Forms.TextBox placaInput;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button crearDefectoButton;
		private System.Windows.Forms.Button mostrarButton;
		private System.Windows.Forms.Button crearButton;
		private System.Windows.Forms.Label mostrarVehiculo;
		private System.Windows.Forms.TextBox colorInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tipoCombustibleInput;
		private System.Windows.Forms.Label tipo;
		private System.Windows.Forms.TextBox nroRuedasInput;
		private System.Windows.Forms.Label nroRuedas;

	}
}
