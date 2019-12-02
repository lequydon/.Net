using App.model;
using App.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var listsv = SinhVienservice.getlist();
            dataGridView1.AutoGenerateColumns = false;
            bindingSource1.DataSource = listsv;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new add();
            if (f.ShowDialog() == DialogResult.OK)
            {
                var listsv = SinhVienservice.getlist();
                dataGridView1.AutoGenerateColumns = false;
                bindingSource1.DataSource = listsv;
                dataGridView1.DataSource = bindingSource1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellcurent = bindingSource1.Current as SinhVIen;
            textBox1.Text = cellcurent.hoten;
            if (cellcurent.gioitinh == true)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
            dateTimePicker1.Value = cellcurent.ngaysinh;
                var van = SinhVienservice.getvan(cellcurent.id);
            if(van!=null)
            {
                textBox2.Text = Convert.ToString(van.vhcd);
                textBox3.Text = Convert.ToString(van.vhhh);
            }
                var ly = SinhVienservice.getvatly(cellcurent.id);
            if (ly != null)
            {
                textBox4.Text = Convert.ToString(ly.cohoc);
                textBox5.Text = Convert.ToString(ly.quanhoc);
                textBox6.Text = Convert.ToString(ly.dien);
                textBox7.Text = Convert.ToString(ly.vlhatnhan);
            }
                var cntt = SinhVienservice.getcntt(cellcurent.id);
            if (cntt != null)
            {
                textBox8.Text = Convert.ToString(cntt.pascal);
                textBox9.Text = Convert.ToString(cntt.csap);
                textBox10.Text = Convert.ToString(cntt.sql);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cellcurent = bindingSource1.Current as SinhVIen;
            var resultDialog = MessageBox.Show(
                    "Bạn có thực sự muốn xóa?",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
            if (resultDialog == DialogResult.OK)
            {
                //Viết code xóa dữ liệu ở đây --> Bài tập về nhà ngày 12/10/2019
                SinhVienservice.delete(cellcurent.id);
                bindingSource1.RemoveCurrent();
            }
        }
    }
}
