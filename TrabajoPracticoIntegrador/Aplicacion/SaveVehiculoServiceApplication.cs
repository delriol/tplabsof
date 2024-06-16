using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoIntegrador.Aplicacion.dto;
using TrabajoPracticoIntegrador.Dominio.Repositorio;

namespace TrabajoPracticoIntegrador.Aplicacion
{
    public class SaveVehiculoServiceApplication
    {
        private VehiculoRepositorio vehiculoRepositorio;

        public SaveVehiculoServiceApplication(VehiculoRepositorio vehiculoRepositorio)
        {
            this.vehiculoRepositorio = vehiculoRepositorio;
        }

        public void Execute(VehiculoDto vehiculoDto)
        {
		this.vehiculoRepositorio.save(
            new Dominio.Entidades.Vehiculo(
                vehiculoDto.getId(), vehiculoDto.getMarca(), vehiculoDto.getModelo(), vehiculoDto.getMotor(), vehiculoDto.getChasis()));
        }
    }
}
