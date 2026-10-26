using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kric5
{
    public partial class Form1 : Form
    {
        private int[] numbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCount.Text, out int size) || size <= 0)
            {
                MessageBox.Show("Введите корректное целое положительное число!", "Ошибка");
                return;
            }

            numbers = new int[size];
            Random rnd = new Random();
            lstArray.Items.Clear();

            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(-50, 50);
                lstArray.Items.Add($"[{i}]: {numbers[i]}");
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Length == 0)
            {
                MessageBox.Show("Массив не создан! Сначала нажмите 'Создать'.", "Внимание");
                return;
            }


            txtRes1.Text = txtRes2.Text = txtRes3.Text = "";


            if (chkNegSum.Checked)
            {
                int sumNeg = numbers.Where(x => x < 0).Sum();
                txtRes1.Text = sumNeg.ToString();
            }


            if (chkIndex3.Checked)
            {
                int sumIdx = 0;
                for (int i = 0; i < numbers.Length; i += 3)
                {
                    sumIdx += numbers[i];
                }
                txtRes2.Text = sumIdx.ToString();
            }


            if (chkMaxMinProd.Checked)
            {
                int max = numbers.Max();
                int min = numbers.Min();
                // Используем long на случай большого произведения
                long product = (long)Math.Abs(max) * Math.Abs(min);
                txtRes3.Text = product.ToString();
            }

            if (!chkNegSum.Checked && !chkIndex3.Checked && !chkMaxMinProd.Checked)
            {
                MessageBox.Show("Выберите хотя бы одну операцию.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
