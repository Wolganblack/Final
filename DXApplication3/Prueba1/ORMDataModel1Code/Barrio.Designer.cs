//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Prueba1.prueba
{

    [Persistent(@"barrio")]
    public partial class Barrio : XPLiteObject
    {
        int fidbarrio;
        [Key(true)]
        public int idbarrio
        {
            get { return fidbarrio; }
            set { SetPropertyValue<int>(nameof(idbarrio), ref fidbarrio, value); }
        }
        string fnombre;
        [Size(200)]
        public string nombre
        {
            get { return fnombre; }
            set { SetPropertyValue<string>(nameof(nombre), ref fnombre, value); }
        }
        string fdetalle;
        [Size(200)]
        public string detalle
        {
            get { return fdetalle; }
            set { SetPropertyValue<string>(nameof(detalle), ref fdetalle, value); }
        }
    }

}
