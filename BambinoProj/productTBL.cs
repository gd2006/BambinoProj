//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BambinoProj
{
    using System;
    using System.Collections.Generic;
    
    public partial class productTBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public productTBL()
        {
            this.productExtraData = new HashSet<productExtraData>();
        }
    
        public int Id { get; set; }
        public string prodName { get; set; }
        public double price { get; set; }
        public int typeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productExtraData> productExtraData { get; set; }
        public virtual productTypeTBL productTypeTBL { get; set; }
    }
}