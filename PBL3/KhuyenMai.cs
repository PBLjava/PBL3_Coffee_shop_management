//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhuyenMai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhuyenMai()
        {
            this.LoaiKhachHangs = new HashSet<LoaiKhachHang>();
        }
    
        public int MaKM { get; set; }
        public string TenCT { get; set; }
        public Nullable<System.DateTime> TGBatDau { get; set; }
        public Nullable<System.DateTime> TGKetThuc { get; set; }
        public string MoTa { get; set; }
        public Nullable<decimal> GiaTriKM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoaiKhachHang> LoaiKhachHangs { get; set; }
    }
}
