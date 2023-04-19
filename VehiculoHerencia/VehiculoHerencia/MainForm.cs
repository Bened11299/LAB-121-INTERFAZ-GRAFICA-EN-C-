/*
 * Created by SharpDevelop.
 * User: KAYLEN
 * Date: 18/4/2023
 * Time: 20:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VehiculoHerencia
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Debemos instanciar nuestros objetos
		Vehiculo a;
		VehiculoTerrestre b;
		Tractor c;
		Bus d;
		
		//Esta es un lista que nos ayudara a insertar elementos en nuestro DataGrid
		//Para que dataGrid pueda acceder a la informacion de nuestro objeto, cambiaremos
		//el protected por public y agregaremos los {get; set;} en los atributos
		public List<Vehiculo> vehiculos { get; set; }
		public MainForm()
		{
			vehiculos = new List<Vehiculo>();
			InitializeComponent();
			
		}
		
		private List<Vehiculo> getVehiculos()
		{
			return vehiculos;
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void TipoClick(object sender, EventArgs e)
		{
			
		}
		
		void NroRuedasEntradaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void CrearButtonClick(object sender, EventArgs e)
		{
			//Para crear nuestros objetos, podemos hacerlo mediante un boton que al ser pulsado, lo que hace es 
			//acceder a la informacion que tiene los 'textBox', para acceder a estos datos lo hacemos a traves 
			//de 'nombreDelTextbox.Text' y lo enviamos al constructor de nuestro objeto
			a = new Vehiculo(int.Parse(nroRuedasInput.Text), tipoCombustibleInput.Text, colorInput.Text);
			
			//Cada que creemos un vehiculo lo añadiremos a la lista para poder visualizarlo en el dataGrid
			vehiculos.Add(a);
		}
		
		void MostrarButClick(object sender, EventArgs e)
		{
			//Para mostrar los datos de nuestros objetos usamos los getters y los concatenamos para asignarlo 
			//en la variable que usaremos para verlos, en este ejemplo usamos un label, que tiene por nombre 'mostrar'
			mostrarVehiculo.Text = (a.getColor()+" "+a.getNroRuedas().ToString()+ " "+ a.getTipoCombustible());
		}

		
		void Button2Click(object sender, EventArgs e)
		{
			//Si vamos a crear un objeto por defecto, no es necesario mandar paramtros a nuestro constructor
			a = new Vehiculo();
			vehiculos.Add(a);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			b = new VehiculoTerrestre(int.Parse(nroRuedasInput.Text), tipoCombustibleInput.Text, colorInput.Text, placaInput.Text, marcaInput.Text);
			//Como VehiculoTerrestre hereda de Vehiculo, es posible que añadamos un objeto VehiculoTerrestre 
			//a nuestra lista de Vehiculos y podemos hacer lo mismo con Tractor y Bus
			vehiculos.Add(b);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			mostrarVT.Text =  (b.getColor()+" "+b.getNroRuedas().ToString()+ " "+ b.getTipoCombustible() + " " +b.getPlaca()+ " " + b.getMarca());
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			d = new Bus(int.Parse(nroRuedasInput.Text), tipoCombustibleInput.Text, colorInput.Text, placaInput.Text, marcaInput.Text, int.Parse(nroPasajerosInput.Text));
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			c = new Tractor(int.Parse(nroRuedasInput.Text), tipoCombustibleInput.Text, colorInput.Text, placaInput.Text, marcaInput.Text, fuerzaPalaInput.Text);
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			mostrarTractor.Text = (c.getColor()+" "+c.getNroRuedas().ToString()+ " "+ c.getTipoCombustible() + " " +c.getPlaca()+ " " +c.getMarca()+ " " + c.getFuerzaPala());
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			mostrarBus.Text = (d.getColor()+" "+d.getNroRuedas().ToString()+ " "+ d.getTipoCombustible() + " " +d.getPlaca()+ " " +d.getMarca()+ " " + d.getNroPasajeros().ToString());
		}
		
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		
		void MostrarBusClick(object sender, EventArgs e)
		{
			
		}
		
		void DataGrid1Navigate(object sender, NavigateEventArgs ne)
		{
			dataGrid1.DataSource = getVehiculos();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//Aqui insertamos la informacion de la lista en el dataGrid, es necesario primero ponerlo en null, para actualizar los datos luego
			dataGrid1.DataSource = null;
			dataGrid1.DataSource = getVehiculos();
		}
	}
}
