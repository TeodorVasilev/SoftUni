﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Scale
{
	public class EqualityScale<T> where T : struct
	{
		private T left;

		private T right;

		public EqualityScale(T left, T right)
		{
			this.left = left;
			this.right = right;
		}
		
		public bool AreEqual()
		{
			return this.left.Equals(this.right);
		}
	}
}
