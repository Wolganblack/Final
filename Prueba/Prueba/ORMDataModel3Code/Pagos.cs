using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Prueba.prueba
{

    public partial class Pagos
    {
        public Pagos(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
