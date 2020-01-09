namespace P09.Rectangle_Intersection
{
	 public class Rectangle
	 {
		public Rectangle(string id, int width, int height, Point topLeft, Point botRight)
		{
			this.Id = id;
			this.Width = width;
			this.Height = height;
			this.TopLeft = topLeft;
			this.BottomRight = botRight;
		}

		public string Id { get; set; }

		public int Width { get; set; }

		public int Height { get; set; }

		public Point TopLeft { get; set; }

		public Point BottomRight { get; set; }

		public bool IntersectionChek(Rectangle rectangle)
		{
			if (rectangle.TopLeft.X >= this.TopLeft.X &&
			   rectangle.BottomRight.X <= this.BottomRight.X &&
			   rectangle.TopLeft.Y >= this.TopLeft.Y &&
			   rectangle.BottomRight.Y <= this.BottomRight.Y)
			{
				return true;
			}

			return false;
		}
	 }
}
