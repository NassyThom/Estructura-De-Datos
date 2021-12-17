using System;
using System.Windows.Forms;

namespace Stack_Without_Default_Class
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Instancce a new object of MyStack
		/// </summary>
		MyStack _myStack = new MyStack();

		public Form1()
		{

			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!ValidateValue())
			{
				Node newNode = new Node();
				newNode.Value = txtValue.Text;
				_myStack.Push(newNode);
				ShowStack();
				//Control configuration
				txtValue.Clear();
				txtValue.Focus();
			}
			else
			{
				MessageBox.Show("Insert Value (°_°)!");
				txtValue.Focus();

			}
		}

		public void ShowStack()
		{
			lstBoxResult.Items.Clear();
			//Validate Top
			if (_myStack.Top() != null)
			{
				ShowNodeToList(_myStack.Top());
			}
			else
			{
				MessageBox.Show("Empty Stack");
			}
		}

		public void ShowNodeToList(Node node)
		{
			lstBoxResult.Items.Add(node.Value);
			//Recursive
			if (node.Next != null)
			{
				ShowNodeToList(node.Next);
			}
		}

		private void btnPop_Click(object sender, EventArgs e)
		{
			//Remove Top 
			_myStack.Pop();
			ShowStack();
		}

		/// <summary>
		/// Validate if a input have value
		/// </summary>
		/// <returns></returns>
		public Boolean ValidateValue()
		{
			return String.IsNullOrEmpty(txtValue.Text);
		}
	}
}
