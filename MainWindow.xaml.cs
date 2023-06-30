using Empleado23AM.Context;
using Empleado23AM.Entities;
using Empleado23AM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Empleado23AM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        Empleado empl = new Empleado();
        EmpleadoServices services = new EmpleadoServices();
        private void Button_Click(object sender, RoutedEventArgs e) // AGREGAR
        {


            empl.Nombre = txtNombre.Text;
            empl.Apellido = txtApellido.Text;
            empl.Correo = txtNombre.Text;

            if (String.IsNullOrEmpty (empl.Nombre) || String.IsNullOrEmpty (empl.Apellido ) || String.IsNullOrEmpty (empl.Correo) ) //DICE QUE TIENE QUE SER DIFERENTE AL NULO Y VACIO 
            {

                services.Add(empl);

                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                MessageBox.Show("Faltan datos por llenar");
              
             
            }
            else
            {
                MessageBox.Show("se agrego correctamente");
            }
            
                
            

       
        
        }
        private void Button_Click_1(object sender, RoutedEventArgs e) // VER
        {
            int id = int.Parse(txtID.Text);
            empl = services.Read(id);
            txtNombre.Text = empl.Nombre;
            txtApellido.Text = empl.Apellido;
            txtCorreo.Text = empl.Correo;
            txtFecha.Text = empl.FechaRegistro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // BORRAR
        {
            int id = int.Parse(txtID.Text);
            empl = services.Delete(id);
            MessageBox.Show("Datos borrados correctamente");

        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // EDITAR
        {
            int id = int.Parse(txtID.Text);
            MessageBox.Show("Ingrese nuevos datos a actualizar");
            
            empl = services.Update(id);
            empl.Nombre = txtNombre.Text;
            empl.Apellido = txtApellido.Text;
            empl.Correo = txtCorreo.Text ;
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
        }
    }
}
