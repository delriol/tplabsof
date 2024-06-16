using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoIntegrador.Dominio.Entidades;
using TrabajoPracticoIntegrador.Dominio.ValueObject;

namespace TrabajoPracticoIntegrador.Aplicacion.dto
{
    public class VehiculoDto
    {
        private Guid id;
        private String marca;
        private String modelo;
        private String motor;
        private String chasis;
        // private TipoVehiculo tipoVehiculo;

        public VehiculoDto(Guid id, String marca, String modelo, String motor, String chasis)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.motor = motor;
            this.chasis = chasis;
        }

        public Guid getId() {
           return this.id;
        }

        public String getMarca () {
           return this.marca;
        }

        public String getModelo()
        {
            return this.modelo;
        }

        public String getMotor()
        {
            return this.motor;
        }

        public String getChasis()
        {
            return this.chasis;
        }
    }
}
