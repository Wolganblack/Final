﻿//------------------------------------------------------------------------------
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
namespace Prueba.prueba
{

    [Persistent(@"role_has_permissions")]
    public partial class Role_has_permissions : XPLiteObject
    {
        public struct CompoundKey1Struct
        {
            [Persistent("permission_id")]
            public ulong permission_id { get; set; }
            [Persistent("role_id")]
            public ulong role_id { get; set; }
        }
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}