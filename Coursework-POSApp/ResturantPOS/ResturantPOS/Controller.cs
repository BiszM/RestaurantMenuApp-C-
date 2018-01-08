using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class Controller
{
	public Controller()
	{
	}

    // adds a new data
    public void AddCtrl(string name, string price, string category, bool status, int row,
        DataGridView gridView, string msg1, string msg2, bool showMsg)
    {
        if (name.Length != 0 && price.Length != 0 && category.Length != 0)
        {
            if (!status)
            {
                int count = gridView.Rows.Count - 1;
                gridView.Rows.Add();
                gridView.Rows[count].Cells[0].Value = name;
                gridView.Rows[count].Cells[1].Value = category;
                gridView.Rows[count].Cells[2].Value = price;
                gridView.Rows[row].Selected = true;
                if (showMsg) MessageBox.Show(msg1);
            }
        }
        else
        {
            if (showMsg) MessageBox.Show(msg2, "", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }

    //Import function
    public void ImportCSVFile(string filePath, DataGridView dataGridView, int row)
    {
        try
        {
            //Reading file text
            TextFieldParser csvreader = new TextFieldParser(filePath);
            //Ignoring first line 
            csvreader.ReadLine();
            //Storing all data of csvreader in array
            string[] data = csvreader.ReadToEnd().Split(",|\r|\n".ToCharArray());
            //Updating data in datagridview
            data = data.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            //inserting data in datagridview
            for (int j = 0; j < data.Length - 1; j += 3)
            {
                int count = dataGridView.Rows.Count - 1;
                dataGridView.Rows.Add();
                dataGridView.Rows[count].Cells[0].Value = data[j];
                dataGridView.Rows[count].Cells[1].Value = data[j + 1];
                dataGridView.Rows[count].Cells[2].Value = data[j + 2];
                dataGridView.Rows[row].Selected = true;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Import CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    //Deletes all data of datagridview
    public void ClearGridView(DataGridView gridView)
    {
        gridView.Rows.Clear();
        gridView.Refresh();
    }
}
