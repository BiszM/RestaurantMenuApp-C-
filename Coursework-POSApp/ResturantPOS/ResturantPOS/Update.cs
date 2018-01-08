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
    public partial class Update : Form
    {
        // using delegate
        public delegate void IdentityHandler(object sender, IdentityEventArgs e);
        public event IdentityHandler IdentityUpated;

        public Update()
        {
            InitializeComponent();
        }

        //displays the data which are passed in this update form
        public void LoadData(string name, string category, int price, string type)
        {
            Console.WriteLine("Load Data");
            if(type == "update")
            {
                sellMsg.Visible = true;
                updateBtn.Text = "Update";
                header.Text = "Update Information";
                sellMsg.Text = "Check the update information";
            }
            else if (type == "sell")
            {
                //Changing UI of form
                sellMsg.Visible = true;
                itemName.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                nameBox.Visible = false;
                priceBox.Visible = false;
                categoryBox.Visible = false;

                this.ClientSize = new Size(399, 200);

                header.Text = "Sell Information";
                header.Location = new Point(0, 0);
                header.Size = new Size(399, 70);

                sellMsg.Text = "Do you want to sell this product?";
                sellMsg.Size = new Size(399, 30);
                sellMsg.Location = new Point(0, 83);

                updateBtn.Text = "Yes";
                updateBtn.Size = new Size(100, 32);
                updateBtn.Location = new Point(50, 140);

                Button btnNo = new Button();
                btnNo.Name = "btnNo";
                btnNo.Text = "No";
                btnNo.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
                btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                btnNo.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold);
                btnNo.ForeColor = Color.White;
                btnNo.Location = new Point(245, 140);
                btnNo.Name = "BtnNo";
                btnNo.Padding = new Padding(2);
                btnNo.Size = new Size(100, 32);
                btnNo.TabIndex = 3;
                btnNo.Text = "No";
                this.updateBtn.UseVisualStyleBackColor = false;
                btnNo.Click += new EventHandler(BtnNo_Click);
                this.Controls.Add(btnNo);
            }
            nameBox.Text = name;
            priceBox.Text = Convert.ToString(price);
            categoryBox.Text = category;
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not recorded!");
            Close();
        }

        //Takes alphabets and space bar key press value
        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char alpha = e.KeyChar;
            string val = Convert.ToString(alpha);
            if (!Char.IsLetter(alpha) && alpha != 8 && alpha != ' ')
            {
                e.Handled = true;
            }
        }

        // Takes only numerical value
        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char alpha = e.KeyChar;
            int val = Convert.ToUInt16(alpha);

            if (!Char.IsDigit(alpha) && alpha != 8)
            {
                e.Handled = true;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            int price = Convert.ToInt32(priceBox.Text);
            string category = categoryBox.Text ;
            nameBox.Text = "";
            priceBox.Text = "";
            categoryBox.Text = "";
            IdentityEventArgs args = new IdentityEventArgs(name, category, price);

            IdentityUpated(this, args);
            Close();
        }
    }

    public class IdentityEventArgs : EventArgs
    {
        private string name;
        private string category;
        private int price;

        public IdentityEventArgs(string name, string category, int price) {
            this.name = name;
            this.category = category;
            this.price = price;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
        }
    }
}
