using QLQCFTest;
using QLQCF.DTO;
using System;
using Xunit;
using QLQCF.DAO;
using QLQCF;
using System.Windows.Forms;
using Moq;
using QLQCFTest.DTO;
using QLQCFTest.DAO;
using TestProject2.Interfaces;


namespace TestQLQCF
{

 
    public class LoginTests
    {
        [Fact]
        public void Login_WithEmptyUsername_ShouldShowErrorMessage()
        {
            // Arrange
            var form = new fLogin();
            form.txbUserName.Text = "";
            form.txbPassWord.Text = "password";

            // Act
            form.btnLogin_Click(null, EventArgs.Empty);

            // Assert
            Assert.Equal("Trường Tên Đăng Nhập không được trống", form.messageBoxText);
        }

        [Fact]
        public void Login_WithEmptyPassword_ShouldShowErrorMessage()
        {
            // Arrange
            var form = new fLogin();
            form.txbUserName.Text = "username";
            form.txbPassWord.Text = "";

            // Act
            form.btnLogin_Click(null, EventArgs.Empty);

            // Assert
            Assert.Equal("Trường Mật Khẩu không được trống", form.messageBoxText);
        }

        [Fact]
        public void Login_WithInvalidCredentials_ShouldShowErrorMessage()
        {
            // Arrange
            var form = new fLogin();
            form.txbUserName.Text = "username";
            form.txbPassWord.Text = "wrongpassword";

            // Act
            form.btnLogin_Click(null, EventArgs.Empty);

            // Assert
            Assert.Equal("Sai tài khoản mật khẩu", form.messageBoxText);
        }

        [Fact ]
        public void Login_WithValidCredentials_ShouldLoginSuccessfully()
        {
            var userName = "admin";
            var passWord = "1";
            var accountDAO = new Mock<IAccountDAO>();
            accountDAO.Setup(dao => dao.Login(userName, passWord)).Returns(true);
            var form=new fLogin();
            form.txbUserName.Text = userName;
            form.txbPassWord.Text = passWord;

            // Act
            form.btnLogin_Click(null, EventArgs.Empty);

            // Assert
            Assert.Equal("đăng nhập thành công", form.messageBoxText);
        }

    }





    public class SwitchTableTests {
        [Fact]
        public void SwitchTable_WithInvalidName_ShouldShowError()
        {
            var form = new fSwitchTable(new Table(1, "valid table", "trống", 1, 1), new fTableManager(new Account("admin", "1", "admin", 1, 1)));

            //ACt
            form.SwitchTable(null, null, false, false);

            //assert
            Assert.Equal("Không tìm thấy bàn hiện tại", form.messageText);
        }
        [Fact]
        public void SwitchTable_WithInvalidNameChangeTo_ShouldShowError()
        {
            var form = new fSwitchTable(new Table(1, "valid table", "trống", 1, 1), new fTableManager(new Account("admin", "1", "admin", 1, 1)));

            //ACt
            form.SwitchTable(new Table(1, "valid table", "trống", 1, 1), null, false, false);

            //assert
            Assert.Equal("Không tìm thấy bàn để chuyển qua", form.messageText);
        }
        [Fact]
        public void SwitchTable_With2UnEmptyTable_ShouldShowError()
        {
            var form = new fSwitchTable(new Table(1, "valid table", "trống", 1, 1), new fTableManager(new Account("admin", "1", "admin", 1, 1)));

            //ACt
            form.SwitchTable(new Table(1, "valid table", "trống", 1, 1), new Table(1, "valid table", "trống", 1, 1), false, false);

            //assert
            Assert.Equal("Không thể chuyển 2 bàn có người!", form.messageText);
        }
        [Fact]
        public void SwitchTable_With2EmptyTable_ShouldShowError()
        {
            var form = new fSwitchTable(new Table(1, "valid table", "trống", 1, 1), new fTableManager(new Account("admin", "1", "admin", 1, 1)));

            //ACt
            form.SwitchTable(new Table(1, "valid table", "trống", 1, 1), new Table(1, "valid table", "trống", 1, 1), true, true);

            //assert
            Assert.Equal("Không thể chuyển bàn vì cả 2 bàn đều không có người", form.messageText);
        }
    }
    public class MergeTableTests
    {
        [Fact]
        public void MergeTable_WithEmptyNameTable_ShouldShowError() {
            var form = new fMergeTable(new Table(1, "valid table", "trống", 1, 1), new fTableManager(new Account("admin", "1", "admin", 1, 1)));
            //Act 
    
            form.MergeTable(null,null, true, true);

            //assert
            Assert.Equal("Bàn sau khi gộp không được trống", form.messageText);

        }

