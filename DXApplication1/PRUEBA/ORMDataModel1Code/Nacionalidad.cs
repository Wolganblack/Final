using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace PRUEBA.mydb
{

    public partial class Nacionalidad
    {
        public Nacionalidad(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
