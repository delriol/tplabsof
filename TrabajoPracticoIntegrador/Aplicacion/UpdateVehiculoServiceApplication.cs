using System;
using TrabajoPracticoIntegrador.Aplicacion.dto;
using TrabajoPracticoIntegrador.Dominio.Repositorio;

namespace TrabajoPracticoIntegrador.Aplicacion
{
    public class UpdateVehiculoServiceApplication
    {
        private VehiculoRepositorio vehiculoRepositorio;

        public UpdateVehiculoServiceApplication(VehiculoRepositorio vehiculoRepositorio)
        {
            this.vehiculoRepositorio = vehiculoRepositorio;
        }

        public void Execute(VehiculoDto vehiculoDto)
        {
		this.vehiculoRepositorio.update(
            new Dominio.Entidades.Vehiculo(
                vehiculoDto.getId(), vehiculoDto.getMarca(), vehiculoDto.getModelo(), vehiculoDto.getMotor(), vehiculoDto.getChasis()));
        }
    }
}
