using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantPOS
{
    class BubbleSort
    {

        string name;
        string cat;
        string price;

        //Constructor without parameter
        public BubbleSort(){ }

        //Constructor with parameter
        public BubbleSort(string name, string cat, string price)
        {
            this.name = name;
            this.cat = cat;
            this.price = price;
        }
        //Getter methods
        public string GetName
        {
            get
            {
                return name;
            }
        }
        public string GetCategory
        {
            get
            {
                return cat;
            }
        }
        public string GetPrice
        {
            get
            {
                return price;
            }
        }

        //Bubble Sort Algorithm
        //Sort by price
        public void SortByPrice(string OrderName, DataGridView dataGridView)
        {
            if (dataGridView.RowCount <= 2)
            {
                MessageBox.Show("Please insert items more than one in menu list to sort", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<string> nameArrayList = new List<string>();
            List<string> categoryArrayList = new List<string>();
            List<int> priceArrayList = new List<int>();

            AddInList(dataGridView, nameArrayList, priceArrayList, categoryArrayList);

            int rowCount = priceArrayList.Count - 1;

            for (int i = 0; i < priceArrayList.Count; i++)
            {
                if (OrderName.ToLower() == "descending")
                {
                    for (int j = 1; j < priceArrayList.Count; j++)
                    {
                        if ((int)priceArrayList[j] < (int)priceArrayList[j - 1])
                        {
                            SwapPosition(j, nameArrayList, priceArrayList, categoryArrayList);
                        }
                    }
                }
                else if (OrderName.ToLower() == "ascending")
                {
                    for (int j = 1; j < priceArrayList.Count; j++)
                    {
                        if ((int)priceArrayList[j] > (int)priceArrayList[j - 1])
                        {
                            SwapPosition(j, nameArrayList, priceArrayList, categoryArrayList);
                        }
                    }
                }

                dataGridView.Rows[i].Cells[0].Value = nameArrayList[rowCount];
                dataGridView.Rows[i].Cells[1].Value = categoryArrayList[rowCount];
                dataGridView.Rows[i].Cells[2].Value = priceArrayList[rowCount];
                rowCount--;
            }
        }

        //sort by name
        public void SortByName(string OrderName, DataGridView dataGridView)
        {
            if(dataGridView.RowCount <= 2)
            {
                MessageBox.Show("Please insert items more than one in menu list to sort", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<string> nameArrayList = new List<string>();
            List<string> categoryArrayList = new List<string>();
            List<int> priceArrayList = new List<int>();

            AddInList(dataGridView, nameArrayList, priceArrayList, categoryArrayList);
           
            int rowCount = nameArrayList.Count - 1;

            for (int i = 0; i < nameArrayList.Count; i++)
            {
                for (int j = 1; j < nameArrayList.Count; j++)
                {
                    if (OrderName.ToLower() == "descending")
                    {
                        if (string.Compare((string)nameArrayList[j-1], ((string)nameArrayList[j])) > 0)
                        {
                            SwapPosition(j, nameArrayList, priceArrayList, categoryArrayList);
                        }
                    }
                    else if (OrderName.ToLower() == "ascending")
                    {
                        if (string.Compare((string)nameArrayList[j-1], ((string)nameArrayList[j])) < 0)
                        {
                            SwapPosition(j, nameArrayList, priceArrayList, categoryArrayList);
                        }
                    }
                }

                dataGridView.Rows[i].Cells[0].Value = nameArrayList[rowCount];
                dataGridView.Rows[i].Cells[1].Value = categoryArrayList[rowCount];
                dataGridView.Rows[i].Cells[2].Value = priceArrayList[rowCount];
                rowCount--;
            }
        }
        
        //swap position
        public void SwapPosition(int j, List<string> nameArrayList, List<int> priceArrayList, List<string> categoryArrayList)
        {
            string tempName = (string)nameArrayList[j];
            nameArrayList[j] = nameArrayList[j - 1];
            nameArrayList[j - 1] = tempName;

            string tempCategory = (string)categoryArrayList[j];
            categoryArrayList[j] = categoryArrayList[j - 1];
            categoryArrayList[j - 1] = tempCategory;

            int tempPrice = (int)priceArrayList[j];
            priceArrayList[j] = priceArrayList[j - 1];
            priceArrayList[j - 1] = tempPrice;
        }

        //add in list
        public void AddInList(DataGridView dataGridView, List<string> nameArrayList, List<int> priceArrayList, List<string> categoryArrayList)
        {
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                string name = dataGridView.Rows[i].Cells[0].Value.ToString();
                string category = dataGridView.Rows[i].Cells[1].Value.ToString();
                string price = dataGridView.Rows[i].Cells[2].Value.ToString();
                if (price != null && price.Length != 0)
                {
                    nameArrayList.Add(name);
                    categoryArrayList.Add(category);
                    priceArrayList.Add(int.Parse(price));
                }
            }
        }

    }
}
