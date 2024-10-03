using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caesar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                tbdv.Text = File.ReadAllText(filePath);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, "Văn bản đầu ra là:\n" + tbdr.Text);
                MessageBox.Show("Đã lưu file ");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            tbdr.Text = "";
            tbdv.Text = "";
        }

        private void tbdv_TextChanged(object sender, EventArgs e)
        {
            if (tbdv.Text.Length > 0)
            {
                btgm.Enabled = true;
                btmh.Enabled = true;
                btclear.Enabled = true;
            }
            else
            { btgm.Enabled = false; btmh.Enabled = false; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tbdr.Enabled = true;
        }

        private void btmh_Click(object sender, EventArgs e)
        {
            string dauvao = HandleInput(tbdv.Text);
            String key = HandleInput(tbkhoa.Text);
            string daura = Mahoa(dauvao, key);
            tbdr.Text = daura;
            DisplayMatrix(key);
        }

        private void btgm_Click(object sender, EventArgs e)
        {
            string dauvao = HandleInput(tbdv.Text);
            String key = HandleInput(tbkhoa.Text);
            string daura = Giaima(dauvao, key);
            tbdr.Text = daura;
            DisplayMatrix(key);
        }

        private string RemoveDuplicates(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (result.IndexOf(text[i]) == -1)
                {
                    result += text[i];
                }
            }
            return result;
        }

        private string GenerateMatrix(string key)
        {
            string alph = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            key = key.ToUpper().Replace("J", "I");
            string matrix = key + alph;
            matrix = RemoveDuplicates(matrix);
            return matrix;
        }
        private string Mahoa(string plainText, string key)
        {
            string matrix = GenerateMatrix(key);
            string cipherText = "";
            for (int i = 0; i < plainText.Length; i += 2)
            {
                char c1 = plainText[i];
                char c2 = i + 1 < plainText.Length ? plainText[i + 1] : 'X';
                if (c1 == c2)
                {
                    c2 = 'X';
                }
                int row1 = matrix.IndexOf(c1) / 5;
                int col1 = matrix.IndexOf(c1) % 5;
                int row2 = matrix.IndexOf(c2) / 5;
                int col2 = matrix.IndexOf(c2) % 5;
                if (row1 == row2)
                {
                    cipherText += matrix[row1 * 5 + (col1 + 1) % 5];
                    cipherText += matrix[row2 * 5 + (col2 + 1) % 5];
                }
                else if (col1 == col2)
                {
                    cipherText += matrix[((row1 + 1) % 5) * 5 + col1];
                    cipherText += matrix[((row2 + 1) % 5) * 5 + col2];
                }
                else
                {
                    cipherText += matrix[row1 * 5 + col2];
                    cipherText += matrix[row2 * 5 + col1];
                }
            }
            return cipherText;
        }

        private string Giaima(string cipherText, string key)
        {
            string matrix = GenerateMatrix(key);
            string plainText = "";
            for (int i = 0; i < cipherText.Length; i += 2)
            {
                char c1 = cipherText[i];
                char c2 = cipherText[i + 1];
                int row1 = matrix.IndexOf(c1) / 5;
                int col1 = matrix.IndexOf(c1) % 5;
                int row2 = matrix.IndexOf(c2) / 5;
                int col2 = matrix.IndexOf(c2) % 5;
                if (row1 == row2)
                {
                    plainText += matrix[row1 * 5 + (col1 - 1 + 5) % 5];
                    plainText += matrix[row2 * 5 + (col2 - 1 + 5) % 5];
                }
                else if (col1 == col2)
                {
                    plainText += matrix[((row1 - 1 + 5) % 5) * 5 + col1];
                    plainText += matrix[((row2 - 1 + 5) % 5) * 5 + col2];
                }
                else
                {
                    plainText += matrix[row1 * 5 + col2];
                    plainText += matrix[row2 * 5 + col1];
                }
                if (plainText[plainText.Length - 1] == 'X' && plainText[plainText.Length - 2] == plainText[plainText.Length - 1])
                {
                    plainText = plainText.Substring(0, plainText.Length - 1);
                }
            }
            return plainText;
        }

        private void DisplayMatrix(string key)
        {
            string matrix = GenerateMatrix(key);
            matran.RowCount = 5;
            matran.ColumnCount = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matran.Rows[i].Cells[j].Value = matrix[i * 5 + j];
                }
            }
        }
        private string HandleInput(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    result.Append(char.ToUpper(input[i]));
                    if (i < input.Length - 1 && input[i] == input[i + 1])
                    {
                        result.Append('X');
                        result.Append(char.ToUpper(input[i]));
                        result.Append(' ');
                        i++;
                    }
                }
                else if (char.IsDigit(input[i]))
                {
                    result.Append(input[i]);
                }
            }

            return result.ToString();
        }




    }
}

