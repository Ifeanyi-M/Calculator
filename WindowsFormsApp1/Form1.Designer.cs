namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.plusBtn = new System.Windows.Forms.Button();
			this.minusBtn = new System.Windows.Forms.Button();
			this.divideBtn = new System.Windows.Forms.Button();
			this.multiplyBtn = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.clearBtn = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.equalityBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDisplay
			// 
			this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisplay.Location = new System.Drawing.Point(12, 12);
			this.txtDisplay.Multiline = true;
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.Size = new System.Drawing.Size(573, 72);
			this.txtDisplay.TabIndex = 0;
			this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.Location = new System.Drawing.Point(12, 102);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(77, 56);
			this.btn1.TabIndex = 1;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn2
			// 
			this.btn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.Location = new System.Drawing.Point(134, 102);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(77, 56);
			this.btn2.TabIndex = 2;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btn3
			// 
			this.btn3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.Location = new System.Drawing.Point(249, 102);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(77, 56);
			this.btn3.TabIndex = 3;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// plusBtn
			// 
			this.plusBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plusBtn.Location = new System.Drawing.Point(365, 102);
			this.plusBtn.Name = "plusBtn";
			this.plusBtn.Size = new System.Drawing.Size(77, 56);
			this.plusBtn.TabIndex = 4;
			this.plusBtn.Text = "+";
			this.plusBtn.UseVisualStyleBackColor = true;
			this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
			// 
			// minusBtn
			// 
			this.minusBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minusBtn.Location = new System.Drawing.Point(495, 102);
			this.minusBtn.Name = "minusBtn";
			this.minusBtn.Size = new System.Drawing.Size(77, 56);
			this.minusBtn.TabIndex = 5;
			this.minusBtn.Text = "-";
			this.minusBtn.UseVisualStyleBackColor = true;
			this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
			// 
			// divideBtn
			// 
			this.divideBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.divideBtn.Location = new System.Drawing.Point(501, 197);
			this.divideBtn.Name = "divideBtn";
			this.divideBtn.Size = new System.Drawing.Size(77, 56);
			this.divideBtn.TabIndex = 10;
			this.divideBtn.Text = "/";
			this.divideBtn.UseVisualStyleBackColor = true;
			this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
			// 
			// multiplyBtn
			// 
			this.multiplyBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.multiplyBtn.Location = new System.Drawing.Point(371, 197);
			this.multiplyBtn.Name = "multiplyBtn";
			this.multiplyBtn.Size = new System.Drawing.Size(77, 56);
			this.multiplyBtn.TabIndex = 9;
			this.multiplyBtn.Text = "x";
			this.multiplyBtn.UseVisualStyleBackColor = true;
			this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
			// 
			// btn6
			// 
			this.btn6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.Location = new System.Drawing.Point(255, 197);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(77, 56);
			this.btn6.TabIndex = 8;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.btn6_Click);
			// 
			// btn5
			// 
			this.btn5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.Location = new System.Drawing.Point(140, 197);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(77, 56);
			this.btn5.TabIndex = 7;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.btn5_Click);
			// 
			// btn4
			// 
			this.btn4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.Location = new System.Drawing.Point(18, 197);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(77, 56);
			this.btn4.TabIndex = 6;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.btn4_Click);
			// 
			// clearBtn
			// 
			this.clearBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearBtn.Location = new System.Drawing.Point(501, 289);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(77, 56);
			this.clearBtn.TabIndex = 20;
			this.clearBtn.Text = "Clear";
			this.clearBtn.UseVisualStyleBackColor = true;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// btn0
			// 
			this.btn0.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn0.Location = new System.Drawing.Point(371, 289);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(77, 56);
			this.btn0.TabIndex = 19;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.btn0_Click);
			// 
			// btn9
			// 
			this.btn9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.Location = new System.Drawing.Point(255, 289);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(77, 56);
			this.btn9.TabIndex = 18;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.btn9_Click);
			// 
			// btn8
			// 
			this.btn8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.Location = new System.Drawing.Point(140, 289);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(77, 56);
			this.btn8.TabIndex = 17;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.btn8_Click);
			// 
			// btn7
			// 
			this.btn7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.Location = new System.Drawing.Point(18, 289);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(77, 56);
			this.btn7.TabIndex = 16;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.btn7_Click);
			// 
			// equalityBtn
			// 
			this.equalityBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equalityBtn.Location = new System.Drawing.Point(255, 369);
			this.equalityBtn.Name = "equalityBtn";
			this.equalityBtn.Size = new System.Drawing.Size(323, 56);
			this.equalityBtn.TabIndex = 21;
			this.equalityBtn.Text = "=";
			this.equalityBtn.UseVisualStyleBackColor = true;
			this.equalityBtn.Click += new System.EventHandler(this.equalityBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 450);
			this.Controls.Add(this.equalityBtn);
			this.Controls.Add(this.clearBtn);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.divideBtn);
			this.Controls.Add(this.multiplyBtn);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.minusBtn);
			this.Controls.Add(this.plusBtn);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.txtDisplay);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDisplay;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button plusBtn;
		private System.Windows.Forms.Button minusBtn;
		private System.Windows.Forms.Button divideBtn;
		private System.Windows.Forms.Button multiplyBtn;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button equalityBtn;
	}
}

