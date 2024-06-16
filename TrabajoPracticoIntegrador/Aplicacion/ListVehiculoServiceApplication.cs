using TrabajoPracticoIntegrador.Aplicacion.dto;
using TrabajoPracticoIntegrador.Dominio.Repositorio;
namespace TrabajoPracticoIntegrador.Aplicacion
{
    public class ListVehiculoServiceApplication
    {
        private VehiculoRepositorio vehiculoRepositorio;

        public ListVehiculoServiceApplication(VehiculoRepositorio vehiculoRepositorio)
        {
            this.vehiculoRepositorio = vehiculoRepositorio;
        }

        public List<VehiculoDto> Execute()
        {
            List<VehiculoDto> vehiculos = new List<VehiculoDto>();
            vehiculoRepositorio.getAll().ForEach(vehiculo =>
            {
                vehiculos.Add(new VehiculoDto(
                vehiculo.getId(), vehiculo.getMarca(), vehiculo.getModelo(), vehiculo.getMotor(), vehiculo.getChasis()));
            });
            return vehiculos;
        }
    }
}
