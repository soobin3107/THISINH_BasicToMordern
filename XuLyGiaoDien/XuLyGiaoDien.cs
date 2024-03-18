using System;
using System.Collections.Generic;
using System.Linq;
using THISINH_BasicToMordern.Data;
using THISINH_BasicToMordern.Models;
using THISINH_BasicToMordern.XuLyDuLieu;

namespace THISINH_BasicToMordern.XuLyGiaoDien
{
    public class XuLyGiaoDien
    {
        private readonly DLKL data;
        private readonly Dictionary<string, List<ThiSinh>> danhSachThiSinhTheoPhong = new Dictionary<string, List<ThiSinh>>();
        private string maphong;

        public XuLyGiaoDien(DLKL data)
        {
            this.data = data;
        }

        public void GiaoDien()
        {
            var xulydulieuthisinh = new XuLyDuLieuThiSinh(data);
            var xulydulieuphongthi = new XuLyDuLieuPhongThi(data);

            do
            {
                Console.WriteLine("1. Nhập Thông Tin Thí Sinh");
                Console.WriteLine("2. Xuất Thông Tin Thí Sinh");
                Console.WriteLine("3. Chỉnh Sửa Thông Tin Thí Sinh Trong Phòng Thi");
                Console.WriteLine("4. Thay Đổi Phòng Thi của Thí Sinh");
                Console.WriteLine("5. Xóa Dữ Liệu của Thí Sinh");
                Console.WriteLine("6. Thoát Chương Trình");
                Console.Write("Nhập lựa chọn của bạn: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    continue;
                }

                Console.Clear();
                switch (choice)
                {
                    case 1:
                        NhapDSTS();
                        break;
                    case 2:
                        XuatDSTS();
                        break;
                    case 3:
                        ChinhSuaDSTS();
                        break;
                    case 4:
                        ThayDoiPhongThi();
                        break;
                    case 5:
                        XoaDSTS();
                        break;
                    case 6:
                        Console.WriteLine("Thoát chương trình...");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            } while (true);
        }

        public void NhapDSTS()
        {
            var xulydulieuthisinh = new XuLyDuLieuThiSinh(data);
            var xulydulieuphongthi = new XuLyDuLieuPhongThi(data);

            do
            {
                Console.WriteLine("\n1. Nhập Thí Sinh cho Phòng \n2. Quay về");
                Console.Write("Nhập lựa chọn của bạn: ");
                int n2;
                if (!int.TryParse(Console.ReadLine(), out n2))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
                }
                Console.Clear();
                if (n2 != 1)
                {
                    break;
                }

                Console.Write("Nhập Mã Phòng của Thí Sinh: ");
                maphong = Console.ReadLine();
                Console.Clear();

                if (!danhSachThiSinhTheoPhong.ContainsKey(maphong))
                {
                    danhSachThiSinhTheoPhong[maphong] = new List<ThiSinh>();
                }

                List<ThiSinh> danhSachThiSinh = danhSachThiSinhTheoPhong[maphong];

                var thiSinh = new ThiSinh();
                Console.WriteLine($"Nhập Thí Sinh cho Phòng {maphong}");
                Console.Write("Nhập Mã Thí Sinh: ");
                thiSinh.MaThiSinh = Console.ReadLine();
                Console.Write("Nhập Tên Thí Sinh: ");
                thiSinh.TenThiSinh = Console.ReadLine();
                Console.Write("Nhập Điểm Toán: ");
                thiSinh.DiemToan = float.Parse(Console.ReadLine());
                Console.Write("Nhập Điểm Lý: ");
                thiSinh.DiemLy = float.Parse(Console.ReadLine());
                Console.Write("Nhập Điểm Hóa: ");
                thiSinh.DiemHoa = float.Parse(Console.ReadLine());

                thiSinh.DiemTong = thiSinh.DiemToan + thiSinh.DiemLy + thiSinh.DiemHoa;

                danhSachThiSinh.Add(thiSinh);
                Console.Clear();
            } while (true);
        }

