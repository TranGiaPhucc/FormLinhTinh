using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALDangNhap
    {
        QLDangNhapDataContext qldn = new QLDangNhapDataContext();
        public DALDangNhap()
        {

        }

        public List<DangNhap> LoadDangNhap()
        {
            return qldn.DangNhaps.Select(t => t).ToList<DangNhap>();
        }
    }
}
