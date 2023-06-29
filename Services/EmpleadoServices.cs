using EmpleaedoM23CV.Context;
using EmpleaedoM23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleaedoM23CV.Services
{
    public class EmpleadoServices
    {
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
    }
}
