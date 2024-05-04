﻿using PBL3.BUS;
using PBL3.GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class ThucDon : Form
    {
        private int maNV;

        public ThucDon()
        {
            InitializeComponent();
        }

        public ThucDon(int maNV)
        {
            this.maNV = maNV;

            InitializeComponent();
            ten.Text = NhanVien_BLL.Instance.getTenNV(maNV);

            ThucDonData.DataSource = SanPham_BLL.Instance.GetListSanPham(0, null);
            RefreshData();
        }

        private void RefreshData()
        {
            //p.MaSP, p.TenSP, p.LoaiSP, p.NhomSP, p.DonViSP, p.GiaSP
            if (ThucDonData.Columns["MaSP"] != null)
            {
                ThucDonData.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            }
            if (ThucDonData.Columns["TenSP"] != null)
            {
                ThucDonData.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            }
            if (ThucDonData.Columns["LoaiSP"] != null)
            {
                ThucDonData.Columns["LoaiSP"].HeaderText = "Loại sản phẩm";
            }   
            if (ThucDonData.Columns["NhomSP"] != null)
            {
                ThucDonData.Columns["NhomSP"].HeaderText = "Nhóm sản phẩm";
            }
            if (ThucDonData.Columns["DonViSP"] != null)
            {
                ThucDonData.Columns["DonViSP"].HeaderText = "Đơn vị";
            }
            if (ThucDonData.Columns["GiaSP"] != null)
            {
                ThucDonData.Columns["GiaSP"].HeaderText = "Giá";
            }
        }

        private void addSp_Click(object sender, EventArgs e)
        {
            ThemMon f = new ThemMon(maNV);
            this.Hide();
            f.ShowDialog();
            this.Show();
            ThucDonData.DataSource = SanPham_BLL.Instance.GetListSanPham(0, null);
        }

        private void ThucDon_Load(object sender, EventArgs e)
        {
            ThucDonData.DataSource = SanPham_BLL.Instance.GetListSanPham(0, null);
        }

        private void editSP_Click(object sender, EventArgs e)
        {
            int Masp = 0;
            if (ThucDonData.SelectedRows.Count == 1)
            {
                Masp = Convert.ToInt32(ThucDonData.SelectedRows[0].Cells["MaSP"].Value.ToString());
            }
            SuaMon f = new SuaMon();
            f.GetThongTin(Masp);
            this.Hide();
            f.ShowDialog();
            this.Show();
            ThucDonData.DataSource = SanPham_BLL.Instance.GetListSanPham(0, null);
        }

        private void deleteSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ThucDonData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in ThucDonData.SelectedRows)
                    {
                        int Masp = Convert.ToInt32(ThucDonData.SelectedRows[0].Cells["MaSP"].Value.ToString());
                        SanPham_BLL.Instance.DeleteSanPham(Masp);
                    }
                    ThucDonData.DataSource = SanPham_BLL.Instance.GetListSanPham(0, null);
                }
            }
        }

        private void exitSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManHinhChinh manHinhChinh = new ManHinhChinh(maNV);
            manHinhChinh.Show();
            this.Close();
        }
    }
}
