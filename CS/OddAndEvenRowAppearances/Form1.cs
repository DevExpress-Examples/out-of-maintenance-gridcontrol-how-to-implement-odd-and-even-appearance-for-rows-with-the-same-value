using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OddAndEvenRowAppearances
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDBDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.carsDBDataSet.Orders);
            RowStyleHelper helper = new RowStyleHelper(gridView1, "PaymentType");
            GridColumn keyColumn = gridView1.Columns["PaymentType"];
            keyColumn.AppearanceCell.Font = new Font(keyColumn.AppearanceCell.Font, FontStyle.Bold);
        }
    }
}
