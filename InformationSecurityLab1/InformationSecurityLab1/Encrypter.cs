using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSecurityLab1
{
	public class Encrypter
	{
		private int rows;
		private int columns;
		private char[,] table;

		private const string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЪЫЭЮЯ";
		private const char nullSymbol = '\0';

		public string Encrypt(string keyword, string inputWord)
		{
			FillTable(keyword);
			return EncryptByTable(inputWord);
		}

		private string EncryptByTable(string inputWord)
		{
			inputWord = inputWord.ToUpper();
			string result = string.Empty;
			for (int i = 0; i < inputWord.Length; i++)
			{
				for (int r = 0; r < rows; r++)
				{
					for (int c = 0; c < columns; c++)
					{
						if (inputWord[i] == table[r, c])
						{
							if (c == columns - 1)
								result += table[r, 0];
							else
								result += table[r, c + 1];
						}
					}
				}
				if (result.Length <= i)
					result += inputWord[i];
			}

			return result;
		}

		private void FillTable(string keyword)
		{
			keyword = new string(keyword.ToUpper().Distinct().ToArray());
			columns = keyword.Length - 1;
			rows = alphabet.Length / columns + 1;
			table = new char[rows, columns];
			char[] tmp = keyword.ToCharArray();
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					int koef = i * columns;
					if (koef + j < keyword.Length && tmp[koef + j] != nullSymbol)
					{
						table[i, j] = tmp[koef + j];
						tmp[koef + j] = nullSymbol;
						continue;
					}
					for (int k = 0; k < alphabet.Length; k++)
					{
						char ch = alphabet[k/*new Random().Next(alphabet.Length - 1)*/];
						if (!ArrayContains(table, ch))
						{
							table[i, j] = ch;
							break;
						}
					}
				}
			}
		}

		private bool ArrayContains(char[,] array, char symbol)
		{
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					if (array[i, j] == symbol)
						return true;
				}
			}

			return false;
		}
	}
}
