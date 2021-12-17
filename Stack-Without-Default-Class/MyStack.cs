namespace Stack_Without_Default_Class
{
	/// <summary>
	/// Stack Operations, Push, Pop, Top-Peeak, Validate Null
	/// </summary>
	public class MyStack
	{
		//Internal Variable 
		Node _top;

		/// <summary>
		/// Get Top value
		/// </summary>
		/// <returns></returns>
		public Node Top()
		{
			return _top;
		}

		/// <summary>
		/// Insert a new Value Stack Inside
		/// </summary>
		/// <param name="newNode"></param>
		public void Push(Node newNode)
		{
			//Verify if this a first insert
			if (_top == null)
			{
				_top = newNode;
			}
			else
			{
				Node Temp = _top;
				_top = newNode;
				_top.Next = Temp;
			}

		}
		/// <summary>
		/// Remove Last insert Value
		/// </summary>
		public void Pop()
		{
			if (_top != null)
			{
				_top = _top.Next;
			}
		}

	}
}
