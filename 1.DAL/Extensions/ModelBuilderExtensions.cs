using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chucVu>().HasData(
                new chucVu() { IDChucVu = 1, tenCV = "Quản lý" },
                new chucVu() { IDChucVu = 2, tenCV = "Nhân viên" }
                );
            modelBuilder.Entity<hangSX>().HasData(
                new hangSX() { IDHangSX = 1, tenHangSX = "Adidas", trangThai = true },
                new hangSX() { IDHangSX = 2, tenHangSX = "Nike", trangThai = true },
                new hangSX() { IDHangSX = 3, tenHangSX = "Quảng Châu", trangThai = true }
                );
            modelBuilder.Entity<khachHang>().HasData(
                new khachHang() { SDT_KH = "0971323123", TenKH = "Nguyễn văn Hoa", gioiTinh=true, diaChi="Hà Nội", trangThai=true, diem = 0 },
                new khachHang() { SDT_KH = "0993123233", TenKH = "Vũ Đình Tú", gioiTinh = true, diaChi = "Sầm Sơn", trangThai = true, diem = 0 },
                new khachHang() { SDT_KH = "0988312333", TenKH = "Vũ Văn Hòa", gioiTinh = true, diaChi = "Tây Ninh", trangThai = true, diem = 0 }
                );
            modelBuilder.Entity<mauSac>().HasData(
                new mauSac() { IDMauSac = 1, tenMau = "Xanh" ,trangThai = true},
                new mauSac() { IDMauSac = 2, tenMau = "Đỏ", trangThai = true },
                new mauSac() { IDMauSac = 3, tenMau = "Trắng", trangThai = true },
                new mauSac() { IDMauSac = 4, tenMau = "Kem", trangThai = true },
                new mauSac() { IDMauSac = 5, tenMau = "Nâu", trangThai = true }
                );
            modelBuilder.Entity<size>().HasData(
                new size() { IDSize = 1, SiZe = "S", trangThai = true },
                new size() { IDSize = 2, SiZe = "M", trangThai = true },
                new size() { IDSize = 3, SiZe = "L", trangThai = true },
                new size() { IDSize = 4, SiZe = "XL", trangThai = true },
                new size() { IDSize = 5, SiZe = "XXL", trangThai = true }
                );
            modelBuilder.Entity<chatLieu>().HasData(
               new chatLieu() { IDChatlieu = 1, ChatLieu = "Cotton", trangThai = true },
               new chatLieu() { IDChatlieu = 2, ChatLieu = "Tơ Tằm", trangThai = true },
               new chatLieu() { IDChatlieu = 3, ChatLieu = "Vải Dù", trangThai = true }
               );
            modelBuilder.Entity<sanPham1>().HasData(
              new sanPham1() { IDsanPham = 1, tenLoaiHang = "Thun Trơn", trangThai = true },
              new sanPham1() { IDsanPham = 2, tenLoaiHang = "Thun H", trangThai = true },
              new sanPham1() { IDsanPham = 3, tenLoaiHang = "Oversize", trangThai = true },
              new sanPham1() { IDsanPham = 4, tenLoaiHang = "Ba lỗ", trangThai = true },
              new sanPham1() { IDsanPham = 5, tenLoaiHang = "Thun Đẹp", trangThai = true },
              new sanPham1() { IDsanPham = 6, tenLoaiHang = "Polo", trangThai = true }
             
              );
            modelBuilder.Entity<nhanVien>().HasData(
                new nhanVien() { IDNhanVien = 1, TenNV = "Vũ Đình Thịnh", IDChucVu = 1, diaChi = "Sầm Sơn",SDT="0974171690", email="thinhvdph26886@fpt.edu.com" ,tinhTrang=true, matKhau="123" },
                 new nhanVien() { IDNhanVien = 2, TenNV = "Hoàng", IDChucVu = 2, diaChi = "Hà Nội", SDT = "0974171690", email = "vudinhthinh22082003@gmail.com", tinhTrang = true, matKhau = "123" }
                );
            modelBuilder.Entity<sanPhamChiTiet>().HasData(
                new sanPhamChiTiet() { IDSanPhamChiTiet = 1,maSP = "SP01", TenSP = "Áo Unisex", Gianhap = 100000, Giaban = 110000, Soluong = 1900, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1,IDChatlieu = 1, linkAnh="" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 2, maSP = "SP02", TenSP = "Áo Polo ", Gianhap = 125000, Giaban = 200000, Soluong = 1600, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, IDChatlieu = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 3, maSP = "SP03", TenSP = "Áo Nike ", Gianhap = 115000, Giaban = 170000, Soluong = 1000, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 1, IDChatlieu = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 4, maSP = "SP04", TenSP = "Áo SamSung", Gianhap = 105000, Giaban = 150000, Soluong = 900, Trangthai = true, IDHangSX = 2, IDSize = 1, IDMauSac = 3, IDsanPham = 3, IDChatlieu = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 5, maSP = "SP05", TenSP = "Áo UNDERBROKEN ", Gianhap = 120000, Giaban = 210000, Soluong = 1400, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, IDChatlieu = 3, linkAnh = "" }
                );
        }
    }
}
