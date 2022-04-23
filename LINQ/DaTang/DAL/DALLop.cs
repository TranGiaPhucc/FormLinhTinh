using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALLop
    {
        LinQDataContext qlsv = new LinQDataContext();
        public DALLop()
        {

        }

        public List<Lop> LoadLop(String pMaKhoa)
        {
            var kq = from lop in qlsv.Lops where lop.MaKhoa == pMaKhoa select lop;
            return kq.ToList<Lop>(); 
        }
    }
}
