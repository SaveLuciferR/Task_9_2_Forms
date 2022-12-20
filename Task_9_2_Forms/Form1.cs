using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_9_2_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{

				StreamReader fileIn = new StreamReader("text.txt");
				string text = fileIn.ReadToEnd();
				fileIn.Close();

				string afterText = "";

				string[] newText = Regex.Split(text, "[\n]+");

				foreach (string s in newText)
				{
					afterText += s[0] + " ";
				}

				textBox1.Text = afterText;
			}
			catch
			{
				textBox1.Text = "Произошла ошибка";
			}
		}
	}
}
