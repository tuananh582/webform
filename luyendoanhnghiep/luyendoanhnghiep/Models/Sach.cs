//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace luyendoanhnghiep.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            this.HoaDonBans = new HashSet<HoaDonBan>();
        }
    
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string TheLoai_ { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }
    }
}
