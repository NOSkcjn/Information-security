using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSecurityLab1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonEncrypt_Click(object sender, EventArgs e)
		{
			string encrypted = new Encrypter().Encrypt(textBoxKeyword.Text, textBoxInputWord.Text);
			textBoxResult.Text = encrypted;
		}
	}
}
