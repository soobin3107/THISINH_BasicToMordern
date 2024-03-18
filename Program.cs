using System;
using THISINH_BasicToMordern.Data;
using THISINH_BasicToMordern.Models;
using THISINH_BasicToMordern.XuLyDuLieu;
using THISINH_BasicToMordern.XuLyGiaoDien;

namespace THISINH_BasicToMordern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                // Tạo đối tượng DLKL ở đây nếu cần
                DLKL data = new DLKL();

                // Tạo đối tượng XuLyGiaoDien
                var xuLyGiaoDien = new THISINH_BasicToMordern.XuLyGiaoDien.XuLyGiaoDien(data); // Thay data bằng đối tượng DLKL nếu cần

                // Gọi phương thức GiaoDien để chạy chương trình
                xuLyGiaoDien.GiaoDien();
            }
        }
    }
}