﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteBanHang.Models
{
    public class ItemGioHang
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public string HinhAnh { get; set; }
        public ItemGioHang(int iMaSP)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                this.MaSP = iMaSP;
                SanPham sp = db.SanPhams.Single(x => x.MaSP == iMaSP);
                this.TenSP = sp.TenSP;
                this.HinhAnh = sp.HinhAnh;
                this.DonGia = sp.DonGia.Value;
                this.SoLuong = 1;
                this.ThanhTien = SoLuong * sp.DonGia.Value;

            }
        }
        public ItemGioHang(int iMaSP,int sl)
        {
            using(QuanLyBanHangEntities db=new QuanLyBanHangEntities())
            {
                this.MaSP = iMaSP;
                SanPham sp = db.SanPhams.Single(x => x.MaSP == iMaSP);
                this.TenSP = sp.TenSP;
                this.HinhAnh = sp.HinhAnh;
                this.DonGia = sp.DonGia.Value;
                this.SoLuong = sl;
                this.ThanhTien = SoLuong * sp.DonGia.Value;

            }
        }
        public ItemGioHang()
        {

        }
    }
}