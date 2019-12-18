﻿using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Dao
{
    public class khachHangDao : DBContext
    {
        public int Add(KHACHHANG p)
        {
            int result = 0;
            context.KHACHHANGs.Add(p);
            result = context.SaveChanges();
            return result;
        }
        public int Update(KHACHHANG pma)
        {
            int result = 0;
            KHACHHANG k = context.KHACHHANGs.FirstOrDefault(m => m.MaKH == pma.MaKH);
            if (k != null)
            {
                k.TenKH = pma.TenKH;
                k.Phai = pma.Phai;
                k.DiaChi = pma.DiaChi;
                k.SDT = pma.SDT;
                k.LoaiKH = pma.LoaiKH;
                k.SoTaiKhoan = pma.SoTaiKhoan;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Update(KHACHHANG pma, int ma)
        {
            int result = 0;
            KHACHHANG k = context.KHACHHANGs.FirstOrDefault(m => m.MaKH == ma);
            if (k != null)
            {
                k.TenKH = pma.TenKH;
                k.Phai = pma.Phai;
                k.DiaChi = pma.DiaChi;
                k.SDT = pma.SDT;
                k.LoaiKH = pma.LoaiKH;
                k.SoTaiKhoan = pma.SoTaiKhoan;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMa)
        {
            int result = 0;
            KHACHHANG k = context.KHACHHANGs.FirstOrDefault(m => m.MaKH == pMa);
            context.KHACHHANGs.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<KHACHHANG> GetList()
        {
            List<KHACHHANG> list = new List<KHACHHANG>();
            list = context.KHACHHANGs.ToList();
            return list;
        }

        public List<KHACHHANG> GetList(string sdt)
        {
            List<KHACHHANG> list = new List<KHACHHANG>();
            list = context.KHACHHANGs.Where(t => t.SDT == sdt).ToList();
            return list;
        }

        public KHACHHANG GetDVByMa(int? pMa)
        {
            KHACHHANG result = new KHACHHANG();
            result = context.KHACHHANGs.FirstOrDefault(m => m.MaKH == pMa);
            return result;
        }

        public KHACHHANG Login_KH(string userName, string pass)
        {
            KHACHHANG result = new KHACHHANG();
            result = context.KHACHHANGs.FirstOrDefault(m => m.TaiKhoan == userName && m.MatKhau == pass);
            return result;
        }

        public int GetMaKH(string sdt)
        {
            int ma;
            KHACHHANG k = context.KHACHHANGs.FirstOrDefault(m => m.SDT == sdt);
            ma = Convert.ToInt32(k.MaKH.ToString());
            return ma;
        }
    }
}
