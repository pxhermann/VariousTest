using System;
using System.Collections.Generic;
using System.Text;

namespace VariousTest
{
	public class CBItem
	{
		public CBItem(string name, int value)
		{
			this.name = name;
			this.val  = value;
		}
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int val;
		public int Value
		{
			get { return val; }
			set { val = value; }
		}
	
		public override string ToString()
		{
			return name;
		}
	}
}
