using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Facturacion.facturacion
{

    public partial class Facturaabono
    {
        public Facturaabono(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
