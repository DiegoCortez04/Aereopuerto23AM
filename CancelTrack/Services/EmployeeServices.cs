using Aereopuerto.Context;
using Aereopuerto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aereopuerto.Services
{
    public class EmployeeServices
    {
        public void Add(Client request)
        {
            try
            {   //Habre la cadena de conexion y todo lo que se encuentre en using entrará a la DB
                using (var _context = new ApplicationDbContext())
                {
                    Client empleado = new Client()
                    {
                        Name = request.Name,
                        LastName = request.LastName,
                        Age = request.Age,
                        INE = request.INE,
                        Phone = request.Phone,
                        Email = request.Email,
                        TypeService = request.TypeService,
                        Passengers = request.Passengers,
                        NoReserve = request.NoReserve
                    };
                    _context.Client.Add(empleado);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedió un error" + ex.Message);
            }
        }
        public Client Read(int Id)
        {
            try
            {
                Client empleado = new Client();
                using (var _context = new ApplicationDbContext())
                {   // Buscar el empleado por su Id
                    empleado = _context.Client.Find(Id);
                    return empleado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedió un error" + ex.Message);
            }
        }
    }
}
