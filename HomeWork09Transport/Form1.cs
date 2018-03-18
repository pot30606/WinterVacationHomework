using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork09Transport
{
    public partial class Form1 : Form
    {
        private List<Transport> _list;

        public Form1()
        {
            InitializeComponent();
            CreateTransport();
            SetCombobox1();
            SetCombobox2();
        }

        private void CreateTransport()
        {
            _list = new List<Transport>()
            {
                new Transport() {Start="台北" , End="新竹",Price=177 },
                new Transport() {Start="台北" , End="台中",Price=375 },
                new Transport() {Start="台北" , End="嘉義",Price=598 },
                new Transport() {Start="台北" , End="台南",Price=738 },
                new Transport() {Start="台北" , End="高雄",Price=842 },
                new Transport() {Start="新竹" , End="台中",Price=197 },
                new Transport() {Start="新竹" , End="嘉義",Price=421 },
                new Transport() {Start="新竹" , End="台南",Price=560 },
                new Transport() {Start="新竹" , End="高雄",Price=755 },
                new Transport() {Start="台中" , End="嘉義",Price=224 },
                new Transport() {Start="台中" , End="台南",Price=363 },
                new Transport() {Start="台中" , End="高雄",Price=469 },
                new Transport() {Start="嘉義" , End="台南",Price=139 },
                new Transport() {Start="嘉義" , End="高雄",Price=245 },
                new Transport() {Start="台南" , End="高雄",Price=106 }
            };
        }

        private void SetCombobox1()
        {
            var address = new List<string> { };
            foreach (var item in _list)
            {
                address.Add(item.Start);
                address.Add(item.End);
            }
            var result = (from x in address
                          select x).Distinct().ToList();
            comboBox1.DataSource = result;
        }

        private void SetCombobox2()
        {
            var address = new List<string> { };
            foreach (var item in _list)
            {
                address.Add(item.Start);
                address.Add(item.End);
            }
            var result = (from x in address
                          select x).Distinct().ToList();
            comboBox2.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal TotalPrice=0;
            string start = comboBox1.SelectedValue.ToString();
            string end = comboBox2.SelectedValue.ToString();

            var result1 = _list.Where((x) => x.Start == start && x.End == end);
            foreach(var item in result1)
            {
                TotalPrice = item.Price;
            }

            if (TotalPrice ==0)
            {
                var result2 = _list.Where((x) => x.Start == end && x.End == start);
                foreach (var item in result2)
                {
                    TotalPrice = item.Price;
                }
            }

            if (checkBox1.Checked)
            {
                TotalPrice = TotalPrice * (decimal)2 * (decimal)0.9;
            }
            if (checkBox2.Checked)
            {
                TotalPrice = TotalPrice * (decimal)0.9;
            }

            label3.Text = "票價為 : " + TotalPrice;

        }

    }
}