using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Prueba1.prueba
{

    public partial class Barrio
    {
        public Barrio(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
