using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Model
{
    public class Model_PhieuNhap
    {
        public int MaPN { get; set; }

        public int? MaNV { get; set; }

        public DateTime? NgayNhap { get; set; }

        public double? TongTien { get; set; }

        public virtual ICollection<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
