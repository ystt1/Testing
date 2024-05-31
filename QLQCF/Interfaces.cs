using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCFTest
{
    public interface IAccountDAO
    {
        bool Login(string userName, string passWord);
        bool UpdateAccountProfile(String name, String displayName, String passWord, String newPass);
    }

    public interface IMessageBoxService
    {
        DialogResult Show(string text);
        // Add other overloads of Show() as needed
    }

    public class MessageBoxService : IMessageBoxService
    {
        public DialogResult Show(string text)
        {
            return MessageBox.Show(text);
        }
        // Implement other overloads of Show() as needed
    }
}
