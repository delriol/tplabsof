using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using TrabajoPracticoIntegrador.Dominio.ValueObject;

namespace TrabajoPracticoIntegrador.Dominio.Entidades
{
    public class Vehiculo
    {
        private Guid id;
        private VehiculoMarcaValueObject marca;
        private VehiculoModeloValueObject modelo;
        private VehiculoMotorValueObject motor;
        private VehiculoChasisValueObject chasis;
       // private TipoVehiculo tipoVehiculo;

        public Vehiculo(Guid id, String marca, String modelo, String motor, String chasis)
        {
            this.id = id;
            this.marca = new VehiculoMarcaValueObject(marca);
            this.modelo = new VehiculoModeloValueObject(modelo);
            this.motor = new VehiculoMotorValueObject(motor);
            this.chasis = new VehiculoChasisValueObject(chasis);
            //this.
        }

        public Guid getId()
        {
            return this.id;
        }

        public String getMarca()
        {
            return this.marca.getValue();
        }

        public String getModelo()
        {
            return this.modelo.getValue();
        }

        public String getMotor()
        {
            return this.motor.getValue();
        }

        public String getChasis()
        {
            return this.chasis.getValue();
        }

    }
}   
