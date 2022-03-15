using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace MatrixForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultsTextBox.Text = matrix.StrMatrix;
        }
        TextBox[,] FirstMatrix = new TextBox[,] {};
        TextBox[,] SecondMatrix = new TextBox[,] {};
        string results = String.Empty;
        public Matrix A = new Matrix(new int[,] { { 6, 8 }, { 7, 5 }, { 5, 4 } });
        public Matrix B = new Matrix(new int[,] { { 2, 4 }, { 1, 2 }, { 3, 1 } });
        public Matrix F = new Matrix(new int[,] { { 1, 4, 5, 1 }, { 8, 3, 6, 3 } });
        public Matrix K = new Matrix(new int[,] { { 1, 2, 3 }, { 5, 4, 6 }, { 7, 3, 4 } });
        public Matrix matrix = new Matrix(new int[,] { { 1, 0, 0, 0 }, { 0, 2, 0, 0 }, { 0, 0, 3, 0 }, { 0, 0, 0, 4 } });
        //Help functions
        bool isEmpty(TextBox[,] temp)
        {
            for(int i = 0; i < temp.GetLength(0); i++)
            {
                for(int j = 0; j < temp.GetLength(1); j++)
                {
                    if(temp[i,j].Text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //Get matrix from form
        Matrix GetMatrix(TextBox[,] form)
        {
            int[,] buff1 = new int[form.GetLength(0), form.GetLength(1)];
            for (int i = 0; i < buff1.GetLength(0); i++)
            {
                for (int j = 0; j < buff1.GetLength(1); j++)
                {
                    buff1[i, j] = int.Parse(form[i, j].Text);
                }
            }
            return new Matrix(buff1);
        }
        //Generate table for filling martrix`s values
        void generateTable( ref TextBox[,] temp , Panel panel)
        {
            for(int i = 0; i < temp.GetLength(0); i++)
            {
                for(int j = 0; j < temp.GetLength(1); j++)
                {
                    temp[i, j] = new TextBox
                    {
                        Height = 40,
                        Width = 30,
                        Location = new Point(j * 40 + 20,i*40  + 20)
                    };
                    temp[i, j].KeyPress += onlyNumber;
                    panel.Controls.Add(temp[i,j]);
                }
            }
        }
        //Only numbers for textBoxs
        void onlyNumber(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!(Char.IsDigit(number) || Char.IsControl(number)))
            {
                e.Handled = true;
            }
        }
        //Fill array of TextBox random values {0,10}
        void FillRandomMatrix(TextBox[,] temp)
        {
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    temp[i, j].Text = Convert.ToString(new Random().Next(10));
                    Thread.Sleep(1);
                }
            }
        }
        //Fill TextBoxs Matrix`s values
        TextBox[,] matrixToTextBoxs(Matrix a,Panel panel)
        {
            int[,] arr = a.ArrayMatrix;
            TextBox[,] temp = new TextBox[arr.GetLength(0), arr.GetLength(1)];
            for(int i = 0; i< temp.GetLength(0); i++)
            {
                for(int j = 0; j < temp.GetLength(1); j++)
                {
                    temp[i, j] = new TextBox
                    {
                        Text = arr[i, j].ToString(),
                        Height = 40,
                        Width = 30,
                        Location = new Point(j * 40 + 20, i * 40 + 20)
                    };
                    temp[i, j].KeyPress += onlyNumber;
                    panel.Controls.Add(temp[i, j]);
                }
            }
            return temp;
        }
        //--------------------------
        //Create matrices
        //Create table for first matrix
        private void CreateFirstMatrix_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                panel1.Controls.Clear();
                FirstMatrix = new TextBox[int.Parse(textBox1.Text),int.Parse(textBox2.Text)];
                generateTable(ref FirstMatrix,panel1);
            }
            else
            {
                 MessageBox.Show("To create a Matrices you need to give up the numbers of columns and rows", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Create table for second matrix
        private void CreateSecondMatrix_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                panel2.Controls.Clear();
                SecondMatrix = new TextBox[int.Parse(textBox4.Text), int.Parse(textBox3.Text)];
                generateTable(ref SecondMatrix, panel2);
            }
            else
            {
                MessageBox.Show("To create a Matrices you need to give up the numbers of columns and rows", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------
        //Operations
        //Product
        private void TransButton_Click(object sender, EventArgs e)
        {
            if(!isEmpty(FirstMatrix))
            {
                results = GetMatrix(FirstMatrix).transpose().StrMatrix;
                resultsTextBox.Text = results;
            }
            else
            {
                MessageBox.Show("Fill first matrix","Empty",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        //Addition
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!isEmpty(FirstMatrix))
            {
                try
                {
                    results = GetMatrix(FirstMatrix).add(GetMatrix(SecondMatrix)).StrMatrix;
                    resultsTextBox.Text = GetMatrix(FirstMatrix).StrMatrix;
                    resultsTextBox.Text += "\r\n+\r\n\r\n";
                    resultsTextBox.Text += GetMatrix(SecondMatrix).StrMatrix;
                    resultsTextBox.Text += "\r\n=\r\n\r\n";
                    resultsTextBox.Text += results;
                }
                catch
                {
                    MessageBox.Show("Dimensions must be equal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Fill first matrix", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        //Subtraction
        private void SubButton_Click(object sender, EventArgs e)
        {
            if (!isEmpty(FirstMatrix))
            {
                try
                {
                    results = GetMatrix(FirstMatrix).sub(GetMatrix(SecondMatrix)).StrMatrix;
                    resultsTextBox.Text = GetMatrix(FirstMatrix).StrMatrix;
                    resultsTextBox.Text += "\r\n-\r\n\r\n";
                    resultsTextBox.Text += GetMatrix(SecondMatrix).StrMatrix;
                    resultsTextBox.Text += "\r\n=\r\n\r\n";
                    resultsTextBox.Text += results;
                }
                catch
                {
                    MessageBox.Show("Dimensions must be equal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Fill first matrix", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Product
        private void ProdButton_Click(object sender, EventArgs e)
        {
            if(!isEmpty(FirstMatrix) && !isEmpty(SecondMatrix))
            {
                try
                {
                    results = GetMatrix(FirstMatrix).prod(GetMatrix(SecondMatrix)).StrMatrix;
                    resultsTextBox.Text = GetMatrix(FirstMatrix).StrMatrix;
                    resultsTextBox.Text += "\r\n*\r\n\r\n";
                    resultsTextBox.Text += GetMatrix(SecondMatrix).StrMatrix;
                    resultsTextBox.Text += "\r\n=\r\n\r\n";
                    resultsTextBox.Text += results;
                }
                catch
                {
                    MessageBox.Show("Rows matrix 1 must be equalt columns matrix 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill matrices", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        //--------------------------
        //Button for filling matrices random values
        private void RandomButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                if (FirstMatrix.Length != 0 && SecondMatrix.Length != 0)
                {
                    FillRandomMatrix(FirstMatrix);
                    FillRandomMatrix(SecondMatrix);
                }
                else
                {
                    MessageBox.Show("Create two matrices", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else if (checkBox1.Checked)
            {
                if(FirstMatrix.Length != 0)
                {
                    FillRandomMatrix(FirstMatrix);
                }
                else
                {
                    MessageBox.Show("Create first matrix", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else if (checkBox2.Checked)
            {
                if(SecondMatrix.Length != 0)
                {
                    FillRandomMatrix(SecondMatrix);
                }
                else
                {
                    MessageBox.Show("Create second matrix", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Choice matrix", "Choice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Save results to file
        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FileName.Text, resultsTextBox.Text);
        }
        //Clear results textBox
        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultsTextBox.Text = "";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             switch (comboBox1.SelectedItem.ToString())
            {
                case "D = A - B":
                    panel1.Controls.Clear();
                    panel2.Controls.Clear();
                    FirstMatrix = matrixToTextBoxs(A,panel1);
                    SecondMatrix = matrixToTextBoxs(B, panel2);
                    break;
                case "C = D x F":
                    Matrix D = A.sub(B);
                    panel1.Controls.Clear();
                    panel2.Controls.Clear();
                    FirstMatrix = matrixToTextBoxs(D, panel1);
                    SecondMatrix = matrixToTextBoxs(F, panel2);
                    break;
                case "Kt = K^T":
                    panel1.Controls.Clear();
                    FirstMatrix = matrixToTextBoxs(K, panel1);
                    break;
            }
        }
    }
}
