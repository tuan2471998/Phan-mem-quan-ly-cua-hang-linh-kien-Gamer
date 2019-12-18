using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Dao
{
    public class loaiDao : DBContext
    {
            public int Add(LOAI p)
            {
                int result = 0;
                context.LOAIs.Add(p);
                result = context.SaveChanges();
                return result;
            }
            public int Update(LOAI pma)
            {
                int result = 0;
                LOAI k = context.LOAIs.FirstOrDefault(m => m.MaLoai == pma.MaLoai);
                if (k != null)
                {
                    k.TenLoai = pma.TenLoai;
                }
                result = context.SaveChanges();
                return result;
            }

            public int Delete(int pMa)
            {
                int result = 0;
                LOAI k = context.LOAIs.FirstOrDefault(m => m.MaLoai == pMa);
                context.LOAIs.Remove(k);
                result = context.SaveChanges();
                return result;
            }
            public List<LOAI> GetList()
            {
                List<LOAI> list = new List<LOAI>();
                list = context.LOAIs.ToList();
                return list;
            }

        public List<string> GetDSTen()
        {
            var list = from a in context.LOAIs select a.TenLoai;
            return list.ToList();
        }

        public LOAI GetDVByMa(int? pMa)
            {
                LOAI result = new LOAI();
                result = context.LOAIs.FirstOrDefault(m => m.MaLoai == pMa);
                return result;
            }
        public LOAI GetDVByMa(string pTen)
        {
            LOAI result = new LOAI();
            result = context.LOAIs.FirstOrDefault(m => m.TenLoai == pTen);
            return result;
        }

    }
}
