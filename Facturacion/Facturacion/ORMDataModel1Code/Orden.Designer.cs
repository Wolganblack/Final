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
namespace Facturacion.facturacion
{

    [Persistent(@"orden")]
    public partial class Orden : XPLiteObject
    {
        int fIdOrden;
        [Key(true)]
        [Persistent(@"idOrden")]
        public int IdOrden
        {
            get { return fIdOrden; }
            set { SetPropertyValue<int>(nameof(IdOrden), ref fIdOrden, value); }
        }
        int fIdProveedor;
        [Persistent(@"idProveedor")]
        public int IdProveedor
        {
            get { return fIdProveedor; }
            set { SetPropertyValue<int>(nameof(IdProveedor), ref fIdProveedor, value); }
        }
        DateTime fFechaOrden;
        [Persistent(@"fechaOrden")]
        public DateTime FechaOrden
        {
            get { return fFechaOrden; }
            set { SetPropertyValue<DateTime>(nameof(FechaOrden), ref fFechaOrden, value); }
        }
        decimal fIva;
        [Persistent(@"iva")]
        public decimal Iva
        {
            get { return fIva; }
            set { SetPropertyValue<decimal>(nameof(Iva), ref fIva, value); }
        }
        decimal fDescuento;
        [Persistent(@"descuento")]
        public decimal Descuento
        {
            get { return fDescuento; }
            set { SetPropertyValue<decimal>(nameof(Descuento), ref fDescuento, value); }
        }
        decimal fTotal;
        [Persistent(@"total")]
        public decimal Total
        {
            get { return fTotal; }
            set { SetPropertyValue<decimal>(nameof(Total), ref fTotal, value); }
        }
        decimal fSaldo;
        [Persistent(@"saldo")]
        public decimal Saldo
        {
            get { return fSaldo; }
            set { SetPropertyValue<decimal>(nameof(Saldo), ref fSaldo, value); }
        }
    }

}
