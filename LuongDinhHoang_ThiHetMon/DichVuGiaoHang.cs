using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuongDinhHoang_ThiHetMon
{
    internal abstract class DichVuGiaoHang
    {
        protected static int autoID = 0;
        public string MaDonHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public float KhoiLuong { get; set; }
        public double PhiDichVu { get; set; }
    }

    internal class GiaoHangTieuChuan : DichVuGiaoHang
    {
        public GiaoHangTieuChuan()
        {
            
        }

        public GiaoHangTieuChuan(string id)
        {
            MaDonHang = id == null ? $"GHTC{++autoID}" : id;
        }

        public GiaoHangTieuChuan(string id, string tenkh, string diachi, float khoiluong):this(id)
        {
            TenKhachHang = tenkh ;
            DiaChi = diachi ;
            KhoiLuong = khoiluong ;
            PhiDichVu = TongPhiDichVu();

        }

        public virtual double TongPhiDichVu()
        {
            return KhoiLuong * 8000;
        }
    }

    internal class GiaoHangNhanh:GiaoHangTieuChuan
    {
        public double PhiThem { get; set; } = 5000;

        public GiaoHangNhanh()
        {
            
        }

        public GiaoHangNhanh(string id)
        {
            MaDonHang = id == null ? $"GHN{++autoID}" : id;
        }

        public GiaoHangNhanh(string id, string tenkh, string diachi, float khoiluong):this(id)
        {
            TenKhachHang = tenkh;
            DiaChi = diachi;
            KhoiLuong = khoiluong;
            PhiDichVu = TongPhiDichVu();
        }

        public double TongPhiThem()
        {
            return PhiThem * KhoiLuong;
        }
        public override double TongPhiDichVu()
        {
            return 10000 + TongPhiThem();    
        }
    }
}
