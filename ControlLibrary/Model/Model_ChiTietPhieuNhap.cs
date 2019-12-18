using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Model
{
    public class Model_ChiTietPhieuNhap
    {
        public int ID_CTPN { get; set; }

        public int? MaPN { get; set; }

        public int? MaSP { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public virtual PHIEUNHAP PHIEUNHAP { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
