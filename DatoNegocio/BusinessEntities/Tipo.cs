using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Tipo
    {
        private int id_tipo;

        public int Id_tipo
        {
            get { return id_tipo; }
            set { id_tipo = value; }
        }
        private string nombre_tipo;

        public string Nombre_tipo
        {
            get { return nombre_tipo; }
            set { nombre_tipo = value; }
        }
    }
}
