using System;
using QLQCF.DAO;
using QLQCF.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQCFTest.DAO;
using QLQCFTest.DTO;

namespace QLQCF
{
    public partial class fSwitchTable : Form
    {
       
        Table tabel;
        fTableManager ftableManager;
        public String messageText;
        public fSwitchTable(Table table,fTableManager fManager)
        {
            ftableManager = fManager;
            tabel = table;
            InitializeComponent();
            LoadFSwitchTable();
        }

        
        private void LoadFSwitchTable()
        {
            lbTableName.Text = tabel.Name;
            List<Table> tables = TableDAO.Instance.LoadTableListExcept(tabel.Id);
            cbListTableCanSwitch.DataSource = tables;
            cbListTableCanSwitch.DisplayMember = "name";
        }
        
        public void btnSwitchTable_Click(object sender, EventArgs e)
        {
            string nameTableChangTo = cbListTableCanSwitch.Text;
            Table tableChangeTo = TableDAO.Instance.GetTableWithName(nameTableChangTo);
            if (tableChangeTo != null)
            {
                SwitchTable(tabel, tableChangeTo, BillDAO.Instance.CheckEmpty(tabel), BillDAO.Instance.CheckEmpty(tableChangeTo));
            }
        }

        public void SwitchTable(Table table,Table ChangeTo,bool CheckEmpty1,bool CheckEmty2)
        {
            if (table == null)
            {
                messageText = "Không tìm thấy bàn hiện tại";
            }
            else
            {
                
                if (ChangeTo == null)
                {
                    messageText = "Không tìm thấy bàn để chuyển qua";
                }
                else
                {
                    if (CheckEmpty1 && CheckEmty2)
                    {
                        messageText = "Không thể chuyển bàn vì cả 2 bàn đều không có người";
                    }
                    else
                    {
                        if (!CheckEmpty1 && !CheckEmty2)
                            messageText = "Không thể chuyển 2 bàn có người!";
                        else
                        {
                            BillDAO.Instance.SwitchTableBill(tabel.Id, ChangeTo.Id);
                            MessageBox.Show("Chuyển bàn thành công!");
                            this.Hide();
                            ftableManager.LoadForm(ShopDAO.Instance.GetShop());
                        }

                    }
                }
            }
            MessageBox.Show(messageText);
        }

        

        private void fSwitchTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            Shop shop = ShopDAO.Instance.GetShop();
            ftableManager.LoadForm(shop);
        }
    }
}
