using System;
using THISINH_BasicToMordern.Models;
using THISINH_BasicToMordern.XuLyDuLieu;

namespace THISINH_BasicToMordern.XuLyGiaoDien
{
    public class XuLyGiaoDienKhoiLop
    {
        XuLyDuLieuKhoiLop xl;
        public XuLyGiaoDienKhoiLop(XuLyDuLieuKhoiLop xl)
        {
            this.xl = xl;
        }

        public void XuatKhoiLop(KhoiLop khoi)
        {
            Console.WriteLine($"Số Thứ Tự: {khoi.SoThuTu}\tTên Khối Lớp: {khoi.TenKhoiLop}");
        }
    }
}
