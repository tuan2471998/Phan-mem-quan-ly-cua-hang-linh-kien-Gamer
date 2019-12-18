﻿using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Dao
{
    public class nhanVienDao : DBContext
    {
        public int Add(NHANVIEN p)
        {
            int result = 0;
            context.NHANVIENs.Add(p);
            result = context.SaveChanges();
            return result;
        }

        public int Update(NHANVIEN pma)
        {
            int result = 0;
            NHANVIEN k = context.NHANVIENs.FirstOrDefault(m => m.MaNV == pma.MaNV);
            if (k != null)
            {
                k.TenNV = pma.TenNV;
                k.NgaySinh = pma.NgaySinh;
                k.Phai = pma.Phai;
                k.DiaChi = pma.DiaChi;
                k.ChucVu = pma.ChucVu;
                k.SDT = pma.SDT;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Update(NHANVIEN pma, int ma)
        {
            int result = 0;
            NHANVIEN k = context.NHANVIENs.FirstOrDefault(m => m.MaNV == ma);
            if (k != null)
            {
                k.TenNV = pma.TenNV;
                k.NgaySinh = pma.NgaySinh;
                k.Phai = pma.Phai;
                k.DiaChi = pma.DiaChi;
                k.ChucVu = pma.ChucVu;
                k.SDT = pma.SDT;
            }
            result = context.SaveChanges();
            return result;
        }


        public int Delete(int pMa)
        {
            int result = 0;
            NHANVIEN k = context.NHANVIENs.FirstOrDefault(m => m.MaNV == pMa);
            context.NHANVIENs.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<NHANVIEN> GetList()
        {
            List<NHANVIEN> list = new List<NHANVIEN>();
            list = context.NHANVIENs.ToList();
            return list;
        }

        public List<string> GetDSTenNV()
        {
            var list = from a in context.NHANVIENs select a.TenNV;
            return list.ToList();
        }

        public List<NHANVIEN> GetList(string pTen)
        {
            List<NHANVIEN> list = new List<NHANVIEN>();
            list = context.NHANVIENs.Where(t => t.TenNV == pTen).ToList();
            return list;
        }

        public NHANVIEN GetDVByMa(int? pMa)
        {
            NHANVIEN result = new NHANVIEN();
            result = context.NHANVIENs.FirstOrDefault(m => m.MaNV == pMa);
            return result;
        }

        public NHANVIEN GetDVByMa(string pTen)
        {
            NHANVIEN result = new NHANVIEN();
            result = context.NHANVIENs.FirstOrDefault(m => m.TenNV == pTen);
            return result;
        }
    }
}
