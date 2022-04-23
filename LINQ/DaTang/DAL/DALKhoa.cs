using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALKhoa
    {
        LinQDataContext qlsv = new LinQDataContext();
        
        public DALKhoa()
        {

        }

        public List<Khoa> LoadKhoa()
        {
            return qlsv.Khoas.Select(t => t).ToList<Khoa>();
        }
    }

}
