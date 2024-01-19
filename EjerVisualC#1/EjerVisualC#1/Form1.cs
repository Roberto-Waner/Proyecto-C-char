using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerVisualC_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double precio, ITBIS = 18, tasa, total;
        private void bt_calcular_Click(object sender, EventArgs e)
        {
            precio = Convert.ToDouble(txt_precio);

            tasa = (precio * ITBIS) / 100;
            total = precio + tasa;



        }
    }
}
