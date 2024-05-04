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
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            this.CaTrucs = new HashSet<CaTruc>();
        }
    
        public int MaNV { get; set; }
        public int MaCV { get; set; }
        public string HoTenNV { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string SDT { get; set; }
        public Nullable<long> Luong { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaTruc> CaTrucs { get; set; }
    }
}
