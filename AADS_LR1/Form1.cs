using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS_LR1
{
    public partial class Form1 : Form
    {
        int[] array;
        int comparisons = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {            
            string[] input = txtInput.Text.Split(',');
            array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {                
                if (!int.TryParse(input[i].Trim(), out array[i]))
                {                    
                    MessageBox.Show($"Некоректне значення: \"{input[i]}\". Введіть ціле число.", 
                        "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            comparisons = 0;
           
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView.Columns.Add("", "");
            }
            
            AddRow(array);
            
            ShakerSort();

            lblResult.Text = $"Відсортований масив: {string.Join(", ", array)}";
            lblComparisons.Text = $"Кількість порівнянь: {comparisons}";
        }
        private void ShakerSort()
        {
            int left = 0;
            int right = array.Length - 1;
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
               
                for (int i = left; i < right; i++)
                {
                    comparisons++;
                   

                    if (array[i] > array[i + 1])
                    {
                        Swap(i, i + 1);
                        swapped = true;
                        AddRow(array, i, i + 1); 
                    }
                }

                if (!swapped)
                    break;

                swapped = false;
                right--;
                                
                for (int i = right; i > left; i--)
                {
                    comparisons++;
                    

                    if (array[i - 1] > array[i])
                    {
                        Swap(i - 1, i);
                        swapped = true;
                        AddRow(array, i - 1, i);  
                    }
                }

                left++;
            }
        }

        private void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private void AddRow(int[] arr, int index1 = -1, int index2 = -1)
        {
            int rowIndex = dataGridView.Rows.Add();
            for (int i = 0; i < arr.Length; i++)
            {
                dataGridView.Rows[rowIndex].Cells[i].Value = arr[i].ToString();
                if (i == index1 || i == index2)
                {                    
                    dataGridView.Rows[rowIndex].Cells[i].Style.BackColor = Color.LightBlue;
                }
                else
                {                    
                    dataGridView.Rows[rowIndex].Cells[i].Style.BackColor = Color.White;
                }
            }
            Application.DoEvents();
            System.Threading.Thread.Sleep(200); 
        }
        
    }
}

