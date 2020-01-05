using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.Rectangle_Intersection
{
	 public class Rectangle
	 {
		private string id;

		private int height;

		private int width;
		
		private int x;

		private int y;

		public int Y
		{
			get { return y; }
			set { y = value; }
		}

		public int X
		{
			get { return x; }
			set { x = value; }
		}

		public int Width
		{
			get { return width; }
			set { width = value; }
		}

		public int Height
		{
			get { return height; }
			set { height = value; }
		}

		public string Id
		{
			get { return id; }
			set { id = value; }
		}
	 }
}
