using Empleado23AM.Context;
using Empleado23AM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado23AM.Services
{
    public class EmpleadoServices
    {
        private object ex;

        public void Add(Empleado request)
        {
            try
            {

                using (var _context= new ApplicationDbContext())
                {
                    Empleado empleado = new Empleado()
                    {
                        Nombre = request.Nombre,
                        Apellido = request.Apellido,
                        FechaRegistro = DateTime.Now,
                        Correo = request.Correo,
                    };
                    _context.Empleados.Add(empleado);   
                    _context.SaveChanges(); 
                }




            }
            catch (Exception ex) 
            {
                throw new Exception("error" + ex.Message);

            }
            

        }
        public Empleado Read (int ID)
        {
            try
            {
                Empleado empleado = new Empleado();

                using (var _context = new ApplicationDbContext())
                {
                    empleado = _context.Empleados.Find(ID);
                    return empleado;

                }
            }
            catch (Exception ex)
            {

                throw new Exception ("Sucedio un error" + ex.Message);
            }
        }
        public Empleado Delete(int ID)
        {
            try
            {
                Empleado empleado = new Empleado();

                using (var _context = new ApplicationDbContext())
                {
                     empleado = _context.Empleados.Find(ID);
                    _context.Empleados.Remove(empleado);
                    _context.SaveChanges();
                    return empleado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Sucedio un error" + ex.Message);
            }
        }
        public Empleado Update(int ID)
        {
            try
            {
               
                using (var _context = new ApplicationDbContext())
                {             
                    Empleado empleado = _context.Empleados.Find(ID);

                    empleado.Nombre = empleado.Nombre;

                    empleado.Apellido = empleado.Apellido;

                    empleado.FechaRegistro = empleado.FechaRegistro;

                    empleado.Correo = empleado.Correo;

                    _context.Empleados.Update(empleado);
                    _context.SaveChanges();
                    return empleado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Sucedio un error" + ex.Message);
            }
        }

    }
}
