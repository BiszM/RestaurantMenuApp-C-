namespace ResturantPOS
{
    partial class Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameBox = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.sellMsg = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.nameBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.nameBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nameBox.Location = new System.Drawing.Point(121, 112);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(220, 25);
            this.nameBox.TabIndex = 0;
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.itemName.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.itemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.itemName.Location = new System.Drawing.Point(29, 113);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(85, 20);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "Name      :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.label1.Location = new System.Drawing.Point(29, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price       :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.label2.Location = new System.Drawing.Point(29, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category  :";
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(95, 15, 80, 10);
            this.header.Size = new System.Drawing.Size(385, 52);
            this.header.TabIndex = 1;
            this.header.Text = "Update Information";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.priceBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.priceBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.priceBox.Location = new System.Drawing.Point(121, 146);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(220, 25);
            this.priceBox.TabIndex = 0;
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(191, 211);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Padding = new System.Windows.Forms.Padding(2);
            this.updateBtn.Size = new System.Drawing.Size(150, 32);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // sellMsg
            // 
            this.sellMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(124)))), ((int)(((byte)(33)))));
            this.sellMsg.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellMsg.ForeColor = System.Drawing.Color.White;
            this.sellMsg.Location = new System.Drawing.Point(0, 63);
            this.sellMsg.Name = "sellMsg";
            this.sellMsg.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.sellMsg.Size = new System.Drawing.Size(383, 26);
            this.sellMsg.TabIndex = 4;
            this.sellMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sellMsg.Visible = false;
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.rowLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.rowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.rowLabel.Location = new System.Drawing.Point(29, 90);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(0, 20);
            this.rowLabel.TabIndex = 1;
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Cold Drinks",
            "Hot Drinks",
            "Black Coffee",
            "Milk Coffee",
            "Burger",
            "Pizza",
            "Hotdog",
            "Sandwich",
            "Fires",
            "Juice"});
            this.categoryBox.Location = new System.Drawing.Point(121, 182);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(220, 21);
            this.categoryBox.TabIndex = 5;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(383, 252);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.sellMsg);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.rowLabel);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label sellMsg;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.ComboBox categoryBox;
    }
}