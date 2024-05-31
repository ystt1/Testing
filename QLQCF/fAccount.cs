using QLQCF.DAO;
using QLQCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQCFTest
{
    public partial class fAccount : Form
    {
        public String messageText;
        private Account acc;
        public AccountDAO accDAO;
        public Account Acc { get => acc; set => acc = value; }

        public fAccount(Account useracc)
        {
            InitializeComponent();

            acc = useracc;

            ChangeAccount(acc);
        }

        public fAccount(Account useracc, IAccountDAO iacc)
        {
            InitializeComponent();
            acc = useracc;
            accDAO = (AccountDAO?)iacc;
            ChangeAccount(acc);
        }

        void ChangeAccount(Account acc)
        {
            txbUserName.Text = acc.UserName;
            txbDisplayUserName.Text = acc.DisplayName;
        }

        public void UpdateAccount()
        {
            string displayName = txbDisplayUserName.Text;
            string password = txbPassword.Text;
            string newpass = txbNewPass.Text;
            string repass = txbRePass.Text;

            if (displayName == "")
            {
                messageText = "Tên hiển thị không được trống";
                return;
            }
            if (password == "")
            {
                messageText = "Mật khẩu không được trống";
                return;
            }
            if (newpass == "")
            {
                messageText = "Mật khẩu mới không được trống";
                return;
            }
            if (repass == "")
            {
                messageText = "Nhập lại mật khẩu không được trống";
                return;
            }
            if (!newpass.Equals(repass))
            {
                messageText = "Nhập lại mật khẩu và mật khẩu không trùng";
            }
            else
            {
                if (accDAO.UpdateAccountProfile(acc.UserName, displayName, password, newpass))
                {
                    messageText = "Cập nhật thành công!";
                }
                else
                {
                    messageText = "Vui lòng điền đúng mật khẩu!";
                }
            }

            MessageBox.Show(messageText);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            UpdateAccount();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
