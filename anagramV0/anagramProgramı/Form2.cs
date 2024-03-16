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
    public partial class Form2 : Form
    {
        public string[] firstArray = new string[15];
        public string[] secondArray = new string[15];
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i].Length == secondArray[j].Length)
                    {
                        string firstletterinarrayy = firstArray[i];
                        string firstletterinarrayx = secondArray[j];
                        for (int k = 0; k < firstletterinarrayy.Length; k++)
                        {
                            for (int l = 0; l < firstletterinarrayx.Length; l++)
                            {
                                if (firstletterinarrayy[k] == firstletterinarrayx[l])
                                {
                                    counter++;
                                    if (counter == firstletterinarrayy.Length)
                                    {
                                        label1.Text += "" + firstletterinarrayy + " anagramdır " + "" + firstletterinarrayx;
                                        label1.Text += "\n";
                                    }
                                    break;
                                }
                            }
                        }
                        counter = 0;
                    }
                }
            }
        }
    }
    
}
