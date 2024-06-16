using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoIntegrador.Dominio.ValueObject
{
    public class VehiculoModeloValueObject
    {
        private String value;

        public VehiculoModeloValueObject(String value) 
        {
            validateValue(value);
	        this.value = value;
	}

        private void validateValue(String value)
        {
            if (value == "") throw new Exception("El modelo no puede estar vacío");
        }
        public String getValue()
        {
            return value;
        }
     }
}
