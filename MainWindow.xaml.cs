using EmpleaedoM23CV.Context;
using EmpleaedoM23CV.Entities;
using EmpleaedoM23CV.Services;
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

namespace EmpleaedoM23CV
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Empleado empl = new Empleado();
            EmpleadoServices services = new EmpleadoServices();

            empl.Nombre = txtNombre.Text;
            empl.Apellido = txtApellido.Text;
            empl.Correo = txtNombre.Text;

            if (empl.Nombre == null && empl.Apellido == null && empl.Correo == null)
            {
           

                MessageBox.Show("Falta campos por llenar");
             
            }
            else
            {
                services.Add(empl);

                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                MessageBox.Show("se agrego correctamente");
            }
            
                
            

            //validar que no esten vacios 

            //services.Add(empl);

            //txtNombre.Clear();
            //txtApellido.Clear();
            //txtCorreo.Clear();
            //MessageBox.Show("se agrego correctamente");
        
        }


       














        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }






    }
}