        [Fact]
        public void MergeTable_WithNoneExistTable_ShouldShowError()
        {
            var form = new fMergeTable(new Table(1, "valid table", "trống", 1, 1), new fTableManager(new Account("admin", "1", "admin", 1, 1)));
            //Act 
            form.cbTableResult.Text = "bàn 1";
            form.MergeTable(null,null, true, true);

            //assert
            Assert.Equal("Bàn cần gộp không tồn tại", form.messageText);

        }

        [Fact]
        public void MergeTable_With2EmptyTable_ShouldShowError()
        {
            var form = new fMergeTable(new Table(1, "valid table", "trống", 1, 1), new fTableManager(new Account("admin", "1", "admin", 1, 1)));
            //Act 
            form.cbTableResult.Text = "bàn 1";
            form.MergeTable(new Table(1, "valid table", "trống", 1, 1), new Table(1, "valid table", "trống", 1, 1), true, true);

            //assert
            Assert.Equal("1 trong 2 bàn không còn gì để gộp!", form.messageText);

        }
    }
    public class AccountTests
    {

        [Fact]
        public void Account_WithBlankDisplay_ShouldShowError()
        {
            //Arrange
            var form = new fAccount(new Account("validusername", "validpassword", "díplayname", 1, 1));

            //Act
            form.txbDisplayUserName.Text = "";
            form.UpdateAccount();

            //Assert
            Assert.Equal("Tên hiển thị không được trống", form.messageText);
        }

        [Fact]
        public void Account_WithBlankPass_ShouldShowError()
        {
            //Arrange
            var form = new fAccount(new Account("validusername", "validpassword", "díplayname", 1, 1));

            //Act
            form.txbDisplayUserName.Text = "abc";
            form.txbDisplayUserName.Text = "abc";
            form.txbPassword.Text = "pass1";
            form.txbNewPass.Text = "newpass";
            form.txbRePass.Text = "repass";
            form.txbPassword.Text = "";
            form.UpdateAccount();

            //Assert
            Assert.Equal("Mật khẩu không được trống", form.messageText);
        }

        [Fact]
        public void Account_WithBlankNewPass_ShouldShowError()
        {
            //Arrange
            var form = new fAccount(new Account("validusername", "validpassword", "díplayname", 1, 1));

            //Act
            form.txbDisplayUserName.Text = "abc";
            form.txbDisplayUserName.Text = "abc";
            form.txbPassword.Text = "pass1";
            form.txbNewPass.Text = "newpass";
            form.txbRePass.Text = "repass";
            form.txbNewPass.Text = "";
            form.UpdateAccount();

            //Assert
            Assert.Equal("Mật khẩu mới không được trống", form.messageText);
        }

        [Fact]
        public void Account_WithBlankRePass_ShouldShowError()
        {
            //Arrange
            var form = new fAccount(new Account("validusername", "validpassword", "díplayname", 1, 1));

            //Act
            form.txbDisplayUserName.Text = "abc";
            form.txbPassword.Text = "pass1";
            form.txbNewPass.Text = "newpass";

            form.txbRePass.Text = "";
            form.UpdateAccount();

            //Assert
            Assert.Equal("Nhập lại mật khẩu không được trống", form.messageText);
        }

        public void Account_WithNewPassAndRePassDiff_ShouldShowError()
        {
            //Arrange
            var form = new fAccount(new Account("validusername", "validpassword", "díplayname", 1, 1));

            //Act
            form.txbDisplayUserName.Text = "abc";
            form.txbPassword.Text = "pass1";
            form.txbNewPass.Text = "newpass";
            form.txbRePass.Text = "repass";

            form.UpdateAccount();

            //Assert
            Assert.Equal("Nhập lại mật khẩu và mật khẩu không trùng", form.messageText);
        }
        /*[Fact]
        public void Account_WithValidCHange_ShouldShowSuccess()
        {
            var mockDao = new Mock<IAccountDAO>();
            mockDao.Setup(m => m.UpdateAccountProfile(It.IsAny<String>(), It.IsAny<String>(), It.IsAny<String>(), It.IsAny<String>())).Returns(true);
            
            var form = new fAccount(new Account("validusername", "validpassword", "díplayname", 1, 1),mockDao.Object);

            //Act
            form.txbDisplayUserName.Text = "abc";
            form.txbPassword.Text = "pass1";
            form.txbNewPass.Text = "newpass";
            form.txbRePass.Text = "newpass";
            form.UpdateAccount(new Account("validusername", "validpassword", "díplayname", 1, 1));
            Assert.Equal("Cập nhật thành công!", form.messageText);
        }*/
    }

}



