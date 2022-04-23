using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLLop
    {
        DALLop dalLop = new DALLop();
        public BLLLop()
        {

        }

        public List<Lop> LoadLop(String pMaKhoa)
        {
            return dalLop.LoadLop(pMaKhoa);
        }
    }
}
