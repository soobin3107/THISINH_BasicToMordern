using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THISINH_BasicToMordern.Data;
using THISINH_BasicToMordern.Models;

namespace THISINH_BasicToMordern.XuLyDuLieu
{
    public class XuLyDuLieuThiSinh
    {
        private DLKL data;

        public XuLyDuLieuThiSinh(DLKL data)
        {
            this.data = data;
        }

        public void ThemThiSinh(ThiSinh thiSinh)
        {
            // Thêm thí sinh vào dữ liệu
            data.ThemThiSinh(thiSinh);
        }

        public List<ThiSinh> LayDuLieuThiSinh()
        {
            // Lấy dữ liệu thí sinh từ dữ liệu
            return data.LayDanhSachThiSinh();
        }

        public void LuuDuLieuThiSinh(ThiSinh ts)
        {
            data.ThiSinhs.Add(ts);
        }

        public List<ThiSinh> LayDuLieuThiSinhFromData()
        {
            return data.ThiSinhs;
        }

        public List<ThiSinh> TimTheoMaPhong(string maPhong)
        {
            var listThiSinh = new List<ThiSinh>();
            foreach (var thiSinh in data.ThiSinhs)
            {
                // Kiểm tra xem thiSinh có thuộc phòng có mã maPhong hay không
                if (thiSinh.MaPhong == maPhong)
                {
                    listThiSinh.Add(thiSinh);
                }
            }
            return listThiSinh;
        }
    }
}
