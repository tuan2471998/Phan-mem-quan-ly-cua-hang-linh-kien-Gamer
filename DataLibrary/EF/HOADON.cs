namespace DataLibrary.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
            DONHANGs = new HashSet<DONHANG>();
        }

        [Key]
        public int MaHD { get; set; }

        public int? MaKH { get; set; }

        public int? MaNV { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        public int? TongMatHang { get; set; }

        public double? TongTien { get; set; }

        public DateTime? NgayLap { get; set; }

        public DateTime? NgayGiao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
