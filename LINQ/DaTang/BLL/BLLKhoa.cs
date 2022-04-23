using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLKhoa
    {
        DALKhoa dal = new DALKhoa();
        public BLLKhoa()
        {

        }

        public List<Khoa> LoadKhoa()
        {
            return dal.LoadKhoa();
        }


    }
}
