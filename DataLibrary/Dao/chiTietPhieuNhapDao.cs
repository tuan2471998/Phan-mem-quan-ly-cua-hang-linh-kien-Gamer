using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.EF;

namespace DataLibrary.Dao
{
    public class chiTietPhieuNhapDao:DBContext
    {
        public int Add(CHITIETPHIEUNHAP p)
        {
            int result = 0;
            context.CHITIETPHIEUNHAPs.Add(p);
            result = context.SaveChanges();
            return result;
        }

        public int Update(CHITIETPHIEUNHAP pma, int ma)
        {
            int result = 0;
            CHITIETPHIEUNHAP k = context.CHITIETPHIEUNHAPs.FirstOrDefault(m => m.ID_CTPN == ma);
            if (k != null)
            {
                k.ID_CTPN = pma.ID_CTPN;
                k.MaPN = pma.MaPN;
                k.MaSP = pma.MaSP;
                k.SoLuong = pma.SoLuong;
                k.DonGia = pma.DonGia;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMa)
        {
            int result = 0;
            CHITIETPHIEUNHAP k = context.CHITIETPHIEUNHAPs.FirstOrDefault(m => m.ID_CTPN == pMa);
            context.CHITIETPHIEUNHAPs.Remove(k);
            result = context.SaveChanges();
            return result;
        }
    }
}
