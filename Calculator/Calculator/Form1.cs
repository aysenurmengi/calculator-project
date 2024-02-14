using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{


    public partial class Calculator : Form
    {
        int choice = 0;
        double number1, number2, result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttons(object sender, EventArgs e)
        {
            if(label1.Text=="0")
            {
                label1.Text = "";
            }
            label1.Text = label1.Text + ((Button)sender).Text;
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                // Metni ters çevir
                char[] charArray = label1.Text.ToCharArray();
                Array.Reverse(charArray);
                string tersMetin = new string(charArray);

                // Ters metinden ilk karakteri sil
                tersMetin = tersMetin.Substring(1);

                // Ters metni tekrar düzelt ve label'a ata
                charArray = tersMetin.ToCharArray();
                Array.Reverse(charArray);
                label1.Text = new string(charArray);
            }
                if (label1.Text=="")
            {
                label1.Text="0";    
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(label1.Text);  //virgüllü sayılarla işlem yapabilmek için double türüne çevirdim (string->double)
            choice = 1;
            label1.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(label1.Text);
            choice = 2;
            label1.Text = "0";
        }


        private void btnMultiply_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(label1.Text);
            choice = 3;
            label1.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if(label1.Text.IndexOf(",")<1)
            {
                label1.Text+= ",";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(label1.Text);
            choice = 4;
            label1.Text = "0";
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(label1.Text); 
            if(choice == 1) 
            {
                result = number1 + number2;
            }
            label1.Text=result.ToString();
            if (choice == 2)
            {
                result = number1 - number2;
            }
            label1.Text = result.ToString();
            if (choice == 3)
            {
                result = number1 * number2;
            }
            label1.Text = result.ToString();
            if (choice == 4)
            {
                result = number1 / number2;
            }
            label1.Text = result.ToString() ;
        }
    }
}
