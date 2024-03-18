using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THISINH_BasicToMordern.Data;
using THISINH_BasicToMordern.Models;

namespace THISINH_BasicToMordern.XuLyDuLieu
{
    public class XuLyDuLieuPhongThi
    {
        DLKL data = new DLKL();

        public XuLyDuLieuPhongThi(DLKL data)
        {
            this.data = data;
        }

        public void LuuDuLieuPhongThi(PhongThi p)
        {
            data.PhongThis.Add(p);
        }

        public List<PhongThi> LayDuLieuPhongThi()
        {
            return data.PhongThis;
        }

        public List<PhongThi> TimTheoTenKhoi(string tenkhoi)
        {
            var listphongthi = new List<PhongThi>();
            foreach (var i in data.PhongThis)
            {
                if (tenkhoi == i.KhoiLop.TenKhoiLop)
                {
                    listphongthi.Add(i);
                }
            }
            return listphongthi;
        }
    }
}
