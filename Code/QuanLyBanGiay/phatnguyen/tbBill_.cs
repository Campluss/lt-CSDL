//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace phatnguyen
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbBill_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbBill_()
        {
            this.tbBillDetails_ = new HashSet<tbBillDetails_>();
        }
    
        public int ID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> StaffID { get; set; }
        public Nullable<System.DateTime> DOS { get; set; }
        public Nullable<double> Total { get; set; }
        public string CustomerCode { get; set; }
        public string StaffCode { get; set; }
    
        public virtual tbCustomer_ tbCustomer_ { get; set; }
        public virtual tbStaff_ tbStaff_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBillDetails_> tbBillDetails_ { get; set; }
    }
}