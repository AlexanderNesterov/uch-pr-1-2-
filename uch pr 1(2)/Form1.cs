using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Уч_пр_1_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(ColumnSizeTextBox.Text);
            int m = int.Parse(RowSizeTextBox.Text);

            createMatrix(n, m);
        }

        private void createMatrix(int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                matrix.Columns.Add("", "");
            }

            for (int j = 0; j < m; j++)
            {
                matrix.Rows.Add();
            }

            fillMatrix();
        }

        private void fillMatrix()
        {
            Random rand = new Random();

            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    matrix[j, i].Value = rand.Next(0, 30);
                }
            }
        }

        private void MaxRowElementButton_Click(object sender, EventArgs e)
        {
            int row = int.Parse(SelectedRowTextBox.Text) - 1;
            int max = -1;

            if (row < 0 || row >= matrix.RowCount)
            {
                MaxRowElement.Text = "Выбранная строка отсутсвует";
                return;
            }

            for (int i = 0; i < matrix.ColumnCount; i++)
            {
                int elementValue = (int)matrix[i, row].Value;

                max = (elementValue > max) ? elementValue : max;
            }

            MaxRowElement.Text = max.ToString();
        }

        private void MinColumnElementButton_Click(object sender, EventArgs e)
        {
            int column = int.Parse(SelectedColumnTextBox.Text) - 1;
            int min = 40;

            if (column < 0 || column >= matrix.ColumnCount)
            {
                MinColumnElement.Text = "Выбранный столбец отсутсвует";
                return;
            }

            for (int i = 0; i < matrix.RowCount; i++)
            {
                int elementValue = (int)matrix[column, i].Value;

                min = (elementValue < min) ? elementValue : min;
            }

            MinColumnElement.Text = min.ToString();
        }

        private void AddColumn_Click(object sender, EventArgs e)
        {
            matrix.Columns.Add("", "");
            int column = matrix.ColumnCount - 1;
            Random rand = new Random();

            for (int i = 0; i < matrix.RowCount; i++)
            {
                matrix[column, i].Value = rand.Next(0, 30);
            }
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            matrix.Rows.Add();
            int row = matrix.RowCount - 1;
            Random rand = new Random();

            for (int i = 0; i < matrix.ColumnCount; i++)
            {
                matrix[i, row].Value = rand.Next(0, 30);
            }
        }
    }
}
