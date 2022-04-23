using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLDangNhap
    {
        DALDangNhap dal = new DALDangNhap();
        public BLLDangNhap()
        {

        }

        public List<DangNhap> LoadDangNhap()
        {
            return dal.LoadDangNhap();
        }
    }
}
