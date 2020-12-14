using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCalculator
{
    public partial class frmCalculator : Form
    {
        protected MemoryCalculator calculator = new MemoryCalculator();

        protected bool clear = false;
        public frmCalculator()
        {
            InitializeComponent();
            this.calculator.ValueStoredInMemory += this.OnValueInMemory;
            this.calculator.ValueNotInMemory += this.OnValueNotInMemory;
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            //If a calculation has been preformed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }



            //Test to see if the "0" will be the first number, if so, don't write it
            //Just makes is 1 instead of 01
            if ((this.calculator.input + "0").IndexOf("0") > 0)
            {
                //Make sure the Text box is clear
                txtCurrentValue.Text = "";

                //Add to the input
                this.calculator.input += "0";

                //Write out the current input
                txtCurrentValue.Text = this.calculator.input;
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurrentValue.Text = "";
            this.calculator.input += "1";
            txtCurrentValue.Text = this.calculator.input;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurrentValue.Text = "";
            this.calculator.input += "2";
            txtCurrentValue.Text = this.calculator.input;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurrentValue.Text = "";
            this.calculator.input += "3";
            txtCurrentValue.Text = this.calculator.input;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurrentValue.Text = "";
            this.calculator.input += "4";
            txtCurrentValue.Text = this.calculator.input;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurrentValue.Text = "";
            this.calculator.input += "5";
            txtCurrentValue.Text = this.calculator.input;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurrentValue.Text = "";
            this.calculator.input += "6";
            txtCurrentValue.Text = this.calculator.input;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurrentValue.Text = "";
            this.calculator.input += "7";
            txtCurrentValue.Text = this.calculator.input;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurrentValue.Text = "";
            this.calculator.input += "8";
            txtCurrentValue.Text = this.calculator.input;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }
            txtCurrentValue.Text = "";
            this.calculator.input += "9";
            txtCurrentValue.Text = this.calculator.input;
        }

        private void BtnPeriod_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }

            if (this.calculator.input.Length == 0)
                this.calculator.input = "0";

            txtCurrentValue.Text = "";

            //Look to see if there is already a period
            if (this.calculator.input.IndexOf(".") == -1)
                this.calculator.input += ".";

            txtCurrentValue.Text = this.calculator.input;

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            this.calculator.operand1 = this.calculator.input;
            this.calculator.op = '+';
            this.calculator.input = string.Empty;
            clear = false; //Don't clear the form on the next number press
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            this.calculator.operand2 = this.calculator.input;
            try
            {
                this.calculator.Calculation();
                txtCurrentValue.Text = this.calculator.result.ToString();
            }
            catch (DivideByZeroException)
            {
                txtCurrentValue.Text = "DIV/0!";
            }
            catch (OverflowException)
            {
                txtCurrentValue.Text = "Overflow!";
            }
            catch (Exception)
            {
                txtCurrentValue.Text = "ERROR!!";
            }

            clear = true; //Clear the form on the next number press
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            this.calculator.operand1 = this.calculator.input;
            this.calculator.op = '-';
            this.calculator.input = string.Empty;

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            this.calculator.operand1 = this.calculator.input;
            this.calculator.op = '*';
            this.calculator.input = string.Empty;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            this.calculator.operand1 = this.calculator.input;
            this.calculator.op = '/';
            this.calculator.input = string.Empty;
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            txtCurrentValue.Text = "";
            this.calculator.Sqrt();
            txtCurrentValue.Text = this.calculator.input;

        }

        private void BtnReciproc_Click(object sender, EventArgs e)
        {
            txtCurrentValue.Text = "";
            try
            {
                this.calculator.Reciprocal();
                txtCurrentValue.Text = this.calculator.input;
            }
            catch (DivideByZeroException)
            {
                txtCurrentValue.Text = "DIV/0!";
            }
            catch (Exception)
            {
                txtCurrentValue.Text = "ERROR!";
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                this.ClearForm();
            }

            //Clear the txt box
            txtCurrentValue.Text = "";

            //Copy the current input
            string value = this.calculator.input;

            //Remove the current value
            this.calculator.input = string.Empty;

            //rebuild the string minus 1
            for (int i = 0; i < value.Length - 1; i++)
            {
                this.calculator.input += value[i];
            }

            //If the user has erased everything, then display zero
            if (this.calculator.input.Length == 0)
            {
                txtCurrentValue.Text = "0";
            }
            else
            {
                //Write the value
                txtCurrentValue.Text = this.calculator.input;
            }


        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void BtnPosMin_Click(object sender, EventArgs e)
        {
            txtCurrentValue.Text = "";
            this.calculator.PositiveNegative();
            txtCurrentValue.Text = this.calculator.input;
        }

        private void ClearForm()
        {
            txtCurrentValue.Text = "0";
            this.calculator.input = string.Empty;
            this.calculator.operand1 = string.Empty;
            this.calculator.operand2 = string.Empty;
            this.calculator.op = ' ';
            this.clear = false;
        }

        public void OnValueInMemory(object source, EventArgs args)
        {
            lblMemory.Text = "M";
        }

        public void OnValueNotInMemory(object source, EventArgs args)
        {
            lblMemory.Text = "";
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {
            this.calculator.MemoryClear();
        }

        private void BtnMS_Click(object sender, EventArgs e)
        {
            this.calculator.MemoryStore();
        }

        private void BtnMR_Click(object sender, EventArgs e)
        {
            this.calculator.MemoryRecall();
            txtCurrentValue.Text = this.calculator.input;
        }

        private void BtnMPlus_Click(object sender, EventArgs e)
        {
            this.calculator.MemoryAdd();
        }
    }
}