using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Prueba2.testeo
{

    public partial class Usuarios
    {
        public Usuarios(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
