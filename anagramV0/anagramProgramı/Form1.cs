using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anagramProgramı
{
    public partial class Form1 : Form
    {
        string[] firstArray = new string[14];
        string[] secondArray = new string[13];
        int firstArrayCounter=0,secondArrayCounter=0;
        bool firstArrayControl = false, secondArrayControl = false,firstArrayItemsadd=false,secondArrayItemsAdd=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void deletButton_Click(object sender, EventArgs e)
        {
            if (firstArrayControl == true)
            {
                listBox1.Items.Remove(listBox1.SelectedIndex);
                firstArrayCounter--;
            }
            else if (secondArrayControl == true)
            {
                listBox1.Items.Remove(listBox1.SelectedIndex);
                secondArrayCounter--;
            }
        }

        private void anagramButton_Click(object sender, EventArgs e)
        {
            Form2 secondForm=new Form2();
            secondForm.firstArray = firstArray;
            secondForm.secondArray = secondArray;
            secondForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Maksimum 15 tane kelime giriniz");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstArrayControl==true)
            {
                firstArray[firstArrayCounter] = textBox1.Text;
                listBox1.Items.Add(firstArray[firstArrayCounter]);
                firstArrayCounter++;
                firstArrayItemsadd = true;
                textBox1.Clear();
            }
            else if (secondArrayControl==true)
            {
                secondArray[secondArrayCounter]=textBox1.Text;
                listBox1.Items.Add(secondArray[secondArrayCounter]);
                secondArrayCounter++;
                secondArrayItemsAdd = true;
                textBox1.Clear();
            }
        }

        private void secondArrayButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            secondArrayControl = true;
            firstArrayControl = false;
            if (secondArrayItemsAdd==true)
            {
                for (int i = 0; i < secondArrayCounter; i++)
                {
                    listBox1.Items.Add(secondArray[i]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            secondArrayControl = false;
            firstArrayControl = true;
            if (firstArrayItemsadd==true)
            {
                for (int i = 0; i < firstArrayCounter; i++)
                {
                    listBox1.Items.Add(firstArray[i]);
                }
            }          
        }
    }
}
