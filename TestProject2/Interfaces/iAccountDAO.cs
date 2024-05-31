using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Interfaces
{
    public interface iAccountDAO
    {
        bool UpdateAccountProfile(String name, String displayName, String passWord, String newPass);
    }
}
