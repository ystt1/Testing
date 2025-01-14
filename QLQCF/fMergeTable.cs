﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQCF.DAO;
using QLQCF.DTO;
using QLQCFTest.DAO;
using QLQCFTest.DTO;

namespace QLQCF
{

    public partial class fMergeTable : Form
    {
        public String messageText;
        fTableManager ftableManager;
        Table table;
        public fMergeTable(Table tabel, fTableManager ftablemanager)
        {
            ftableManager = ftablemanager;
            table = tabel;
            InitializeComponent();
            LoadfMergeTable();

        }

        private void LoadfMergeTable()
        {
            cbTableResult.Items.Clear();
            lbNameTable.Text = table.Name;
            List<Table> lTable = TableDAO.Instance.GetListTableUnEmptyandExceptChoose(table);

            cbTableCanMerge.DataSource = lTable;
            cbTableCanMerge.DisplayMember = "name";
            cbTableResult.Items.Clear();
            cbTableResult.Items.Add(table);
            Table tablefirstchoose = lTable[0];
            cbTableResult.Items.Add(tablefirstchoose);
            cbTableResult.Tag = tablefirstchoose;
            cbTableResult.DisplayMember = "name";


        }


        private void btnMergeTable_Click(object sender, EventArgs e)
        {
            Table table1 = cbTableResult.Tag as Table;
            MergeTable(table, table1, BillDAO.Instance.CheckEmpty(table), BillDAO.Instance.CheckEmpty(table1));
        }

        public void MergeTable(Table table1, Table table2, bool empty1, bool empty2)
        {

            if (cbTableResult.Text == "")
            {
                messageText = "Bàn sau khi gộp không được trống";
            }
            else
            {
                if (table1 == null || table2 == null)
                {
                    messageText = "Bàn cần gộp không tồn tại";
                }
                else
                {
                    if (empty1 || empty2)
                    {
                        messageText = "1 trong 2 bàn không còn gì để gộp!";
                    }
                    else
                    {
                        if (cbTableResult.Text == table.Name)
                        {
                            BillDAO.Instance.Mergetable(table2, table1);
                        }
                        else
                        {
                            BillDAO.Instance.Mergetable(table1, table2);
                        }
                        messageText = "Gộp bàn thành công!";
                        Shop shop = ShopDAO.Instance.GetShop();
                        ftableManager.LoadForm(shop);
                        this.Hide();
                    }
                }
            }
            MessageBox.Show(messageText);
        }

        private void cbTableCanMerge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TableDAO.Instance.GetTableWithName(cbTableCanMerge.Text) == null)
            {
            }
            else
            {
                cbTableResult.Items.Clear();
                cbTableResult.Items.Add(table);
                cbTableResult.Items.Add(TableDAO.Instance.GetTableWithName(cbTableCanMerge.Text));
                cbTableResult.DisplayMember = "name";
                cbTableResult.Tag = TableDAO.Instance.GetTableWithName(cbTableCanMerge.Text);
            }
        }

        private void fMergeTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            Shop shop = ShopDAO.Instance.GetShop();
            ftableManager.LoadForm(shop);
        }

        private void txbCanNotChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void fMergeTable_Load(object sender, EventArgs e)
        {

        }
    }
}
