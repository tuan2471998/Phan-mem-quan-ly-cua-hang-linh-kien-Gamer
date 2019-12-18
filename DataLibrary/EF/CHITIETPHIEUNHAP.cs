namespace DataLibrary.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHIEUNHAP")]
    public partial class CHITIETPHIEUNHAP
    {
        [Key]
        public int ID_CTPN { get; set; }

        public int? MaPN { get; set; }

        public int MaSP { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public virtual PHIEUNHAP PHIEUNHAP { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
