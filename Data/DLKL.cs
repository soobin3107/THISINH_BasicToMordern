using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THISINH_BasicToMordern.Models;

namespace THISINH_BasicToMordern.Data
{
    public class DLKL
    {
        public List<KhoiLop> KhoiLops { get; set; }
        public List<PhongThi> PhongThis { get; set; }
        public List<ThiSinh> ThiSinhs { get; set; }

        public DLKL()
        {
            KhoiLops = new List<KhoiLop>();
            PhongThis = new List<PhongThi>();
            ThiSinhs = new List<ThiSinh>();
            ThiSinhs = new List<ThiSinh>();
        }

        public List<ThiSinh> LayDanhSachThiSinh()
        {
            return ThiSinhs;
        }

        public void ThemThiSinh(ThiSinh thiSinh)
        {
            ThiSinhs.Add(thiSinh);
        }
    }
}
