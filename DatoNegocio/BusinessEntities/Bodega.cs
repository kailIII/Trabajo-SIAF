using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Bodega
    {
        private string cod_bodega;

        public string Cod_bodega
        {
            get { return cod_bodega; }
            set { cod_bodega = value; }
        }
        private int id_usuario;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

    }
}
