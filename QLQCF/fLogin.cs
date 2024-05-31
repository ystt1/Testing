using QLQCF.DAO;
using QLQCF.DTO;
using QLQCFTest;
using QLQCFTest.DAO;
using QLQCFTest.DTO;

namespace QLQCF
{
    public partial class fLogin : Form
    {
        private readonly IMessageBoxService _messageBoxService;
        public fLogin(IMessageBoxService messageBoxService)
        {
            _messageBoxService = messageBoxService;
   
        }

        public fLogin()
        {
            InitializeComponent();
        }
        public String messageBoxText;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {    
            string userName = txbUserName.Text;
            string passWord =  txbPassWord.Text;
            if(userName=="")
            {
                messageBoxText = "Trường Tên Đăng Nhập không được trống";
                
            }
            else
            {
                if(passWord=="")
                {
                    messageBoxText = "Trường Mật Khẩu không được trống";
               
                }
                else
                {
                    if (Login(userName, passWord))
                    {
                        messageBoxText = "đăng nhập thành công";
                        Console.WriteLine(messageBoxText);
                        Account acc = AccountDAO.Instance.LoadUser(userName);
                        fTableManager f = new fTableManager(acc);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        txbPassWord.Text = null;

                    }
                    else
                    {
                        messageBoxText = "Sai tài khoản mật khẩu";
                        

                    }
                }    
            }
            MessageBox.Show(messageBoxText);
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        public void chbShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassWord.Checked)
            {
                txbPassWord.UseSystemPasswordChar = false;
            }
            else
                txbPassWord.UseSystemPasswordChar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            Shop shop = ShopDAO.Instance.GetShop();
            lbNameShop.Text = shop.NameShop;
        }
    }
}