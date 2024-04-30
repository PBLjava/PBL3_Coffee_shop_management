﻿using PBL3.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL3.GUI.Admin
{
    public partial class NguyenLieu : Form
    {
        public NguyenLieu()
        {
            InitializeComponent();
        }

        private void NLExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void addNL_Click(object sender, EventArgs e)
        {
            ThemNguyenLieu f = new ThemNguyenLieu();
            this.Hide();
            f.ShowDialog();
            this.Show();
            NLData.DataSource = NguyenLieu_BLL.Instance.GetListNguyenLieu(0, null);
        }

        private void editNL_Click(object sender, EventArgs e)
        {
            int Manl = 0;
            if (NLData.SelectedRows.Count == 1)
            {
                Manl = Convert.ToInt32(NLData.SelectedRows[0].Cells["MaNL"].Value.ToString());
            }
            SuaNguyenLieu f = new SuaNguyenLieu();
            f.GetThongTin(Manl);
            this.Hide();
            f.ShowDialog();
            this.Show();
            NLData.DataSource = NguyenLieu_BLL.Instance.GetListNguyenLieu(0, null);
        }

        private void clearNL_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (NLData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in NLData.SelectedRows)
                    {
                        int Manl = Convert.ToInt32(NLData.SelectedRows[0].Cells["MaNL"].Value.ToString());
                        NguyenLieu_BLL.Instance.DeleteNguyenLieu(Manl);
                    }
                    NLData.DataSource = NguyenLieu_BLL.Instance.GetListNguyenLieu(0, null);
                }
            }
        }

        private void NguyenLieu_Load(object sender, EventArgs e)
        {
            NLData.DataSource = NguyenLieu_BLL.Instance.GetListNguyenLieu(0, null);
        }

        private void searchNL_Click(object sender, EventArgs e)
        {
            string txt = nameNLTb.Text;
            NLData.DataSource = NguyenLieu_BLL.Instance.GetListNguyenLieu(0, txt);
        }
    }
}