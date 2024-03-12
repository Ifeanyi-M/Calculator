using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string CalcTotal;
		public double num1;
		public double num2;
		public String option;
		public double result;
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btn1.Text;
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btn2.Text;
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btn3.Text;
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btn4.Text;
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btn5.Text;
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btn6.Text;
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btn7.Text;
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btn8.Text;
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btn9.Text;
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btn0.Text;
		}

		private void plusBtn_Click(object sender, EventArgs e)
		{
			option = "+";
			num1 = double.Parse(txtDisplay.Text);

			txtDisplay.Clear();
		}

		private void minusBtn_Click(object sender, EventArgs e)
		{
			option = "-";
			num1 = double.Parse(txtDisplay.Text);

			txtDisplay.Clear();
		}

		private void multiplyBtn_Click(object sender, EventArgs e)
		{
			option = "*";
			num1 = double.Parse(txtDisplay.Text);

			txtDisplay.Clear();
		}

		private void divideBtn_Click(object sender, EventArgs e)
		{
			option = "/";
			num1 = double.Parse(txtDisplay.Text);

			txtDisplay.Clear();
		}

		private void equalityBtn_Click(object sender, EventArgs e)
		{
			num2 = double.Parse(txtDisplay.Text);

			if (option.Equals("+"))
				result = num1 + num2;
			if (option.Equals("-"))
				result = num1 - num2;
			if (option.Equals("*"))
				result = num1 * num2;
			if (option.Equals("/"))
			{
				result = num1 / num2;
				if(num2 == 0 || num1 == 0)
				{
					result = 0;
				}
			}
				
		

			txtDisplay.Text = result + "";
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			txtDisplay.Clear();
			result = (0);
			num1 = (0);
			num2 = (0);
		}


	}
}
