using System;
using THISINH_BasicToMordern.Models;
using THISINH_BasicToMordern.XuLyDuLieu;

namespace THISINH_BasicToMordern.XuLyGiaoDien
{
    public class XuLyGiaoDienThiSinh
    {
        XuLyDuLieuThiSinh xl;
        public XuLyGiaoDienThiSinh(XuLyDuLieuThiSinh xl)
        {
            this.xl = xl;
        }

        public ThiSinh NhapThiSinh(PhongThi ph)
        {
            var ts = new ThiSinh();
            ts.Phong = ph;
            Console.Write("Nhập Mã Thí Sinh: ");
            ts.MaThiSinh = Console.ReadLine();
            Console.Write("Nhập tên thí sinh: ");
            ts.TenThiSinh = Console.ReadLine();
            Console.Write("Nhập Điểm Toán: ");
            ts.DiemToan = float.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Lý: ");
            ts.DiemLy = float.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Hóa: ");
            ts.DiemHoa = float.Parse(Console.ReadLine());

            ts.DiemTong = ts.DiemToan + ts.DiemLy + ts.DiemHoa;
            return ts;
        }

        public void NhapDuLieu(PhongThi ph, ThiSinh ts)
        {
            ts = NhapThiSinh(ph);
            xl.LuuDuLieuThiSinh(ts);
        }

        public void XuatThiSinh(ThiSinh ts)
        {
            Console.WriteLine($"Mã Thí Sinh: {ts.MaThiSinh}");
            Console.WriteLine($"Tên Thí Sinh: {ts.TenThiSinh}");
            Console.WriteLine($"Điểm Toán: {ts.DiemToan}");
            Console.WriteLine($"Điểm Lý: {ts.DiemLy}");
            Console.WriteLine($"Điểm Hóa: {ts.DiemHoa}");
            Console.WriteLine($"Điểm Tổng: {ts.DiemTong}");
        }
    }
}
