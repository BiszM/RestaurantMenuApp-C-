using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace ResturantPOS
{
    public partial class Form1 : Form
    {
        Controller Ctrl= new Controller();
        BubbleSort BSort = new BubbleSort();
        private bool status = false;
        private int row = 0;
        List<ItemDetail> itemList = new List<ItemDetail>();

        public Form1()
        {
            InitializeComponent();
        }

        // Takes only numerical value
        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char alpha = e.KeyChar;
            int val = Convert.ToUInt16(alpha);

            if (!Char.IsDigit(alpha) && alpha != 8)
            {
                e.Handled = true;
            }
        }

        //Takes alphabets and space bar key press value
        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char alpha = e.KeyChar;
            string val = Convert.ToString(alpha);
            if (!Char.IsLetter(alpha) && alpha != 8 && alpha != ' ')
            {
                e.Handled = true;
            }
        }

        // add an item calling controller add function if button clicked
        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string price = priceTxt.Text;
            string category = categoryTxt.Text;
            Ctrl.AddCtrl(name, price, category, this.status, this.row, dataGridView,
                        "Record Added", 
                        "Invalid name and product. Fill in the boxes with correct names.",
                        true);
            nameTxt.Text = "";
            priceTxt.Text = "";
            categoryTxt.SelectedIndex = -1;
            this.row = 0;
            this.status = false;
        }

        // deletes seleted item of datagridview
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView.CurrentCell.RowIndex;
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this product?", "Delete Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (selectedRow >= 0)
                {
                    dataGridView.Rows.RemoveAt(selectedRow);
                }
                MessageBox.Show("Record is removed.", "Delete Message");
            }
        }

        // opens dialog and saves file path
        // calls controller import function to insert data in datagridview
        private void importBtn_Click(object sender, EventArgs e)
        {
            // opens windows dialog and gets file path 
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Files(*.txt, *.csv)|*.txt;*.csv|All Files(*.*)|*.*";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string Fname = dialog.FileName;
                Ctrl.ImportCSVFile(Fname, dataGridView, this.row);
            }
        }

        // opens a new form from messagebox event when cell is double clicked
        // it gives option either to save file or update file
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[0].Value);
            string category = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[1].Value);
            int price = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[2].Value);

            DialogResult dialogResult = MessageBox.Show("Choose \"Yes\" to sell \"No\" to update", "Do you want to sell or update this product?",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (name != "" && name.Length > 0 && category != "" && price > 0)
                {
                    //use of delegate from update.cs file
                    Update u = new Update();
                    u.LoadData(name, category, price, "sell");
                    u.IdentityUpated += new Update.IdentityHandler(SellRecord);
                    u.ShowDialog();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                if (name != "" && name.Length > 0 && category != "" && price > 0)
                {
                    this.row = e.RowIndex;
                    Update u = new Update();
                    u.LoadData(name, category, price, "update");
                    u.IdentityUpated += new Update.IdentityHandler(UpdateRecord);
                    u.LoadData(name, category, price, "update");
                    if (sellDataView.RowCount >= 0)
                    {
                        this.status = false;
                    }
                    else
                    {
                        this.status = true;
                    }
                    u.ShowDialog();
                }
            }
            else { }
            dataGridView.Refresh();
            Console.WriteLine("refreshed");
        }

        //use of delegete and event to update the data
        private void UpdateRecord(object sender, IdentityEventArgs ea)
        {
            dataGridView.Rows[row].Cells[0].Value = ea.Name;
            dataGridView.Rows[row].Cells[1].Value = ea.Category;
            dataGridView.Rows[row].Cells[2].Value = ea.Price;
        }
        
        //use of delegete, linq and event to sell the data
        private void SellRecord(object sender, IdentityEventArgs ea)
        {
            if (ea.Name != "" && ea.Name.Length > 0 && ea.Category != "" && ea.Price > 0)
            {
                List<ItemDetail> modelList = new List<ItemDetail>();

                if (!this.status)
                {
                    itemList.Add(new ItemDetail()
                    {
                        Name = ea.Name,
                        Price = ea.Price,
                        Category = ea.Category,
                        Quantity = 1
                    });
                    var items= itemList.GroupBy(x => new {x.Name});

                    foreach (var item in items)
                    {
                        modelList.Add(new ItemDetail()
                        {   
                            Name = item.Key.Name,
                            Price = item.Sum(x => x.Price),
                            Quantity = item.Sum(x => x.Quantity),
                            Category = (from x1 in item select x1.Category).FirstOrDefault().ToString()
                        });
                    }
                }
                Ctrl.ClearGridView(sellDataView);
                for (int i = 0; i < modelList.Count; i++)
                {
                    Console.WriteLine(i);
                    sellDataView.Rows.Add();
                    sellDataView.Rows[i].Cells[0].Value = modelList[i].Name;
                    sellDataView.Rows[i].Cells[1].Value = modelList[i].Category;
                    sellDataView.Rows[i].Cells[2].Value = modelList[i].Price;
                    sellDataView.Rows[i].Cells[3].Value = modelList[i].Quantity;
                }
                
                this.row = 0;
                this.status = false;
            }
            else
            {
                MessageBox.Show("Invalid name and product. Fill in the boxes with correct names.");
            }
        }

        // sort using bubble sort
        private void sortByBtn_Click(object sender, EventArgs e)
        {
            string SortName = sortBox.Text;
            string OrderName = orderBox.Text;
            if (SortName.Length > 0 && OrderName.Length > 0)
            {
                if (SortName.ToLower() == "item")
                {
                    BSort.SortByName(OrderName, dataGridView);
                }
                else
                {
                    BSort.SortByPrice(OrderName, dataGridView);
                }
                orderBox.SelectedIndex = -1;
                sortBox.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Fill up both sort by and order by to continue.", "", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
        }
      
        // showing chart when chart button clicked
        private void chartBtn_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.showChart(sellDataView);
            chart.ShowDialog();
        }

        //Getting the total income of all sell items
        private void totalBtn_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < sellDataView.RowCount; i++)
            {
                int price = Convert.ToInt32(sellDataView.Rows[i].Cells[2].Value);
                total = total + price;
            }
            MessageBox.Show("Total Price:" + total);
        }

        //Clears the datagridview when clicked
        private void clearBtn_Click(object sender, EventArgs e)
        {
            Ctrl.ClearGridView(dataGridView);
        }

    }
}
