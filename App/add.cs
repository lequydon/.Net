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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sv = new SinhVIen();
            sv.id = Guid.NewGuid().ToString();
            sv.hoten = textBox1.Text;
            if (checkBox1.Checked)
            {
                sv.gioitinh = true;
            }
            else
                sv.gioitinh = false;
            sv.ngaysinh = dateTimePicker1.Value;
            var van = new van();
            van.idsv = sv.id;
            van.vhcd = Convert.ToInt64(numericUpDown1.Value);
            van.vhhh = Convert.ToInt64(numericUpDown2.Value);
            var vatly = new vatly();
            vatly.idsv = sv.id;
            vatly.cohoc = Convert.ToInt64(numericUpDown3.Value);
            vatly.quanhoc = Convert.ToInt64(numericUpDown4.Value);
            vatly.dien = Convert.ToInt64(numericUpDown5.Value);
            vatly.vlhatnhan = Convert.ToInt64(numericUpDown6.Value);
            var cntt = new cntt();
            cntt.idsv = sv.id;
            cntt.pascal = Convert.ToInt64(numericUpDown7.Value);
            cntt.csap = Convert.ToInt64(numericUpDown8.Value);
            cntt.sql = Convert.ToInt64(numericUpDown9.Value);
            SinhVienservice.adddata(sv, van, vatly, cntt);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
