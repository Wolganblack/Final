using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Prueba.prueba
{

    public partial class Proforma
    {
        public Proforma(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
