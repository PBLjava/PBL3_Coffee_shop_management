//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class CaTruc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaTruc()
        {
            this.NhanViens = new HashSet<NhanVien>();
        }
    
        public int MaCT { get; set; }
        public System.DateTime NgayTruc { get; set; }
        public Nullable<System.TimeSpan> ThoiGianBD { get; set; }
        public Nullable<System.TimeSpan> ThoiGianKT { get; set; }
    
        public virtual DoanhThu DoanhThu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
