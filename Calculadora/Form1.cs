using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string selectedOperator;
        int acumulatedValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberAction_Click(object sender, EventArgs e)
        {
            
            Button btnNumbers = (Button)sender;             
            int btnValue = int.Parse(btnNumbers.Text);      //Valor que se clickea
            int currentValue = int.Parse(txtValue.Text);  //Valor entero que se acumula en la caja de texto
            
            currentValue = currentValue * 10 + btnValue;
            txtValue.Text = currentValue.ToString();
        }

        private void OperatorAction_Click(object sender, EventArgs e)
        {
            Button btnOperators = (Button)sender;
            selectedOperator = btnOperators.Text;
            acumulatedValue = int.Parse(txtValue.Text);
            txtValue.Text = "0";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            int secondAcumulatedValue = int.Parse(txtValue.Text);
            int result = 0;

            switch (selectedOperator)
            {
                    case "+":
                    result = acumulatedValue + secondAcumulatedValue;
                    break;

                    case "-":
                    result = acumulatedValue - secondAcumulatedValue;
                    break;

                    case "*":
                    result = acumulatedValue * secondAcumulatedValue;
                    break;

                    case "/":
                    result = acumulatedValue / secondAcumulatedValue;
                    break;
            }
            
            txtValue.Text = result.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
            acumulatedValue = 0;
            selectedOperator = string.Empty;
        }
    }
}
