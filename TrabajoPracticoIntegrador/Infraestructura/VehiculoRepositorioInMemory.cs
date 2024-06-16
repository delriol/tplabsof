using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoIntegrador.Dominio.Entidades;
using TrabajoPracticoIntegrador.Dominio.Repositorio;

namespace TrabajoPracticoIntegrador.Infraestructura
{
    public class VehiculoRepositorioInMemory : VehiculoRepositorio
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        public List<Vehiculo> getAll()
        {
            return this.vehiculos;
        }

        public void save(Vehiculo vehiculo)
        {
            this.vehiculos.Add(vehiculo);
        }

        void VehiculoRepositorio.delete(string id)
        {
            //throw new NotImplementedException();
        }

        void VehiculoRepositorio.update(Vehiculo vehiculo)
        {
            //throw new NotImplementedException();
        }
    }
}
