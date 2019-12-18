using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.Dao;
using ControlLibrary.Model;
using DataLibrary.EF;

namespace ControlLibrary.UC.Display
{
    public partial class UC_UserProfile : UserControl
    {
        public UC_UserProfile()
        {
            InitializeComponent();
        }

        hoaDonDao _hoaDonDao = new hoaDonDao();

        private void cbb_KieuThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_KieuThongKe.SelectedIndex == 0)
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "MM/dd/yyyy";
                dateTimePicker1.Enabled = true;
                cbb_Quy.Enabled = false;
                cbb_Thang.Enabled = false;
            }
            if (cbb_KieuThongKe.SelectedIndex == 1)
            {
                dateTimePicker1.Enabled = false;
                cbb_Quy.Enabled = false;
                cbb_Thang.Enabled = true;
            }
            if (cbb_KieuThongKe.SelectedIndex == 2)
            {
                dateTimePicker1.Enabled = false;
                cbb_Thang.Enabled = false;
                cbb_Quy.Enabled = true;
            }
        }

        public List<Model_HoaDon> ListModel_HD(List<HOADON> ds)
        {
            List<Model_HoaDon> DS_HoaDon = new List<Model_HoaDon>();
            foreach (var item in ds)
            {
                Model_HoaDon model = new Model_HoaDon
                {
                    MaHD = item.MaHD,
                    MaKH = item.MaKH,
                    MaNV = item.MaNV,
                    DiaChi = item.DiaChi,
                    TongMatHang = item.TongMatHang,
                    TongTien = item.TongTien,
                    NgayLap = item.NgayLap,
                    NgayGiao = item.NgayGiao
                };
                DS_HoaDon.Add(model);
            }
            return DS_HoaDon;
        }

        private void UC_UserProfile_Load(object sender, EventArgs e)
        {
            dataGV_ThongKe.DataSource = ListModel_HD(_hoaDonDao.GetList());
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            int tongmathang = 0;
            int tongtien = 0;

            try
            {
                if (cbb_KieuThongKe.SelectedIndex == 0)
                {
                    string date = dateTimePicker1.Text;
                    for (int i = 0; i < dataGV_ThongKe.Rows.Count; i++)
                    {
                        if (dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(0, 10) == date)
                        {
                            tongmathang += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[4].Value.ToString());
                            tongtien += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[5].Value.ToString());
                        }
                        label_ketqua.Text = "Kết quả ngày " + dateTimePicker1.Text + "\nTổng mặt hàng được bán: " + tongmathang.ToString() + "\nTổng tiền: " + tongtien.ToString();
                    }
                }

                if (cbb_KieuThongKe.SelectedIndex == 1)
                {
                    string thang = (cbb_Thang.SelectedIndex + 1).ToString();
                    for (int i = 0; i < dataGV_ThongKe.Rows.Count; i++)
                    {
                        string thangdata;
                        if (dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(1, 1).ToString() == "/")
                            thangdata = dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(0, 1).ToString();
                        else
                            thangdata = dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(0, 2).ToString();
                        if ( thangdata == thang)
                        {
                            tongmathang += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[4].Value.ToString());
                            tongtien += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[5].Value.ToString());
                        }
                        label_ketqua.Text = "Kết quả tháng " + thang + "\nTổng mặt hàng được bán: " + tongmathang.ToString() + "\nTổng tiền: " + tongtien.ToString();
                    }
                }
                if (cbb_KieuThongKe.SelectedIndex == 2)
                {
                    int quy = cbb_Quy.SelectedIndex + 1;
                    for (int i = 0; i < dataGV_ThongKe.Rows.Count; i++)
                    {                      
                        if (quy == 1)
                        {
                            string quydata;
                            if (dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(1, 1).ToString() == "/")
                                quydata = dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(0, 1).ToString();
                            else
                                quydata = dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(0, 2).ToString();
                            if (quydata == "1" || quydata == "2" || quydata == "3")
                            {
                                tongmathang += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[4].Value.ToString());
                                tongtien += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[5].Value.ToString());
                            }
                            label_ketqua.Text = "Kết quả " + cbb_Quy.Text +  "\nTổng mặt hàng được bán: " + tongmathang.ToString() + "\nTổng tiền: " + tongtien.ToString();
                        }
                        if (quy == 2)
                        {
                            string quydata;
                            if (dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(1, 1).ToString() == "/")
                                quydata = dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(0, 1).ToString();
                            else
                                quydata = dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(0, 2).ToString();
                            if (quydata == "4" || quydata == "5" || quydata == "6")
                            {
                                tongmathang += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[4].Value.ToString());
                                tongtien += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[5].Value.ToString());
                            }
                            label_ketqua.Text = "Kết quả " + cbb_Quy.Text + "\nTổng mặt hàng được bán: " + tongmathang.ToString() + "\nTổng tiền: " + tongtien.ToString();
                        }
                        if (quy == 3)
                        {
                            string quydata;
                            if (dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(1, 1).ToString() == "/")
                                quydata = dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(0, 1).ToString();
                            else
                                quydata = dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(0, 2).ToString();
                            if (quydata == "7" || quydata == "8" || quydata == "9")
                            {
                                tongmathang += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[4].Value.ToString());
                                tongtien += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[5].Value.ToString());
                            }
                            label_ketqua.Text = "Kết quả " + cbb_Quy.Text + "\nTổng mặt hàng được bán: " + tongmathang.ToString() + "\nTổng tiền: " + tongtien.ToString();
                        }
                        if (quy == 4)
                        {
                            string quydata;
                            if (dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(1, 1).ToString() == "/")
                                quydata = dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(0, 1).ToString();
                            else
                                quydata = dataGV_ThongKe.Rows[i].Cells[6].Value.ToString().Substring(0, 2).ToString();
                            if (quydata == "10" || quydata == "11" || quydata == "12")
                            {
                                tongmathang += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[4].Value.ToString());
                                tongtien += Convert.ToInt32(dataGV_ThongKe.Rows[i].Cells[5].Value.ToString());
                            }
                            label_ketqua.Text = "Kết quả " + cbb_Quy.Text + "\nTổng mặt hàng được bán: " + tongmathang.ToString() + "\nTổng tiền: " + tongtien.ToString();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thông tin lỗi");
            }
            
        }
    }
}
