//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wcfmayoreoc
{
    using System;
    using System.Collections.Generic;
    
    public partial class envios
    {
        public int idenvio { get; set; }
        public string paqueteria { get; set; }
        public Nullable<decimal> costo { get; set; }
        public Nullable<System.DateTime> fechaEnvio { get; set; }
        public Nullable<System.DateTime> fechaLlegada { get; set; }
        public string referenciaDomicilio { get; set; }
        public string domicilioEntrega { get; set; }
        public string telefono { get; set; }
        public string numeroGuia { get; set; }
        public int ordenCompra_idordenCompra { get; set; }
    
        public virtual ordencompra ordencompra { get; set; }
    }
}
