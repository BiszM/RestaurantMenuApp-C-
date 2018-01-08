using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantPOS
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();

        }
        //showing data in piechart according to sell price
        public void showChart(DataGridView sellGridView)
        {
            for (int i = 0; i < sellGridView.RowCount -1; i++)
            {
                pieChart.Series["Price"].Points.Add(Convert.ToDouble(sellGridView.Rows[i].Cells[2].Value));
                Color[] PieColors = {Color.Red, Color.Black, Color.Aquamarine, Color.Aqua, Color.AntiqueWhite, Color.Beige, Color.Blue, Color.Brown, Color.CadetBlue, Color.Chartreuse, Color.Coral, Color.Cornsilk, Color.DarkBlue, Color.DarkGoldenrod};
                pieChart.Series["Price"].Points[i].LegendText = sellGridView.Rows[i].Cells[0].Value.ToString() + " | " + sellGridView.Rows[i].Cells[3].Value.ToString();
                pieChart.Series["Price"].Points[i].Label = "Rs."+ sellGridView.Rows[i].Cells[2].Value.ToString();

            }
        }
    }
}
