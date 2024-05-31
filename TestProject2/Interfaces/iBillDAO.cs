using QLQCF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Interfaces
{
    public interface IBillDAO
    {
        bool CheckEmpty(Table table);
        Bill GetUnCheckBillwithtable(Table table);
    }
}
