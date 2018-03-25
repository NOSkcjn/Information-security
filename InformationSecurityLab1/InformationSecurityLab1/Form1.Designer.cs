namespace InformationSecurityLab1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelKeyword = new System.Windows.Forms.Label();
			this.labelInputWord = new System.Windows.Forms.Label();
			this.labelResult = new System.Windows.Forms.Label();
			this.textBoxKeyword = new System.Windows.Forms.TextBox();
			this.textBoxInputWord = new System.Windows.Forms.TextBox();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.buttonEncrypt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelKeyword
			// 
			this.labelKeyword.AutoSize = true;
			this.labelKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelKeyword.Location = new System.Drawing.Point(87, 76);
			this.labelKeyword.Name = "labelKeyword";
			this.labelKeyword.Size = new System.Drawing.Size(53, 17);
			this.labelKeyword.TabIndex = 0;
			this.labelKeyword.Text = "Лозунг";
			// 
			// labelInputWord
			// 
			this.labelInputWord.AutoSize = true;
			this.labelInputWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelInputWord.Location = new System.Drawing.Point(87, 113);
			this.labelInputWord.Name = "labelInputWord";
			this.labelInputWord.Size = new System.Drawing.Size(48, 17);
			this.labelInputWord.TabIndex = 1;
			this.labelInputWord.Text = "Слово";
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelResult.Location = new System.Drawing.Point(87, 155);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(76, 17);
			this.labelResult.TabIndex = 2;
			this.labelResult.Text = "Результат";
			// 
			// textBoxKeyword
			// 
			this.textBoxKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxKeyword.Location = new System.Drawing.Point(169, 78);
			this.textBoxKeyword.Name = "textBoxKeyword";
			this.textBoxKeyword.Size = new System.Drawing.Size(152, 23);
			this.textBoxKeyword.TabIndex = 3;
			// 
			// textBoxInputWord
			// 
			this.textBoxInputWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxInputWord.Location = new System.Drawing.Point(169, 115);
			this.textBoxInputWord.Name = "textBoxInputWord";
			this.textBoxInputWord.Size = new System.Drawing.Size(152, 23);
			this.textBoxInputWord.TabIndex = 4;
			// 
			// textBoxResult
			// 
			this.textBoxResult.Enabled = false;
			this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxResult.Location = new System.Drawing.Point(169, 149);
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.Size = new System.Drawing.Size(152, 23);
			this.textBoxResult.TabIndex = 5;
			// 
			// buttonEncrypt
			// 
			this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonEncrypt.Location = new System.Drawing.Point(169, 221);
			this.buttonEncrypt.Name = "buttonEncrypt";
			this.buttonEncrypt.Size = new System.Drawing.Size(111, 28);
			this.buttonEncrypt.TabIndex = 6;
			this.buttonEncrypt.Text = "Зашифровать";
			this.buttonEncrypt.UseVisualStyleBackColor = true;
			this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 332);
			this.Controls.Add(this.buttonEncrypt);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.textBoxInputWord);
			this.Controls.Add(this.textBoxKeyword);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.labelInputWord);
			this.Controls.Add(this.labelKeyword);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelKeyword;
		private System.Windows.Forms.Label labelInputWord;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.TextBox textBoxKeyword;
		private System.Windows.Forms.TextBox textBoxInputWord;
		private System.Windows.Forms.TextBox textBoxResult;
		private System.Windows.Forms.Button buttonEncrypt;
	}
}

