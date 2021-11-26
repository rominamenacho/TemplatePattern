using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Clases_Patron
{
   public abstract class Credito:Verificaciones
    {
        public Credito(Cliente c)
        {
            _cliente = c;
        }

        protected abstract override string VerificarAcciones();
        protected abstract override string VerificarBalance();
        protected abstract override string VerificarCreditos();
        protected abstract override string VerificarIngresos();
    }
}
