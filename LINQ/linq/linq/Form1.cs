using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq
{
    public partial class Form1 : Form
    {
        QLSINHVIENDataContext qlsv = new QLSINHVIENDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDuLieu()
        {
            var monhocs = qlsv.MonHocs.Select(mh => mh);
            dataGridView1.DataSource = monhocs;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }



        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MonHoc monhoc = new MonHoc();
            
            monhoc.MaMonHoc = txtMaMH.Text;
            monhoc.TenMonHoc = txtTenMH.Text;

            qlsv.MonHocs.InsertOnSubmit(monhoc);
            qlsv.SubmitChanges();

            LoadDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMH = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            MonHoc mh = qlsv.MonHocs.Where(t => t.MaMonHoc == maMH).FirstOrDefault();

            qlsv.MonHocs.DeleteOnSubmit(mh);
            qlsv.SubmitChanges();

            LoadDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMH = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            MonHoc mh = qlsv.MonHocs.Where(t => t.MaMonHoc == maMH).FirstOrDefault();

            //mh.MaMonHoc = txtMaMH.Text;
            mh.TenMonHoc = txtTenMH.Text;

            qlsv.SubmitChanges();

            LoadDuLieu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maMH = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            MonHoc mh = qlsv.MonHocs.Where(t => t.MaMonHoc == maMH).FirstOrDefault();

            qlsv.MonHocs.DeleteOnSubmit(mh);
            qlsv.SubmitChanges();

            MonHoc mh1 = new MonHoc();

            mh1.MaMonHoc = txtMaMH.Text;
            mh1.TenMonHoc = txtTenMH.Text;

            qlsv.MonHocs.InsertOnSubmit(mh1);
            qlsv.SubmitChanges();

            LoadDuLieu();
        }
    }
}
