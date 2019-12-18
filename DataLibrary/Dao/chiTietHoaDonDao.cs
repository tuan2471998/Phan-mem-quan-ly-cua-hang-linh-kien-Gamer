﻿using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Dao
{
    public class chiTietHoaDonDao : DBContext
    {
        public int Add(CHITIETHOADON p)
        {
            int result = 0;
            context.CHITIETHOADONs.Add(p);
            result = context.SaveChanges();
            return result;
        }
        public int Update(CHITIETHOADON pma)
        {
            int result = 0;
            CHITIETHOADON k = context.CHITIETHOADONs.FirstOrDefault(m => m.MaHD == pma.MaHD && m.MaSP == pma.MaSP);
            if (k != null)
            {
                k.SoLuong = pma.SoLuong;
                k.DonGia = pma.DonGia;
                k.ThanhTien = pma.ThanhTien;
               
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMa, int maSP)
        {
            int result = 0;
            CHITIETHOADON k = context.CHITIETHOADONs.FirstOrDefault(m => m.MaHD == pMa && m.MaSP == maSP);
            context.CHITIETHOADONs.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<CHITIETHOADON> GetList()
        {
            List<CHITIETHOADON> list = new List<CHITIETHOADON>();
            list = context.CHITIETHOADONs.ToList();
            return list;
        }

        public CHITIETHOADON GetDVByMa(int pMa, int maSP)
        {
            CHITIETHOADON result = new CHITIETHOADON();
            result = context.CHITIETHOADONs.FirstOrDefault(m => m.MaHD == pMa && m.MaSP == maSP);
            return result;
        }

        public List<CHITIETHOADON> GetList(int ma)
        {
            List<CHITIETHOADON> list = new List<CHITIETHOADON>();
            list = context.CHITIETHOADONs.Where(t => t.MaHD == ma).ToList();
            return list;
        }
    }
}
