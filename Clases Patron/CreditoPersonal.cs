using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Clases_Patron
{
    class CreditoPersonal : Credito
    {
        public CreditoPersonal(Cliente c) : base(c)
        {
        }

        protected override string VerificarAcciones()
        {
            return "Verificando acciones [CP]";
        }

        protected override string VerificarBalance()
        {
            return "Verificando balances [CP]";
        }

        protected override string VerificarCreditos()
        {
            return "Verificando creditos [CP]";
        }

        protected override string VerificarIngresos()
        {
            return "Verificando ingresos [CP]";
        }
    }
}
