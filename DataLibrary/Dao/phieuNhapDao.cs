using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.EF;

namespace DataLibrary.Dao
{
    public class phieuNhapDao : DBContext
    {
        public int Add(PHIEUNHAP p)
        {
            int result = 0;
            context.PHIEUNHAPs.Add(p);
            result = context.SaveChanges();
            return result;
        }

        public int Update(PHIEUNHAP pma, int ma)
        {
            int result = 0;
            PHIEUNHAP k = context.PHIEUNHAPs.FirstOrDefault(m => m.MaPN == ma);
            if (k != null)
            {
                k.MaPN = pma.MaPN;
                k.MaNV = pma.MaNV;
                k.NgayNhap = pma.NgayNhap;
                k.TongTien = pma.TongTien;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMa)
        {
            int result = 0;
            PHIEUNHAP k = context.PHIEUNHAPs.FirstOrDefault(m => m.MaPN == pMa);
            context.PHIEUNHAPs.Remove(k);
            result = context.SaveChanges();
            return result;
        }

        public List<PHIEUNHAP> GetList()
        {
            List<PHIEUNHAP> list = new List<PHIEUNHAP>();
            list = context.PHIEUNHAPs.ToList();
            return list;
        }
    }
}
