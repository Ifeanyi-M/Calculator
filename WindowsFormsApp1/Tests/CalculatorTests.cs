using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;

namespace WindowsFormsApp1.Tests
{
	public class CalculatorTests
	{
		[Fact]
		public void plusBtn_Click_ShouldSetOptionToPlus()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "10";
			txtDisplayField.SetValue(calculator, txtDisplay);

			var method = typeof(Form1).GetMethod("plusBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal("+", calculator.option);
			
		}

		[Fact]
		public void plusBtn_Click_ShouldSetNum1ToParsedValue()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new  TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "5";
			txtDisplayField.SetValue(calculator, txtDisplay);

			var method = typeof(Form1).GetMethod("plusBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal(5.0, calculator.num1);
		}

		[Fact]
		public void minusBtn_Click_ShouldSetOptionToMinus()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "10";
			txtDisplayField.SetValue(calculator, txtDisplay);

			var method = typeof(Form1).GetMethod("minusBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal("-", calculator.option);

		}

		[Fact]
		public void minusBtn_Click_ShouldSetNum1ToParsedValue()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "5";
			txtDisplayField.SetValue(calculator, txtDisplay);

			var method = typeof(Form1).GetMethod("minusBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal(5.0, calculator.num1);
		}

		[Fact]
		public void multiplyBtn_Click_ShouldSetOptionToMultiply()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "10";
			txtDisplayField.SetValue(calculator, txtDisplay);

			var method = typeof(Form1).GetMethod("multiplyBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal("*", calculator.option);

		}

		[Fact]
		public void multiplyBtn_Click_ShouldSetNum1ToParsedValue()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "5";
			txtDisplayField.SetValue(calculator, txtDisplay);

			var method = typeof(Form1).GetMethod("multiplyBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal(5.0, calculator.num1);
		}

		[Fact]
		public void divideBtn_Click_ShouldSetOptionToDivide()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "10";
			txtDisplayField.SetValue(calculator, txtDisplay);

			var method = typeof(Form1).GetMethod("divideBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal("/", calculator.option);

		}

		[Fact]
		public void divideBtn_Click_ShouldSetNum1ToParsedValue()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "5";
			txtDisplayField.SetValue(calculator, txtDisplay);

			var method = typeof(Form1).GetMethod("divideBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal(5.0, calculator.num1);
		}

		[Fact]

		public void equalityBtn_Click_ShouldPerformAddition()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "5";
			txtDisplayField.SetValue(calculator, txtDisplay);
			calculator.num1 = 10;
			calculator.option = "+";
			var method = typeof(Form1).GetMethod("equalityBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal("15", txtDisplay.Text);

		}

		[Fact]
		public void equalityBtn_Click_ShouldPerformSubtraction()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "5";
			txtDisplayField.SetValue(calculator, txtDisplay);
			calculator.num1 = 10;
			calculator.option = "-";
			var method = typeof(Form1).GetMethod("equalityBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal("5", txtDisplay.Text);

		}

		[Fact]
		public void equalityBtn_Click_ShouldPerformMultiplication()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "5";
			txtDisplayField.SetValue(calculator, txtDisplay);
			calculator.num1 = 10;
			calculator.option = "*";
			var method = typeof(Form1).GetMethod("equalityBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal("50", txtDisplay.Text);

		}

		[Fact]
		public void equalityBtn_Click_ShouldPerformDivision()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "5";
			txtDisplayField.SetValue(calculator, txtDisplay);
			calculator.num1 = 10;
			calculator.option = "/";
			var method = typeof(Form1).GetMethod("equalityBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal("2", txtDisplay.Text);

		}

		[Fact]
        public void equalityBtn_Click_ShouldPerformDivisionandGiveZeroWhenDenominatorIsZero()
        {
            //Arrange
            var calculator = new Form1();
            var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
            var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
            txtDisplay.Text = "0";
            txtDisplayField.SetValue(calculator, txtDisplay);
            calculator.num1 = 10;
            calculator.option = "/";
            var method = typeof(Form1).GetMethod("equalityBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            var parameters = new object[] { null, EventArgs.Empty };

            //Act
            method.Invoke(calculator, parameters);

            //Assert
            Assert.Equal("0", txtDisplay.Text);

        }

        [Fact]
        public void equalityBtn_Click_ShouldPerformDivisionandGiveZeroWhenNumeratorIsZero()
        {
            //Arrange
            var calculator = new Form1();
            var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
            var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
            txtDisplay.Text = "2";
            txtDisplayField.SetValue(calculator, txtDisplay);
            calculator.num1 = 0;
            calculator.option = "/";
            var method = typeof(Form1).GetMethod("equalityBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            var parameters = new object[] { null, EventArgs.Empty };

            //Act
            method.Invoke(calculator, parameters);

            //Assert
            Assert.Equal("0", txtDisplay.Text);

        }

        [Fact]
		public void clearBtn_Click_ShouldClearDisplay()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "5";
			txtDisplayField.SetValue(calculator, txtDisplay);
		
			var method = typeof(Form1).GetMethod("clearBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal(string.Empty, txtDisplay.Text);

		}

		[Fact]
		public void clearBtn_Click_ShouldResetValues()
		{
			//Arrange
			var calculator = new Form1();
			var txtDisplayField = typeof(Form1).GetField("txtDisplay", BindingFlags.NonPublic | BindingFlags.Instance);
			var txtDisplay = new TextBox(); // Replace "TextBox" with the actual type of txtDisplay
			txtDisplay.Text = "5";
			txtDisplayField.SetValue(calculator, txtDisplay);

			calculator.result = 15;
			calculator.num1 = 12;
			calculator.num2 = 3;

			var method = typeof(Form1).GetMethod("clearBtn_Click", BindingFlags.NonPublic | BindingFlags.Instance);
			var parameters = new object[] { null, EventArgs.Empty };

			//Act
			method.Invoke(calculator, parameters);

			//Assert
			Assert.Equal(string.Empty, txtDisplay.Text);
			Assert.Equal(0, calculator.result);
			Assert.Equal(0, calculator.num1);
			Assert.Equal(0, calculator.num2);


		}
	}
}
