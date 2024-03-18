using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THISINH_BasicToMordern.Data;
using THISINH_BasicToMordern.Models;

namespace THISINH_BasicToMordern.XuLyDuLieu
{
    public class XuLyDuLieuKhoiLop
    {
        DLKL data;

        public XuLyDuLieuKhoiLop(DLKL data)
        {
            this.data = data;
        }

        public void LuuKhoiLopMoi(KhoiLop khoi)
        {
            data.KhoiLops.Add(khoi);
        }

        public List<KhoiLop> LayDuLieuKhoiLop()
        {
            return data.KhoiLops;
        }
    }
}
