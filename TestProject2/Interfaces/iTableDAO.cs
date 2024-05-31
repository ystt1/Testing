using QLQCF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Interfaces
{
    public interface ITableDAO
    {
        List<Table> LoadTableList();
        Table FindTableById(int id);
        void AddTable(Table table);
        void UpdateTable(Table table);
        // Các phương thức khác liên quan đến việc quản lý bàn
    }

}
