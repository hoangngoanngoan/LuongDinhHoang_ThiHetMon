namespace LuongDinhHoang_ThiHetMon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<GiaoHangTieuChuan> ds1 = new List<GiaoHangTieuChuan>();
        List<GiaoHangNhanh> ds2 = new List<GiaoHangNhanh>();
        double doanhthu = 0;


        private void btnthem1_Click(object sender, EventArgs e)
        {
            var tenkh = txttenkh1.Text;
            var diachi = txtdiachi1.Text;
            var khoiluong = float.Parse(txtkhoiluong1.Text);
            var newor = new GiaoHangTieuChuan(null, tenkh, diachi, khoiluong);

            ds1.Add(newor);
            dt1.DataSource = null;
            dt1.DataSource = ds1;
            lbdoanhthu.Text = TongDoanhThu().ToString();
        }

        private void btnthem2_Click(object sender, EventArgs e)
        {
            var tenkh = txttenkh2.Text;
            var diachi = txtdiachi2.Text;
            var khoiluong = float.Parse(txtkhoiluong2.Text);
            var newor = new GiaoHangNhanh(null, tenkh, diachi, khoiluong);

            ds2.Add(newor);
            dt2.DataSource = null;
            dt2.DataSource = ds2;
            lbdoanhthu.Text = TongDoanhThu().ToString();
        }

        private void btnxoa1_Click(object sender, EventArgs e)
        {
            var madh = txtmadonhang1.Text;
            foreach (var i in ds1)
            {
                if (i.MaDonHang == madh)
                {
                    ds1.Remove(i);
                    break;
                }
            }
            dt1.DataSource = null;
            dt1.DataSource = ds1;
            lbdoanhthu.Text = TongDoanhThu().ToString();
        }

        private void btnxoa2_Click(object sender, EventArgs e)
        {
            var madh = txtmadonhang2.Text;
            foreach (var i in ds2)
            {
                if (i.MaDonHang == madh)
                {
                    ds2.Remove(i);
                    break;
                }
            }
            dt2.DataSource = null;
            dt2.DataSource = ds2;
            lbdoanhthu.Text = TongDoanhThu().ToString();
        }

        private void btnsua1_Click(object sender, EventArgs e)
        {
            var madh = txtmadonhang1.Text;
            foreach (var i in ds1)
            {
                if (i.MaDonHang == madh)
                {
                    i.TenKhachHang = txttenkh1.Text;
                    i.DiaChi = txtdiachi1.Text;
                    i.KhoiLuong = float.Parse(txtkhoiluong1.Text);
                    i.PhiDichVu = i.TongPhiDichVu();
                    break;
                }
            }
            dt1.DataSource = null;
            dt1.DataSource = ds1;
            lbdoanhthu.Text = TongDoanhThu().ToString();
        }

        private void btnsua2_Click(object sender, EventArgs e)
        {
            var madh = txtmadonhang2.Text;
            foreach (var i in ds2)
            {
                if (i.MaDonHang == madh)
                {
                    i.TenKhachHang = txttenkh2.Text;
                    i.DiaChi = txtdiachi2.Text;
                    i.KhoiLuong = float.Parse(txtkhoiluong2.Text);
                    i.PhiDichVu = i.TongPhiDichVu();
                    break;
                }
            }
            dt2.DataSource = null;
            dt2.DataSource = ds2;
            lbdoanhthu.Text = TongDoanhThu().ToString();
        }

        private double TongDoanhThu()
        {
            doanhthu = 0;
            foreach (var i in ds1)
            {
                doanhthu += i.PhiDichVu;
            }
            foreach (var i in ds2)
            {
                doanhthu += i.PhiDichVu;
            }
            return doanhthu;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tổng doanh thu trong ngày là {doanhthu}");
        }
    }
}
