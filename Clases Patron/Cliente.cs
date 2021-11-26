using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Clases_Patron
{
  public  class Cliente
    {
        private string nombre;

        public Cliente(string _nombre)
        {
            this.Nombre = _nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
