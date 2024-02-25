using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora
{
    public partial class FormCalc : Form
    {
        private List<string> listNumber = new List<string>();
        private List<string> listOperation = new List<string>();
        private decimal result = 0;

        public FormCalc()
        {
            InitializeComponent();
        }

        //deteccion de primer numero ingresado
        private void firstNumber(string number)
        {

            if (TextBoxOperation.Lines[0] == "0" && TextBoxOperation.Lines.Length == 1)
            {
                TextBoxOperation.Text = number;
            }
            else
            {
                TextBoxOperation.Text += number;
            }

        }

        //deteccion de operacion
        private decimal DetectOperation(string symbol, decimal result, string operation = "")
        {
            switch (symbol)
            {
                case "+":
                    result = Convert.ToDecimal(listNumber[0]) + Convert.ToDecimal(listNumber[1]);
                    textBoxParcial.Text = "";
                    TextBoxOperation.Text = Convert.ToString(result);
                    listNumber.Clear();
                    break;
                case "-":
                    result = Convert.ToDecimal(listNumber[0]) - Convert.ToDecimal(listNumber[1]);
                    textBoxParcial.Text = "";
                    TextBoxOperation.Text = Convert.ToString(result);
                    listNumber.Clear();
                    break;
                case "X":
                    result = Convert.ToDecimal(listNumber[0]) * Convert.ToDecimal(listNumber[1]);
                    textBoxParcial.Text = "";
                    TextBoxOperation.Text = Convert.ToString(result);
                    listNumber.Clear();
                    break;
                case "/":
                    try
                    {
                        result = Convert.ToDecimal(listNumber[0]) / Convert.ToDecimal(listNumber[1]);
                        textBoxParcial.Text = "";
                        TextBoxOperation.Text = Convert.ToString(result);
                        listNumber.Clear();
                    }  
                    catch(Exception e) 
                    {
                        MessageBox.Show(e.Message, "Ocurrio un fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxOperation.Font = new Font("Segoe UI", 15F);
                        TextBoxOperation.Text = e.Message;
                        textBoxParcial.Text = "";
                        listNumber.Clear();
                        LockButtons(true);
                    }
                    break;
                case "%":
                    break;
                case "=":
                    DetectOperation(operation, result);
                    listOperation.Clear();
                    break;
            }

            return result;
        }

        //habilita o deshabilita controles de botones
        private void LockButtons(bool flag)
        {
            ButtomMinus.Enabled = !flag;
            ButtomPlus.Enabled = !flag;
            ButtomProd.Enabled = !flag;
            ButtonDiv.Enabled = !flag;
            ButtonDot.Enabled = !flag;
            ButtonEqual.Enabled = !flag;
            ButtonNum0.Enabled = !flag;
            ButtonNum1.Enabled = !flag;
            ButtonNum2.Enabled = !flag;
            ButtonNum3.Enabled = !flag;
            ButtonNum4.Enabled = !flag;
            ButtonNum5.Enabled = !flag;
            ButtonNum6.Enabled = !flag;
            ButtonNum7.Enabled = !flag;
            ButtonNum8.Enabled = !flag;
            ButtonNum9.Enabled = !flag;
        }

        //eventos de click en numeros

        private void ButtonNum1_Click(object sender, EventArgs e)
        {
            firstNumber(ButtonNum1.Text);
        }

        private void ButtonNum2_Click(object sender, EventArgs e)
        {
            firstNumber(ButtonNum2.Text);
        }

        private void ButtonNum3_Click(object sender, EventArgs e)
        {
            firstNumber(ButtonNum3.Text);
        }

        private void ButtonNum4_Click(object sender, EventArgs e)
        {
            firstNumber(ButtonNum4.Text);
        }

        private void ButtonNum5_Click(object sender, EventArgs e)
        {
            firstNumber(ButtonNum5.Text);
        }

        private void ButtonNum6_Click(object sender, EventArgs e)
        {
            firstNumber(ButtonNum6.Text);
        }

        private void ButtonNum7_Click(object sender, EventArgs e)
        {
            firstNumber(ButtonNum7.Text);
        }

        private void ButtonNum8_Click(object sender, EventArgs e)
        {
            firstNumber(ButtonNum8.Text);
        }

        private void ButtonNum9_Click(object sender, EventArgs e)
        {
            firstNumber(ButtonNum9.Text);
        }

        private void ButtonNum0_Click(object sender, EventArgs e)
        {
            firstNumber(ButtonNum0.Text);
        }

        //eventos de click en operaciones

        //suma
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            string operation = "+";
            string number = TextBoxOperation.Text;
            listNumber.Add(number);
            listOperation.Add(operation);

            if (listNumber.Count == 2)
            {
                result = DetectOperation(operation, result);
            }
            else
            {
                result = Convert.ToDecimal(listNumber[0]) + 0;
                textBoxParcial.Text = Convert.ToString(result);
                TextBoxOperation.Text = "0";
            }
        }

        //resta
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            string operation = "-";
            string number = TextBoxOperation.Text;
            listNumber.Add(number);

            if (listNumber.Count == 2)
            {
                result = DetectOperation(operation, result);
            }
            else
            {
                result = Convert.ToDecimal(listNumber[0]) - 0;
                textBoxParcial.Text = Convert.ToString(result);
                TextBoxOperation.Text = "0";
            }
        }

        //multiplicacion
        private void ButtonProd_Click(object sender, EventArgs e)
        {
            string operation = "X";
            string number = TextBoxOperation.Text;
            listNumber.Add(number);
            listOperation.Add(operation);

            if (listNumber.Count == 2)
            {
                result = DetectOperation(operation, result);
            }
            else
            {
                result = Convert.ToDecimal(listNumber[0]) + 0;
                textBoxParcial.Text = Convert.ToString(result);
                TextBoxOperation.Text = "0";
            }
        }

        //limpiar visor y resetea stats de controles
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            TextBoxOperation.Font = new Font("Segoe UI", 25F);
            TextBoxOperation.Text = "0";
            textBoxParcial.Text = "";
            listNumber.Clear();
            listOperation.Clear();
            LockButtons(false);
        }

        //resultado de operacion
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            string operation = "=";
            string number = TextBoxOperation.Text;
            listNumber.Add(number);

            if (listNumber.Count == 2 && listOperation.Count == 1)
            {
                result = DetectOperation(operation, result, listOperation[0]);

            }
            else
            {
                result = Convert.ToDecimal(listNumber[0]) + 0;
                textBoxParcial.Text = Convert.ToString(result);
                TextBoxOperation.Text = Convert.ToString(result); ;
            }
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            string operation = "/";
            string number = TextBoxOperation.Text;
            listNumber.Add(number);
            listOperation.Add(operation);

            if (listNumber.Count == 2)
            {
                result = DetectOperation(operation, result);
            }
            else
            {
                result = Convert.ToDecimal(listNumber[0]) + 0;
                textBoxParcial.Text = Convert.ToString(result);
                TextBoxOperation.Text = "0";
            }
        }
    }
}