        public void XuatDSTS()
        {
            Console.Write("Nhập Mã Phòng của Thí Sinh: ");
            string maPhong = Console.ReadLine();
            Console.Clear();

            if (danhSachThiSinhTheoPhong.ContainsKey(maPhong))
            {
                List<ThiSinh> danhSachThiSinh = danhSachThiSinhTheoPhong[maPhong];
                Console.WriteLine($"Danh sách thí sinh của Phòng {maPhong}");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Mã Phòng\tMã Thí Sinh\tHọ Tên\t\t\tĐiểm Toán\tĐiểm Lý\t\tĐiểm Hóa\tĐiểm Tổng");

                foreach (var thiSinh in danhSachThiSinh)
                {
                    Console.WriteLine($"{maPhong}\t\t{thiSinh.MaThiSinh}\t{thiSinh.TenThiSinh.PadRight(24)}{thiSinh.DiemToan}\t\t{thiSinh.DiemLy}\t\t{thiSinh.DiemHoa}\t\t{thiSinh.DiemTong}");
                }

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy Phòng Thi có mã {maPhong}");
            }
        }


        public void ChinhSuaDSTS()
        {
            var xulydulieuthisinh = new XuLyDuLieuThiSinh(data);
            Console.Write("Nhập mã thí sinh cần chỉnh sửa: ");
            string maThiSinh = Console.ReadLine();
            var thiSinhCanChinhSua = xulydulieuthisinh.LayDuLieuThiSinh().FirstOrDefault(ts => ts.MaThiSinh == maThiSinh);
            if (thiSinhCanChinhSua != null)
            {
                Console.WriteLine("Nhập thông tin mới cho thí sinh:");
                Console.Write("Tên thí sinh: ");
                thiSinhCanChinhSua.TenThiSinh = Console.ReadLine();
                Console.Write("Điểm Toán: ");
                thiSinhCanChinhSua.DiemToan = float.Parse(Console.ReadLine());
                Console.Write("Điểm Lý: ");
                thiSinhCanChinhSua.DiemLy = float.Parse(Console.ReadLine());
                Console.Write("Điểm Hóa: ");
                thiSinhCanChinhSua.DiemHoa = float.Parse(Console.ReadLine());
                thiSinhCanChinhSua.DiemTong = thiSinhCanChinhSua.DiemToan + thiSinhCanChinhSua.DiemLy + thiSinhCanChinhSua.DiemHoa;
                Console.WriteLine("Thông tin thí sinh đã được cập nhật.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy thí sinh có mã " + maThiSinh);
            }
        }

        public void ThayDoiPhongThi()
        {
            var xulydulieuthisinh = new XuLyDuLieuThiSinh(data);
            var xulydulieuphongthi = new XuLyDuLieuPhongThi(data);
            Console.Write("Nhập mã thí sinh cần thay đổi phòng thi: ");
            string maThiSinh = Console.ReadLine();
            var thiSinhCanThayDoiPhong = xulydulieuthisinh.LayDuLieuThiSinh().FirstOrDefault(ts => ts.MaThiSinh == maThiSinh);
            if (thiSinhCanThayDoiPhong != null)
            {
                Console.WriteLine("Nhập mã phòng mới cho thí sinh:");
                foreach (var phongThi in xulydulieuphongthi.LayDuLieuPhongThi())
                {
                    Console.WriteLine(phongThi.MaPhong + "\t| " + phongThi.TenPhong);
                }
                Console.Write("Mã phòng mới: ");
                string maPhongMoi = Console.ReadLine();
                var phongMoi = xulydulieuphongthi.LayDuLieuPhongThi().FirstOrDefault(pt => pt.MaPhong == maPhongMoi);
                if (phongMoi != null)
                {
                    thiSinhCanThayDoiPhong.Phong = phongMoi;
                    Console.WriteLine("Phòng thi của thí sinh đã được thay đổi.");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy Phòng Thi có mã " + maPhongMoi);
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy thí sinh có mã " + maThiSinh);
            }
        }

        public void XoaDSTS()
        {
            var xulydulieuthisinh = new XuLyDuLieuThiSinh(data);
            Console.Write("Nhập mã thí sinh cần xóa: ");
            string maThiSinh = Console.ReadLine();
            var thiSinhCanXoa = xulydulieuthisinh.LayDuLieuThiSinh().FirstOrDefault(ts => ts.MaThiSinh == maThiSinh);
            if (thiSinhCanXoa != null)
            {
                xulydulieuthisinh.LayDuLieuThiSinh().Remove(thiSinhCanXoa);
                Console.WriteLine("Thí sinh có mã " + maThiSinh + " đã được xóa.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy thí sinh có mã " + maThiSinh);
            }
        }
    }
}
