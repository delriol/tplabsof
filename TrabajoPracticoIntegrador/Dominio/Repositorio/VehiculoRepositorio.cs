using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoIntegrador.Dominio.Entidades;

namespace TrabajoPracticoIntegrador.Dominio.Repositorio
{
    public interface VehiculoRepositorio
    {
        public void save(Vehiculo vehiculo);

        public void update(Vehiculo vehiculo);

        public void delete(string id);
        public List<Vehiculo> getAll();
    }
}
