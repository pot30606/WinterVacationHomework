using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork08Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var _Sales = CreateSaler();
            var _Product = CreateProduct();
            
            var order1 =
                from s in _Sales
                join p in _Product
                on s.P_Name equals p.P_Name
                select new SalesResult { P_Price=p.P_Price , P_Quantity=s.P_Quantity , SalesName = s.SalesName };

                //將同名稱SalesName 的業績彙整
                var q = (from h in order1
                         group h by new { h.SalesName } into hh
                         select new
                         {
                             hh.Key.SalesName,
                             Total = hh.Sum(s => s.SalesTotal)
                         });

            
            var order2 =
                from s in _Sales
                join p in _Product
                on s.P_Name equals p.P_Name
                select new ProductResult { ProductTotal = s.P_Quantity * p.P_Price , P_Name=p.P_Name };
            //將同名稱P_Name的 銷售總合彙整
            var pr = (from h in order2
                     group h by new { h.P_Name } into hh
                     select new
                     {
                         hh.Key.P_Name,
                         Total = hh.Sum(s => s.ProductTotal)
                     });


            int count = 0;
            foreach (var sales in q)
            {

                dataGridView1.Columns[count].HeaderText = sales.SalesName;
                dataGridView1[count,0].Value = sales.Total;
                count++;
            }

            count = 0;
            foreach(var n in pr)
            {
                dataGridView2.Columns[count].HeaderText = n.P_Name;
                dataGridView2[count, 0].Value = n.Total;
                count++;
            }


            var result1 = q.Max((x) => x.Total);
            var bestman = q.Where((x) => x.Total == result1 );
            foreach (var n in bestman)
            {
                BestSeller.Text = n.SalesName;
            }


            var result2 = pr.Max((x) => x.Total);
            var Bestproduct = pr.Where((x) => x.Total == result2);
            foreach(var m in Bestproduct)
            {
                BestProduct.Text = m.P_Name;
            }

        }

        static List<BestSeller> CreateBestSeller(string name, int total)
        {
            var list = new List<BestSeller>()
            {
                new BestSeller() {SalesName=name,TotalPrice= total}
            };
            return list;
        }
            

        static List<Product> CreateProduct()
        {
            var List = new List<Product>()
            {
                new Product() {P_Name="原子筆" , P_Price=12 },
                new Product() {P_Name="鉛筆" , P_Price=16 },
                new Product() {P_Name="橡皮擦" , P_Price=10 },
                new Product() {P_Name="直尺" , P_Price=14 },
                new Product() {P_Name="立可白" , P_Price=15 }
            };
            return List;
        }

        static List<Sales> CreateSaler()
        {
            var list = new List<Sales>()
            {
                new Sales() {SalesName="Bill" , P_Name="原子筆" , P_Quantity=33 },
                new Sales() {SalesName="Bill" , P_Name="鉛筆" , P_Quantity=32 },
                new Sales() {SalesName="Bill" , P_Name="橡皮擦" , P_Quantity=56 },
                new Sales() {SalesName="Bill" , P_Name="直尺" , P_Quantity=45 },
                new Sales() {SalesName="Bill" , P_Name="立可白" , P_Quantity=33 },
                new Sales() {SalesName="John", P_Name="原子筆" , P_Quantity=77 },
                new Sales() {SalesName="John", P_Name="鉛筆" , P_Quantity=33 },
                new Sales() {SalesName="John", P_Name="橡皮擦" , P_Quantity=68 },
                new Sales() {SalesName="John", P_Name="直尺" , P_Quantity=45 },
                new Sales() {SalesName="John", P_Name="立可白" , P_Quantity=23 },
                new Sales() {SalesName="David",P_Name="原子筆" , P_Quantity=43 },
                new Sales() {SalesName="David",P_Name="鉛筆" , P_Quantity=55 },
                new Sales() {SalesName="David",P_Name="橡皮擦" , P_Quantity=43 },
                new Sales() {SalesName="David",P_Name="直尺" , P_Quantity=67 },
                new Sales() {SalesName="David",P_Name="立可白" , P_Quantity=65 }
            };
            return list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
