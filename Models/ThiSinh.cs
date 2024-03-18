using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THISINH_BasicToMordern.Models
{
    public class ThiSinh
    {
        public string MaThiSinh { get; set; }
        public float DiemToan { get; set; }
        public float DiemLy { get; set; }
        public float DiemHoa { get; set; }
        public float DiemTong { get; set; }
        public string TenThiSinh { get; set; }
        public string MaPhong { get; set; }
        public PhongThi Phong { get; set; }
    }
}
