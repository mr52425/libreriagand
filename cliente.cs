//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyectolibreriaOF1
{
    using System;
    using System.Collections.Generic;
    
    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            this.ventas = new HashSet<ventas>();
        }
    
        public int id_cliente { get; set; }
        public string nom_cliente { get; set; }
        public string ape_cliente { get; set; }
        public Nullable<int> edad { get; set; }
        public string direccion { get; set; }
        public Nullable<int> telefono { get; set; }
        public string email { get; set; }
        public string tipo_cliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ventas> ventas { get; set; }
    }
}
