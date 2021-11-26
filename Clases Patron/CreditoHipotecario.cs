using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Clases_Patron
{
    class CreditoHipotecario : Credito
    {
        public CreditoHipotecario(Cliente c) : base(c)
        {
        }

        protected override string VerificarAcciones()
        {
            return "Verificando acciones [CH]";
        }

        protected override string VerificarBalance()
        {
            return "Verificando balance [CH]";
        }

        protected override string VerificarCreditos()
        {
            return "Verificando creditos [CH]";
        }

        protected override string VerificarIngresos()
        {
            return "Verificando ingresos [CH]";
        }
    }
}
