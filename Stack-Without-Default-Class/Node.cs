using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Without_Default_Class
{
	/// <summary>
	/// Model for Node with value and recursive class for the next object.
	/// </summary>
	public class Node
	{
		/// <summary>
		/// Value of a Node
		/// </summary>
		public  string Value { get; set; }
		/// <summary>
		/// For recursive Node;
		/// </summary>
		public Node Next { get; set; }
	}
}
