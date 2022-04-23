using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Form1 : Form
    {
        BLLKhoa bllKhoa = new BLLKhoa();
        BLLLop bllLop = new BLLLop();
        BLLMonHoc bllMonHoc = new BLLMonHoc();
        LinQDataContext qlsv = new LinQDataContext();
        public Form1()
        {
            InitializeComponent();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = comboBox1.SelectedValue.ToString();
            comboBox2.DataSource = bllLop.LoadLop(value);
            comboBox2.DisplayMember = "TenLop";
            comboBox2.ValueMember = "MaLop";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bllKhoa.LoadKhoa();
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.ValueMember = "MaKhoa";

            comboBoxMonHoc.DataSource = bllMonHoc.LoadMonHoc();
            comboBoxMonHoc.DisplayMember = "TenMonHoc";
            comboBoxMonHoc.ValueMember = "MaMonHoc";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = comboBox2.SelectedValue.ToString();
            var sinhviens = from sv in qlsv.View_SinhViens where sv.MaLop == value select sv;
            //var sinhviens = from sv in qlsv.SinhViens select sv;
            dataGridView1.DataSource = sinhviens;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = comboBoxMonHoc.SelectedValue.ToString();
            var diems = from d in qlsv.Diems where d.MaMonHoc == value select d;
            dataGridView2.DataSource = diems;
        }
    }
}
