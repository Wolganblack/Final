using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Prueba.prueba
{

    public partial class Prestamo
    {
        public Prestamo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }


        public string nombrecompleto
        {
            get
            {
                    return cliente_clienteid.nombre
            }

        }
        public string esActivo
        {
            get { return activo ? "SI" : "NO"; }
        }
    }
}
