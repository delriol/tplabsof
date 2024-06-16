using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoIntegrador.Dominio.ValueObject
{
    public class VehiculoChasisValueObject
    {
        private String value;

        public VehiculoChasisValueObject(String value) 
        {
            validateValue(value);
		this.value = value;
	}

        private void validateValue(String value)
        {
            if (value == "") throw new Exception("El número de chasis no puede estar vacío");
        }
        public String getValue()
        {
            return value;
        }
     }
}
