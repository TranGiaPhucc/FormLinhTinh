using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALMonHoc
    {
        LinQDataContext linq = new LinQDataContext();
        public DALMonHoc()
        {

        }

        public List<MonHoc> LoadMonHoc()
        {
            return linq.MonHocs.Select(t => t).ToList<MonHoc>();
        }
    }
}
